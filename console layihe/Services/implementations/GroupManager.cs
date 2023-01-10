using ConsoleApp15.Services.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15.Services.implementations
{
    internal class GroupManager : IGroupService
    {
        List<Group> _groups=Lists.Groups;
        public void Add(Group group)
        {
            List<Group> groups = _groups.Where(x => x.No == group, No).ToList() ;
              if (groups.Count == 0) 
            {
                if(group.IsOnline==true)
                {
                    group.Limit = 15;
                }
                else
                {
                    group.Limit = 10;
                }
                _groups.Add(group);
            }
            else
            {
                Console.WriteLine("Bu qrup nomresi var");
            }
            Console.Write("Yeniden qrup nomresi yazin:");
            string Groupnumber=Console.ReadLine();
            group.GroupName = Groupnumber;
            Add(group);
        }

        public List<Group> GetAll()
        {
            return _groups;
        }

        public void Update(string GroupNumber,string NewNumber)
        {
            Group _group=_groups.FirstOrDefault(x=>x. GroupName==GroupNumber);
            if (_group == null)
            {
                Console.WriteLine("Bele nomrede qrup yoxdur");
            } 
            else 
            {
                Group group1=_groups.FirstOrDefault(x => x.GroupName == NewNumber);
                if (group1 == null) 
                {
                    _groups.FirstOrDefault(x => x.GroupName == GroupNumber).GroupName = NewNumber;
                }
                else
                {
                    Console.WriteLine("Bu qrup nomresi movcuddur");
                    Console.Write("Yeniden Qrup nomrei yaz:");
                    Newgroupnumber=Console.ReadLine();
                    NewNumber = Newgroupnumber;
                    Update(GroupNumber, NewNumber);
                }
            }

        }

        public void Update(string GroupNumber)
        {
            throw new NotImplementedException();
        }
    }
}
