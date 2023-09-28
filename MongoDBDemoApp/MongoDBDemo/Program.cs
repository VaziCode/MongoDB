using System.Collections.Generic;
using System.Linq;



namespace MongoDBDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            MongoCRUD db = new MongoCRUD("AddressBook");
            //PersonModel person = new PersonModel
            //{
            //    FirstName = "Sapir",
            //    LastName = "Pashali",
            //    PrimaryAddress = new AddressModel
            //    {
            //        State = "Israel",
            //        City = "Ashdod",
            //        StreetAdress = "Tel-Hai 67 strret",
            //        ZiplCode = "12345"
            //    }
            //};
            //var recs = db.LoadRecords<PersonModel>("Users");
            //foreach (var rec in recs)
            //{
            //    Console.WriteLine($"{rec.Id}: {rec.FirstName}  {rec.LastName}");
            //    if (rec.PrimaryAddress != null)
            //    {
            //        Console.WriteLine(rec.PrimaryAddress.City);

            //    }
            //    Console.WriteLine();

            //}
            var recs = db.LoadRecords<NameModel>("Users");
            foreach (var rec in recs)
            {
                Console.WriteLine($"{rec.FirstName}  {rec.LastName}");
                
                Console.WriteLine();

            }

            //var oneRec = db.LoadRecordById<PersonModel>("Users", new Guid("5223bb8b-4280-433c-b10a-9d3510ade40d"));
            //oneRec.DateOfBirth = new DateTime(1994, 3, 7,0,0,0,DateTimeKind.Utc);
            //db.UpsertRecord("Users",oneRec.Id, oneRec);
            //db.DeleteRecord<PersonModel>("Users", oneRec.Id);
            //db.InsertRecord("Users", new PersonModel { FirstName = "Gal", LastName = "Cohen" });
            //db.InsertRecord("Users", person);

            //Take the object and store it as a BSON(Like JSON for Mongo) as a record to our table.
            Console.ReadLine();
        }
    }
}