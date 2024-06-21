using Speridian.MMS.DAL;
using Speridian.MMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speridian.MMS.BusinessLayer
{
    public class ActorBL
    {
        public static List<Actor> GetActors()
        {
            var list = ActorDAL.GetActors();
            return list;
        }
        public static bool Add(Actor actor)
        {
            var isadded = ActorDAL.Add(actor);
            return isadded;
        }

        public static Actor GetByid(int id)
        {
            var emp = ActorDAL.GetByid(id);
            return emp;
        }

        public static bool Update(int id, Actor actor)
        {
            var isUpdated = ActorDAL.Update(id, actor);
            return isUpdated;
        }

        public static void Delete(int id)
        {
            ActorDAL.Delete(id);
        }
        public static Actor GetByTitle(string name)
        {
            return ActorDAL.GetByTitle(name);


            // return list.FirstOrDefault(movie => movie.Name.Equals(title, StringComparison.OrdinalIgnoreCase));
        }
    }
}
