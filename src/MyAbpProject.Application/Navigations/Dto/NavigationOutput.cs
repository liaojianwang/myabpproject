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
        public long ParentId { get; set; }
        public string NavTitle { get; set; }
        public string NavName { get; set; }
        public int ClassLayer { get; set; }
        public string IconUrl { get; set; }
        public string LinkUrl { get; set; }
        public long ChannelId { get; set; }
    }
}
