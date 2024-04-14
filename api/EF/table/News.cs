﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace api.EF.table
{
    public class News
    {
        public int ID { get; set; }
        public string TITLE { get; set; }
        public DateTime DATE { get; set; }
        [ForeignKey("Category")]
        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }
    }
}