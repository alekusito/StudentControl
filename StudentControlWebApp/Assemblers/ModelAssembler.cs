using Microsoft.EntityFrameworkCore.Metadata.Internal;
using StudentControlWebApp.Data;
using Entities = StudentControlWebApp.Entities;
using Models = StudentControlWebApp.Models;

namespace StudentControlWebApp.Assemblers.ModelAssembler
{
    public class ModelAssembler()
    {
               
        public Models.Belt CreateBelt(Entities.Belt beltEntity)
        {
            Models.Belt belt = new Models.Belt
            {
                Id = beltEntity.BeltId,
                Description = beltEntity.BeltDescription
            };

            return belt;
        }

        public List<Models.Belt> CreateBelts(List<Entities.Belt> beltEntities)
        {
            List<Models.Belt> belts = new List<Models.Belt>();

            foreach(Entities.Belt beltEntity in beltEntities)
            {
                belts.Add(CreateBelt(beltEntity));
            }

            return belts;            
        }
    }
}