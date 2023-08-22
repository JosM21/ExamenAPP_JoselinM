using ExamenAPI_JoselinM;
using ExamenAPP_JoselinM.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamenAPP_JoselinM.ViewModels
{
    public class AskViewModel :BaseViewModel
    {

        public Ask MyAsk { get; set; }

        public AskStatus MyAskStatus { get; set; }

      

        public AskViewModel()
        {
            MyAsk = new Ask();
            MyAskStatus = new AskStatus();
         
        }



        public async Task<List<AskStatus>> GetAskStatussAsync()
        {
            try
            {
                List<AskStatus> roles = new List<AskStatus>();

                roles = await MyAskStatus.GetAllAskStatusAsync();

                if (roles == null)
                {
                    return null;
                }

                return roles;

            }
            catch (Exception)
            {

                throw;
            }
        }




        public async Task<bool> AddAsksAsync( 
                                     DateTime pDate,
                                     string pAsk,
                                     int pUserID,
                                     int pAskStatus,
                                     string pImageURL,
                                     string pAskDetail)
                                  
                                    
        {
            if (IsBusy) return false;
            IsBusy = true;

            try
            {
                MyAsk = new Ask();

                MyAsk.Date = pDate;
                MyAsk.Ask1 = pAsk;
                MyAsk.UserId = pUserID;
                MyAsk.AskStatusId = pAskStatus;
                MyAsk.ImageUrl = pImageURL;
                MyAsk.AskDetail = pAskDetail;
                

                bool R = await MyAsk.AddAsksAsync();

                return R;

            }
            catch (Exception)
            {

                throw;

            }
            finally { IsBusy = false; }

        }

        //carga la lista de roles, que se usaran por ejemplo en el picker de roles en la
        //creación de un usuario nuevo
        public async Task<List<AskStatus>> GetAskStatusAsync()
        {
            try
            {
                List<AskStatus> roles = new List<AskStatus>();

                roles = await MyAskStatus.GetAllAskStatusAsync();

                if (roles == null)
                {
                    return null;
                }

                return roles;

            }
            catch (Exception)
            {

                throw;
            }
        }

    }

}

