using CQRSWithMediateR.InfraStructure.Command;
using CQRSWithMediateR.InfraStructure.DataAccess;
using CQRSWithMediateR.InfraStructure.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSWithMediateR.InfraStructure.Handlers
{
    public class AddEmployeeHandler : IRequestHandler<AddEmployeeCommand, Employee>
    {
        private readonly IEmployeesRepo employeesRepo;

        public AddEmployeeHandler(IEmployeesRepo employeesRepo)
        {
            this.employeesRepo = employeesRepo;
        }
        public Task<Employee> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(employeesRepo.Add(new()
            {
                Id = request.Id,
                Name = request.Name,
                Position = request.Position
            }));
        }
    }
}
