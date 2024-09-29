using IPService.Entities;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Mapping.ByCode;
using NHibernate.Tool.hbm2ddl;
using System.Data.Entity;
using System.Data.SQLite;
using System.Reflection;

namespace IPService.Helpers;

public class DatabaseHelper
{
    public static ISessionFactory SessionFactory;

    private const string ConnectionString = "Data Source=AppData.sqlite;Version=3;";

    public static void Initialize()
    {
        var config = new Configuration();
        config.DataBaseIntegration(db =>
        {
            db.Dialect<NHibernate.Dialect.MsSql2012Dialect>();
            db.Driver<NHibernate.Driver.SQLite20Driver>();

            db.ConnectionString = ConnectionString;
            db.KeywordsAutoImport = Hbm2DDLKeyWords.AutoQuote;
            db.SchemaAction = SchemaAutoAction.Update;
        });

        var mapper = new ModelMapper();
        mapper.AddMappings(Assembly.GetExecutingAssembly().GetExportedTypes());
        
        config.AddMapping(mapper.CompileMappingForAllExplicitlyAddedEntities());
        
        SessionFactory = config.BuildSessionFactory();
        
        // Create database schema if it does not exist
        using var connection = new SQLiteConnection(ConnectionString);
        connection.Open();
        var command = connection.CreateCommand();
        command.CommandText =
            @"CREATE TABLE IF NOT EXISTS Users (Id INTEGER PRIMARY KEY AUTOINCREMENT, Username NVARCHAR(200), Password NVARCHAR(200));"
            + "CREATE TABLE IF NOT EXISTS BlockedIps (Id INTEGER PRIMARY KEY AUTOINCREMENT, IpAddress NVARCHAR(200));"
            + "CREATE TABLE IF NOT EXISTS BlockedRegions (Id INTEGER PRIMARY KEY AUTOINCREMENT, Region NVARCHAR(200));";
        command.ExecuteNonQuery();
        connection.Close();
        
        using var session = SessionFactory.OpenSession();
        var rowCount = session.QueryOver<User>().RowCount();
        if (rowCount == 0)
        {
            var user = new User
            {
                UserName = "demo",
                Password = "demo123"
            };
            session.Save(user);
            session.Flush();
        }
    }
}