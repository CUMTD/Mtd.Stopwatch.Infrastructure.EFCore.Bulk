using Microsoft.EntityFrameworkCore;

using Mtd.Infrastructure.EFCore.Bulk.Repository;
using Mtd.Stopwatch.Core.Entities.Transit;
using Mtd.Stopwatch.Core.Repositories.Bulk.Transit;

namespace Mtd.Stopwatch.Infrastructure.EFCore.Bulk.Repository;

public class BulkTripRepository(DbContext dbContext) : AsyncBulkEFIdentifiableRepository<string, Trip>(dbContext), IBulkTripRepository<IReadOnlyCollection<Trip>>
{
	public Task<IReadOnlyCollection<Trip>> GetAllWithRoutesAsync(CancellationToken cancellationToken) => throw new NotImplementedException();
}