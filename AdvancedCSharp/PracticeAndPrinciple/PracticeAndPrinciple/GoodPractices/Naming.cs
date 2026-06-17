using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAndPrinciple.GoodPractices
{
    #region CLASSES,PROPERTIES,FIELDS,METHODS,VARIABLES,NAMESPACES,PARAMETERS ETC.
    //Bad Example:

    internal class User
    {
        private readonly string _userFolder = @"C:\users";
        public int Age { get; set; }
        public bool IsLogged { get; set; }
        public List<string> Hobbies { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public User()
        {
            
        }

        public void ChangeUsername(string username)
        {
            Username = username;
        }

        public void ChangePassword(string password)
        {
            Password = password;
        }
        public async Task GetUsersAsync()
        {
            //da ni bide return task type
            //namesto void stavame Task
        }
        //imenuvanje na enums sekogas treba da ne go piuvame vo ne RoleEnums tuku Role samo
        //da ne naglasuvame celo vreme deka imame Enum 


    }

    #endregion

    #region ENUMS
    //bad example: 
    public enum RoleEnum
    {
        Admin,
        User,
        Manager,
    }
    //good example:
    public enum Role
    {
        Admin = 1 ,
        User,//= 2,
        Manager//= 3
    }

    #endregion

    #region INTERFACES
    //BAD EXAMPLE
    public interface iuserrepository
    {

    }

    //Good Example
    public interface IUserRepository
    {

    }
    public interface IUserService
    {

    }

    #endregion

    public class Naming
    {

    }
}
