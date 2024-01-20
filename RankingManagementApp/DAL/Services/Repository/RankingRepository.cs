using RankingManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace RankingManagementApp.DAL.Services.Repository
{
    public class RankingRepository : IRankingRepository
    {
        private readonly DatabaseContext _dbContext;
        public RankingRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<Ranking> CreateRanking(Ranking expense)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteRankingById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Ranking> GetAllRankings()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<Ranking> GetRankingById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

      
        

        public async Task<Ranking> UpdateRanking(Ranking model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}