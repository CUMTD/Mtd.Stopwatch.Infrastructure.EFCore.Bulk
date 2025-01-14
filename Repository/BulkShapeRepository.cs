using Microsoft.EntityFrameworkCore;

using Mtd.Infrastructure.EFCore.Bulk.Repository;
using Mtd.Stopwatch.Core.Entities.Transit;
using Mtd.Stopwatch.Core.Repositories.Bulk.Transit;

namespace Mtd.Stopwatch.Infrastructure.EFCore.Bulk.Repository;

public class BulkShapeRepository(DbContext dbContext) : AsyncBulkEFIdentifiableRepository<string, Shape>(dbContext), IBulkShapeRepository<IReadOnlyCollection<Shape>>
{
	public Task<IReadOnlyCollection<Shape>> GetAllWithShapePointsAsync(CancellationToken cancellationToken) => throw new NotImplementedException();
	public Task<Shape> GetByIdentityWithShapePointsAsync(string shapeId, CancellationToken cancellationToken) => throw new NotImplementedException();
	public Task<Shape?> GetByIdentityWithShapePointsOrDefaultAsync(string shapeId, CancellationToken cancellationToken) => throw new NotImplementedException();
}
