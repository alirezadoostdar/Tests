namespace Tests.Src.UnitTests.Example4;
public class PagedList<T>
{
    public int TotalItems { get; }
    public int PageNumber { get; }
    public int PageSize { get; }
    public IReadOnlyCollection<T> Items { get; }

    private PagedList(int totalItems, int pageNumber, int pageSize, IReadOnlyCollection<T> items)
    {
        TotalItems = totalItems;
        PageNumber = pageNumber;
        PageSize = pageSize;
        Items = items;
    }

    public static async Task<PagedList<T>> Paginate(IQueryable<T> sourece,int pageNumber, int pageSize,CancellationToken cancellationToken = default)
    {
        var totalItems = sourece.Count();
        var items = sourece.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
        return new PagedList<T>(totalItems,pageNumber,pageSize,items);
    }
    public int TotalPgaes => (int)Math.Ceiling(TotalItems / (double)PageSize);
    public bool HasPreviousPage => PageNumber > 1;
    public bool HasNextPage => PageNumber < TotalPgaes;
    public int NextPageNumber => HasNextPage ? PageNumber + 1 : TotalPgaes;
    public int PreviousPageNumber => HasPreviousPage ? PageNumber - 1 : 1;
}
