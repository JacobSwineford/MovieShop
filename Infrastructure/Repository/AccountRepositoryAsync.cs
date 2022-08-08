using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Contracts.Repository;
using Infrastructure.Data;
using Core.Models;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Repository
{
    public class AccountRepositoryAsync : BaseRepositoryAsync<SignUpModel>, IAccountRepositoryAsync
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public AccountRepositoryAsync(MVCDbContext _dbContext, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager) : base(_dbContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<SignInResult> SignInAsync(LoginModel login)
        {
            return await _signInManager.PasswordSignInAsync(login.UserName, login.Password, false, false);
        }

        public async Task<IdentityResult> SignUpAsync(SignUpModel model)
        {
            ApplicationUser user = new ApplicationUser();
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.Email = model.Email;
            user.UserName = model.Email;
            return await _userManager.CreateAsync(user, model.Password);
        }
    }
}