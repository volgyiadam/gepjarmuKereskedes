using gepjarmuKereskedes.Infrastructure;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using NHibernate.Linq;

namespace GepjarmuKereskedes.DA
{
    public class CarRepository : ICarRepository
    {



        public Car Get(int id)
        {

            using (ISession session = NHibernateSession.OpenSession())
            {
                return session.Get<Car>(id);

            }

        }

        public List<Car> GetAll()
        {
            using (ISession session = NHibernateSession.OpenSession())
            {
                return session.Query<Car>().ToList();

            }
            
        }

        public List<Car> GetByModel(string model)
        {
            using (ISession session = NHibernateSession.OpenSession())
            {

                return session.Query<Car>().Where(x => x.Brand == model).ToList();

            }
            

        }
    }
}
