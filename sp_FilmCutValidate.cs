using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OutboundDataAccess.Models
{
    public class sp_FilmCutValidate
    {
        [Key]
        public int? No { get; set; }

        public string Tag_No { get; set; }

        public string Product_Id { get; set; }
        
        public string Product_Name { get; set; }

        public Int16? Station { get; set; }

        public Int16? Status { get; set; }
    }
}
