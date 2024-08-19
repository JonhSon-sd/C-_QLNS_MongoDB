using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class khachh
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("Mã khách")]
        public int makhach { get; set; }

        [BsonElement("Tên khách")]
        public string tenkhach { get; set; }

        [BsonElement("Số điện thoại")]
        public int sdt { get; set; }

        [BsonElement("Lượt mua")]
        public int luotmua { get; set; }
    }

