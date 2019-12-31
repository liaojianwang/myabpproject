using Abp.AutoMapper;
using MyAbpProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAbpProject.Navigations.Dto
{
    [AutoMap(typeof(NavigationInfo))]
    public class NavigationOutput
    {
        public long Id { get; set; }
        public int ParentId { get; set; }
        public string NavTitle { get; set; }
        public int ClassLayer { get; set; }
    }
}
