using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace ApiForMicrTest.Models
{
    class UserQuestionModel
    {
        [Key]
        [Column(Order = 1)]
        public int userTestID { get; set; }
        [Key]
        [Column(Order = 2)]
        public int QID { get; set; }
        public int Result { get; set; }
    }
}
