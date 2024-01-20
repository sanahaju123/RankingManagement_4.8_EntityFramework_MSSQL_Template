using RankingManagementApp.DAL.Interrfaces;
using RankingManagementApp.DAL.Services.Repository;
using RankingManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace RankingManagementApp.DAL.Services
{
    public class RankingService : IRankingService
    {
        private readonly IRankingRepository _repository;

        public RankingService(IRankingRepository repository)
        {
            _repository = repository;
        }

        public Task<Ranking> CreateRanking(Ranking expense)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<bool> DeleteRankingById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Ranking> GetAllRankings()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<Ranking> GetRankingById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<Ranking> UpdateRanking(Ranking model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}