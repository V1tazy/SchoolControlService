using AirlineControlService.DAL.Entityes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineControlService.DAL.Entityes
{
    public class ParentChild : Entity
    {
        public User Parent { get; set; }
        public int ParentId { get; set; }

        public Child Child { get; set; }
        public int ChildId { get; set; }
    }
}
