using Mtd.Infrastructure.EFCore.Bulk.Repository;
using Mtd.Stopwatch.Core.Entities.Transit;
using Mtd.Stopwatch.Core.Repositories.Bulk.Transit;

namespace Mtd.Stopwatch.Infrastructure.EFCore.Bulk.Repository;

public class BulkStopRepository(StopwatchContext dbContext) : AsyncBulkEFIdentifiableRepository<string, Stop>(dbContext), IBulkStopRepository<Stop, IReadOnlyCollection<Stop>>
{
	public Task<IReadOnlyCollection<Stop>> GetAllActiveAsync(CancellationToken cancellationToken) => throw new NotImplementedException();
}
