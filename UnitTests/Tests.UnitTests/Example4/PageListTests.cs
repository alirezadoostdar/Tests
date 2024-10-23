using FluentAssertions;
using Tests.Src.UnitTests.Example4;

namespace Tests.UnitTests.Example4;

public class PageListTests
{
    [Fact]
    public async void Constractor_ShouldInitilizeProperties()
    {
        //arrange
        var items = new List<string> { "item1", "item2", "items3" };
        var expecteditems = new List<string> { "item1", "item2" };

        var pagedList = await PagedList<string>.Paginate(items.AsQueryable(),1,2,CancellationToken.None);

        //assert
        pagedList.TotalItems.Should().Be(3);
        pagedList.Items.Should().HaveCount(2);
        pagedList.PageNumber.Should().Be(1);
        pagedList.PageSize.Should().Be(2);
        pagedList.HasNextPage.Should().BeTrue();
        pagedList.HasPreviousPage.Should().BeFalse();

        pagedList.Items.Should().BeEquivalentTo(expecteditems);
    }
}
