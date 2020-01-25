using System.Web.Mvc;
using System.Diagnostics;
using System;
using ShlyahApi.Client.Models;
using ShlyahApi.Client.Models.Types;
using System.Data.SQLite;
using DBFile = System.IO.File;
using System.Text;
using System.Configuration;

namespace ShlyahApi.Client.Controllers 
{
    public class IndexController : Controller
    {
        public string HealthCheck()
        {
            System.Diagnostics.Debug.WriteLine( String.Join(" ",ConfigurationManager .AppSettings.AllKeys));
            return  "Mobile and desktop API is online";
        }
        [HttpGet]
        public ActionResult Index()
        {


            TokenData tokenData = new TokenData
            {
                Id = 0,
                    client = new MobileClient { Name = "Android", Type = ClientType.Mobile },
                    Key = "63nummnbynin"
                };

            ViewBag.Title = "Registarion";
            using (var DB = new AccessLogs())
            {
                //DB.TokenDatas.Add(tokenData);
             //   DB.SaveChanges();
            }

            return View("Index", tokenData);
        }


        public ActionResult Contact()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            var db = ConfigurationManager.ConnectionStrings["SQLITE"] ;
            string fullDB = db.ConnectionString.Replace(@"~\", path);
            Debug.WriteLine(fullDB);
            return Content("some info"); 
        }
        public string Statistics()
        {
            StringBuilder answer = new StringBuilder();
            string db = ConfigurationManager.AppSettings.Get("connectionString");
            string path = AppDomain.CurrentDomain.BaseDirectory;
            if (!DBFile.Exists(path+@"\AccessDB.sqlite"))
            {
                SQLiteConnection.CreateFile(@"C:\Users\Lenovo\source\repos\ShlyahApi.Client\Content\AccessDB.sqlite");
                answer.Append("DB file created"); 
            }
                answer.Append( "DB init started");

             SQLiteConnection c=  new SQLiteConnection(@"Data Source=C:\Users\Lenovo\source\repos\ShlyahApi.Client\Content\AccessDB.sqlite;version=3;");
            c.Open();
            SQLiteCommand command = new SQLiteCommand();
            command.Connection = c;
            command.CommandText = @"CREATE TABLE [workers] (
                    [id] integer PRIMARY KEY AUTOINCREMENT NOT NULL,
                    [name] char(100) NOT NULL,
                    [family] char(100) NOT NULL,
                    [age] int NOT NULL,
                    [profession] char(100) NOT NULL
                    );";
            
            command.CommandType = System.Data.CommandType.Text;
            command.ExecuteNonQuery();
            return answer.ToString();
        }
    }
}