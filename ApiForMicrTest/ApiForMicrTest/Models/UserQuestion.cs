using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppForTest.Models
{
    public class UserQuestion
    {
        [Key]
        [Column(Order = 1)]
        public int userTestID { get; set; }
        [Key]
        [Column(Order = 2)]
        public int QID { get; set; }
        public int Result { get; set; }
        //public int ut_q_id { get; set; }
    }
}