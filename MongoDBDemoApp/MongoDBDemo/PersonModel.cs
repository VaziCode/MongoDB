using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;



namespace MongoDBDemo
{
    public class PersonModel
    {
        [BsonId] // Telling Mongo that this is his ID -> Behind the scene it gonna be stored as _id field. so this is goign to be its unique identify field.
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AddressModel PrimaryAddress { get; set; }
        [BsonElement("dob")] //Decorator -> restored in our DB as "dob" instead of DateOfBirth
        public DateTime DateOfBirth { get; set; }
    }
}