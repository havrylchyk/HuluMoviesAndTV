using HuluMoviesAndTV.Core.Context;
using HuluMoviesAndTV.Core.Entity;
using HuluMoviesAndTV.Repositories;

var repository = new Repository<MovieAndShow, Guid>(new MoviesAndShowsContext());

repository.Create(new MovieAndShow
{
    Title = "A new Title",
    Duration = "30minutes",
    Description = "some description",
    TypeId = Guid.Parse("7873F208-05FA-46F3-9F9A-0010F9CE1985"),
    YearId = Guid.Parse("DC77DE1B-E2A8-47FD-B710-0019DFE6E13B"),
    DirectorId = Guid.Parse("F3F77B94-0796-454B-9726-27B6A15B8612"),
    RatingId = Guid.Parse("86B6356E-B6BE-4E2F-9C00-026E866115E2"),
}) ;

//Console.WriteLine($"Count: {repository.GetAll().Count()}");



foreach (var movieAndShow in repository.GetAll().OrderBy(x => x.Title))
{
    Console.WriteLine($"MovieAndShow: {movieAndShow.Title}");
}
