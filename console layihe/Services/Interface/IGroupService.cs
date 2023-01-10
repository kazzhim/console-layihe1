using ConsoleApp15.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15.Services.Interface
{
    internal interface IGroupService
    {
        void Add(Group group);
        List<Group> GetAll();
        void Update(string GroupNumber);


        

    }
}
