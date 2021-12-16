using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace WebAppDisney.Validations
{
    public class CheckCalificacion : ValidationAttribute
    {
        public CheckCalificacion()
        {
            ErrorMessage = "Rating must be between 1 and 5.";
        }
        public override bool IsValid(object value)
        {
            int raiting = Convert.ToInt32(value);
            if (raiting < 1 || raiting < 5)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
