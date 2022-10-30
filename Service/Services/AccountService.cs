using Service.Helpers.Constants;
using Service.Helpers.Enums;
using Service.Services.Interfaces;

namespace Service.Services
{
    public class AccountService : IAccountService

    {
        public string Login(string email, string password, int role)
        {
            if(email == AccountConstants.Email && password == AccountConstants.Password)
                if(CheckRole(role))
                {
                    return AccountConstants.Success;
                }
                else
                {
                    return AccountConstants.NoAuthorize;
                }

            return AccountConstants.Failed; 
        }

        private bool CheckRole(int role)
        {
            //switch (role)
            //{
            //    case (int)Roles.SuperAdmin:
            //        return true;
            //    default:
            //        return false;
            //}

            if (role == (int)Roles.SuperAdmin)
                return true;

            return false;
        }
    }
}
