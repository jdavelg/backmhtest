// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace mhtest.Models
{
    public partial class Score
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public int StudentId { get; set; }

        public virtual Student Student { get; set; }
    }
}