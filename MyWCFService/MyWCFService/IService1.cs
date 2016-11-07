using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MyWCFService
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        IEnumerable<Product> GetProducts();
        [OperationContract]
        void CreateProduct(Product _product);
        [OperationContract]
        void EditProduct(Product _product);
        [OperationContract]
        void DeleteProduct(int id);

    }


    [DataContract]
    public class Product
   {
        [DataMember]
        [Key]
        [Required]
        public int ProductId { get; set; }

        [DataMember]
        [Required]
        public string Name { get; set; }

        [DataMember]
        [Required]
        public int Price { get; set; }

        [DataMember]
        [Required]
        public string Description { get; set; }
    }
    
}
