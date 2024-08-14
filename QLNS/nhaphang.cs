using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

public class Nhaphang
{
    [BsonId]
    public ObjectId Id { get; set; }

    [BsonElement("Masanpham")]
    public int Masanpham { get; set; }

    [BsonElement("Tensanpham")]
    public string Tensanpham { get; set; }

    [BsonElement("SoLuong")]
    public int SoLuong { get; set; }

    [BsonElement("GiaBan")]
    public decimal GiaBan { get; set; }

    [BsonElement("Loaisanpham")]
    public string Loaisanpham { get; set; }

    [BsonElement("NgayNhap")]
    [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
    public DateTime NgayNhap { get; set; }
}
