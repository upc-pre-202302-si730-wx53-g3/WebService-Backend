﻿using Data.Model;

namespace Data.Persistencia.Impl;

public interface ITouristData
{
    public Task<Tourist> GetById(int id);
    public Task<List<Tourist>> GetFilteredData(Tourist tourist);
    public Task<List<Tourist>> GetAll();
    public Task<bool> GetByPhone(string phone);
    public Task<bool> Create(Tourist tourist);
    public Task<bool> Update(Tourist tourist, int id);
    public Task<bool> Delete(int id);
}