using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using UniveraStoreCase.DataAccess.Data;
using UniveraStoreCase.DataAccess.Repositories.GenericRepositories;
using UniveraStoreCase.DataAccess.Repositories.IRepositories;
using UniveraStoreCase.Entities.Entities;

namespace UniveraStoreCase.DataAccess.Repositories.EfCoreRepositories
{
    public class EfUserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly UniveraDbContext _dbContext;
        private readonly IMapper _mapper;

        public EfUserRepository(UniveraDbContext dbContext,IMapper mapper):base(dbContext)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
    }
}
