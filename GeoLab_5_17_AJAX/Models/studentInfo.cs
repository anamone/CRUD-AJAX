using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GeoLab_5_17_AJAX.Models
{
    public class studentInfo
    {
        [StringLength(6,ErrorMessage="იყოს 6-ზე ნაკლები")]
        public String StudentName { get; set; }
    }
}