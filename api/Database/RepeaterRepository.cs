using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UtahRepeaters.Api.Database;
using UtahRepeaters.Api.Database.Models;

namespace UtahRepeaters.Api.Database {
    public class RepeaterRepository : IRepeaterRepository {
        private readonly RepeaterContext context;
        public RepeaterRepository (RepeaterContext context) {
            this.context = context;

        }
        public IQueryable<Repeater> GetAllAsync () {
            return this.context.Repeaters.AsQueryable();
        }

        public async Task<Repeater> GetAsync (int id) {
            return await this.context.Repeaters.FindAsync(id);
        }

        public async Task AddAsync (Repeater repeater) {
            await this.context.Repeaters.AddAsync(repeater);
        }
    }

    public interface IRepeaterRepository
    {
        IQueryable<Repeater> GetAllAsync ();
        Task<Repeater> GetAsync (int id);

        Task AddAsync (Repeater repeater);
    }
}