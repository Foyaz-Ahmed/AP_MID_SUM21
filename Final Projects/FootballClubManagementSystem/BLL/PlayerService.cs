using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PlayerService
    {
        public static List<PlayerModel> GetAllPlayers()
        {
           var info = PlayerRepo.GetAllPlayers();
           var data = AutoMapper.Mapper.Map<List<Player>, List<PlayerModel>>(info);
           return data;
        }

        public static void AddPlayer(AddPlayerModel model)
        {
            var data = AutoMapper.Mapper.Map<AddPlayerModel, Player>(model);
            PlayerRepo.AddPlayer(data);

        }
        public static PlayerModel GetPlayer(int id) {

            var data = PlayerRepo.GetPlayer(id);
            var p = AutoMapper.Mapper.Map<Player, PlayerModel>(data);
            return p;

        }

        public static void PlayerEdit(EditPlayerModel obj)
        {
            
          var data = AutoMapper.Mapper.Map<EditPlayerModel, Player>(obj);
          PlayerRepo.PlayerEdit(data);
        }

        public static void PlayerDelete(int id)
        {
            PlayerRepo.PlayerDelete(id);
        }

        public static List<PlayerModel> GetWinger()
        {
            var info = PlayerRepo.GetWingers();
            var data = AutoMapper.Mapper.Map<List<Player>, List<PlayerModel>>(info);
            return data;
        }

        public static void SearchPlayer(string search_text)
        {
            var info = PlayerRepo.SearchPlayer(search_text);
            var data = AutoMapper.Mapper.Map<List<Player>, List<PlayerModel>>(info);
            
        }
    }
}
