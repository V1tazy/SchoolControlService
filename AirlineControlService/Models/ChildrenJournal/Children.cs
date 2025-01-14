using AirlineControlService.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineControlService.Models.ChildrenJournal
{
    internal class Children: IEntity
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Birth_day { get; set; }

        public IList<User> Parent { get; set; } = new List<User>();

        public string Created_at { get; set; }

        public string Update_at { get; set; }
    }
}
