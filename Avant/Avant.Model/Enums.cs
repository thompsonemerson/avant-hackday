using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avant.Model
{
    public enum Category
    {
        [Display(Name = "Perfumaria")]
        Perfumery = 0,
        [Display(Name = "Roupas")]
        Clothes = 1
    }
}
