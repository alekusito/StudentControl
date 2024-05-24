using Microsoft.EntityFrameworkCore.Metadata.Internal;
using StudentControlWebApp.Data;
using Entities = StudentControlWebApp.Entities;
using Models = StudentControlWebApp.Models;

namespace StudentControlWebApp.Assemblers.EntityAssembler
{
    public class EntityAssembler()
    {
               
        public Entities.Belt CreateBelt(Models.Belt belt)
        {
            Entities.Belt beltEntity = new Entities.Belt
            {
                BeltId = belt.Id,
                BeltDescription = belt.Description
            };

            return beltEntity;
        }
    }
}