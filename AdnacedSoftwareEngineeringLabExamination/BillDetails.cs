using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDemo
{
    public class BillDetails
    {
        public int Id { get; set; }
        public int BillId { get; set; }
        public List<Item> Items { get; set; }
    }
}
