﻿using CompupharmLtd.Data;
using CompupharmLtd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CompupharmLtd.Service
{
    public class UserService
    {
        public static LoginStatus Login(LoginUser cred)
        {
            var status = new LoginStatus();
            if (cred.UserName != null)
            {
                LoginUser result = UserData.LoginData(cred.UserName);
                if (result.UserName == null)
                {
                    status.statusCode = 02;
                    status.status = "User Account Doesnt exist";
                }
                else {
                   // Regex.Replace(result.UserName, @"\s+", "");
                   if (result.UserName.Trim() == cred.UserName)
                    {
                        status.statusCode = 00;
                        status.status = "Successfull";

                    }
                    else {
                        status.statusCode = 01;
                        status.status = "Invalid Username and Password Match";
                    }

                }
            }
            return status;
        }

        public static CreateUserResponse Create(User customer)
        {
            var response = new CreateUserResponse();
            User result = UserData.CreateData(customer);
            if (result.CompanyName == null)
            {

                response.StatusCode = 01;
                response.Status = "request was  unsuccessful";
            }
            else {
                response.StatusCode = 00;
                response.Status = "Successfull";
            }
            return response;
        }
    }
}
