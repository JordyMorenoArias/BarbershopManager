using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Final.Models
{
    internal class Service
    {
        public int IdService { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public TimeSpan Duration { get; set; }

        public Service(int idService, string name, string description, double price, TimeSpan duration)
        {
            IdService = idService;
            Name = name;
            Description = description;
            Price = price;
            Duration = duration;
        }

        public void CreateService(Service service)
        {
            // TODO: Implementar método
        }

        public void ModifyService(Service service)
        {
            // TODO: Implementar método
        }
        public void DeleteService(Service service)
        {
            // TODO: Implementar método
        }
    }
}
