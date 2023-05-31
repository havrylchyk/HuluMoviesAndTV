using HuluMoviesAndTV.Core.Entity;
using System;

namespace HuluMoviesAndTV.WinApp
{
    public partial class Form1 : Form
    {
        private void LoadMovieAndShow()
        {
            var movieAndShows = movieAndShowRepository.GetAll().Select(ms => new
            {
                ms.Id,
                ms.Title,
                ms.Duration,
                ms.Description,
                TypeId = ms.Type.Id,
                TypeName = ms.Type.Name,
                YearId = ms.Year.Id,
                YearValue = ms.Year.Year,
                DirectorId = ms.Director?.Id,
                DirectorName = ms.Director?.Name,
                RatingId = ms.Rating?.Id,
                RatingValue = ms.Rating?.Name,
                Countries = string.Join(", ", ms.Country.Select(c => c.Name)),
                Listened = string.Join(", ", ms.Listened.Select(c => c.Name)),
            }).ToList();

            MovieAndShowdataGridView.DataSource = movieAndShows;
            MovieAndShowdataGridView.Columns["TypeId"].Visible = false;
            MovieAndShowdataGridView.Columns["YearId"].Visible = false;
            MovieAndShowdataGridView.Columns["DirectorId"].Visible = false;
            MovieAndShowdataGridView.Columns["RatingId"].Visible = false;
            MovieAndShowdataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }

        private void LoadProgramTypesForComboBox()
        {
            var programTypes = programTypeRepository.GetAll().ToList();

            ProgramTypecomboBox.Items.Clear();

            foreach (var programType in programTypes)
            {
                ProgramTypecomboBox.Items.Add(programType.Name);
            }
        }

        private void LoadDirectorComboBox()
        {
            var directors = directorRepository.GetAll().ToList();

            DirectorcomboBox.Items.Clear();

            foreach (var director in directors)
            {
                DirectorcomboBox.Items.Add(director.Name);
            }
        }

        private void LoadRatingComboBox()
        {
            var ratings = ratingRepository.GetAll().ToList();

            RatingcomboBox.Items.Clear();

            foreach (var rating in ratings)
            {
                RatingcomboBox.Items.Add(rating.Name);
            }
        }

        private void LoadReleaseYearComboBox()
        {
            var releaseYears = releaseYearRepository.GetAll().ToList();

            ReleaseYearcomboBox.Items.Clear();

            foreach (var releaseYear in releaseYears)
            {
                ReleaseYearcomboBox.Items.Add(releaseYear.Year);
            }
        }

        private void LoadCountryComboBox()
        {
            var countries = countryRepository.GetAll().ToList();

            CountryComboBox.Items.Clear();

            foreach (var country in countries)
            {
                CountryComboBox.Items.Add(country.Name);
            }
        }

        private void LoadListenedComboBox()
        {
            var listenedItems = listenedRepository.GetAll().ToList();

            ListenedComboBox.Items.Clear();

            foreach (var item in listenedItems)
            {
                ListenedComboBox.Items.Add(item.Name);
            }
        }
      
        private void AddMovieAndSwhow(MovieAndShow movieAndShow)
        {
            movieAndShowRepository.Create(movieAndShow);
            movieAndShowRepository.Save();
            LoadMovieAndShow();
        }
        private void AddMainbutton_Click_1(object sender, EventArgs e)
        {
            MovieAndShow movieAndShow = new MovieAndShow
            {

                Title = TitletextBox.Text,
                Duration = DurationtextBox.Text,
                Description = DescriptiontextBox.Text,
            };



            AddMovieAndSwhow(movieAndShow);
            LoadMovieAndShow();
        }


        private void UpdateMainButton_Click(object sender, EventArgs e)
        {
        }




        private void DeleteMain(Guid movieAndShowId)
        {
            var movieAndShow = movieAndShowRepository.Get(movieAndShowId);
            if (movieAndShow != null)
            {
                movieAndShowRepository.Delete(movieAndShow);
                LoadMovieAndShow();
            }
        }

        private void DeleteMainButton_Click(object sender, EventArgs e)
        {
            if (MovieAndShowdataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = MovieAndShowdataGridView.SelectedRows[0];
                Guid movieAndShowId = (Guid)row.Cells["Id"].Value;
                DeleteMain(movieAndShowId);
            }
        }
    }

}
