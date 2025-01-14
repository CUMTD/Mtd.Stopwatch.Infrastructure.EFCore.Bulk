using Microsoft.EntityFrameworkCore;

using Mtd.Infrastructure.EFCore.Bulk.Repository;
using Mtd.Stopwatch.Core.Entities.Transit;
using Mtd.Stopwatch.Core.Repositories.Bulk.Transit;

namespace Mtd.Stopwatch.Infrastructure.EFCore.Bulk.Repository;

public class BulkChildStopRepository(DbContext dbContext) : AsyncBulkEFIdentifiableRepository<string, ChildStop>(dbContext), IBulkChildStopRepository<IReadOnlyCollection<ChildStop>>
{
	public Task<IReadOnlyCollection<ChildStop>> GetAllActiveAsync(CancellationToken cancellationToken) => throw new NotImplementedException();
	public Task<IReadOnlyCollection<ChildStop>> GetAllWithParentAsync(CancellationToken cancellationToken) => throw new NotImplementedException();
}
