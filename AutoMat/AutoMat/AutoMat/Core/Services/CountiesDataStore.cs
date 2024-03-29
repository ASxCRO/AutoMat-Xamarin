﻿using AutoMat.Core.Models;
using AutoMat.Core.Services;
using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[assembly: Xamarin.Forms.Dependency(typeof(CountiesDataStore))]
namespace AutoMat.Core.Services
{
    public class CountiesDataStore : IDataStore<County>
    {
        private FirebaseClient firebase { get; } = FirebaseDatabaseClient.Instance;
        public CountiesDataStore()
        {
        }

        public Task<bool> AddItemAsync(County item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<County> GetItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<County>> GetItemsAsync(bool forceReload)
        {
            return (await firebase
                      .Child("counties")
                      .OnceAsync<County>()).Select(item => new County
                      {
                          Id = item.Object.Id,
                          Name = item.Object.Name,
                          EntityType = item.Object.EntityType
                      }).ToList();
        }

        public Task<Dictionary<string, County>> GetItemsKeyValueAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateItemAsync(County item)
        {
            throw new NotImplementedException();
        }
    }
    }
