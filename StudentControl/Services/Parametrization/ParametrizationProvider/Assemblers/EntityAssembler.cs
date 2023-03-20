using System;
using Models = StudentControl.PersonServices.Models;
using Entities = StudentControl.PersonServices.Entities;

namespace StudentControl.ParametrizationServices.Assemblers
{
    public class EntityAssembler
    {
        public static Entities.Belt CreateBelt(Models.Belt belt)
        {
            Entities.Belt beltEntity = new Entities.Belt();
            beltEntity.BeltId = belt.Id;
            beltEntity.BeltDescrition = belt.Description;            

            return beltEntity;
        }
    }
}
