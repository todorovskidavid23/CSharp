using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.WebRequestMethods;

namespace Generics.Domain.Models
{
    public class Order : BaseEntity
    {
        public string Reciever { get; set; }
        public string Address { get; set; }
        public override string GetInfo()
        {
            return $"{Id}) {Reciever} - {Address}";
        }
    }
}
