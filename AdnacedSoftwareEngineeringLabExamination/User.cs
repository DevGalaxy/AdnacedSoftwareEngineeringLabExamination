﻿using System;
using System.Text;

namespace OOPDemo
{
    public class User
    {
      
        public int Id { get; set; }
        public string Name { get; set; }
        private string _email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        public string GetEmail()
        {
            return _email;
        }
        public void SetEmail(string email)
        {
            // 
        }
    }
}
