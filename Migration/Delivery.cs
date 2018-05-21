using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migration
{
    public class Delivery
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Addres { get; set; }
        public int BookId{ get; set; }
        public virtual Book Book
        {
            get;set;
        }
    }
}
