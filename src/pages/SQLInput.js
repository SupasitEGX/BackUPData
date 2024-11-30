import React, { useState, useEffect } from 'react';
import { Spin, Input, Button, Row, Col, Tabs, Modal, Avatar, Table, Divider, Tag, Badge, Card, Switch, Select, Form, Pagination, notification } from 'antd';
import axios from 'axios';
import {
  CheckCircleOutlined,
  ClockCircleOutlined,
  CloseCircleOutlined,
  ExclamationCircleOutlined,
  MinusCircleOutlined,
  SyncOutlined,
} from '@ant-design/icons';
import { NotificationPlacement } from "antd/es/notification";

const SqlInputForm = () => {

  const { Option } = Select;
  const [formHeader_SELECT] = Form.useForm();
  const [formHeader_UPDATE] = Form.useForm();
  const [formHeader_INSERT] = Form.useForm();
  const [pageSize, setPageSize] = useState(10);
  const [currentPage, setCurrentPage] = useState(1);
  const [loading, setLoading] = useState(false); //true
  const [sqlQuery, setSqlQuery] = useState('');
  const [sqlConn, setSqlConn] = useState('');
  const [dataSource, initdata] = useState([]);
  const [sqlResultData, setSqlResultData] = useState('-');
  const [sqlResultType, setSqlResultType] = useState('default');
  const [sqlResultPresets, setSqlResultPresets] = useState('yellow'); //// [red, yellow, green]
  const [sqlType, setSqlType] = useState('SELECT');
  const [activeTabKey, setActiveTabKey] = useState('SELECT');
  const [defaultActiveKey, setdefaultActiveKey] = useState(1);
  const [dataJsonCase, initdataJsonCase] = useState([]);
  const [dataJsonConn, initdataJsonConn] = useState([]);

  //#region Notification
  const [api, contextHolder] = notification.useNotification();
  const openNotification = (type, placement: NotificationPlacement, Msg) => {
    notification[type]({
      message: `Notification `,
      description: Msg,
      placement,
    });
  };
  //#endregion

  //#region useEffect
  useEffect(() => {
    const fetchData = async () => {

      try {
        const responseConn = await fetch(`${process.env.PUBLIC_URL}/conn/connection.json`);
        const jsonDataConn = await responseConn.json();
        initdataJsonConn(jsonDataConn.conn.data);
      } catch (error) {
        console.error('Error fetching data jsonDataConn:', error);
      }
      try {
        const responseCase = await fetch(`${process.env.PUBLIC_URL}/case/wms/selsct.json`);
        const jsonDataCase = await responseCase.json();
        initdataJsonCase(jsonDataCase.case.data.filter((item) => item.conn === "wms"));
      } catch (error) {
        console.error('Error fetching data jsonDataCase:', error);
      }

    };

    fetchData();
  }, []);
  //#endregion

  //#region OnClick All AND ExecuteQuery
  const fetchInputChangeConn = async (value) => {
    try {
      var urlPath = `${process.env.PUBLIC_URL}/case/` + value.toLowerCase() + `/selsct.json`;
      const responseCase = await fetch(urlPath);
      const jsonDataCase = await responseCase.json();
      if (jsonDataCase.case.data.length > 0) {
        initdataJsonCase(jsonDataCase.case.data.filter((item) => item.conn === value.toLowerCase()));
      }
      else {
        initdataJsonCase([]);
        setSqlQuery('');
        formHeader_SELECT.setFieldsValue({
          Case: ""
        });
      }
    } catch (error) {
      initdataJsonCase([]);
      setSqlQuery('');
      formHeader_SELECT.setFieldsValue({
        Case: ""
      });
    }
  };

  const handleInputChangeConn = (event) => {
    setSqlConn(event.value);
    fetchInputChangeConn(event.value);
  };

  const handleInputChangeCase = (event) => {
    setSqlQuery(event.target.value);
  };

  const handleSqlTypeChange = (value) => {
    setSqlType(value);
    if (sqlQuery.length > 0) {
      confirm(value);
    }
    else {
      setSqlResultPresets('yellow');
      setSqlResultType('default');
      setSqlResultData('-');
      setActiveTabKey(value);
      setSqlQuery('');
      initdata([]);
    }
  };

  const handleExecuteQuery = () => {

    if (sqlConn === "" || sqlConn === undefined) {
      openNotification("error", "topRight", "No Query Data !!!!");
      return
    }

    setLoading(true);
    axios.post('http://203.154.39.126/Support/SupportAPI_NET6/api/TestSQL/selectByText', { "query": sqlQuery, "db": sqlConn })
      .then(response => {
        debugger
        setLoading(false);
        if (response.data.response === 200) {
          initdata(response.data.items);
          setSqlResultPresets('yellow');
          setSqlResultType('default');
          setSqlResultData('-');
        } else if (response.data.response === 400) {
          setSqlResultPresets('red');
          setSqlResultType('error');
          setSqlResultData(response.data.message);
          initdata([]);
          initdataJsonCase([]);
        } else {
          initdata([]);
          initdataJsonCase([]);
        }

        // console.log('SQL Execution Result:', response.data);
        // ทำสิ่งที่คุณต้องการกับผลลัพธ์ที่ได้จากการประมวลผลคำสั่ง SQL
      })
      .catch(error => {
        debugger
        setLoading(false);
        setSqlResultPresets('red');
        setSqlResultType('error');
        setSqlResultData(error.message);
        initdata([]);
        initdataJsonCase([]);
        // console.error('Error executing SQL:', error);
        // จัดการกับข้อผิดพลาดที่เกิดขึ้นในการประมวลผลคำสั่ง SQL
      });


    // var myHeaders = new Headers();
    // myHeaders.append("Content-Type", "application/json");

    // var requestOptions = {
    //   method: 'POST',
    //   headers: myHeaders,
    //   body: JSON.stringify(sqlQuery),
    //   redirect: 'follow'
    // };

    // fetch("http://203.154.39.126/Test/TEST_WMS_MasterAPI_NET6/api/TestSQL/selectByText", requestOptions)
    //   .then(response => response.text())
    //   .then(result => {
    //     debugger
    //     setLoading(false);
    //     initdata(JSON.parse(result));
    //     setSqlResultPresets('yellow');
    //     setSqlResultType('default');
    //     setSqlResultData('-');
    //   })
    //   .catch(error => {
    //     debugger
    //     setLoading(false);
    //     setSqlResultPresets('red');
    //     setSqlResultType('error');
    //     setSqlResultData(error.message);
    //     initdata([]);
    //   });
  };
  //#endregion

  //#region Create columns dynamically based on keys  
  const keys = dataSource.reduce((acc, obj) => {
    Object.keys(obj).forEach(key => {
      if (!acc.includes(key)) {
        acc.push(key);
      }
    });
    return acc;
  }, []);

  // Create columns dynamically based on keys
  const columns = keys.map(key => ({
    title: key,  // Use the key as column title
    dataIndex: key, // Use the key to access data in each object
    key: key,  // Unique key for React to identify each column
  }));
  //#endregion

  //#region Modal Confirm
  const confirm = (value) => {
    Modal.confirm({
      title: '',
      style: { width: '750px' },
      icon: <ExclamationCircleOutlined />,
      okText: 'OK',
      content: (
        <div>
          <p>{'ต้องการเปลี่ยนคำสั่งการทำงาน ใช่หรือไม่ ??'}</p>
        </div>
      ),
      onOk() {
        setSqlResultPresets('yellow');
        setSqlResultType('default');
        setSqlResultData('-');
        setActiveTabKey(value);
        setSqlQuery('');
        initdata([]);
        initdataJsonCase([]);
      },
    });
  };
  //#endregion

  //#region tableFooter

  //Handle page change
  const handlePageChange = (page, pageSize) => {
    setCurrentPage(page);
    setPageSize(pageSize);
  };

  //Custom footer for the table
  // const tableFooter = () => (
  //   <div>
  //     <span>
  //       <h1 style={{ fontStyle: 'italic', fontWeight: 'bold' }}>
  //         Showing {dataSource.length === 0 ? 0 : ((currentPage - 1) * pageSize) + 1} to {Math.min(currentPage * pageSize, dataSource.length)} of {dataSource.length} items
  //       </h1>
  //     </span>
  //   </div>
  // );
  //#endregion

  //#region tebArray
  const tebArray = [
    {
      key: 'SELECT',
      label: <div
        style={{
          padding: 4,
        }}
      >
        <Avatar
          style={{
            backgroundColor: '#87d068',
          }}
        >
          SELECT
        </Avatar>
        <div>SELECT</div>
      </div>,
      children:
        <div>
          <Form
            form={formHeader_SELECT}
            layout="vertical"
            className="row-col"
            size="large"
          >
            <Row gutter={[12, 0]} >

              <Col
                span={24}
                xs={{ span: 24 }}
                md={{ span: 24 }}
                lg={{ span: 2 }}
              >
                <br></br>
                <Form.Item
                  className="form-group"
                  label="Connection"
                  name="Connection"
                >
                  <Select
                    labelInValue
                    showSearch
                    defaultValue="WMS"
                    onChange={(e) => {
                      if (e === undefined) {
                        setSqlConn('');
                      } else {
                        handleInputChangeConn(e);
                      }
                    }}
                  >
                    {dataJsonConn ? (
                      dataJsonConn.map((item) => (
                        <Option
                          key={item.conn}
                          value={item.description}
                        >
                          {item.title}
                        </Option>
                      ))
                    ) : (
                      <></>
                    )}
                  </Select>
                </Form.Item>
              </Col>

              <Col
                span={24}
                xs={{ span: 24 }}
                md={{ span: 24 }}
                lg={{ span: 6 }}
              >
                <br></br>
                <Form.Item
                  className="form-group"
                  label="Case"
                  name="Case"
                >
                  <Select
                    labelInValue
                    showSearch
                    onChange={(e) => {
                      if (e === undefined) {
                        setSqlQuery('');
                      } else {
                        setSqlQuery(e.value);
                      }
                    }}
                  >
                    {dataJsonCase ? (
                      dataJsonCase.map((item) => (
                        <Option
                          key={item.case}
                          value={item.description}
                        >
                          {item.title}
                        </Option>
                      ))
                    ) : (
                      <></>
                    )}
                  </Select>
                </Form.Item>
              </Col>

              <Col
                span={24}
                xs={{ span: 24 }}
                md={{ span: 24 }}
              // lg={{ span: 2 }}
              >
                {/* <br></br> */}
                <Form.Item
                  className="form-group"
                // label=" "
                >
                  <Button
                    className="btn-primary"
                    type="primary"
                    size="large"
                    style={{ width: "100%", color: 'white' }}
                    onClick={handleExecuteQuery}
                  >
                    Execute SQL
                  </Button>
                </Form.Item>
              </Col>

            </Row>
          </Form>

          <Row gutter={[12, 0]} >
            <Col span={24} xs="24" xl={24}>
              <Input.TextArea
                // style={{ height: "80vh" }}
                rows={5}
                placeholder={"กรุณาใส่คำสั่ง SQL " + sqlType + " ของคุณที่นี่"}
                value={sqlQuery}
                onChange={handleInputChangeCase}
              />
            </Col>
          </Row>

          <Row gutter={[12, 0]} >
            <Col span={24} xs="24" xl={24}>
              <Divider orientation="left" orientationMargin="0">
                <span>
                  <h1 style={{ fontStyle: 'italic', fontWeight: 'bold' }}>
                    Data Result {sqlResultType === "error" ? sqlResultData : (
                      dataSource.length === 0 ? "" :
                        `${((currentPage - 1) * pageSize) + 1} to ${Math.min(currentPage * pageSize, dataSource.length)} of ${dataSource.length} items`
                    )}
                  </h1>
                </span>
              </Divider>
              <div className="table-responsive">
                <Table
                  style={{
                    padding: 0,
                    margin: 0,
                    width: "100%",
                    height: "48vh",
                    borderRadius: 5,
                    backgroundColor: "rgba(255,255,255,0.8)",
                  }}
                  pagination={{
                    pageSize: pageSize, // Number of items per page
                    total: dataSource.length, // Total number of items
                    showSizeChanger: true, // Show options to change the page size
                    pageSizeOptions: [10, 20, 30, 50, 100],
                    onChange: (page, pageSize) => {
                      setPageSize(pageSize);
                      handlePageChange(page, pageSize);
                    },
                  }}
                  columns={columns}
                  dataSource={dataSource}
                  size="small"
                // footer={tableFooter}
                >
                </Table>
              </div>
            </Col>
          </Row>
        </div>
      ,
    },
    {
      key: 'UPDATE',
      label: <div
        style={{
          padding: 4,
        }}
      >
        <Avatar
          style={{
            backgroundColor: '#f56a00',
          }}
        >
          UPDATE
        </Avatar>
        <div>UPDATE</div>
      </div>,
      children:
        <div>
          <Form
            form={formHeader_UPDATE}
            layout="vertical"
            className="row-col"
            size="large"
          >
            <Row gutter={[12, 0]} >

              <Col
                span={24}
                xs={{ span: 24 }}
                md={{ span: 24 }}
                lg={{ span: 2 }}
              >
                <br></br>
                <Form.Item
                  className="form-group"
                  label="Connection"
                  name="Connection"
                >
                  <Select
                    labelInValue
                    showSearch
                    defaultValue="WMS"
                    onChange={(e) => {
                      if (e === undefined) {
                        setSqlConn('');
                      } else {
                        handleInputChangeConn(e);
                      }
                    }}
                  >
                    {dataJsonConn ? (
                      dataJsonConn.map((item) => (
                        <Option
                          key={item.conn}
                          value={item.description}
                        >
                          {item.title}
                        </Option>
                      ))
                    ) : (
                      <></>
                    )}
                  </Select>
                </Form.Item>
              </Col>

              <Col
                span={24}
                xs={{ span: 24 }}
                md={{ span: 24 }}
                lg={{ span: 6 }}
              >
                <br></br>
                <Form.Item
                  className="form-group"
                  label="Case"
                  name="Case"
                >
                  <Select
                    labelInValue
                    showSearch
                    onChange={(e) => {
                      // if (e === undefined) {
                      //   setSqlQuery('');
                      // } else {
                      //   setSqlQuery(e.value);
                      // }
                    }}
                  >
                    {/* {dataJsonCase ? (
                      dataJsonCase.map((item) => (
                        <Option
                          key={item.case}
                          value={item.description}
                        >
                          {item.title}
                        </Option>
                      ))
                    ) : (
                      <></>
                    )} */}
                  </Select>
                </Form.Item>
              </Col>

              <Col
                span={24}
                xs={{ span: 24 }}
                md={{ span: 24 }}
              // lg={{ span: 2 }}
              >
                {/* <br></br> */}
                <Form.Item
                  className="form-group"
                // label=" "
                >
                  <Button
                    className="btn-primary"
                    type="primary"
                    size="large"
                    style={{ width: "100%", color: 'white' }}
                    // onClick={handleExecuteQuery}
                  >
                    Execute SQL
                  </Button>
                </Form.Item>
              </Col>

            </Row>
          </Form>

          <Row gutter={[12, 0]} >
            <Col span={24} xs="24" xl={24}>
              <Input.TextArea
                // style={{ height: "80vh" }}
                rows={5}
                placeholder={"กรุณาใส่คำสั่ง SQL " + sqlType + " ของคุณที่นี่"}
                value={sqlQuery}
                onChange={handleInputChangeCase}
              />
            </Col>
          </Row>

          <Row gutter={[12, 0]} >
            <Col span={24} xs="24" xl={24}>
              <Divider orientation="left" orientationMargin="0">
                <span>
                  <h1 style={{ fontStyle: 'italic', fontWeight: 'bold' }}>
                    Data Result
                  </h1>
                </span>
              </Divider>
              <Badge.Ribbon
                text="Processing"
                color={sqlResultPresets}
              >
                <Card title="" size="small"
                  style={{
                    width: "100%",
                    height: "48vh",
                  }}
                >
                  {
                    <p>
                      {
                        sqlResultType === 'default' ?
                          <Tag icon={<ClockCircleOutlined />} color="default">
                            waiting
                          </Tag>
                          : sqlResultType === 'success' ?
                            <Tag icon={<CheckCircleOutlined />} color="success">
                              success
                            </Tag>
                            :
                            <Tag icon={<CloseCircleOutlined />} color="error">
                              error
                            </Tag>
                      }
                      {sqlResultData}
                    </p>
                  }
                </Card>
              </Badge.Ribbon>
            </Col>
          </Row>
        </div>
      ,
    },
    {
      key: 'INSERT',
      label: <div
        style={{
          padding: 4,
        }}
      >
        <Avatar
          style={{
            backgroundColor: '#f56a00',
          }}
        >
          INSERT
        </Avatar>
        <div>INSERT</div>
      </div>,
      children:
        <div>
          <Form
            form={formHeader_INSERT}
            layout="vertical"
            className="row-col"
            size="large"
          >
            <Row gutter={[12, 0]} >

              <Col
                span={24}
                xs={{ span: 24 }}
                md={{ span: 24 }}
                lg={{ span: 2 }}
              >
                <br></br>
                <Form.Item
                  className="form-group"
                  label="Connection"
                  name="Connection"
                >
                  <Select
                    labelInValue
                    showSearch
                    defaultValue="WMS"
                    onChange={(e) => {
                      if (e === undefined) {
                        setSqlConn('');
                      } else {
                        handleInputChangeConn(e);
                      }
                    }}
                  >
                    {dataJsonConn ? (
                      dataJsonConn.map((item) => (
                        <Option
                          key={item.conn}
                          value={item.description}
                        >
                          {item.title}
                        </Option>
                      ))
                    ) : (
                      <></>
                    )}
                  </Select>
                </Form.Item>
              </Col>

              <Col
                span={24}
                xs={{ span: 24 }}
                md={{ span: 24 }}
                lg={{ span: 6 }}
              >
                <br></br>
                <Form.Item
                  className="form-group"
                  label="Case"
                  name="Case"
                >
                  <Select
                    labelInValue
                    showSearch
                    onChange={(e) => {
                      // if (e === undefined) {
                      //   setSqlQuery('');
                      // } else {
                      //   setSqlQuery(e.value);
                      // }
                    }}
                  >
                    {/* {dataJsonCase ? (
                      dataJsonCase.map((item) => (
                        <Option
                          key={item.case}
                          value={item.description}
                        >
                          {item.title}
                        </Option>
                      ))
                    ) : (
                      <></>
                    )} */}
                  </Select>
                </Form.Item>
              </Col>

              <Col
                span={24}
                xs={{ span: 24 }}
                md={{ span: 24 }}
              // lg={{ span: 2 }}
              >
                {/* <br></br> */}
                <Form.Item
                  className="form-group"
                // label=" "
                >
                  <Button
                    className="btn-primary"
                    type="primary"
                    size="large"
                    style={{ width: "100%", color: 'white' }}
                    onClick={handleExecuteQuery}
                  >
                    Execute SQL
                  </Button>
                </Form.Item>
              </Col>

            </Row>
          </Form>

          <Row gutter={[12, 0]} >
            <Col span={24} xs="24" xl={24}>
              <Input.TextArea
                // style={{ height: "80vh" }}
                rows={5}
                placeholder={"กรุณาใส่คำสั่ง SQL " + sqlType + " ของคุณที่นี่"}
                value={sqlQuery}
                onChange={handleInputChangeCase}
              />
            </Col>
          </Row>

          <Row gutter={[12, 0]} >
            <Col span={24} xs="24" xl={24}>
              <Divider orientation="left" orientationMargin="0">
                <span>
                  <h1 style={{ fontStyle: 'italic', fontWeight: 'bold' }}>
                    Data Result
                  </h1>
                </span>
              </Divider>
              <Badge.Ribbon text="Processing" color={sqlResultPresets}>
                <Card title="" size="small"
                  style={{
                    width: "100%",
                    height: "48vh",
                  }}
                >
                  {
                    <p>
                      {
                        sqlResultType === 'default' ?
                          <Tag icon={<ClockCircleOutlined />} color="default">
                            waiting
                          </Tag>
                          : sqlResultType === 'success' ?
                            <Tag icon={<CheckCircleOutlined />} color="success">
                              success
                            </Tag>
                            :
                            <Tag icon={<CloseCircleOutlined />} color="error">
                              error
                            </Tag>
                      }
                      {sqlResultData}
                    </p>
                  }
                </Card>
              </Badge.Ribbon>
            </Col>
          </Row>
        </div >
      ,
    },
  ];
  //#endregion
  
  //#region return
  return (
    <div>
      <Spin spinning={loading} delay={500} size="large">
        <Row gutter={[12, 0]}>
          <Col span={24} xs="24" xl={24}>
            {/* <Switch defaultChecked onChange={onChangeSwitch} /> */}

            {/* <Form.Item
              className="form-group"
              // label="Connection"
              name="Connection"
            >
              <Select
                labelInValue
                showSearch
                defaultValue="WMS"
                style={{
                  width: 220,
                }}
                onChange={(e) => {
                  if (e === undefined) {
                    setSqlConn('');
                  } else {
                    handleInputChangeConn(e);
                  }
                }}
              >
                {dataJsonConn ? (
                  dataJsonConn.map((item) => (
                    <Option
                      key={item.conn}
                      value={item.description}
                    >
                      {item.title}
                    </Option>
                  ))
                ) : (
                  <></>
                )}
              </Select>
            </Form.Item> */}

            <Tabs
              size={'small'}
              style={{
                marginBottom: 12,
              }}
              tabPosition={'left'}
              onChange={handleSqlTypeChange}
              defaultActiveKey={defaultActiveKey}
              activeKey={activeTabKey}
              items={tebArray}
            >
            </Tabs>
          </Col>
        </Row>
      </Spin>

    </div>
  );
  //#endregion

};

export default SqlInputForm;
