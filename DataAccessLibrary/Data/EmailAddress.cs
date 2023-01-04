using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
    public class EmailAddress
    {
        public int ID { get; set; } = -1;
        public int EntityID { get; set; }
        public string? Name { get; set; } = "";
        public string? Address { get; set; } = "";

    }
}
