using Core.Entities;
using Core.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts.Repository
{
    public interface IAccountRepositoryAsync : IRepositoryAsync<SignUpModel>
    {
        Task<IdentityResult> SignUpAsync(SignUpModel user);
        Task<SignInResult> SignInAsync(LoginModel login);
    }
}
