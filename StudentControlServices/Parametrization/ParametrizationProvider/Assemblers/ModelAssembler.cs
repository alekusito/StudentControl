using Models = StudentControl.ParametrizationServices.Models;
using Entities = StudentControl.ParametrizationServices.Entities;
using System.Collections.Generic;
using StudentControl.DAL;
using System.Linq;

namespace StudentControl.ParametrizationServices.Assemblers
{
    public class ModelAssembler
    {
        
        /// <summary>
        /// CreateBelt
        /// </summary>
        /// <param name="beltEntity"></param>
        /// <returns></returns>
        public Models.Belt CreateBelt(Entities.Belt beltEntity)
        {
            Models.Belt belt = new Models.Belt();

            belt.Id = beltEntity.BeltId;
            belt.Description = beltEntity.BeltDescrition;

            return belt;
        }

        /// <summary>
        /// CreateBelts
        /// </summary>
        /// <param name="studentControlContext"></param>
        /// <returns></returns>
        public List<Models.Belt> CreateBelts(DataBaseContext _dataBaseContext)
        {
            List<Models.Belt> belts = new List<Models.Belt>();

            foreach (Entities.Belt item in _dataBaseContext.Belts.ToList())
            {
                belts.Add(CreateBelt(item));
            }

            return belts;
        }

    }
}
