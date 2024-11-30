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
import axios from 'axios';
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
  const [loading, setLoading] = useState(false); //true
  const [formHeader] = Form.useForm();
  const searchInput = useRef(null);
  const [mainvisible, setmain] = useState(true);
  const [dataSource, setDataSource] = useState([]);
  const [isPageSize, setisPageSize] = useState(10);
  const [searchText, setSearchText] = useState("");
  const [searchedColumn, setSearchedColumn] = useState("");

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
  }, []);
  //#endregion

  //#region filter
  const filter = () => {
    let params = formHeader.getFieldValue();

    axios.post('http://203.154.39.126/Amazon/backend/AMZ_SupportAPI/api/Support/filter', {
      "tagOut_No_1": params.Tag_no //"424041484"
    })
    .then(response => { 
      if(response.data[0].Tag_No === null || response.data[0] === undefined)
      {
        openNotification("warning", "top", "tag not found !!");
      }
      else
      {
        formHeader.setFieldsValue({
          No: response.data[0].No, 
          Product_Id: response.data[0].Product_Id,
          Product_Name: response.data[0].Product_Name,
          Station: response.data[0].Station,
          Status: response.data[0].Status,
          Tag_No: response.data[0].Tag_No,
        });
      }

    })
    .catch(error => {
      
    });
  };
  //#endregion
  const filmcut_update = (statusValue) => {
      let params = formHeader.getFieldValue();

      debugger
      if(params !== undefined && params.Tag_no != null && params.Station != null && params.Status === 10)
      {
        axios.post('http://203.154.39.126/Amazon/backend/AMZ_SupportAPI/api/Support/update', {
          "tagOut_No_1" : params.Tag_no , "status": statusValue
        })
        .then(response => { 
  
          debugger
          openNotification("success", "top", "update success.");
          formHeader.resetFields();
  
        })
        .catch(error => {
          
        });
      }
      else
      {
          openNotification("warning", "top", "cannot update filmcutting wcs.");
      }

  };
  
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

  //#region columns
  const columns = [
    // {
    //   title: "Action",
    //   key: "Action",
    //   fixed: "left",
    //   width: 150,
    //   render: (text, record) => (
    //     <Space>
    //       <Tooltip title="Edit">
    //         <Button
    //           style={{ background: "#47a447", color: "white" }}
    //           onClick={() => showCreateOrUpdate("update", record)}
    //           className="btn-action"
    //           // shape="circle"
    //           icon={<EditOutlined />}
    //         />
    //       </Tooltip>
    //       <Tooltip title="Confirm">
    //         <Button
    //           style={{
    //             background:
    //               record.document_Status !== 0 ? "#cccccc" : "#EAC200",
    //             color: "white",
    //           }}
    //           onClick={() => showConfirmStatus(record)}
    //           Primary
    //           className="btn-action"
    //           // shape="circle"
    //           type="primary"
    //           // icon={<CheckCircleFilled />}
    //           icon={<CheckOutlined />}
    //           disabled={record.document_Status != 0}
    //         />
    //       </Tooltip>
    //       <Tooltip title="other">
    //         <Dropdown
    //           style={{ background: "#e89113", color: "white" }}
    //           className="btn-action"
    //           placement="bottom"
    //           trigger={["click"]}
    //           disabled={record.tabselect == 3 || record.tabselect == 4}
    //           // shape="circle"
    //           overlay={
    //             <Menu>
    //               <Menu.Item
    //                 disabled={record.tabselect != 1}
    //                 key="1"
    //                 onClick={() => showDeleteConfirm(record)}
    //               >
    //                 Cancel
    //               </Menu.Item>
    //               <Menu.Item
    //                 disabled={record.tabselect != 2}
    //                 key="2"
    //                 onClick={() => showCloseConfirm(record)}
    //               >
    //                 Close Document
    //               </Menu.Item>
    //             </Menu>
    //           }
    //         >
    //           <Button>
    //             <UnorderedListOutlined />
    //           </Button>
    //         </Dropdown>
    //       </Tooltip>
    //     </Space>
    //   ),
    // },
    {
      title: "No.",
      dataIndex: "row",
      key: "row",
      filterSearch: false,
      width: 80,
      render: (text, record, index) => index + 1,
    },
    {
      title: "Order No",
      dataIndex: "planGoodsIssue_No",
      key: "planGoodsIssue_No",
      filterSearch: false,
      width: 150,
      sorter: (a, b) => a.planGoodsIssue_No.localeCompare(b.planGoodsIssue_No),
      ...getColumnSearchProps("planGoodsIssue_No"),
    },
  ];

  //#endregion

  //#region return
  return (
    <div>
      <Spin spinning={loading} delay={500} size="large">
        {mainvisible && (
          <Row gutter={[24, 0]} >
            <Col span={24} xs="24" xl={24}>
              {/* #region ------------------ */}
              <Card
                bordered={false}
                className="criclebox tablespace mb-24"
                title="Cutting Film"
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
                        label="Tag No"
                        name="Tag_no"
                        rules={[
                          {
                            required: true,
                            message: "Please input your Tag No!",
                          },
                        ]}
                      >
                        <Input placeholder="Tag No" />
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
                          onClick={() => filter({})}
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
                  <Row gutter={[12, 0]}>
                    <Col
                      span={24}
                      xs={{ span: 24 }}
                      md={{ span: 24 }}
                      lg={{ span: 8 }}
                    >
                      <Form.Item className="form-group " label="ลำดับ" name="No">
                        <Input placeholder="ลำดับ" disabled/>
                      </Form.Item>
                    </Col>
                  </Row>
                  <Row gutter={[12, 0]}>
                    <Col
                      span={24}
                      xs={{ span: 24 }}
                      md={{ span: 24 }}
                      lg={{ span: 8 }}
                    >
                      <Form.Item
                        className="form-group "
                        label="Tag No"
                        name="Tag_No"
                      >
                        <Input placeholder="Tag No" disabled/>
                      </Form.Item>
                    </Col>
                  </Row>
                  <Row gutter={[12, 0]}>
                    <Col
                      span={24}
                      xs={{ span: 24 }}
                      md={{ span: 24 }}
                      lg={{ span: 8 }}
                    >
                      <Form.Item
                        className="form-group "
                        label="Product ID"
                        name="Product_Id"
                      >
                        <Input placeholder="Product ID" disabled/>
                      </Form.Item>
                    </Col>
                  </Row>
                  <Row gutter={[12, 0]}>
                    <Col
                      span={24}
                      xs={{ span: 24 }}
                      md={{ span: 24 }}
                      lg={{ span: 8 }}
                    >
                      <Form.Item
                        className="form-group "
                        label="Product Name"
                        name="Product_Name"
                      >
                        <Input placeholder="Product Name" disabled/>
                      </Form.Item>
                    </Col>
                  </Row>
                  <Row gutter={[12, 0]}>
                    <Col
                      span={24}
                      xs={{ span: 24 }}
                      md={{ span: 24 }}
                      lg={{ span: 8 }}
                    >
                      <Form.Item
                        className="form-group "
                        label="Station"
                        name="Station"
                      >
                        <Input placeholder="Station" disabled/>
                      </Form.Item>
                    </Col>
                  </Row>
                  <Row gutter={[12, 0]}>
                    <Col
                      span={24}
                      xs={{ span: 24 }}
                      md={{ span: 24 }}
                      lg={{ span: 8 }}
                    >
                      <Form.Item className="form-group " label="สถานะ" name="Status">
                        <Input placeholder="สถานะ" disabled/>
                      </Form.Item>
                    </Col>
                  </Row>
                  <Row>
                    <Col
                      span={24}
                      xs={{ span: 24 }}
                      md={{ span: 24 }}
                      lg={{ span: 8 }}
                    >
                      <Form.Item className="form-group " label=" ">
                        <Button
                          onClick={() => filmcut_update(20)}
                          type="primary"
                          size="large"
                          className="btn-primary"
                          style={{
                            width: "100%",
                            background: "#45556a",
                            color: "white",
                          }}
                        >
                          Update
                        </Button>
                      </Form.Item>
                    </Col>
                  </Row>
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
