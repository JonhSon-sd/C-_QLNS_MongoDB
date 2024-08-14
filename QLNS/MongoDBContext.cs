using MongoDB.Bson;
using MongoDB.Driver;

public class MongoDBContext
{
    private readonly IMongoDatabase _database;
    
    public MongoDBContext()
    {
        var client = new MongoClient("mongodb://localhost:27017");
        _database = client.GetDatabase("QLNS");
        
    }

    public IMongoCollection<Sach> Saches => _database.GetCollection<Sach>("QLSach");
    public IMongoCollection<Hoadon> Hoadons => _database.GetCollection<Hoadon>("Hoadon");
    public IMongoCollection<Kiemke> Kiemkes => _database.GetCollection<Kiemke>("Kiemke");
    public IMongoCollection<Nhaphang> Nhaphangs => _database.GetCollection<Nhaphang>("Nhaphang");
}