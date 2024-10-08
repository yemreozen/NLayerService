﻿using Microsoft.EntityFrameworkCore;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
using NLayer.Service.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Services
{
    public class Service<T> : IServices<T> where T : class
    {
        private readonly IGenericRepository<T> _repository;
        private readonly IUnityOfWork _unityOfWork;

        public Service(IGenericRepository<T> repository, IUnityOfWork unityOfWork)
        {
            _repository = repository;
            _unityOfWork = unityOfWork;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _repository.AddAsync(entity);
            await _unityOfWork.CommitAsync();
            return entity;

        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
            return await _repository.AnyAsync(expression); 
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
          return await _repository.GetAll().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var hasProduct=await _repository.GetByIdAsync(id);
            if (hasProduct == null)
            {
                throw new ClientSideException($"{typeof(T).Name}({id}) not found");
            }
            return hasProduct;

		}
       
        public async Task RemoveAsync(T entity)
        {
             _repository.Remove(entity);
            await _unityOfWork.CommitAsync();

        }

        public async Task RemoveRangeAsync(IEnumerable<T> entites)
        {
             _repository.RemoveRange(entites);
            await _unityOfWork.CommitAsync();   
        }

        public async Task UpdateAsync(T entity)
        {
            _repository.Update(entity);
            await _unityOfWork.CommitAsync();

        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return _repository.Where(expression);
        }

        public async Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities)
        {
            await _repository.AddRangeAsync(entities);
            await _unityOfWork.CommitAsync();
            return entities;

        }

        
    }
}
