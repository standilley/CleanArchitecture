using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.UseCases.GetAllUser
{
    public sealed class GetAllUserValidator : AbstractValidator<GetAllUserRequest>
    {
        public GetAllUserValidator()
        {
            // sem validação
        }
    }
}
