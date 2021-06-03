using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDemo
{
    public class Bill
    {
        public int Id { get; set; }
        public int BorrowId { get; set; }
        public Borrow Borrow { get; set; }
    }
}
