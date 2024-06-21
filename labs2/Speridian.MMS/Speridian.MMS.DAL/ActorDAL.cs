using Speridian.MMS.Entities;
using Speridian.MMS.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speridian.MMS.DAL
{
    public class ActorDAL
    {
        static List<Actor> list = new List<Actor>
        {
            new Actor
            {   Id=1,
                Name="ketaki",
                DateOfBirth=new DateOnly(2000,1,1),
          
                Gender=Gender.Female,
               
            },

            new Actor
            {   Id=2,
                Name="ketan",
                DateOfBirth=new DateOnly(2001,11,1),
              
                Gender=Gender.Male,
               
            }
        };
        static int counter = 2;
        public static List<Actor> GetActors()
        {
            return list;
        }
        public static bool Add(Actor actor)
        {
            bool isExists = list.Exists(e => e.Name == actor.Name && e.DateOfBirth == actor.DateOfBirth);
            if (isExists)
            {
                throw new EMSException("Actor already Exists");
            }
            actor.Id = ++counter;
            list.Add(actor);
            return true;
        }
        public static Actor GetByid(int id)
        {
            var act = list.Find(d => d.Id == id);
            return act;

        }
        public static bool Update(int id, Actor actor)
        {
            var id1 = list.First(e => e.Id == id);
            id1.Name = actor.Name;
            id1.DateOfBirth = actor.DateOfBirth;
            id1.Gender = actor.Gender;
           
            return true;
        }
        public static void Delete(int id)
        {
            bool isExists = list.Exists(e => e.Id == id);
            if (isExists)
            {
                list.RemoveAll(e => e.Id == id);
                Console.WriteLine("Deleted successfully");
            }
            else
            {
                Console.WriteLine("error");
            }
            /// employee.Id = ++counter;

            //return true;
        }
        public static Actor GetByTitle(string name)
        {
            Actor mov = list.Find(d => d.Name == name);
            return mov;

        }
    }
}
