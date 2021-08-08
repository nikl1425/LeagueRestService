using System;
using Microsoft.EntityFrameworkCore;
namespace DataService.Model
{
    public class UserModel
    {
        
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string email { get; set; }
    }
}
