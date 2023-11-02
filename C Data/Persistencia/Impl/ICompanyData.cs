﻿using Data.Model;

namespace Data.Persistencia.Impl;

public interface ICompanyData
{
    public Task<Company> GetById(int id);
    public Task<List<Company>> GetByName(Company company);
    public Task<List<Company>> GetAll();
    public Task<List<Company>> GetByRuc(Company company);
    public Task<bool> Create(Company company);
    public Task<bool> Update(Company company, int id);
    public Task<bool> Delete(int id);
}