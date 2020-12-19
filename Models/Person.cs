using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Codeboxx_Stack_Demo.Models
{
    public class Person
    {
        //this will force the user to enter a value between 10 and 99 inclusivly
        [Range(10, 99)]
        public int Age { get; set; }




        // this will require the user to have an email other wise the 'ModelState.IsValid' will return false. Wich in term will display an error to the user
        [Required]
        public string Email { get; set; }




        // We can also have more than 1 requirement per field. In here we require the user to enter its name. His name cannot be less than 3 characters long
        [Required, MinLength(3)]
        public string Name { get; set; }
    }
}
