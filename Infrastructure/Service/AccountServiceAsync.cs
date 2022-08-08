using Core.Contracts.Repository;
using Core.Contracts.Service;
using Core.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
    public class AccountServiceAsync : IAccountServiceAsync
    {
        private readonly IAccountRepositoryAsync _accountRepositoryAsync;
        public AccountServiceAsync(IAccountRepositoryAsync accountRepositoryAsync)
        {
            _accountRepositoryAsync = accountRepositoryAsync;
        }

        public async Task<SignInResult> SignInAsync(LoginModel model)
        {
            return await _accountRepositoryAsync.SignInAsync(model);
        }

        public async Task<IdentityResult> SignUpAsync(SignUpModel model)
        {
            return await _accountRepositoryAsync.SignUpAsync(model);
        }
    }
}
