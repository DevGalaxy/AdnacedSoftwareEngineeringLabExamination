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
        public void GetAllBills()
        {
            throw new NotImplementedException();
        }
        public void CreateBill()
        {
            throw new NotImplementedException();
        }
        public void DisplayBill(int id)
        {
            throw new NotImplementedException();
        }
        public void UpdateBill(Bill bill)
        {
            throw new NotImplementedException();
        }
        public void DeleteBill(int id)
        {
            throw new NotImplementedException();
        }
    }
}
