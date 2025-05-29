using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace BO
{
    internal static class Tools
    {
        public static string ToStringProperty<T>(this T obj, string prefix = " ")
        {
            StringBuilder sb = new StringBuilder();
            Type t = obj.GetType();

            foreach (PropertyInfo propertyInfo in t.GetProperties())
            {
                if (propertyInfo.PropertyType.IsPrimitive
                  || propertyInfo.PropertyType == typeof(string)
                  || propertyInfo.PropertyType == typeof(DateTime))
                {
                    sb.AppendLine($"{prefix}{propertyInfo.Name}= {propertyInfo.GetValue(obj)}");
                }
                else
                {
                    sb.AppendLine($"{prefix}{propertyInfo.Name}=\n {propertyInfo.GetValue(obj).ToStringProperty(prefix + "\t")}");
                }
            }
            return sb.ToString();
        }

        public static BO.Sale convertSaleDoToBo(this DO.Sale obj)
        {
            BO.Sale result = new BO.Sale()
            {
                Code = obj.Code,
                ProductId = obj.ProductId,
                MinQuantity = obj.MinQuantity,
                Price = obj.Price,
                InClab = obj.InClab,
                BeginSale = obj.BeginSale,
                EndSale = obj.EndSale

            };
            return result;
        }

        public static DO.Sale converSaletBoToDo(this BO.Sale obj)
        {
            DO.Sale result = new DO.Sale()
            {
                Code = obj.Code,
                ProductId = obj.ProductId,
                MinQuantity = obj.MinQuantity,
                Price = obj.Price,
                InClab = obj.InClab,
                BeginSale = obj.BeginSale,
                EndSale = obj.EndSale

            };
            return result;
        }

        public static DO.Product convertProductBoToDo(this BO.Product obj)
        {
            DO.Product result = new DO.Product()
            {
                Id = obj.Id,
                ProductName = obj.ProductName,
                Category = (DO.Categories)obj.Category,
                Price = obj.Price,
                QuantityInStock = obj.QuantityInStock,


            };
            return result;
        }

        public static BO.Product convertProductDoToBo(this DO.Product obj)
        {
            BO.Product result = new BO.Product()
            {
                Id = obj.Id,
                ProductName = obj.ProductName,
                Category = (BO.Categories)obj.Category,
                Price = obj.Price,
                QuantityInStock = obj.QuantityInStock,


            };
            return result;
        }


        public static BO.Customer convertCustomerDoToBo(this DO.Customer obj)
        {
            BO.Customer result = new BO.Customer()
            {
                Id = obj.Id,
                Address = obj.Address,
                Name = obj.Name,
                Phone = obj.Phone
            };
            return result;
        }

        public static DO.Customer convertCustomerBoToDo(this BO.Customer obj)
        {
            DO.Customer result = new DO.Customer()
            {
                Id = obj.Id,
                Address = obj.Address,
                Name = obj.Name,
                Phone = obj.Phone
            };
            return result;
        }
        public static BO.SaleInProduct convertSaleBoToSaleInProductBo(this DO.Sale obj)
        {
            BO.SaleInProduct result = new BO.SaleInProduct()
            {
                Amount=obj.MinQuantity,
                Price = obj.Price,
                DesignedForEveryone = obj.InClab 
            };
            return result;

        }
    }
}
