using Mtd.Infrastructure.EFCore.Bulk.Repository;
using Mtd.Stopwatch.Core.Entities.Transit;
using Mtd.Stopwatch.Core.Repositories.Bulk.Transit;

namespace Mtd.Stopwatch.Infrastructure.EFCore.Bulk.Repository;

public class BulkParentStopRepository(StopwatchContext dbContext) : AsyncBulkEFIdentifiableRepository<string, ParentStop>(dbContext), IBulkParentStopRepository<IReadOnlyCollection<ParentStop>>
{
	public Task<IReadOnlyCollection<ParentStop>> GetAllActiveAsync(CancellationToken cancellationToken) => throw new NotImplementedException();
	public Task<IReadOnlyCollection<ParentStop>> GetAllWithChildStopsAsync(CancellationToken cancellationToken) => throw new NotImplementedException();
	public Task<ParentStop?> GetByIdentityOrDefaultWithChildStopsAsync(string id, CancellationToken cancellationToken) => throw new NotImplementedException();
	public Task<ParentStop> GetByIdentityWithChildStopsAsync(string id, CancellationToken cancellationToken) => throw new NotImplementedException();
	public Task<IReadOnlyCollection<ParentStop>> GetWithoutIStopsAsync(CancellationToken cancellationToken) => throw new NotImplementedException();
}
