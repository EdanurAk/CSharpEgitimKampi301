using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Context
{
    public class KampContext : DbContext//Veritabanına yansıtmak istediğimiz tüm sınıfları KampContext içinde tutuyoruz
    {
        public DbSet<Category> Categories { get; set; }//Category class ismi categories veritabanına yasıyacak olan tablo ismi (karışmasın diye)
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
