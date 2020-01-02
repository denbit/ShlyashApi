namespace ShlyashApi.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class AccessLogs : DbContext
    {
        // Your context has been configured to use a 'AccessLogs' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ShlyashApi.Models.AccessLogs' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'AccessLogs' 
        // connection string in the application configuration file.
        public AccessLogs()
            : base("name=AccessLogs")
        {
        }

        public virtual DbSet<TokenData> TokenDatas { set; get; }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}