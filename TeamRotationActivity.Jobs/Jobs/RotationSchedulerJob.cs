﻿using TeamRotationActivity.Domain.Interfaces.Jobs;

namespace TeamRotationActivity.Jobs.Jobs;

/// <summary>
/// Планировщик ротации участников команды.
/// </summary>
public class RotationSchedulerJob : IJob<RotationSchedulerJob>
{
    public Task ExecuteAsync(string jobId, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }
}
