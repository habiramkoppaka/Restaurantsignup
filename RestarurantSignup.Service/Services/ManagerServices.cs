using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestarurantSignup.DataAccessLayer.Repositories.Interface;
using RestarurantSignup.Models.Models;
using SmartyStreets;
using SmartyStreets.USStreetApi;

namespace RestarurantSignup.Service
{
    public interface IManagerServices
    {
        IEnumerable<Manger> GetAllManger(string name = null);
        Manger GetManager(int id);
        Manger GetManger(string name);
        void CreateManger(Manger manager);
        void DeleteManger(Manger manager);


    }
    public class ManagerServices : IManagerServices
    {
        private readonly IManagerRespository managerrepository;

        public ManagerServices(IManagerRespository managerrepository)
        {
            this.managerrepository = managerrepository;

        }

        public void CreateManger(Manger manager)
        {
            //var authId = Environment.GetEnvironmentVariable("c2533b80-5870-dd44-851d-5adb8418534b");
            //var authToken = Environment.GetEnvironmentVariable("nthnatiZtCYV3uwOlyTd");
            //var client = new ClientBuilder(authId, authToken).Build();



            //var lookup = new Lookup
            //{
            //    Street= manager.Address1,
            //    City = manager.City,
            //    State = manager.State,



            //};

            //try
            //{
            //    client.Send(lookup);
            //}
            //catch (SmartyException ex)
            //{
            //    var Excepion = ex.Message;
            //    var stack = (ex.StackTrace);
            //}

            //var candidates = lookup.Result;
            //if (candidates.Count == 0)
            //{
            //    var result = "No candidates. This means the address is not valid.";

            //}

            //else
            //{
                //var firstCandidate = candidates[0];

                //var succeed = "Address is valid. (There is at least one candidate)";
                //var zip = ("ZIP Code: " + firstCandidate.Components.ZipCode);
                //var country = ("County: " + firstCandidate.Metadata.CountyName);
                //var lati = ("Latitude: " + firstCandidate.Metadata.Latitude);
                //var longit = ("Longitude: " + firstCandidate.Metadata.Longitude);



                managerrepository.Add(manager);
            //}

        }

        public void DeleteManger(Manger manager)
        {
            managerrepository.Delete(manager);
        }

        public IEnumerable<Manger> GetAllManger(string name = null)
        {
            return
                  string.IsNullOrEmpty(name)
                  ? managerrepository.GetAll()
                  : managerrepository.GetAll().Where(c => c.LastName == name);

        }

        public Manger GetManager(int id)
        {
            var m = managerrepository.GetById(id);
            return m;

        }

        public Manger GetManger(string name)
        {
            var m = managerrepository.GetByName(name);
            return m;
        }


    }
}
