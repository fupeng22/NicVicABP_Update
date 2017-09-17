﻿using NicVicABP.EntityFramework;
using EntityFramework.DynamicFilters;

namespace NicVicABP.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly NicVicABPDbContext _context;

        public InitialHostDbBuilder(NicVicABPDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
