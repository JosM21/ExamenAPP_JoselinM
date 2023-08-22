using ExamenAPP_JoselinM.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamenAPP_JoselinM.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        public User MyUser { get; set; }

        public UserViewModel() 
        { 
            MyUser = new User();

        }



        //funcion que carga los datos del objeto de usuario global
        public async Task<User> GetUserDataAsync()
        {
            if (IsBusy) return null;
            IsBusy = true;

            try
            {
                User user = new User();

                user = await MyUser.GetUsuario();

                if (user == null) return null;

                return user;

            }
            catch (Exception)
            {
                return null;
                throw;
            }
            finally { IsBusy = false; }


        }


    }
}
