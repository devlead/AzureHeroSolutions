﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SmartHotel.Registration.Wcf.Models
{
    [DataContract]
    public class Registration
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public string CustomerId { get; set; }
        [DataMember]
        public string CustomerName { get; set; }
        [DataMember]
        public string Passport { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public int Amount { get; set; }
        [DataMember]
        public int Total { get; set; }
        [DataMember]
        public string Culture { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }
    }
}