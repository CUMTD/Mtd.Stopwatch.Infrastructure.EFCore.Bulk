using Mtd.Infrastructure.EFCore.Bulk.Repository;
using Mtd.Stopwatch.Core.Entities.Transit;
using Mtd.Stopwatch.Core.Repositories.Bulk.Transit;

namespace Mtd.Stopwatch.Infrastructure.EFCore.Bulk.Repository;

public class BulkStopTimeRepository(StopwatchContext dbContext) : AsyncBulkEFRepository<StopTime>(dbContext), IBulkStopTimeRepository<IReadOnlyCollection<StopTime>>
{
	public Task<StopTime> GetByIdentityAsync(string tripId, short stopSequence, CancellationToken cancellationToken) => throw new NotImplementedException();
	public Task<StopTime?> GetByIdentityOrDefaultAsync(string tripId, short stopSequence, CancellationToken cancellationToken) => throw new NotImplementedException();
}
