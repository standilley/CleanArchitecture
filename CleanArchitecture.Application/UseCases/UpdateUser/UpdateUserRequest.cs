using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.UseCases.UpdateUser
{
    public sealed record UpdateUserRequest(Guid id, string Email, string Name) 
                                    :IRequest<UpdateUserResponse>
    {
    }
}
