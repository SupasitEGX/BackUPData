import {
  Table,
  Tooltip,
  Switch,
  Button,
  Space,
  Modal,
  message,
  Row,
  Spin,
  Col,
  Card,
  Form,
  Input,
  InputNumber,
  Alert,
  Divider,
  Select,
  Radio,
  notification,
  Checkbox,
  Tabs,
  Layout,
  DatePicker,
  TimePicker,
  Tree,
  Dropdown,
  Badge,
  MenuProps,
  Menu,
  Collapse,
  AutoComplete,
} from "antd";
import axios from "axios";
import React, { useRef, useState, useEffect } from "react";
import {
  EditOutlined,
  DeleteOutlined,
  FileFilled,
  SearchOutlined,
  ExclamationCircleFilled,
  PlusOutlined,
  EyeInvisibleOutlined,
  EyeTwoTone,
  CloseCircleFilled,
  CheckCircleFilled,
  DownSquareFilled,
  CloseCircleOutlined,
  CheckOutlined,
  CloseOutlined,
  StarOutlined,
  FormOutlined,
  ClockCircleFilled,
  DeleteFilled,
  PrinterOutlined,
  UnorderedListOutlined,
  PrinterTwoTone,
} from "@ant-design/icons";
import dayjs from "dayjs";
import { NotificationPlacement } from "antd/es/notification";

const SqlTESTForm = () => {
  const { confirm } = Modal;
  const [loading, setLoading] = useState(false); //true
  const [formHeader] = Form.useForm();
  const searchInput = useRef(null);
  const [mainvisible, setmain] = useState(true);
  const [dataSource, setDataSource] = useState([]);
  const [isPageSize, setisPageSize] = useState(10);
  const [searchText, setSearchText] = useState("");
  const [searchedColumn, setSearchedColumn] = useState("");
  const [selectedRowKeys, setSelectedRowKeys] = useState([]);
  const [selectedRowDatas, setSelectedRowDatas] = useState([]);

  const [tagData, setTagData] = useState([]);
  const [tagItemData, setTagItemData] = useState([]);

  const data1 = [
    {
      key: 1,
      name: "Check Diff GI VS Bal",
      age: 32,
      tag_Index:"1"
    },
    {
      key: 2,
      name: "Check Diff GI VS Bal",
      age: 40,
      tag_Index:"2"
    },
  ];

  const data2 = [
    {
      key: "1",
      name: "4",
      age: 32,
      tagItemIndex: "1",
      tag_Index:"1"
    },
    {
      key: "2",
      name: "5",
      age: 42,
      tagItemIndex: "2",
      tag_Index:"1"
    },
    {
      key: "3",
      name: "6",
      age: 32,
      tagItemIndex: "3",
      tag_Index:"2"
    },
  ];

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
    // const fetchData = async () => {};
    // fetchData();
    setTagData(data1);
  }, []);
  //#endregion

  const showCreateOrUpdate = (type, param) => {
    // setmain(false);
    // setcreateupdate(true);
  };

  //#region convertDate
  const convertDateStart = (param) => {
    var d1 = new Date(param).toLocaleDateString("fr-FR");
    var array1 = d1.split("/");
    return array1[2] + array1[1] + array1[0];
  };

  const convertDateEnd = (param) => {
    var d1 = new Date(param).toLocaleDateString("fr-FR");
    var array1 = d1.split("/");
    return array1[2] + array1[1] + array1[0];
  };

  const convertDateFilterStart = (param) => {
    var d1 = new Date(param).toLocaleDateString("fr-FR");
    var array1 = d1.split("/");
    return array1[2] + "-" + array1[1] + "-" + array1[0] + "T00:00:00Z";
  };

  const convertDateFilterEnd = (param) => {
    var d1 = new Date(param).toLocaleDateString("fr-FR");
    var array1 = d1.split("/");
    return array1[2] + "-" + array1[1] + "-" + array1[0] + "T23:59:59Z";
  };

  const convertDate = (param) => {
    if (param === "" || param === null || param === undefined) {
      return "-";
    }
    return (
      param.substring(8, 6) +
      "/" +
      param.substring(6, 4) +
      "/" +
      param.substring(0, 4)
    );
  };
  //#endregion

  //#region handleSearch
  const handleSearch = (selectedKeys, confirm, dataIndex) => {
    confirm();
    setSearchText(selectedKeys[0]);
    setSearchedColumn(dataIndex);
  };
  //#endregion

  //#region getColumnSearchProps

  const getColumnSearchProps = (dataIndex) => ({
    filterDropdown: ({
      setSelectedKeys,
      selectedKeys,
      confirm,
      clearFilters,
    }) => (
      <div style={{ padding: 8 }}>
        <Input
          ref={searchInput}
          placeholder={`Search ${dataIndex}`}
          value={selectedKeys[""]}
          onChange={(e) =>
            setSelectedKeys(e.target.value ? [e.target.value] : [])
          }
          onPressEnter={() => handleSearch(selectedKeys, confirm, dataIndex)}
          style={{ width: 188, marginBottom: 8, display: "block" }}
        />
        <Space align="end">
          <Button
            type="primary"
            onClick={() => handleSearch(selectedKeys, confirm)}
            icon={<SearchOutlined />}
            size="small"
            style={{ width: 90 }}
          >
            Search
          </Button>
        </Space>
      </div>
    ),
    filterIcon: (filtered) => (
      <SearchOutlined style={{ color: filtered ? "#1890ff" : undefined }} />
    ),
    onFilter: (value, record) =>
      record[dataIndex]
        ? record[dataIndex]
            .toString()
            .toLowerCase()
            .includes(value.toLowerCase())
        : "",
  });
  //#endregion
  const deleteTagItem = () => {
    confirm({
      title: "you want to delete?",
      icon: <ExclamationCircleFilled />,
      okText: "Yes",
      okType: "danger",
      cancelText: "No",
      onOk() {},
      onCancel() {},
    });
  };
  const onSelectChange = (newSelectedRowKeys) => {
    console.log('selectedRowKeys changed: ', newSelectedRowKeys);
    setSelectedRowKeys(newSelectedRowKeys);
  };
  const rowSelection = {
    selectedRowKeys,
    onChange: onSelectChange,
  };

const showTagItem = (param) =>{
  debugger
  var Ti = data2.filter((i) => i.tag_Index===param.tag_Index);
  setTagItemData(Ti);
};

  //#region columns
  const columns1 = [
    {
      title: "action",
      key: "Action",
      width: 50,
      render: (text, record) => (
        <Space>
          <Tooltip title='edit'>
            <Button
              style={{ background: '#47a447', color: 'white' }}
              onClick={() => (showTagItem(record))}
              className="btn-action"
              icon={<DeleteOutlined />}
            ></Button>
          </Tooltip>
        </Space>
      ),
    },
    {
      title: "Detail",
      dataIndex: "name",
      key: "name",
      width: 150,
    },
    {
      title: "Tag_No",
      dataIndex: "age",
      key: "age",
      width: 120,
    },
    {
      title: "Product_Id",
      dataIndex: "age",
      key: "age",
      width: 120,
    },
    {
      title: "Product_Name",
      dataIndex: "age",
      key: "age",
      width: 120,
    },
    {
      title: "BinBalance_QtyBal",
      dataIndex: "age",
      key: "age",
      width: 120,
    },
    {
      title: "BinBalance_QtyReserve",
      dataIndex: "age",
      key: "age",
      width: 150,
    },
    {
      title: "Gi_TotalQty",
      dataIndex: "age",
      key: "age",
      width: 120,
    },
    {
      title: "Diff",
      dataIndex: "age",
      key: "age",
      width: 120,
    },
  ];

  
  const columns2 = [
    {
      title: "TotalQty",
      dataIndex: "name",
      key: "name",
      width: 70,
    },
    {
      title: "Tag_No",
      dataIndex: "age",
      key: "age",
      width: 70,
    },
    {
      title: "Product_Id",
      dataIndex: "age",
      key: "age",
      width: 70,
    },
    {
      title: "Product_Name",
      dataIndex: "age",
      key: "age",
      width: 120,
    },
  ];

  

  //#endregion

  //#region return
  return (
    <div>
      <Spin spinning={loading} delay={500} size="large">
        {mainvisible && (
          <Row gutter={[24, 0]}>
            <Col span={24} xs="24" xl={24}>
              {/* #region ------------------ */}
              <Card
                bordered={false}
                className="criclebox tablespace mb-24"
                title="Check Diff Reserve"
                style={{
                  paddingLeft: "3rem",
                }}
              >
                <Form
                  form={formHeader}
                  layout="vertical"
                  className="row-col"
                  // size="large"
                >
                  <Row gutter={[6, 0]} style={{ paddingTop: "10px" }}>
                    {/* <Col
                          span={24}
                          xs={{ span: 24 }}
                          md={{ span: 24 }}
                          lg={{ span: 2 }}
                        ></Col> */}
                    <Col
                      span={24}
                      xs={{ span: 24 }}
                      md={{ span: 24 }}
                      lg={{ span: 4 }}
                    >
                      <Form.Item
                        className="form-group "
                        label="GI No"
                        name="GI No"
                        rules={[
                          {
                            required: true,
                            message: "Please input your GI!",
                          },
                        ]}
                      >
                        <Input placeholder="GI No" />
                      </Form.Item>
                    </Col>

                    <Col
                      span={24}
                      xs={{ span: 24 }}
                      md={{ span: 24 }}
                      lg={{ span: 4 }}
                    >
                      <Form.Item className="form-group " label=" ">
                        <Button
                          //onClick={() => filter({})}
                          type="primary"
                          size="large"
                          className="btn-primary"
                          style={{
                            width: "100%",
                            background: "#45556a",
                            color: "white",
                          }}
                          icon={<SearchOutlined />}
                        >
                          Search
                        </Button>
                      </Form.Item>
                    </Col>
                  </Row>

                  <Table
                   rowKey={(record) => record.id}
                    columns={columns1}
                    dataSource={tagData}
                    scroll={{
                      y: 150,
                      x: 1000,
                    }}
                    pagination={false}
                  />

                  <Table
                  rowKey={(record) => record.id}
                    rowSelection={rowSelection}
                    columns={columns2}
                    dataSource={tagItemData}
                    scroll={{
                      y: 150,
                      x: 1000,
                    }}
                    pagination={false}
                  />

                  <div style={{ display: "flex", justifyContent: "center" }}>
                    <Form.Item className="form-group " label=" ">
                      <Button
                        onClick={() => deleteTagItem({})}
                        type="primary"
                        size="large"
                        className="btn-primary"
                        style={{
                          width: 120,
                          color: "white",
                        }}
                        danger
                      >
                        Delete
                      </Button>
                    </Form.Item>
                  </div>
                </Form>
              </Card>

              {/* #endregion */}
            </Col>
          </Row>
        )}
      </Spin>
    </div>
  );
  //#endregion
};

export default SqlTESTForm;
