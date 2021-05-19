using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SoftDevLab
{
    public partial class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
    }
}
