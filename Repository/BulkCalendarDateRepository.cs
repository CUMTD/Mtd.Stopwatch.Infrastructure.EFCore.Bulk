using Microsoft.EntityFrameworkCore;

using Mtd.Infrastructure.EFCore.Bulk.Repository;
using Mtd.Stopwatch.Core.Entities.Transit;
using Mtd.Stopwatch.Core.Repositories.Bulk.Transit;

namespace Mtd.Stopwatch.Infrastructure.EFCore.Bulk.Repository;

public class BulkCalendarDateRepository(DbContext dbContext) : AsyncBulkEFRepository<CalendarDate>(dbContext), IBulkCalendarDateRepository<IReadOnlyCollection<CalendarDate>>
{
	public Task<CalendarDate> GetByIdentityAsync(string serviceId, DateTime date, CancellationToken cancellationToken) => throw new NotImplementedException();
	public Task<CalendarDate?> GetByIdentityOrDefault(string serviceId, DateTime date, CancellationToken cancellationToken) => throw new NotImplementedException();
}
