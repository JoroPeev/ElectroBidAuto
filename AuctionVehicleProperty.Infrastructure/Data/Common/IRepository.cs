﻿namespace AuctionVehicleProperty.Infrastructure.Data.Common
{
    public interface IRepository
    {
        IQueryable<T> All<T>() where T : class;

        IQueryable<T> AllReadOnly<T>() where T : class;

        Task AddAsync<T>(T entity) where T : class;

        Task<int> SaveChangesAsync();

        Task<T?> GetByIdAsync<T>(object id) where T : class;

        Task DeleteEntity<T>(int id) where T : class;

        Task UpdateAsync<T>(T entity) where T : class;
        IQueryable<TEntity> Query<TEntity>() where TEntity : class;
    }
}
