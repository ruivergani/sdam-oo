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
                if (value <= 0)
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
                else if (value.Trim().Length == 0)
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
                if (value < 0)
                {
                    throw new ArithmeticException("Quantity cannot be zero or negative. ");
                }
                else
                {
                    quantityInStock = value;
                }
            }
        }


        //Constructor
        public StockItem(int code, string name, int quantityInStock)
        {
            if ((code <= 0) && (name == "") && (quantityInStock <= 0))
            {
                throw new ArithmeticException("Item code must be a positive integer. Item name cannot be blank. Quantity cannot be zero or negative. ");
            }
            else if ((code <= 0) && (name.Contains(" "))){
                throw new ArithmeticException("Item code must be a positive integer. Item name cannot be just spaces. ");
            }
            else
            {
                Code = code;
                Name = name;
                QuantityInStock = quantityInStock;
            }
        }
        public StockItem()
        {

        }
        //Methods
        public void AddQuantity(int qty)
        {
            if (qty <= 0)
            {
                throw new ArithmeticException("Quantity cannot be negative");
            }
            else
            {
                QuantityInStock += qty;
            }
            
        }
        public void SubtractQuantity(int qty)
        {
            if (qty < 0)
            {
                throw new ArithmeticException("Quantity cannot be negative");
            }
            else
            {
                if (qty > quantityInStock)
                {
                    throw new ArithmeticException("Insufficient quantity in stock");
                }
                else
                {
                    QuantityInStock -= qty;
                }
            } 
        }
    }
}
