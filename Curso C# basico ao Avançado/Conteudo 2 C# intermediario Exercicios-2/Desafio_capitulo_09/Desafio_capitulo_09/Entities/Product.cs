﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_capitulo_09.Entities
{
    class Product
    {
        public string Name { get; set; }

        public double Price { get;  private set; }


        public Product()
        {

        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }


    }
}
