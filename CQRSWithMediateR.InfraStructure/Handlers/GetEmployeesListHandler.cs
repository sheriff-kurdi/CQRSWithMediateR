using CQRSWithMediateR.InfraStructure.DataAccess;
using CQRSWithMediateR.InfraStructure.Entities;
using CQRSWithMediateR.InfraStructure.Query;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSWithMediateR.InfraStructure.Handlers
{
    public class GetEmployeesListHandler : IRequestHandler<GetEmployeesListQuery, List<Employee>>
    {
        private readonly IEmployeesRepo employeeRepo;

        public GetEmployeesListHandler(IEmployeesRepo employeeRepo)
        {
            this.employeeRepo = employeeRepo;
        }
        public Task<List<Employee>> Handle(GetEmployeesListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(employeeRepo.GetAll());
        }
    }
}
