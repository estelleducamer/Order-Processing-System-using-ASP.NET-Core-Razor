﻿using OrderProcessingSystem.Models;

namespace OrderProcessingSystem.Contracts
{
    /// <summary>
    ///     Interface for the OrderProcessing "Unit of Work"
    /// </summary>
    public interface IOrderProcessingUow
    {
        // Repositories 
        IRepository<Order> Orders { get; }

        // Save pending changes to the data store.
        void Commit();
    }
}