using RankingManagement.Models;
using RankingManagementApp.DAL.Interrfaces;
using RankingManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace RankingManagementApp.Controllers
{
    public class RankingController : ApiController
    {
        private readonly IRankingService _service;
        public RankingController(IRankingService service)
        {
            _service = service;
        }
        public RankingController()
        {
            // Constructor logic, if needed
        }
        [HttpPost]
        [Route("api/Ranking/CreateRanking")]
        [AllowAnonymous]
        public async Task<IHttpActionResult> CreateRanking([FromBody] Ranking model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpPut]
        [Route("api/Ranking/UpdateRanking")]
        public async Task<IHttpActionResult> UpdateRanking([FromBody] Ranking model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpDelete]
        [Route("api/Ranking/DeleteRanking")]
        public async Task<IHttpActionResult> DeleteRanking(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("api/Ranking/GetRankingById")]
        public async Task<IHttpActionResult> GetRankingById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("api/Ranking/GetAllRankings")]
        public async Task<IEnumerable<Ranking>> GetAllRankings()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
