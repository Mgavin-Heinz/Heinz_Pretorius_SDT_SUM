using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStockCapture
{
    public class MobileStock
    {
        public int Code { get; set; }
        public string Make { get; set; }
        public int Quantity { get; set; }

    public MobileStock(int code, string make, int quantity)
        {
            Code = code;
            Make = make;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"Code: {Code}, Make: {Make}, Quantity: {Quantity}";
        }
    } 

    

    
}


    
