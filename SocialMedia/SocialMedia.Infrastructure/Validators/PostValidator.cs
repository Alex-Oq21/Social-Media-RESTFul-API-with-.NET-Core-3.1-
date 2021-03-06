﻿using FluentValidation;
using SocialMedia.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SocialMedia.Infrastructure.Validators
{
    public class PostValidator: AbstractValidator<PostDTO>
    {
        public PostValidator()
        {
            RuleFor(post => post.Description)
               .NotNull()
               .Length(10, 500);

            RuleFor(post => post.Date)
              .LessThan(DateTime.Now);
        }
    }
}
