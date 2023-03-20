using System;
using StudentControl.DAL;
using Models = StudentControl.PersonServices.Models;
using Entities = StudentControl.PersonServices.Entities;
using StudentControl.PersonServices.Provider.Assemblers;
using System.Linq;
using System.Collections.Generic;

namespace StudentControl.PersonServices.Provider
{
    public class PersonServiceProvider : IPersonService
    {
        #region Context

        public DataBaseContext _studentControlContext;

        public PersonServiceProvider(DataBaseContext studentControlContext)
        {
            _studentControlContext = studentControlContext;
        }

        #endregion Context

        #region Person

        /// <summary>
        /// SavePerson
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public Models.Person SavePerson(Models.Person person)
        {
            try
            {
                //convierto de modelo a entidad.
                Entities.Person personEntity = EntityAssembler.CreatePerson(person);

                _studentControlContext.Persons.Add(personEntity);
                _studentControlContext.SaveChanges();

                int id = personEntity.IndividualId; //esto se usa cuando son claves del tipo Identity
                personEntity.IndividualId = id;

                person = ModelAssembler.CreatePerson(personEntity);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                person = new Models.Person();
                person.FirstName = message;
            }

            return person;
        }

        /// <summary>
        /// UpdatePerson
        /// </summary>
        /// <param name="accountingAccount"></param>
        /// <param name="parentId"></param>
        /// <returns></returns>
        public Models.Person UpdatePerson(Models.Person person)
        {
            try
            {
                //convierto de modelo a entidad.
                Entities.Person personEntity = EntityAssembler.CreatePerson(person);

                _studentControlContext.Persons.Update(personEntity);
                _studentControlContext.SaveChanges();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                person = new Models.Person();
                person.FirstName = message;
            }

            return person;
        }

        /// <summary>
        /// GetPerson
        /// </summary>
        /// <param name="accountingAccountId"></param>
        /// <returns></returns>
        public Models.Person GetPerson(int individualId)
        {
            Models.Person person = new Models.Person();

            try
            {
                Entities.Person personEntity = _studentControlContext.Persons.FirstOrDefault(x => x.IndividualId == individualId);

                if (personEntity != null)
                {
                    person = ModelAssembler.CreatePerson(personEntity);
                }                
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                person.IndividualId = -1;
                person.FirstName = ex.Message;
            }

            return person;
        }

        /// <summary>
        /// GetPersons
        /// </summary>
        /// <returns></returns>
        public List<Models.Person> GetPersons()
        {
            List<Entities.Person> personCollection = _studentControlContext.Persons.ToList();
            List<Models.Person> persons = new List<Models.Person>();

            foreach (Entities.Person item in personCollection)
            {
                persons.Add(ModelAssembler.CreatePerson(item));
            }

            return persons;
        }

        #endregion Person
    }
}
