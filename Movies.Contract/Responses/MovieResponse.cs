namespace Movies.Contract.Responses;

internal class MovieResponse
{
    public required Guid Id { get; init; }
    public required string Title { get; init; }
    public required int YearOfRelease { get; init; }
    public required IEnumerable<string> Genres { get; init; } = Enumerable.Empty<string>();
}
