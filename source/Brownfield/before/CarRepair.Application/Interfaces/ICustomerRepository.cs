using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CarRepair.Core.Entities;

namespace CarRepair.Application.Interfaces
{
    public interface ICustomerRepository
    {
        Task<List<Customer>> GetAllCustomersAsync();

        ValueTask<Customer> GetCustomerByIdAsync(Guid id);

        Task<Customer> AddCustomerAsync(Customer customer);

        Task UpdateCustomerAsync(Customer customer);

        Task DeleteCustomerByIdAsync(Guid id);
    }
}