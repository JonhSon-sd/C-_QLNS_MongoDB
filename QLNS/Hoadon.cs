using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
public class Hoadon
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
}