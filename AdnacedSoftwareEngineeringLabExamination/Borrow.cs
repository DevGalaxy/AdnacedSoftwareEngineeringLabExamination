﻿using System;

namespace OOPDemo
{
    public class Borrow
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int UserId { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public User User { get; set; }
        public Item Item { get; set; }

        public void GetAllBorrows()
        {
            throw new NotImplementedException();
        }
        public bool AddNewBorrow()
        {
            throw new NotImplementedException();
        }
        public void AddFine(int borrowId)
        {
            throw new NotImplementedException();
        }
    }
}