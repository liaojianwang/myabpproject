using Abp.Dapper.Repositories;
using Abp.ObjectMapping;
using MyAbpProject.Entities;
using MyAbpProject.Navigations.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyAbpProject.Navigations
{
    public class NavigationService : INavigationService
    {
        private readonly IDapperRepository<NavigationInfo, long> _navigation;
        private readonly IObjectMapper _objectMapper;
        public NavigationService(IDapperRepository<NavigationInfo, long> navigation
            , IObjectMapper objectMapper)
        {
            _navigation = navigation;
            _objectMapper = objectMapper;
        }

        public List<NavigationOutput> GetList(long parentid, string navtype)
        {
            List<NavigationOutput> list = new List<NavigationOutput>();
            if (string.IsNullOrWhiteSpace(navtype))
            {
                return list;
            }
            var navigations = _navigation.GetAll(c => c.NavType == navtype);//.ToList();
            var query = _objectMapper.ProjectTo<NavigationOutput>(navigations.AsQueryable()).ToList();
            GetChilds(query, list, parentid, 0);
            return list;
        }

        private void GetChilds(List<NavigationOutput> oldData, List<NavigationOutput> newData, long parentid, int classlayer)
        {
            classlayer++;
            IEnumerable<NavigationOutput> list = oldData.Where(c => c.ParentId == parentid);
            foreach (var item in list)
            {
                item.ClassLayer = classlayer;
                newData.Add(item);
                this.GetChilds(oldData, newData, item.Id, classlayer);
            }
        }
    }
}
