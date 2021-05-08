﻿using System.Threading;
using System.Threading.Tasks;
using eBug.Domain.Entities;

namespace eBug.Application.Abstractions.Persistence
{
    public interface IProjectRepository : IAsyncRepository<Project>
    {
        Task<bool> IsProjectExists(int projectId, CancellationToken token);
        Task<bool> UniqueProjectName(string projectName, CancellationToken token);
    }
}