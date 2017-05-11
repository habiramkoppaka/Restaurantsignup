using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestarurantSignup.Models.Models;
using RestarurantSignup.DataAccessLayer.Repositories.Interface;

namespace RestarurantSignup.Service.Services
{
    public interface ILocationServices
    {
        IEnumerable<Location> GetAllLocation(string name = null);
        Location GetLocationbyID(int id);
        Location GetLocationbyName(string name);
        void CreateLocation(Location location);
        void DeleteLocation(Location location);

    }
    public class LocationServices : ILocationServices
    {
        private readonly ILocationRepository locationrepository;
        public LocationServices(ILocationRepository locationrepository)
        {
            this.locationrepository = locationrepository;
        }

        public void CreateLocation(Location location)
        {
            locationrepository.Add(location);
        }

        public void DeleteLocation(Location location)
        {
            locationrepository.Delete(location);
        }

        public IEnumerable<Location> GetAllLocation(string name = null)
        {
            return
                   string.IsNullOrEmpty(name)
                   //if location not specified
                   ? locationrepository.GetAll()
                   //if location specified
                   : locationrepository.GetAll().Where(c => c.LocationName == name);
        }

        public Location GetLocationbyID(int id)
        {
           return locationrepository.GetById(id);
        }

        public Location GetLocationbyName(string name)
        {
            throw new NotImplementedException();
        }
    }


}
