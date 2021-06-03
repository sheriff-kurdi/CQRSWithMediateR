using CQRSWithMediateR.InfraStructure.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSWithMediateR.InfraStructure.Command
{
    public record AddEmployeeCommand(int Id, string Name, string Position) : IRequest<Employee>;

}
