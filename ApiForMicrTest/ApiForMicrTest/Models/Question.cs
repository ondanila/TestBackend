using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppForTest.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string QText { get; set; }
        public string AText { get; set; }
        public int Topic { get; set; }
    }
}