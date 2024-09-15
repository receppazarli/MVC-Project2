using mvc_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_2.Data
{
    public class CustomerData
    {
        public static List<Customer> Customers = new List<Customer>() {

            new Customer
            {
                Id = 1,
                FirstName = "Recep",
                LastName = "Pazarlı",
                NationalityId = "11111111111",
                City = "Bursa",
                County = "Mudanya",
                Address = "Merkez mahallesi",
                Phone = "0123 458 7474"
            },
            new Customer
            {
                Id = 2,
                FirstName = "Ahmet",
                LastName = "Yılmaz",
                NationalityId = "22222222222",
                City = "İstanbul",
                County = "Kadıköy",
                Address = "Merkez mahallesi",
                Phone = "1234 567 1212"
            }

        };
    }
}