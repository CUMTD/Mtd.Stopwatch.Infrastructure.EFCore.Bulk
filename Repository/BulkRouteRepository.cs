using Microsoft.EntityFrameworkCore;

using Mtd.Infrastructure.EFCore.Bulk.Repository;
using Mtd.Stopwatch.Core.Entities.Transit;
using Mtd.Stopwatch.Core.Repositories.Bulk.Transit;

namespace Mtd.Stopwatch.Infrastructure.EFCore.Bulk.Repository;

public class BulkRouteRepository(DbContext dbContext) : AsyncBulkEFIdentifiableRepository<string, Route>(dbContext), IBulkRouteRepository<IReadOnlyCollection<Route>>
{
	public Task<IReadOnlyCollection<Route>> GetAllWithDirectionAsync(CancellationToken cancellationToken) => throw new NotImplementedException();
}
