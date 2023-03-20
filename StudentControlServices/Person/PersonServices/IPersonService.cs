using System;
using System.Collections.Generic;

namespace StudentControl.PersonServices
{
    public interface IPersonService
    {
        /// <summary>
        /// GetPersons
        /// </summary>
        /// <returns></returns>
        List<Models.Person> GetPersons();
    }
}
