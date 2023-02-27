using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniveraStoreCase.DataAccess.Data;
using UniveraStoreCase.DataAccess.Repositories.GenericRepositories;
using UniveraStoreCase.DataAccess.Repositories.IRepositories;
using UniveraStoreCase.Entities.DTOs.ResponseDtos;
using UniveraStoreCase.Entities.Entities;

namespace UniveraStoreCase.DataAccess.Repositories.EfCoreRepositories
{
    public class EfProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly UniveraDbContext _context;

        private IMapper _mapper;

        public EfProductRepository(UniveraDbContext context, IMapper mapper) : base(context)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
