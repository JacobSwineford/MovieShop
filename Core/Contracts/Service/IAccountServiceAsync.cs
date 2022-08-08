using Core.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts.Service
{
    public interface IAccountServiceAsync
    {
        Task<IdentityResult> SignUpAsync(SignUpModel model);
        Task<SignInResult> SignInAsync(LoginModel model);
    }
}
