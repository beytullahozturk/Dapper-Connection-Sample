using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Dapper_Connection_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Server=DESKTOP-IK51R9P\\SQLEXPRESS;Database=CoreBlogDb;User Id=ozbeytullah;Password=123456;";
                connection.Open();

                Console.WriteLine($"Connection State : {connection.State}");
                Console.WriteLine($"ConnectionString : {connection.ConnectionString}");

                // isimsiz tip ekleme
                //connection.Execute("insert into Writers(WriterName, WriterAbout, WriterEmail, WriterStatus)" +
                //    "values(@WriterName, @WriterAbout, @WriterEmail, @WriterStatus)",
                //    new[] { new { WriterName = "Emre", WriterAbout = "Ahmet", WriterEmail = "test@test1.com" , WriterStatus=true } });

                //// data model ekleme
                //connection.Execute("insert into Writers(WriterName, WriterAbout, WriterEmail, WriterStatus)" +
                //    "values(@WriterName, @WriterAbout, @WriterEmail, @WriterStatus)",
                //    new Writers() { WriterName = "İbrahim", WriterAbout = "Öz", WriterEmail = "test@test5.com", WriterStatus = true });

                // isimsiz tip listeleme
                //var result = connection.Query("SELECT * FROM Writers");
                //if (result.ToList().Count > 0)
                //{
                //    foreach (var item in result.ToList())
                //    {
                //        Console.WriteLine($"{item.WriterId}: {item.WriterName} - {item.WriterEmail} - {item.WriterAbout}");
                //    }
                //}

                //data model listeleme
                //List<Writers> students = connection.Query<Writers>("SELECT * FROM Writers").ToList();
                //if (students.Count > 0)
                //{
                //    foreach (var item in students)
                //    {
                //        Console.WriteLine($"{item.WriterId}: {item.WriterName} - {item.WriterEmail} - {item.WriterAbout}");
                //    }
                //}

                connection.Close();
            }
        }
        public class Writers
        {
            public int WriterId { get; set; }
            public String WriterName { get; set; }
            public String WriterAbout { get; set; }
            public String WriterImage { get; set; }
            public String WriterEmail { get; set; }
            public String WriterPassword { get; set; }
            public bool WriterStatus { get; set; }

        }
    }
}
