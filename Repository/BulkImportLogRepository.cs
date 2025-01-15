using Mtd.Infrastructure.EFCore.Bulk.Repository;
using Mtd.Stopwatch.Core.Entities.Transit;
using Mtd.Stopwatch.Core.Repositories.Bulk.Transit;

namespace Mtd.Stopwatch.Infrastructure.EFCore.Bulk.Repository;

public class BulkImportLogRepository(StopwatchContext dbContext) : AsyncBulkEFIdentifiableRepository<string, ImportLog>(dbContext), IBulkImportLogRepository<IReadOnlyCollection<ImportLog>>
{
	public Task<IReadOnlyCollection<ImportLog>> GetLastNLogsAsync(int n, CancellationToken cancellationToken) => throw new NotImplementedException();
	public Task<ImportLog> GetMostRecentSuccessAsync(CancellationToken cancellationToken) => throw new NotImplementedException();
}
