﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using GWebsite.AbpZeroTemplate.Core.Models;

namespace GWebsite.AbpZeroTemplate.Application.Share.NhanViens.Dto
{

    /// <summary>
    /// <model cref="NhanVien'"></model>
    /// </summary>
    public class NhanVienForViewDto
    {
        public string TenNhanVien { get; set; }
        public int MaDV { get; set; }
        public string TenDV { get; set; }
    }
}
