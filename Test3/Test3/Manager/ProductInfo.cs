using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test3.Manager
{
    public class ProductInfo
    {
        [PrimaryKey, AutoIncrement]
        public int ProductId { get; set; }
        public string ProductName { get; set; } // Номер талона
        public string Description { get; set; } // номер договора
        public string Zakaz { get; set; } // заказчик
        public string KodFKKO { get; set; } // код фкко
        public string Massa { get; set; } // масса
        public string Data { get; set; } // дата
        public string NomerMashini { get; set; } //номер машины
        public string ImageUrl { get; set; }
    }
}
