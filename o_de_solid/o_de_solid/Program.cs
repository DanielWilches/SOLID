using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace o_de_solid
{

    public class Orden 
    {
        private string linelItems = string.Empty;
        private IShipping shipping;
        public double getTotal() 
        {
            return 0.0;
        }
        public void getTotalWeight() { }
        public void setShippingType(IShipping shpiiping) { }
        public string getShippingCost() { return string.Empty; }
        public void getShippingDate(string shippingCost) { }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }


    public class Air : IShipping
    {
        public object getCost(object Orden) 
        {
            return null;
        }
        public object getDate(object Orden) 
        {
            return null;
        }
    }

    public class Train : IShipping
    {
        public object getCost(object Orden)
        {
            return null;
        }
        public object getDate(object Orden)
        {
            return null;
        }
    }
    public class Water : IShipping
    {
        public object getCost(object Orden)
        {
            return null;
        }
        public object getDate(object Orden)
        {
            return null;
        }
    }



    public interface IShipping 
    {
        object getCost(object Orden);
        object getDate(object Orden);
    
    }
}
