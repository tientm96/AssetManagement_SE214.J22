﻿namespace GWebsite.AbpZeroTemplate.Core.Models
{
    public class Customer_SuaChua : FullAuditModel
    {
        public string ngayXuat { get; set; }
        public string ngaySuaXong { get; set; }
        public string maBDS { get; set; }
        public string tenBDS { get; set; }

        public string nguoiDeXuat { get; set; }
        public string nvPhuTrach { get; set; }
        public string trangThaiDuyet { get; set; }



    }
}