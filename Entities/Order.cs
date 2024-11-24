﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project09_MongoDbOrder.Entities
{
    public class Order
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string  OrderId { get; set; }
        public string  CustomerName { get; set; }
        public string  District { get; set; }
        public string  City { get; set; }
        public decimal  TotalPrice { get; set; }
    }
}