using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagement.Controller
{
    class ModuleListController
    {
        TrainingManagementEntities entities = new TrainingManagementEntities();

        public dynamic getAllModule(string major, string moduleCode, string moduleName)
        {
            var result = from c in entities.module_list
                         select c;

            if (moduleCode != "")
                result = from c in entities.module_list
                         where c.code.Contains(moduleCode)
                         select c;

            if (moduleName != "")
                result = from c in entities.module_list
                         where c.name.Contains(moduleName)
                         select c; 

            var data = from c in result
                       where c.major.name.Equals(major)
                       orderby c.code ascending
                       select new
                       {
                           Code = c.code,
                           Name = c.name,
                           Credits = c.credits
                       };

            return data.ToList();
        }

        public dynamic getCreditsByCode(string moduleName, string right, string moduleCode)
        {
            var data = from c in entities.module_list
                       where c.name.Equals(moduleName) && c.major.name.Equals(right) && c.code.Equals(moduleCode)
                       select new
                       {
                           Credits = c.credits
                       };
            return data.ToList().FirstOrDefault();
        }
    }
}
