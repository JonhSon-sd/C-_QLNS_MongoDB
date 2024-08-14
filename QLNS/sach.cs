using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Sach
{
    [BsonId]
    public ObjectId Id { get; set; }

    [BsonElement("Mã sản phẩm")]
    public int Masanpham { get; set; }

    [BsonElement("Tên sản phẩm")]
    public string Tensanpham { get; set; }

    [BsonElement("Số lượng")]
    public int SoLuong { get; set; }

    [BsonElement("Giá bán")]
    public decimal GiaBan { get; set; }

    [BsonElement("Loại Hàng")]
    public string Loaisanpham { get; set; }
}