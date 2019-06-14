﻿using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Application.Share.Projects.Dto
{
   public partial class ProjectDto :Entity<int>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ActiveDate { get; set; }
        public int Status { get; set; }
    }
}