using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Linq;
using gepjarmuKereskedes.Infrastructure;
using NHibernate;

namespace GepjarmuKereskedes.DA
{
    class SiteRepository
    {
        public Site Get(int id)
        {

            using (ISession session = NHibernateSession.OpenSession())
            {
                return session.Get<Site>(id);

            }

        }

        public List<Site> GetAll()
        {
            using (ISession session = NHibernateSession.OpenSession())
            {
                return session.Query<Site>().ToList();

            }

        }

        public List<Site> GetByAddress(string address)
        {
            using (ISession session = NHibernateSession.OpenSession())
            {

                return session.Query<Site>().Where(x => x.Address == address).ToList();

            }


        }



    }
}
