using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

public class Kiemke
{
    [BsonId]
    public ObjectId Id { get; set; }

    [BsonElement("MaSanPham")]
    public int MaSanPham { get; set; }

    [BsonElement("TenSanPham")]
    public string TenSanPham { get; set; }

    [BsonElement("GiaBan")]
    public decimal GiaBan { get; set; }

    [BsonElement("SoLuong")]
    public int SoLuong { get; set; }

    [BsonElement("GiamGia")]
    public decimal GiamGia { get; set; }

    [BsonElement("TongTien")]
    public decimal TongTien { get; set; }

    [BsonElement("NgayXuat")]
    [BsonDateTimeOptions(Kind = DateTimeKind.Local)]  // Lựa chọn nếu bạn muốn lưu thời gian theo múi giờ địa phương
    public DateTime NgayXuat { get; set; } = DateTime.Now;
}
