using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GepjarmuKereskedes.DA
{
    public static class NHibernateSession
    {
        static ISessionFactory sessionFactory;

        public static void BuildSession()
        {
            var configuration = new Configuration();
            //var configurationPath = HttpContext.Current.Server.MapPath(@"~\Models\hibernate.cfg.xml");
            //configuration.Configure(configurationPath);
            //var carConfigurationFile = HttpContext.Current.Server.MapPath(@"~\Models\Car.hbm.xml");
            //configuration.AddFile(carConfigurationFile);
            //var siteConfigurationFile = HttpContext.Current.Server.MapPath(@"~\Models\Site.hbm.xml");
            //configuration.AddFile(siteConfigurationFile);

            sessionFactory = configuration.BuildSessionFactory();
        }

        public static ISession OpenSession()
        {
            
            return sessionFactory.OpenSession();
        }

        
    }
}