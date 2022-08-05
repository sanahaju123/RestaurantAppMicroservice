using Customer.DataLayer.Data;
using Customer.Entities.Models;
using Customer.BusinessLayer.Services.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customer.BusinessLayer.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<IEnumerable<Customers>> FindAllAsync()
        {
            return await _customerRepository.FindAllAsync();
        }

        public async Task<Customers> FindOneAsync(int id)
        {
            return await _customerRepository.FindOneAsync(id);
        }

        public async Task<Customers> InsertAsync(Customers customer)
        {
            return await _customerRepository.InsertAsync(customer);
        }

        public async Task<Customers> UpdateAsync(Customers customer)
        {
            return await _customerRepository.UpdateAsync(customer);
        }
    }
}

