using System;
using Models = StudentControl.ParametrizationServices.Models;
using Entities = StudentControl.ParametrizationServices.Entities;

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
