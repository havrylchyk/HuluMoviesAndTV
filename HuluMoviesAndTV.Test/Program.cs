using HuluMoviesAndTV.Core.Context;
using HuluMoviesAndTV.Core.Entity;
using HuluMoviesAndTV.Repositories;

var repository = new Repository<MovieAndShow, Guid>(new MoviesAndShowsContext());

repository.Create(new MovieAndShow
{
    Title = "A new Title",
    Duration = "30minutes",
    Description = "some description",

});

Console.WriteLine($"Count: {repository.GetAll().Count()}");


foreach (var movieAndShow in repository.GetAll().OrderBy(x => x.Title))
{
    Console.WriteLine($"Game: {movieAndShow.Title}");
}
