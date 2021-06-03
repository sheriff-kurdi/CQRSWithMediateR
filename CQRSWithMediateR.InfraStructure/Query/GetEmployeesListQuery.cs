using CQRSWithMediateR.InfraStructure.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSWithMediateR.InfraStructure.Query
{
    public record GetEmployeesListQuery() : IRequest<List<Employee>>;
}
