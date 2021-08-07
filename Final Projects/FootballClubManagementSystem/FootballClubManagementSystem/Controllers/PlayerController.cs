using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FootballClubManagementSystem.Controllers
{
    
    public class PlayerController : ApiController
    {
        [Route("api/Player/Add")]
        [HttpPost]
        public void AddPlayer(AddPlayerModel model)
        {
            PlayerService.AddPlayer(model);
        }

        [Route("api/Players/All")]
        [HttpGet]
        public List<PlayerModel> GetAllPlayers() {

                return PlayerService.GetAllPlayers();
        }
        [Route("api/Player/{id}")]
        [HttpGet]
        public PlayerModel GetPlayer(int id)
        {
            return PlayerService.GetPlayer(id);
        }

        [Route("api/PlayerEdit/{id}")]
        [HttpPost]
        public void PlayerEdit(EditPlayerModel obj)
        {
            PlayerService.PlayerEdit(obj);
        }

        [Route("api/Delete/{id}")]
        [HttpGet]
        public void PlayerDelete(int id) {

            PlayerService.PlayerDelete(id);
        }
        [Route("api/Player/Wingers")]
        [HttpGet]
        public List<PlayerModel> GetWinger() {

            return PlayerService.GetWinger();
        }
        [Route("api/player/search")]
        [HttpPost]
        public void SearchPlayer(string search_text) {

            PlayerService.SearchPlayer(search_text);
        }

    }
}
