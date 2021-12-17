using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTest.Models
{
    public class RegisterMemberReq
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }

        public bool IsSubscript { get; set; }
    }

    public class MemberValidator : AbstractValidator<RegisterMemberReq>
    {
        public MemberValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Name).Length(2,4);
            RuleFor(x => x.Email).EmailAddress();
            RuleFor(x => x.Age).InclusiveBetween(18, 99);
        }
    }
}
