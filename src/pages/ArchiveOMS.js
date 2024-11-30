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
import React, { useRef, useState, useEffect,Component } from "react";
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
import * as XLSX from "xlsx";
import { NotificationPlacement } from "antd/es/notification";

const ArchiveOMS = () => {
  // const { Option } = Select;
  // const [formHeader_SELECT] = Form.useForm();
  // const [formHeader_UPDATE] = Form.useForm();
  // const [formHeader_INSERT] = Form.useForm();
  const [pageSize, setPageSize] = useState(10);
  const [currentPage, setCurrentPage] = useState(1);
  const [loading, setLoading] = useState(false); //true
  // const [sqlQuery, setSqlQuery] = useState('');
  // const [sqlConn, setSqlConn] = useState('');
  const [dataSource, setdataSource] = useState([]);
  // const [sqlResultData, setSqlResultData] = useState('-');
  // const [sqlResultType, setSqlResultType] = useState('default');
  // const [sqlResultPresets, setSqlResultPresets] = useState('yellow'); //// [red, yellow, green]
  // const [sqlType, setSqlType] = useState('SELECT');
  // const [activeTabKey, setActiveTabKey] = useState('SELECT');
  // const [defaultActiveKey, setdefaultActiveKey] = useState(1);
  // const [dataJsonCase, initdataJsonCase] = useState([]);
  // const [dataJsonConn, initdataJsonConn] = useState([]);
  const [formValues, setFormValues] = useState({ Start_Date: "", End_Date: "" });
  const [flag, setflag] = useState(0);
  
 
    

 

  
  const columns = [
    // {
    //   title: "archiveData_Index",
    //   dataIndex: "archiveData_Index",
    //   key: "archiveData_Index",
    // },
    {
      title: "archiveData_Name",
      dataIndex: "archiveData_Name",
      key: "archiveData_Name",
    },
    // {
    //   title: "archiveData_Status",
    //   dataIndex: "archiveData_Status",
    //   key: "archiveData_Status",
    // },
    {
      title: "archiveData_Table_Name",
      dataIndex: "archiveData_Table_Name",
      key: "archiveData_Table_Name",
    },
    {
      title: "archiveData_Period",
      dataIndex: "archiveData_Period",
      key: "archiveData_Period",
    },
    {
      title: "archiveData_BeforeCount",
      dataIndex: "archiveData_BeforeCount",
      key: "archiveData_BeforeCount",
    },
    {
      title: "archiveData_Count",
      dataIndex: "archiveData_Count",
      key: "archiveData_Count",
    },
    {
      title: "archiveData_Balance_Count",
      dataIndex: "archiveData_Balance_Count",
      key: "archiveData_Balance_Count",
    },
    {
      title: "archiveData_Min_Date",
      dataIndex: "archiveData_Min_Date",
      key: "archiveData_Min_Date",
    },
    {
      title: "archiveData_Start_Date",
      dataIndex: "archiveData_Start_Date",
      key: "archiveData_Start_Date",
    },
    {
      title: "archiveData_End_Date",
      dataIndex: "archiveData_End_Date",
      key: "archiveData_End_Date",
    },
    {
      title: "message",
      dataIndex: "message",
      key: "message",
    },                  
  ];
  // const fetchData = async () => {
  //   let isMounted = true;
  //   setLoading(true);
  //   try {
//   const response = await fetch("https://localhost:44378/api/LogArchive/LogArchive_Data",{
//    method: "POST",
//   headers: { "Content-Type": "application/json" },
//     body: JSON.stringify({}),
//  })
  //     const response = await axios.post(
  //       "https://localhost:44378/api/LogArchive/LogArchive_Data",
  //       {}, // Payload หรือข้อมูลที่ต้องการส่งใน POST body
  //       {
  //         headers: { "Content-Type": "application/json" },
  //       }
  //     );
  //     // if (!response.ok) {
  //     //   throw new Error(`HTTP error! Status: ${response.status}`);
  //     // }
  //     console.log("Response",response);
  //     const data = response.data;
  //     console.log(data);
  //     initdata("Data",data);
      
  //   } catch (error) {
  //     handleError(error.message || "Error connecting to API");
      
  //   } finally {
  //     if (isMounted) {
  //       setLoading(false); // Update state only if mounted
  //     }
  //   }
  // };
  // const fetchData = async () => {
  //   setLoading(true);
    
  //   try {
  //     const response = fetch("https://localhost:44378/api/LogArchive/LogArchive_Data",{
  //       method: "POST",
  //      headers: { "Content-Type": "application/json" },
  //        body: JSON.stringify({}),
  //     }).then(res=>{ return res.json()}).then(resjson=>{setdataSource(resjson);});
      
  //     console.log(dataSource);
  //     debugger
  //     // const result =response.json();
  //     // setdataSource(result); // Update the state
  //   } catch (error) {
  //     handleError(error.response?.data?.message || error.message || "Error connecting to API");
  //   } finally {
  //     setLoading(false); // Set loading to false when done
  //   }
  // };
  // Log the dataSource after it's updated

  
  // const ShowdataSource = dataSource.map(d=>{
  //   console.log("ShowdataSource",d)
  //   return d;
  // })
  
  const fetchData = async () => {
    setLoading(true);
    try {
      const response = await fetch("http://203.154.39.126/Amazon/backEnd/AMZ_SupportAPI/api/LogArchiveOMS/LogArchive_Data", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({
          Start_Date: formValues.Start_Date,
          End_Date: formValues.End_Date,
        }),
      }).then(res=>{ return res.json()}).then(resjson=>{setdataSource(resjson);});
      console.log(dataSource);
    } catch (error) {
      handleError(error.message || "Error connecting to API");
    } finally {
      setLoading(false);
    }
  };
  
  const handleError = (message) => {
    setLoading(false);
    notification.error({
      message: "Error",
      description: message,
    });
    
  };
  // useEffect(() => {
  //   console.log("Updated dataSource ss", dataSource);
  //   fetchData();
  //   return () => {
  //     console.log('Component is unmounted.');
  //   };
  // },[]);

  const handleInputChange = (e) => {
    const { name, value } = e.target;
    setFormValues({ ...formValues, [name]: value });
    if(name =='Start_Date'){
      console.log('Start_Date name:',name)
      console.log('Start_Date value:',value)
    }else{
      console.log('End_Date name:' ,name)
      console.log('End_Date value:' ,value)
    }
    
  };
  const handleClickSearch= async ()=>{
    //console.log("click");
    console.log("Start_Date",formValues.Start_Date);
    console.log("End_Date",formValues.End_Date);
    fetchData();
  }
  const handleClickExport = () => {
    try {
      const exportData = dataSource.map(item => ({
        archiveData_Name: item.archiveData_Name,
        archiveData_Table_Name: item.archiveData_Table_Name,
        archiveData_Period: item.archiveData_Period,
        archiveData_BeforeCount: item.archiveData_BeforeCount,
        archiveData_Count: item.archiveData_Count,
        archiveData_Balance_Count: item.archiveData_Balance_Count,
        archiveData_Min_Date: item.archiveData_Min_Date,
        archiveData_Start_Date: item.archiveData_Start_Date,
        archiveData_End_Date: item.archiveData_End_Date,
        message: item.message
      }));
  
      const ws = XLSX.utils.json_to_sheet(exportData);
      const headers = columns.map(col => col.title);
      XLSX.utils.sheet_add_aoa(ws, [headers], { origin: 'A1' });
      const wb = XLSX.utils.book_new();
      XLSX.utils.book_append_sheet(wb, ws, "LogArchiveOMS");
      XLSX.writeFile(wb, "LogArchiveOMS_Data.xlsx", { compression: true });
    } catch (error) {
      console.error("Export Error: ", error);
      notification.error({
        message: "Export Failed",
        description: error.message || "An error occurred during export",
      });
    }
  };
  return (
    <Spin spinning={loading}>
      <h3>Log Archive Data OMS</h3>
      <Form
        className="row-col"
      >
        <Row>
          <Col>
            <Form.Item
              label="Start_Date"
            >
              <Input 
              id ='Start_Date'
              placeholder="Start Date" 
              type="date"
              name="Start_Date"
              value={formValues.Start_Date}
              onChange={handleInputChange}
              ></Input>
            </Form.Item>
          </Col>
          <Col>
            <Form.Item
              label="End_Date"
            >
              <Input 
              id ='End_Date'
              placeholder="End Date" 
              type="date"
              name="End_Date"
              value={formValues.End_Date}
              onChange={handleInputChange}
              ></Input>
            </Form.Item>
          </Col>
          <Col 
          >
            <Form.Item>
            <Button
              size="large"
              style={{ width: "100%", color: '#ffffff' ,backgroundColor:'gray',marginLeft:17}}
              id ='btn-search'
              onClick={handleClickSearch}
              icon={<SearchOutlined />}
            >
              Search
            </Button>
            </Form.Item>
          </Col>
          <Col 
          >
            <Form.Item>
            <Button
              size="large"
              style={{ width: "100%", color: '#ffffff' ,backgroundColor:'gray',marginLeft:17}}
              id ='btn-search'
              onClick={handleClickExport}
              //icon={<SearchOutlined />}
            >
              Export
            </Button>
            </Form.Item>
          </Col>
        </Row>
        
      </Form>

        <Table
          dataSource={dataSource}
          columns={columns}
          rowKey="archiveData_Index"
          pagination={{
            pageSize,
            current: currentPage,
            onChange: (page, size) => {
              setCurrentPage(page);
              setPageSize(size);
            },
          }}
        />
    </Spin>
  );
  
};

export default ArchiveOMS;
