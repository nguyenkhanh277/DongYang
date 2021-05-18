using DongYangweb.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DongYangweb.Controllers
{
    public class ProductionController : Controller
    {
        ConnectionManagement _connectionManagement = new ConnectionManagement();
        DbBusiness _dbBusiness = new DbBusiness();
        string _username = "";
        string _barcode = "";
        string _productionStatus = "";
        string _actionStatus = "";
        string _completedStatus = "";

        string _result = "NG";
        string _description = "";

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ConfirmProduct()
        {
            return View();
        }

        public ActionResult CheckProduct()
        {
            return View();
        }

        public ActionResult ApproveProduct()
        {
            return View();
        }

        public ActionResult ImportProduct()
        {
            return View();
        }

        [ActionName("CheckBarcode")]
        public ActionResult CheckBarcode(string barcode, string actionStatus)
        {
            try
            {
                _connectionManagement = new ConnectionManagement();
                _dbBusiness = new DbBusiness();
                _barcode = barcode;
                _productionStatus = "";
                _actionStatus = actionStatus;
                _result = "NG";
                _description = "";
                if (CheckData())
                {
                    if (VerifyData())
                    {
                        _result = "OK";
                    }
                }
            }
            catch
            {
                _result = "NG";
                _description = "Không thể kết nối với máy chủ";
            }
            return Content(_result + "#" + _description);
        }

        [ActionName("VerifyProduct")]
        public ActionResult VerifyProduct(string username, string barcode, string productionStatus, string actionStatus)
        {
            try
            {
                _connectionManagement = new ConnectionManagement();
                _dbBusiness = new DbBusiness();
                _username = username;
                _barcode = barcode;
                _productionStatus = productionStatus;
                _actionStatus = actionStatus;
                _result = "NG";
                _description = "";
                if (CheckData())
                {
                    if (VerifyData())
                    {
                        if (WriteData())
                        {
                            _result = "OK";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _result = "NG";
                _description = "Lỗi trong quá trình xử lý. " + Environment.NewLine + ex.ToString();
            }
            return Content(_result + "#" + _description);
        }

        private bool CheckData()
        {
            bool result = false;
            if (_dbBusiness.CheckBarcode(_barcode, _connectionManagement.GetDefaultConnection()))//Mã vạch có tồn tại
            {
                result = true;
            }
            else
            {
                _description += "Mã vạch không tồn tại." + Environment.NewLine;
            }
            return result;
        }

        private bool VerifyData()
        {
            bool result = false;
            DataTable production = _dbBusiness.GetProduction(_barcode, _connectionManagement.GetDefaultConnection());
            if (_actionStatus == "0")//Xác nhận sản phẩm
            {
                //Chỉ được xác nhận 1 lần hoặc sản phẩm vừa bị bảo lưu
                if (production.Rows.Count == 0//Xác nhận lần đầu
                    ||//Hoặc
                    production.Rows[0]["ProductionStatus"].ToString() == "3")//Sản phẩm vừa bị Hold
                {
                    result = true;
                }
                else
                {
                    _description += "Xác nhận thất bại." + Environment.NewLine;
                    _description += "Chỉ được xác nhận 1 lần hoặc sản phẩm vừa bị bảo lưu." + Environment.NewLine;
                }
            }
            else if (_actionStatus == "1")//Kiểm tra sản phẩm
            {
                //Chỉ kiểm tra khi sản phẩm vừa xác nhận OK
                if (production.Rows.Count > 0
                    && production.Rows[0]["Action"].ToString() == "0"//Vừa xác nhận sản phẩm
                    && production.Rows[0]["ProductionStatus"].ToString() == "1")//Sản phẩm OK
                {
                    result = true;
                }
                else if (production.Rows.Count == 0)
                {
                    _description += "Kiểm tra thất bại." + Environment.NewLine;
                    _description += "Sản phẩm này chưa được công nhân xác nhận." + Environment.NewLine;
                }
                else
                {
                    _description += "Kiểm tra thất bại." + Environment.NewLine;
                    _description += "Chỉ kiểm tra khi sản phẩm vừa được công nhân xác nhận OK." + Environment.NewLine;
                }
            }
            else if (_actionStatus == "2")//Đánh giá sản phẩm
            {
                //Chỉ đánh giá khi sản phẩm vừa kiểm tra NG
                if (production.Rows.Count > 0
                    && production.Rows[0]["Action"].ToString() == "1"//Vừa kiểm tra sản phẩm
                    && production.Rows[0]["ProductionStatus"].ToString() == "2")//Sản phẩm NG
                {
                    if (_productionStatus == "2")//Đánh giá NG
                    {
                        _completedStatus = "2";//Scrap
                    }
                    result = true;
                }
                else if (production.Rows.Count == 0)
                {
                    _description += "Kiểm tra thất bại." + Environment.NewLine;
                    _description += "Sản phẩm này chưa được công nhân xác nhận." + Environment.NewLine;
                }
                else
                {
                    _description += "Đánh giá thất bại." + Environment.NewLine;
                    _description += "Chỉ đánh giá khi sản phẩm vừa được QC kiểm tra NG." + Environment.NewLine;
                }
            }
            else if (_actionStatus == "3")//Nhập kho sản phẩm
            {
                //Chỉ nhập kho khi sản phẩm vừa được QC kiểm tra OK hoặc vừa được QA đánh giá OK
                if (production.Rows.Count > 0 &&
                    (
                        production.Rows[0]["Action"].ToString() == "1"//Vừa kiểm tra sản phẩm
                        ||//Hoặc
                        production.Rows[0]["Action"].ToString() == "2"//Vừa đánh giá sản phẩm
                    ) && production.Rows[0]["ProductionStatus"].ToString() == "1"//Sản phẩm OK
                )
                {
                    _completedStatus = "1";//OK
                    result = true;
                }
                else if (production.Rows.Count == 0)
                {
                    _description += "Kiểm tra thất bại." + Environment.NewLine;
                    _description += "Sản phẩm này chưa được công nhân xác nhận." + Environment.NewLine;
                }
                else
                {
                    _description += "Nhập kho thất bại." + Environment.NewLine;
                    _description += "Chỉ nhập kho khi sản phẩm vừa được QC kiểm tra OK hoặc vừa được QA đánh giá OK." + Environment.NewLine;
                }
            }

            else if (_actionStatus == "4")//Đánh giá OQC sản phẩm
            {
                //Chỉ đánh giá khi sản phẩm vừa nhập kho sản phẩm
                if (production.Rows.Count > 0
                    && production.Rows[0]["Action"].ToString() == "3"//Vừa nhập kho sản phẩm
                    && production.Rows[0]["ProductionStatus"].ToString() == "1")//Sản phẩm OK
                {
                    result = true;
                }
                else if (production.Rows.Count == 0)
                {
                    _description += "Kiểm tra thất bại." + Environment.NewLine;
                    _description += "Sản phẩm này chưa được công nhân xác nhận." + Environment.NewLine;
                }
                else
                {
                    _description += "Kiểm tra thất bại." + Environment.NewLine;
                    _description += "Chỉ đánh giá OQC sản phẩm khi sản phẩm vừa được công nhân nhập kho." + Environment.NewLine;
                }
            }
            return result;
        }

        private bool WriteData()
        {
            bool result = false;
            if (_dbBusiness.SetProduction(_username, _barcode, _productionStatus, _actionStatus, _completedStatus, _connectionManagement.GetDefaultConnection()))
            {
                result = true;
            }
            else
            {
                _description = "Lỗi trong quá trình xử lý dữ liệu do không kết nối được máy chủ " + Environment.NewLine;
            }
            return result;
        }
    }
}