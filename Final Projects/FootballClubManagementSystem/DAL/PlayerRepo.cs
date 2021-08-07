using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PlayerRepo
    {
        static FCMSEntities context;
        static PlayerRepo()
        {
            context = new FCMSEntities();
        }

        public static List <Player> GetAllPlayers()
        {
            var data = context.Players.ToList();
            return data;
        }

        public static void AddPlayer(Player data)
        {
            context.Players.Add(data);
            context.SaveChanges();
        }
        

        public static void PlayerEdit(Player obj)
        {
            var data = context.Players.FirstOrDefault(e => e.Id == obj.Id);
            context.Entry(data).CurrentValues.SetValues(obj);
            context.SaveChanges();
        }

        public static Player GetPlayer(int id)
        {
            var data = context.Players.FirstOrDefault(e => e.Id == id);
            return data;
        }

        public static void PlayerDelete(int id)
        {
            var player = context.Players.FirstOrDefault(e => e.Id == id);
            context.Players.Remove(player);
            context.SaveChanges();
        }

        public static List <Player> GetWingers()
        {
            var data = context.Players.Where(e => e.Position == "Winger").ToList();
            return data;
        }

        public static List<Player> SearchPlayer(string search_text)
        {
            var player = context.Players.ToList();
            player = context.Players.Where(e => e.Name.Contains(search_text) || e.Position.Contains(search_text) 
             ).ToList();
            return player;
        }
    }
}
