﻿using AccountCore.DataModels;
using AccountCore.Helpers;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AccountCore.Repositories.Interfaces
{


    public interface ILoggedAccountManager
    {

        string CurrentUserId { get; }
    }


    public interface IAccountManager
    {

        string CurrentUserId { get; }
		Claim CurrentUserClaim { get; }
		Task<Tuple<bool, string[]>> CreateUserAsync(ApplicationUsers user, IEnumerable<string> roles, string password);
        Task<IdentityResult> CreateUserAsync(ApplicationUsers user);
        Task<bool> CheckPasswordAsync(ApplicationUsers user, string password);
        Task<Tuple<bool, string[]>> DeleteUserAsync(ApplicationUsers user);
        Task<Tuple<bool, string[]>> DeleteUserAsync(string userId);
        Task<Tuple<ApplicationUsers, string[]>> GetUserAndRolesAsync(string userId);
        Task<ApplicationUsers> GetUserByEmailAsync(string email);
        Task<ApplicationUsers> GetUserByIdAsync(string userId);
        Task<ApplicationUsers> GetUserByUserNameAsync(string userName);
        Task<IList<string>> GetUserRolesAsync(ApplicationUsers user);
        Task<List<Tuple<ApplicationUsers, string[]>>> GetUsersAndRolesAsync(int page, int pageSize);
        Task<Tuple<bool, string[]>> ResetPasswordAsync(ApplicationUsers user, string newPassword);
        Task<Tuple<bool, string[]>> UpdatePasswordAsync(ApplicationUsers user, string currentPassword, string newPassword);
        Task<Tuple<bool, string[]>> UpdateUserAsync(ApplicationUsers user);
        Task<Tuple<bool, string[]>> UpdateUserAsync(ApplicationUsers user, IEnumerable<string> roles);
        Task<Tuple<bool, string[]>> CreateRoleAsync(ApplicationRoles role, IEnumerable<string> claims);
        Task SignInAsync(ApplicationUsers user, bool isPersistent, string authenticationMethod = null);
        Task<IdentityResult> SetLockoutEnabledAsync(ApplicationUsers user, bool enabled);
        Task SignOutAsync();
        Task<ApplicationUsers> GetTwoFactorAuthenticationUserAsync();

        //Task<Tuple<bool, string[]>> UpdateRoleAsync(ApplicationRole role, IEnumerable<string> claims);
        //Task<ApplicationRole> GetRoleByIdAsync(string roleId);
        Task<ApplicationRoles> GetRoleByNameAsync(string roleName);
        //Task<ApplicationRole> GetRoleLoadRelatedAsync(string roleName);
        //Task<List<ApplicationRole>> GetRolesLoadRelatedAsync(int page, int pageSize);
        //



    }
}
