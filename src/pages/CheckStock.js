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
  Tag,
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
  ScissorOutlined ,
} from "@ant-design/icons";
import dayjs from "dayjs";
import * as XLSX from "xlsx";
import { NotificationPlacement } from "antd/es/notification";

const CheckStock = () => {
  const [pageSize, setPageSize] = useState(10);
  const [currentPage, setCurrentPage] = useState(1);
  const [loading, setLoading] = useState(false); //true
  const [dataSource, setdataSource] = useState([]);
  const [isSearched, setIsSearched] = useState(false); // สถานะตรวจสอบการค้นหา

  const [formValues, setFormValues] = useState({ Tag_no: "", Goodsissue_no: "" });

  const [TagItemData, setTagItemData] = useState([]);
  const [BinBalanceData, setBinBalanceData] = useState([]);
  const [griData, setgriData] = useState([]);
  const [gilData, setgilData] = useState([]);
  const [gilSQTYData, setgilSQTYData] = useState([]);
  const [TaskItemData, setTaskItemData] = useState([]);
  const [TagOutItemData, setTagOutItemData] = useState([]);
  const [BinCardReserve_GINOTCOMFIRMData, setBinCardReserve_GINOTCOMFIRMData] = useState([]);
  const [BinCardReserveData, setBinCardReserveData] = useState([]);
  const [BinBalanceGIData, setBinBalanceGIData] = useState([]);
  const [BinBalanceGRData, setBinBalanceGRData] = useState([]);
  const [GoodsTransferItemWTData, setGoodsTransferItemDataWT] = useState([]);
  const [GoodsTransferItemWGITLData, setGoodsTransferItemDataWGITL] = useState([]);
  const [Bin_index,setBin_index] =useState([]);
  const columns = [
    {
      title: "create_By",
      dataIndex: "create_By",
      key: "create_By",
      render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "cancel_Date",
      dataIndex: "cancel_Date",
      key: "cancel_Date",
      render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "cancel_By",
      dataIndex: "cancel_By",
      key: "cancel_By",
      render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "cancel_By",
      dataIndex: "cancel_By",
      key: "cancel_By",
      render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "update_Date",
      dataIndex: "update_Date",
      key: "update_Date",
      render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "update_By",
      dataIndex: "update_By",
      key: "update_By",
      render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "location_Name",
      dataIndex: "location_Name",
      key: "location_Name",
      render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "binBalance_QtyBal",
      dataIndex: "binBalance_QtyBal",
      key: "binBalance_QtyBal",
      render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "tag_No",
      dataIndex: "tag_No",
      key: "tag_No",
      render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "goodsReceive_No",
      dataIndex: "goodsReceive_No",
      key: "goodsReceive_No",
      render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "product_Id",
      dataIndex: "product_Id",
      key: "product_Id",
      render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "product_Name",
      dataIndex: "product_Name",
      key: "product_Name",
      render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "productConversion_Name",
      dataIndex: "productConversion_Name",
      key: "productConversion_Name",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "product_Lot",
      dataIndex: "product_Lot",
      key: "product_Lot",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "itemStatus_Name",
      dataIndex: "itemStatus_Name",
      key: "itemStatus_Name",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "BinBalance_QtyBegin",
      dataIndex: "binBalance_QtyBegin",
      key: "binBalance_QtyBegin",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "BinBalance_QtyReserve",
      dataIndex: "binBalance_QtyReserve",
      key: "binBalance_QtyReserve",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "ERP_Location",
      dataIndex: "erP_Location",
      key: "erP_Location",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    // {
    //   title: "BinBalance_Index",
    //   dataIndex: "BinBalance_Index",
    //   key: "BinBalance_Index",
    // },
    // {
    //   title: "GoodsReceiveItemLocation_Index",
    //   dataIndex: "GoodsReceiveItemLocation_Index",
    //   key: "GoodsReceiveItemLocation_Index",
    // },
    // {
    //   title: "Tag_Index",
    //   dataIndex: "Tag_Index",
    //   key: "Tag_Index",
    // },
  ];

  const columnsTagItem = [
    {
      title: "qty",
      dataIndex: "qty",
      key: "qty",  render: (text) => (text === null || text === "" ? "NULL" : text)    

    },
    {
      title: "Ratio",
      dataIndex: "ratio",
      key: "ratio", render: (text) => (text === null || text === "" ? "NULL" : text)     

    },
    {
      title: "TotalQty",
      dataIndex: "totalQty",
      key: "totalQty",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "TotalQty",
      dataIndex: "totalQty",
      key: "totalQty",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "Tag_No",
      dataIndex: "tag_No",
      key: "tag_No",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "TagItem_Index",
      dataIndex: "tagItem_Index",
      key: "tagItem_Index",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "Tag_Index",
      dataIndex: "tag_Index",
      key: "tag_Index",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "Tag_No",
      dataIndex: "tag_No",
      key: "tag_No",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "GoodsReceive_Index",
      dataIndex: "goodsReceive_Index",
      key: "goodsReceive_Index",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "GoodsReceiveItem_Index",
      dataIndex: "goodsReceiveItem_Index",
      key: "goodsReceiveItem_Index",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "Process_Index",
      dataIndex: "process_Index",
      key: "process_Index",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "Product_Index",
      dataIndex: "product_Index",
      key: "product_Index",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "product_Id",
      dataIndex: "product_Id",
      key: "product_Id",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "product_Name",
      dataIndex: "product_Name",
      key: "product_Name",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "product_SecondName",
      dataIndex: "product_SecondName",
      key: "product_SecondName",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "product_ThirdName",
      dataIndex: "product_ThirdName",
      key: "product_ThirdName",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "product_Lot",
      dataIndex: "product_Lot",
      key: "product_Lot",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "itemStatus_Index",
      dataIndex: "itemStatus_Index",
      key: "itemStatus_Index",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "itemStatus_Id",
      dataIndex: "itemStatus_Id",
      key: "itemStatus_Id",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "itemStatus_Name",
      dataIndex: "itemStatus_Name",
      key: "itemStatus_Name",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "suggest_Location_Index",
      dataIndex: "suggest_Location_Index",
      key: "suggest_Location_Index",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "suggest_Location_Id",
      dataIndex: "suggest_Location_Id",
      key: "suggest_Location_Id",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "suggest_Location_Name",
      dataIndex: "suggest_Location_Name",
      key: "suggest_Location_Name",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "qty",
      dataIndex: "qty",
      key: "qty",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "ratio",
      dataIndex: "ratio",
      key: "ratio",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "totalQty",
      dataIndex: "totalQty",
      key: "totalQty",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "productConversion_Index",
      dataIndex: "productConversion_Index",
      key: "productConversion_Index",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "productConversion_Id",
      dataIndex: "productConversion_Id",
      key: "productConversion_Id",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "productConversion_Name",
      dataIndex: "productConversion_Name",
      key: "productConversion_Name",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "mfG_Date",
      dataIndex: "mfG_Date",
      key: "mfG_Date",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "exP_Date",
      dataIndex: "exP_Date",
      key: "exP_Date",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "tagRef_No1",
      dataIndex: "tagRef_No1",
      key: "tagRef_No1",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "tagRef_No2",
      dataIndex: "tagRef_No2",
      key: "tagRef_No2",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "tagRef_No3",
      dataIndex: "tagRef_No3",
      key: "tagRef_No3",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "tagRef_No4",
      dataIndex: "tagRef_No4",
      key: "tagRef_No4",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "tagRef_No5",
      dataIndex: "tagRef_No5",
      key: "tagRef_No5",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "tag_Status",
      dataIndex: "tag_Status",
      key: "tag_Status",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "udF_1",
      dataIndex: "udF_1",
      key: "udF_1",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "udF_2",
      dataIndex: "udF_2",
      key: "udF_2",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "udF_3",
      dataIndex: "udF_3",
      key: "udF_3",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "udF_4",
      dataIndex: "udF_4",
      key: "udF_4",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "weight",
      dataIndex: "weight",
      key: "weight",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "unitWeight",
      dataIndex: "unitWeight",
      key: "unitWeight",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "netWeight",
      dataIndex: "netWeight",
      key: "netWeight",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "weight_Index",
      dataIndex: "weight_Index",
      key: "weight_Index",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "weight_Id",
      dataIndex: "weight_Id",
      key: "weight_Id",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "weight_Name",
      dataIndex: "weight_Name",
      key: "weight_Name",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "weightRatio",
      dataIndex: "weightRatio",
      key: "weightRatio",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "unitGrsWeight",
      dataIndex: "unitGrsWeight",
      key: "unitGrsWeight",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "grsWeight",
      dataIndex: "grsWeight",
      key: "grsWeight",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "grsWeight_Index",
      dataIndex: "grsWeight_Index",
      key: "grsWeight_Index",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "grsWeight_Id",
      dataIndex: "grsWeight_Id",
      key: "grsWeight_Id",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "grsWeight_Name",
      dataIndex: "grsWeight_Name",
      key: "grsWeight_Name",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "grsWeightRatio",
      dataIndex: "grsWeightRatio",
      key: "grsWeightRatio",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "unitWidth",
      dataIndex: "unitWidth",
      key: "unitWidth",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "width",
      dataIndex: "width",
      key: "width",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "width_Index",
      dataIndex: "width_Index",
      key: "width_Index",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "width_Id",
      dataIndex: "width_Id",
      key: "width_Id",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "width_Name",
      dataIndex: "width_Name",
      key: "width_Name",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "widthRatio",
      dataIndex: "widthRatio",
      key: "widthRatio",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "unitLength",
      dataIndex: "unitLength",
      key: "unitLength",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "length",
      dataIndex: "length",
      key: "length",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "length_Index",
      dataIndex: "length_Index",
      key: "length_Index",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "length_Id",
      dataIndex: "length_Id",
      key: "length_Id",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "length_Name",
      dataIndex: "length_Name",
      key: "length_Name",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "lengthRatio",
      dataIndex: "lengthRatio",
      key: "lengthRatio",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "unitHeight",
      dataIndex: "unitHeight",
      key: "unitHeight",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "height",
      dataIndex: "height",
      key: "height",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "height_Index",
      dataIndex: "height_Index",
      key: "height_Index",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "height_Id",
      dataIndex: "height_Id",
      key: "height_Id",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "height_Name",
      dataIndex: "height_Name",
      key: "height_Name",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "heightRatio",
      dataIndex: "heightRatio",
      key: "heightRatio",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "unitVolume",
      dataIndex: "unitVolume",
      key: "unitVolume",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "volume",
      dataIndex: "volume",
      key: "volume",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "volume_Index",
      dataIndex: "volume_Index",
      key: "volume_Index",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "volume_Id",
      dataIndex: "volume_Id",
      key: "volume_Id",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "volume_Name",
      dataIndex: "volume_Name",
      key: "volume_Name",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "volumeRatio",
      dataIndex: "volumeRatio",
      key: "volumeRatio",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "unitPrice",
      dataIndex: "unitPrice",
      key: "unitPrice",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "price",
      dataIndex: "price",
      key: "price",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "totalPrice",
      dataIndex: "totalPrice",
      key: "totalPrice",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "currency_Index",
      dataIndex: "currency_Index",
      key: "currency_Index",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "currency_Id",
      dataIndex: "currency_Id",
      key: "currency_Id",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "currency_Name",
      dataIndex: "currency_Name",
      key: "currency_Name",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "ref_Code1",
      dataIndex: "ref_Code1",
      key: "ref_Code1",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "ref_Code2",
      dataIndex: "ref_Code2",
      key: "ref_Code2",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "ref_Code2",
      dataIndex: "ref_Code2",
      key: "ref_Code2",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "ref_Code3",
      dataIndex: "ref_Code3",
      key: "ref_Code3",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "ref_Code4",
      dataIndex: "ref_Code4",
      key: "ref_Code4",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "udF_5",
      dataIndex: "udF_5",
      key: "udF_5",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "create_By",
      dataIndex: "create_By",
      key: "create_By",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "create_Date",
      dataIndex: "create_Date",
      key: "create_Date",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "update_By",
      dataIndex: "update_By",
      key: "update_By",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "update_Date",
      dataIndex: "update_Date",
      key: "update_Date",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "cancel_By",
      dataIndex: "cancel_By",
      key: "cancel_By",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "cancel_Date",
      dataIndex: "cancel_Date",
      key: "cancel_Date",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "userAssign",
      dataIndex: "userAssign",
      key: "userAssign",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "erP_Location",
      dataIndex: "erP_Location",
      key: "erP_Location",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "isScanDockToStaging",
      dataIndex: "isScanDockToStaging",
      key: "isScanDockToStaging",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "location_Index",
      dataIndex: "location_Index",
      key: "location_Index",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "location_Id",
      dataIndex: "location_Id",
      key: "location_Id",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "location_Name",
      dataIndex: "location_Name",
      key: "location_Name",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "updateDockToStaging_By",
      dataIndex: "updateDockToStaging_By",
      key: "updateDockToStaging_By",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "updateDockToStaging_Date",
      dataIndex: "updateDockToStaging_Date",
      key: "updateDockToStaging_Date",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "isPallet_Inspection",
      dataIndex: "isPallet_Inspection",
      key: "isPallet_Inspection",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "updatePallet_Inspection_By",
      dataIndex: "updatePallet_Inspection_By",
      key: "updatePallet_Inspection_By",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "updatePallet_Inspection_Date",
      dataIndex: "updatePallet_Inspection_Date",
      key: "updatePallet_Inspection_Date",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "isPallet_Inspection_Location_Name",
      dataIndex: "isPallet_Inspection_Location_Name",
      key: "isPallet_Inspection_Location_Name",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "isPallet_Inspection_Location_Id",
      dataIndex: "isPallet_Inspection_Location_Id",
      key: "isPallet_Inspection_Location_Id",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "isPallet_Inspection_Location_Index",
      dataIndex: "isPallet_Inspection_Location_Index",
      key: "isPallet_Inspection_Location_Index",render: (text) => (text === null || text === "" ? "NULL" : text)
    },

  ];

  const columnsBinBalance =[ 
    {
      title: "create_By",
      dataIndex: "create_By",
      key: "create_By",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "cancel_Date",
      dataIndex: "cancel_Date",
      key: "cancel_Date",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "cancel_By",
      dataIndex: "cancel_By",
      key: "cancel_By",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "update_Date",
      dataIndex: "update_Date",
      key: "update_Date",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "location_Name",
      dataIndex: "location_Name",
      key: "location_Name",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "binBalance_QtyBal",
      dataIndex: "binBalance_QtyBal",
      key: "binBalance_QtyBal",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "tag_No",
      dataIndex: "tag_No",
      key: "tag_No",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "goodsReceive_No",
      dataIndex: "goodsReceive_No",
      key: "goodsReceive_No",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "product_Id",
      dataIndex: "product_Id",
      key: "product_Id",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "product_Name",
      dataIndex: "product_Name",
      key: "product_Name",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "productConversion_Name",
      dataIndex: "productConversion_Name",
      key: "productConversion_Name",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "product_Lot",
      dataIndex: "product_Lot",
      key: "product_Lot",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "itemStatus_Name",
      dataIndex: "itemStatus_Name",
      key: "itemStatus_Name",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "binBalance_QtyBegin",
      dataIndex: "binBalance_QtyBegin",
      key: "binBalance_QtyBegin",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "binBalance_QtyReserve",
      dataIndex: "binBalance_QtyReserve",
      key: "binBalance_QtyReserve",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "erP_Location",
      dataIndex: "erP_Location",
      key: "erP_Location",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "binBalance_Index",
      dataIndex: "binBalance_Index",
      key: "binBalance_Index",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "goodsReceiveItemLocation_Index",
      dataIndex: "goodsReceiveItemLocation_Index",
      key: "goodsReceiveItemLocation_Index",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "tag_Index",
      dataIndex: "tag_Index",
      key: "tag_Index",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
  ];

  const columnsGoodsReceiveItemLocation=
  [
    {
      title: "tag_No",
      dataIndex: "tag_No",
      key: "tag_No",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "grlQty",
      dataIndex: "grlQty",
      key: "grlQty",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "grlTotalQty",
      dataIndex: "grlTotalQty",
      key: "grlTotalQty",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "maxPutaway_Date",
      dataIndex: "maxPutaway_Date",
      key: "maxPutaway_Date",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
  ];
  const columnsGoodsIssueItemLocation = [
    {
      title: "tag_No",
      dataIndex: "tag_No",
      key: "tag_No",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "goodsIssue_No",
      dataIndex: "goodsIssue_No",
      key: "goodsIssue_No",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "location_Name",
      dataIndex: "location_Name",
      key: "location_Name",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "product_Id",
      dataIndex: "product_Id",
      key: "product_Id",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "product_Name",
      dataIndex: "product_Name",
      key: "product_Name",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "productConversion_Name",
      dataIndex: "productConversion_Name",
      key: "productConversion_Name",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "giQty",
      dataIndex: "giQty",
      key: "giQty",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "giTotalQty",
      dataIndex: "giTotalQty",
      key: "giTotalQty",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
  ];
  const columnsGoodsIssueItemLocationSQTY=[
    {
      title: "tag_No",
      dataIndex: "tag_No",
      key: "tag_No",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "giQty",
      dataIndex: "giQty",
      key: "giQty",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "giTotalQty",
      dataIndex: "giTotalQty",
      key: "giTotalQty",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
  ];
  const columnsTaskItem=[
    {
      title: "picking_Status",
      dataIndex: "picking_Status",
      key: "picking_Status",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "TaskQty",
      dataIndex: "tiQty",
      key: "tiQty",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "TaskTotalQty",
      dataIndex: "totalQty",
      key: "totalQty",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
  ];
  const columnsTagOutItem=[
    {
      title: "TagOut_Status",
      dataIndex: "tagOut_Status",
      key: "tagOut_Status",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "TAGQty",
      dataIndex: "qty",
      key: "qty",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "TAGTotalQty",
      dataIndex: "totTotalQtyalQty",
      key: "totTotalQtyalQty",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
  ];

  const columnsBinCardReserve_GINOTCOMFIRM=[
    {
      title: "BinCardReserve_Status",
      dataIndex: "binCardReserve_Status",
      key: "binCardReserve_Status",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "zBinCardReserve_QtyBal",
      dataIndex: "binCardReserve_QtyBal",
      key: "binCardReserve_QtyBal",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    
  ];
  const columnsBinCardReserve=[
    {
      title: "BinCardReserve_Status",
      dataIndex: "binCardReserve_Status",
      key: "binCardReserve_Status",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "BinCardReserve_QtyBal",
      dataIndex: "binCardReserve_QtyBal",
      key: "binCardReserve_QtyBal",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    
  ];
  const columnsBinBalanceGI=[
    {
      title: "location_Name",
      dataIndex: "location_Name",
      key: "location_Name",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "BinBalance_QtyBal",
      dataIndex: "binBalance_QtyBal",
      key: "binBalance_QtyBal",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "BinBalance_QtyReserve",
      dataIndex: "binBalance_QtyReserve",
      key: "binBalance_QtyReserve",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
  ];
  const columnsBinBalanceGR=[
    {
      title: "Tag_No",
      dataIndex: "tag_No",
      key: "tag_No",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "location_Name",
      dataIndex: "location_Name",
      key: "location_Name",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "BinBalance_QtyBal",
      dataIndex: "binBalance_QtyBal",
      key: "binBalance_QtyBal",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "BinBalance_QtyReserve",
      dataIndex: "binBalance_QtyReserve",
      key: "binBalance_QtyReserve",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "ERP_Location",
      dataIndex: "erP_Location",
      key: "erP_Location",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
  ];
  const columnsGoodsTransferItemWT=[
    {
      title: "document_Status",
      dataIndex: "document_Status",
      key: "document_Status",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "item_Document_Status",
      dataIndex: "item_Document_Status",
      key: "item_Document_Status",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "goodsTransfer_No",
      dataIndex: "goodsTransfer_No",
      key: "goodsTransfer_No",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "documentType_Name",
      dataIndex: "documentType_Name",
      key: "documentType_Name",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "create_Date",
      dataIndex: "create_Date",
      key: "create_Date",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "create_By",
      dataIndex: "create_By",
      key: "create_By",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "tag_No",
      dataIndex: "tag_No",
      key: "tag_No",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "tag_No_To",
      dataIndex: "tag_No_To",
      key: "tag_No_To",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "product_Id",
      dataIndex: "product_Id",
      key: "product_Id",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "qty",
      dataIndex: "qty",
      key: "qty",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "totalQty",
      dataIndex: "totalQty",
      key: "totalQty",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "productConversion_Name",
      dataIndex: "productConversion_Name",
      key: "productConversion_Name",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "location_Name",
      dataIndex: "location_Name",
      key: "location_Name",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "location_Name_To",
      dataIndex: "location_Name_To",
      key: "location_Name_To",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "itemStatus_Name",
      dataIndex: "itemStatus_Name",
      key: "itemStatus_Name",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "itemStatus_Name_To",
      dataIndex: "itemStatus_Name_To",
      key: "itemStatus_Name_To",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "ERP_Location",
      dataIndex: "ERP_Location",
      key: "ERP_Location",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "ERP_Location_To",
      dataIndex: "ERP_Location_To",
      key: "ERP_Location_To",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "goodsReceiveItemLocation_Index",
      dataIndex: "goodsReceiveItemLocation_Index",
      key: "goodsReceiveItemLocation_Index",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "goodsTransferItem_Index",
      dataIndex: "goodsTransferItem_Index",
      key: "goodsTransferItem_Index",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
  ];
  const columnsGoodsTransferItemWGITL=[
    {
      title: "document_Status",
      dataIndex: "document_Status",
      key: "document_Status",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "item_Document_Status",
      dataIndex: "item_Document_Status",
      key: "item_Document_Status",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "goodsTransfer_No",
      dataIndex: "goodsTransfer_No",
      key: "goodsTransfer_No",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "documentType_Name",
      dataIndex: "documentType_Name",
      key: "documentType_Name",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "create_Date",
      dataIndex: "create_Date",
      key: "create_Date",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "create_By",
      dataIndex: "create_By",
      key: "create_By",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "tag_No",
      dataIndex: "tag_No",
      key: "tag_No",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "tag_No_To",
      dataIndex: "tag_No_To",
      key: "tag_No_To",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "product_Id",
      dataIndex: "product_Id",
      key: "product_Id",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "qty",
      dataIndex: "qty",
      key: "qty",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "totalQty",
      dataIndex: "totalQty",
      key: "totalQty",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "productConversion_Name",
      dataIndex: "productConversion_Name",
      key: "productConversion_Name",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "location_Name",
      dataIndex: "location_Name",
      key: "location_Name",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "location_Name_To",
      dataIndex: "location_Name_To",
      key: "location_Name_To",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "itemStatus_Name",
      dataIndex: "itemStatus_Name",
      key: "itemStatus_Name",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "itemStatus_Name_To",
      dataIndex: "itemStatus_Name_To",
      key: "itemStatus_Name_To",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "ERP_Location",
      dataIndex: "ERP_Location",
      key: "ERP_Location",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "ERP_Location_To",
      dataIndex: "ERP_Location_To",
      key: "ERP_Location_To",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "goodsReceiveItemLocation_Index",
      dataIndex: "goodsReceiveItemLocation_Index",
      key: "goodsReceiveItemLocation_Index",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
    {
      title: "goodsTransferItem_Index",
      dataIndex: "goodsTransferItem_Index",
      key: "goodsTransferItem_Index",render: (text) => (text === null || text === "" ? "NULL" : text)
    },
  ];
  const fetchData = async () => {
    setLoading(true);
    try {
      const response = await fetch("https://localhost:44378/api/CheckStock/CheckStock", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({
          Goodsissue_no : formValues.Goodsissue_no
        })
      }).then(res=>{ return res.json()}).then(resjson=>{
        if(resjson.message === "No Data"){
          console.log("check :",resjson.message)
          setdataSource([]);
        }
        else{
          setdataSource(resjson);
        }
        });
      console.log(dataSource);
    } catch (error) {
      handleError(error.message || "Error connecting to API");
    } finally {
      setLoading(false);
    }
  };
  
  const fetchDataTagItem = async () => {
    setLoading(true);
    try {
      const response = await fetch("https://localhost:44378/api/CheckTag/CheckTag_TagItem", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({
          Tag_no : formValues.Tag_no
        })
      }).then(res=>{ return res.json()}).then(resjson=>{
        if(resjson.message === "No Data"){
          console.log("check :",resjson.message)
          setTagItemData([]);
        }
        else{
          setTagItemData(resjson);
        }
        });
    } catch (error) {
      handleError(error.message || "Error connecting to API");
    } finally {
      setLoading(false);
    }
  };
  
  const fetchDataBinbalance = async () => {
    setLoading(true);
    try {
      const response = await fetch("https://localhost:44378/api/CheckTag/CheckTag_BinBalance", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({
          Tag_no : formValues.Tag_no
        })
      }).then(res=>{ return res.json()}).then(resjson=>{
        if(resjson.message === "No Data"){
          console.log("check :",resjson.message)
          setBinBalanceData([]);
        }
        else{
          setBinBalanceData(resjson);
          resjson.forEach(item => {
            console.log("Binbalance index:", item.binBalance_Index);
            setBin_index(item.binBalance_Index)
          });
        }
        });
    } catch (error) {
      handleError(error.message || "Error connecting to API");
    } finally {
      setLoading(false);
    }
  };
  
  const fetchDataGRI= async () => {
    setLoading(true);
    try {
      const response = await fetch("https://localhost:44378/api/CheckTag/CheckTag_GoodsReceiveItemLocation", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({
          Tag_no : formValues.Tag_no
        })
      }).then(res=>{ return res.json()}).then(resjson=>{
        if(resjson.message === "No Data"){
          console.log("check :",resjson.message)
          setgriData([]);
        }
        else{
          setgriData(resjson);
        }
        });
    } catch (error) {
      handleError(error.message || "Error connecting to API");
    } finally {
      setLoading(false);
    }
  };
  
  const fetchDataGIL= async () => {
    setLoading(true);
    try {
      const response = await fetch("https://localhost:44378/api/CheckTag/CheckTag_GoodsIssueItemLocation", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({
          Tag_no : formValues.Tag_no
        })
      }).then(res=>{ return res.json()}).then(resjson=>{
        if(resjson.message === "No Data"){
          console.log("check :",resjson.message)
          setgilData([]);
        }
        else{
          setgilData(resjson);
        }
        });
    } catch (error) {
      handleError(error.message || "Error connecting to API");
    } finally {
      setLoading(false);
    }
  };
  
  const fetchDatagilSQTY= async () => {
    setLoading(true);
    try {
      const response = await fetch("https://localhost:44378/api/CheckTag/CheckTag_GoodsIssueItemLocationSQTY", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({
          Tag_no : formValues.Tag_no
        })
      }).then(res=>{ return res.json()}).then(resjson=>{
        if(resjson.message === "No Data"){
          console.log("check :",resjson.message)
          setgilSQTYData([]);
        }
        else{
          setgilSQTYData(resjson);
        }
        });
    } catch (error) {
      handleError(error.message || "Error connecting to API");
    } finally {
      setLoading(false);
    }
  };
  
  const fetchDataTaskItem = async () => {
    setLoading(true);
    try {
      const response = await fetch("https://localhost:44378/api/CheckTag/CheckTag_TaskItem", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({
          Tag_no : formValues.Tag_no
        })
      }).then(res=>{ return res.json()}).then(resjson=>{
        if(resjson.message === "No Data"){
          console.log("check :",resjson.message)
          setTaskItemData([]);
        }
        else{
          setTaskItemData(resjson);
        }
        });
    } catch (error) {
      handleError(error.message || "Error connecting to API");
    } finally {
      setLoading(false);
    }
  };
  
  const fetchDataTagOutItemData = async () => {
    setLoading(true);
    try {
      const response = await fetch("https://localhost:44378/api/CheckTag/CheckTag_TagOutItem", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({
          Tag_no : formValues.Tag_no
        })
      }).then(res=>{ return res.json()}).then(resjson=>{
        if(resjson.message === "No Data"){
          console.log("check :",resjson.message)
          setTagOutItemData([]);
        }
        else{
          setTagOutItemData(resjson);
        }
        });
    } catch (error) {
      handleError(error.message || "Error connecting to API");
    } finally {
      setLoading(false);
    }
  };
  
  const fetchDataBinCardReserve_GINOTCOMFIRM = async () => {
    setLoading(true);
    try {
      const response = await fetch("https://localhost:44378/api/CheckTag/CheckTag_BinCardReserve_GINOTCOMFIRM", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({
          Tag_no : formValues.Tag_no
        })
      }).then(res=>{ return res.json()}).then(resjson=>{
        if(resjson.message === "No Data"){
          console.log("check :",resjson.message)
          setBinCardReserve_GINOTCOMFIRMData([]);
        }
        else{
          setBinCardReserve_GINOTCOMFIRMData(resjson);
        }
       });
    } catch (error) {
      handleError(error.message || "Error connecting to API");
    } finally {
      setLoading(false);
    }
  };
  const fetchBinCardReserve = async () => {
    setLoading(true);
    try {
      const response = await fetch("https://localhost:44378/api/CheckTag/CheckTag_BinCardReserve", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({
          Tag_no : formValues.Tag_no
        })
      }).then(res=>{ return res.json()}).then(resjson=>{
        if(resjson.message === "No Data"){
          console.log("check :",resjson.message)
          setBinCardReserveData([]);
        }
        else{
          setBinCardReserveData(resjson);
        }
        });
    } catch (error) {
      handleError(error.message || "Error connecting to API");
    } finally {
      setLoading(false);
    }
  };

  const fetchBinBalanceGI = async () => {
    setLoading(true);
    try {
      const response = await fetch("https://localhost:44378/api/CheckTag/CheckTag_BinBalanceGI", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({
          Tag_no : formValues.Tag_no
        })
      }).then(res=>{ return res.json()}).then(resjson=>{
        if(resjson.message === "No Data"){
          console.log("check :",resjson.message)
          setBinBalanceGIData([]);
        }
        else{
          setBinBalanceGIData(resjson);
        }
      });
    } catch (error) {
      handleError(error.message || "Error connecting to API");
    } finally {
      setLoading(false);
    }
  };
  
  const fetchBinBalanceGR = async () => {
    setLoading(true);
    try {
      const response = await fetch("https://localhost:44378/api/CheckTag/CheckTag_BinBalanceGR", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({
          Tag_no : formValues.Tag_no
        })
      }).then(res=>{ return res.json()}).then(resjson=>{
        if(resjson.message === "No Data"){
          console.log("check :",resjson.message)
          setBinBalanceGRData([]);
        }
        else{
          setBinBalanceGRData(resjson);
        }
       });
    } catch (error) {
      handleError(error.message || "Error connecting to API");
    } finally {
      setLoading(false);
    }
  };
  
  const GoodsTransferItemWT = async () => {
    setLoading(true);
    try {
      const response = await fetch("https://localhost:44378/api/CheckTag/CheckTag_GoodsTransferItemWT", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({
          Tag_no : formValues.Tag_no
        })
      }).then(res=>{ return res.json()}).then(resjson=>{
        if(resjson.message === "No Data"){
          console.log("check :",resjson.message)
          setGoodsTransferItemDataWT([]);
        }
        else{
          setGoodsTransferItemDataWT(resjson);
        }
        });
    } catch (error) {
      handleError(error.message || "Error connecting to API");
    } finally {
      setLoading(false);
    }
  };
  
  const GoodsTransferItemWGITL = async () => {
    setLoading(true);
    try {
      const response = await fetch("https://localhost:44378/api/CheckTag/CheckTag_GoodsTransferItemWGITL", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({
          Tag_no : formValues.Tag_no
        })
      }).then(res=>{ return res.json()}).then(resjson=>{
        if(resjson.message === "No Data"){
          console.log("check :",resjson.message)
          setGoodsTransferItemDataWGITL([]);
        }
        else{
          setGoodsTransferItemDataWGITL(resjson);
        }
      });
      
    } catch (error) {
      handleError(error.message || "Error connecting to API");
    } finally {
      setLoading(false);
    }
  };
  const CutStock = async () => {
    setLoading(true);
    try {
      const response = await fetch("https://localhost:44378/api/CheckTag/CheckTag_CutStock", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({
          Tag_no : formValues.Tag_no
        })
      }).then(res=>{ return res.json()}).then(resjson=>{
       console.log("Cut Thing Cut Kwang",resjson);
      });
      
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

  const handleInputChange = (e) => {
    const  {name ,value} = e.target;
    setFormValues({ ...formValues,[name]:value});
    console.log('name:',name)
    console.log('value:',value)
    
  };
  const CheckStock_ClickSearch= async ()=>{
    console.log("click");
    console.log("GI NO: ",formValues.Goodsissue_no);
    fetchData();
  }
  const CheckTag_ClickSearch= async ()=>{
    
    console.log("Tag_no: ",formValues.Tag_no);
    await fetchDataTagItem();
    await fetchDataBinbalance();
    await fetchDataGRI();
    await fetchDataGIL();
    await fetchDatagilSQTY();
    await fetchDataTaskItem();
    await fetchDataTagOutItemData();
    await fetchDataBinCardReserve_GINOTCOMFIRM();
    await fetchBinCardReserve();
    await fetchBinBalanceGI();
    await fetchBinBalanceGR()
    await GoodsTransferItemWT();
    await GoodsTransferItemWGITL();
    setIsSearched(true);
  }
  const CheckTag_ClickCutStock = async ()=>{
    const confirmDelete = window.confirm(`ต้องการ Cut Stock \nTag_No : ${formValues.Tag_no} \nBinbalance_index : ${Bin_index}`); 
    if(confirmDelete){
    console.log("click Cut Stock");
    await CutStock();
    await fetchDataTagItem();
    await fetchDataBinbalance();
    await fetchDataGRI();
    await fetchDataGIL();
    await fetchDatagilSQTY();
    await fetchDataTaskItem();
    await fetchDataTagOutItemData();
    await fetchDataBinCardReserve_GINOTCOMFIRM();
    await fetchBinCardReserve();
    await fetchBinBalanceGI();
    await fetchBinBalanceGR()
    await GoodsTransferItemWT();
    await GoodsTransferItemWGITL();
    }
    else{
      console.log("cancel");
    }
  }
  // const handleClickExport = () => {
  //   try {
  //     const exportData = dataSource.map(item => ({
  //       archiveData_Name: item.archiveData_Name,
  //       archiveData_Table_Name: item.archiveData_Table_Name,
  //       archiveData_Period: item.archiveData_Period,
  //       archiveData_BeforeCount: item.archiveData_BeforeCount,
  //       archiveData_Count: item.archiveData_Count,
  //       archiveData_Balance_Count: item.archiveData_Balance_Count,
  //       archiveData_Min_Date: item.archiveData_Min_Date,
  //       archiveData_Start_Date: item.archiveData_Start_Date,
  //       archiveData_End_Date: item.archiveData_End_Date,
  //       message: item.message
  //     }));
  
  //     const ws = XLSX.utils.json_to_sheet(exportData);
  //     const headers = columns.map(col => col.title);
  //     XLSX.utils.sheet_add_aoa(ws, [headers], { origin: 'A1' });
  //     const wb = XLSX.utils.book_new();
  //     XLSX.utils.book_append_sheet(wb, ws, "LogArchiveOMS");
  //     XLSX.writeFile(wb, "LogArchiveOMS_Data.xlsx", { compression: true });
  //   } catch (error) {
  //     console.error("Export Error: ", error);
  //     notification.error({
  //       message: "Export Failed",
  //       description: error.message || "An error occurred during export",
  //     });
  //   }
  // };
  return (
    <Spin spinning={loading}>
      <h3>Check Stock</h3>
      <Form>
          <Row>
              <Col>
                  <Form.Item>
                    <Input 
                    id ='Goodsissue_NO'
                    placeholder="Goodsissue_NO" 
                    type="text"
                    name="Goodsissue_no"
                    //value={Tag_no}
                    onChange={handleInputChange}
                    />
                  </Form.Item>
              </Col>
              <Col>
                <Form.Item>
                  <Button
                    size="large"
                    style={{ width: "100%", color: '#ffffff' ,backgroundColor:'gray',marginLeft:17}}
                    id ='btn-search'
                    onClick={CheckStock_ClickSearch}
                    icon={<SearchOutlined />}
                  >
                    Search
                  </Button>
                </Form.Item>
              </Col>
            </Row> 
          </Form>
        <Table
          dataSource={dataSource}
          columns={columns}
          rowKey="binBalance_Index"
          pagination={{
            pageSize,
            current: currentPage,
            onChange: (page, size) => {
              setCurrentPage(page);
              setPageSize(size);
            },
          }}
        />
        <h3>Check Tag</h3>
        <Form>
          <Row>
              <Col>
                  <Form.Item>
                    <Input 
                    id ='Tag_no'
                    placeholder="Tag_NO" 
                    type="text"
                    name="Tag_no"
                    //value={Tag_no}
                    onChange={handleInputChange}
                    />
                  </Form.Item>
              </Col>
              <Col>
                <Form.Item>
                  <Button
                    size="large"
                    style={{ width: "100%", color: '#ffffff' ,backgroundColor:'gray',marginLeft:17}}
                    id ='btn-search'
                    onClick={CheckTag_ClickSearch}
                    icon={<SearchOutlined />}
                  >
                    Search
                  </Button>
                </Form.Item>
              </Col>
              {isSearched && (
                <Col>
                  <Form.Item>
                    <Button
                      size="large"
                      style={{ width: "100%", color: '#ffffff' ,backgroundColor:'red',marginLeft:27}}
                      id="btn-cut-stock"
                      onClick={CheckTag_ClickCutStock}
                      icon={<ScissorOutlined/>}

                    >
                      Cut Stock
                    </Button>
                  </Form.Item>
                </Col>
              )}
            </Row> 
          </Form>
          <h3>TagItem</h3>
          <Table
          dataSource={TagItemData}
          columns={columnsTagItem}
          rowKey="TagItem_Index"
          pagination={{
            pageSize,
            current: currentPage,
            onChange: (page, size) => {
              setCurrentPage(page);
              setPageSize(size);
            },
          }}
          locale={{
            emptyText: "No Data", // This sets the message when there's no data
          }}
          />
          <h3>BinBalanceData</h3>
          <Table
          dataSource={BinBalanceData}
          columns={columnsBinBalance}
          rowKey="binBalance_Index"
          pagination={{
            pageSize,
            current: currentPage,
            onChange: (page, size) => {
              setCurrentPage(page);
              setPageSize(size);
            },
          }}
          locale={{
            emptyText: "No Data", // This sets the message when there's no data
          }}
          />
          <h3>GoodsReceiveItemLocation</h3>
          <Table
          dataSource={griData}
          columns={columnsGoodsReceiveItemLocation}
          rowKey={(record) => record.id || record.key || Math.random().toString(36).substr(2, 9)}
          pagination={{
            pageSize,
            current: currentPage,
            onChange: (page, size) => {
              setCurrentPage(page);
              setPageSize(size);
            },
          }}
          locale={{
            emptyText: "No Data", // This sets the message when there's no data
          }}
          />
          <h3>GoodsIssueItemLocation</h3>
          <Table
          dataSource={gilData}
          columns={columnsGoodsIssueItemLocationSQTY}
          rowKey={(record) => record.id || record.key || Math.random().toString(36).substr(2, 9)}
          pagination={{
            pageSize,
            current: currentPage,
            onChange: (page, size) => {
              setCurrentPage(page);
              setPageSize(size);
            },
          }}
          locale={{
            emptyText: "No Data", // This sets the message when there's no data
          }}
          />
          
          <h3>GoodsIssueItemLocation Sum QTY</h3>
          <Table
          dataSource={gilSQTYData}
          columns={columnsGoodsIssueItemLocation}
          rowKey={(record) => record.id || record.key || Math.random().toString(36).substr(2, 9)}
          pagination={{
            pageSize,
            current: currentPage,
            onChange: (page, size) => {
              setCurrentPage(page);
              setPageSize(size);
            },
          }}
          locale={{
            emptyText: "No Data", // This sets the message when there's no data
          }}
          />
          <h3>TaskItem</h3>
          <Table
          dataSource={TaskItemData}
          columns={columnsTaskItem}
          rowKey={(record) => record.id || record.key || Math.random().toString(36).substr(2, 9)}
          pagination={{
            pageSize,
            current: currentPage,
            onChange: (page, size) => {
              setCurrentPage(page);
              setPageSize(size);
            },
          }}
          locale={{
            emptyText: "No Data", // This sets the message when there's no data
          }}
          />
          <h3>TagOutItemData</h3>
          <Table
          dataSource={TagOutItemData}
          columns={columnsTagOutItem}
          rowKey={(record) => record.id || record.key || Math.random().toString(36).substr(2, 9)}
          pagination={{
            pageSize,
            current: currentPage,
            onChange: (page, size) => {
              setCurrentPage(page);
              setPageSize(size);
            },
          }}
          locale={{
            emptyText: "No Data", // This sets the message when there's no data
          }}
          />
          <h3>BinCardReserve_GINOTCOMFIRM</h3>
          <Table
          dataSource={BinCardReserve_GINOTCOMFIRMData}
          columns={columnsBinCardReserve_GINOTCOMFIRM}
          rowKey={(record) => record.id || record.key || Math.random().toString(36).substr(2, 9)}
          pagination={{
            pageSize,
            current: currentPage,
            onChange: (page, size) => {
              setCurrentPage(page);
              setPageSize(size);
            },
          }}
          locale={{
            emptyText: "No Data", // This sets the message when there's no data
          }}
          />
          
          <h3>BinCardReserve</h3>
          <Table
          dataSource={BinCardReserveData}
          columns={columnsBinCardReserve}
          rowKey={(record) => record.id || record.key || Math.random().toString(36).substr(2, 9)}
          pagination={{
            pageSize,
            current: currentPage,
            onChange: (page, size) => {
              setCurrentPage(page);
              setPageSize(size);
            },
          }}
          locale={{
            emptyText: "No Data", // This sets the message when there's no data
          }}
          />
          <h3>BinBalance GI</h3>
          <Table
          dataSource={BinBalanceGIData}
          columns={columnsBinBalanceGI}
          rowKey={(record) => record.id || record.key || Math.random().toString(36).substr(2, 9)}
          pagination={{
            pageSize,
            current: currentPage,
            onChange: (page, size) => {
              setCurrentPage(page);
              setPageSize(size);
            },
          }}
          locale={{
            emptyText: "No Data", // This sets the message when there's no data
          }}
          />
          <h3>BinBalanceGR</h3>
          <Table
          dataSource={BinBalanceGRData}
          columns={columnsBinBalanceGR}
          rowKey={(record) => record.id || record.key || Math.random().toString(36).substr(2, 9)}
          pagination={{
            pageSize,
            current: currentPage,
            onChange: (page, size) => {
              setCurrentPage(page);
              setPageSize(size);
            },
          }}
          locale={{
            emptyText: "No Data", // This sets the message when there's no data
          }}
          />
           <h3>GoodsTransferItemWT</h3>
          <Table
          dataSource={GoodsTransferItemWTData}
          columns={columnsGoodsTransferItemWT}
          rowKey={(record) => record.id || record.key || Math.random().toString(36).substr(2, 9)}
          pagination={{
            pageSize,
            current: currentPage,
            onChange: (page, size) => {
              setCurrentPage(page);
              setPageSize(size);
            },
          }}
          locale={{
            emptyText: "No Data", // This sets the message when there's no data
          }}
          />
         
          <h3>GoodsTransferItemWGITL</h3>
          <Table
          dataSource={GoodsTransferItemWGITLData}
          columns={columnsGoodsTransferItemWGITL}
          rowKey={(record) => record.id || record.key || Math.random().toString(36).substr(2, 9)}
          pagination={{
            pageSize,
            current: currentPage,
            onChange: (page, size) => {
              setCurrentPage(page);
              setPageSize(size);
            },
          }}
          locale={{
            emptyText: "No Data", // This sets the message when there's no data
          }}
          />
          
    </Spin>
  );
  
};

export default CheckStock;
