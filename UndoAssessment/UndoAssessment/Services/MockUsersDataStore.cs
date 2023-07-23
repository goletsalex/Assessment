using System;
using System.Collections.Generic;
using UndoAssessment.Models;

namespace UndoAssessment.Services
{
    internal class MockUsersDataStore : DataStore<User>, IDataStore<User>
    {
        readonly List<User> users;

        public MockUsersDataStore()
        {
            users = new List<User>()
            {
                new User { Id = Guid.NewGuid().ToString(), Name = "First user", Age = 20 },
                new User { Id = Guid.NewGuid().ToString(), Name = "Second user", Age = 25 },
                new User { Id = Guid.NewGuid().ToString(), Name = "Third user", Age = 30 },
                new User { Id = Guid.NewGuid().ToString(), Name = "Fourth user", Age = 35 },
            };
        }
    }
}
