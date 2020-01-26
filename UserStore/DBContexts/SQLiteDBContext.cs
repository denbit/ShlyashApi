namespace ShlyahApi.UserStore.DBContexts
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public class SQLiteDBContext : DbContext
    {
        public SQLiteDBContext()
            : base("name=UsersDataStore")
        {
            System.Diagnostics.Debug.Write("testetse");
            this.users.ToString();
        }

#pragma warning disable IDE1006 // Naming Styles
        public DbSet<UserStore.Entity.User> users { get; set; }
#pragma warning restore IDE1006 // Naming Styles

     //   protected override void OnModelCreating(DbModelBuilder modelBuilder) => modelBuilder.Conventions.Add<PluralizingTableNameConvention>();
    }
}
