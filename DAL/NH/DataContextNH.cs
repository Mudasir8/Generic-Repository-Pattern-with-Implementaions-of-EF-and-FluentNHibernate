using Models;
using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using DAL.NH.Mappings;
using NHibernate.Tool.hbm2ddl;

namespace DAL.NH
{
    public class DataContextNH
    {
        private static ISessionFactory session;

        // create database
        private static ISessionFactory CreateSession()
        {
            if (session != null)
            {
                return session;
            }

            FluentConfiguration _config = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(@"Server=.\SQLEXPRESS;Database=UniversityDB;Integrated Security=True;"))
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<StudentMapping>())
                    .ExposeConfiguration(c => new SchemaUpdate(c).Execute(false, true));

            session = _config.BuildSessionFactory();
            return session;
        }

        public static ISession SessionOpen()
        {
            return CreateSession().OpenSession();
        }

    }
}
