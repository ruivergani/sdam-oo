using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime;

namespace StockManagement
{
    public class StockItem
    {
        //Attributes - fiels
        private int code;
        private string name;
        private int quantityInStock;
   

        //Get/Set Properties
        public int Code
        {
            get
            {
                return code;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArithmeticException("Item code must be a positive integer. ");
                }
                else
                {
                    code = value;
                }
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Item name cannot be blank. ");
                }
                else if (value.Contains(" "))
                {
                    throw new ArgumentException("Item name cannot be just spaces. ");
                }
                else
                {
                    name = value;
                }
                
            }
        }
        public int QuantityInStock
        {
            get
            {
                return quantityInStock;
            }
            set
            {
                quantityInStock = value;
            }
        }


        //Constructor
        public StockItem(int code, string name, int quantityInStock)
        {
            Code = code;
            Name = name;
            QuantityInStock = quantityInStock;
        }
        //Methods
        public void AddQuantity(int qty)
        {

        }
        public void SubtractQuantity(int qty)
        {

        }


    }
}
