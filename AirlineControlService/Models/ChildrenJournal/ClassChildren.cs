using AirlineControlService.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineControlService.Models.ChildrenJournal
{
    internal class ClassChildren: IEntity
    {
        public int Id { get; set; }
        public Classes Class { get; set; }
        public IList<Children> Childrens { get; set; } = new List<Children>();
    }
}
