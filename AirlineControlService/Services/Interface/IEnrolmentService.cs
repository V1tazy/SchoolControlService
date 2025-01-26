using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AirlineControlService.DAL.Entityes;

namespace AirlineControlService.BLL.Services
{
    public interface IEnrolmentService
    {
        IEnumerable<Child> Childs { get; }

        Task<Child> MakeEnrolment(
            string FirstName,
            string LastName,
            DateTime BirthDay,
            DateTime CreatedAt,
            DateTime UpdatedAt,
            int ParentId
        );
    }
}
