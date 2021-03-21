using System;
using System.Collections.Generic;
using System.Text;

namespace Polyclinic.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }

        public static implicit operator User(Data.User v)
        {
            throw new NotImplementedException();
        }
    }
}
