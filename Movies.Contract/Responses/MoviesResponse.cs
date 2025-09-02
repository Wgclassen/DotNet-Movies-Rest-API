namespace Movies.Contract.Responses;

internal class MoviesResponse
{
    public required IEnumerable<MoviesResponse> Items { get; init; } = Enumerable.Empty<MoviesResponse>();
}
