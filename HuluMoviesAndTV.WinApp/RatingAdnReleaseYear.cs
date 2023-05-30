using HuluMoviesAndTV.Core.Entity;

namespace HuluMoviesAndTV.WinApp
{
    public partial class Form1 : Form
    {

        //Заповнення даних//
        private void LoadRating()
        {
            var rating = ratingRepository.GetAll();
            RatingdataGridView.DataSource = rating;
            RatingdataGridView.Columns["MovieAndShows"].Visible = false;
            RatingdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void LoadReleaseYear()
        {
            var releaseYear = releaseYearRepository.GetAll();
            ReleaseYeardataGridView.DataSource = releaseYear;
            ReleaseYeardataGridView.Columns["MovieAndShows"].Visible = false;
            ReleaseYeardataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void AddRating(Rating rating)
        {
            ratingRepository.Create(rating);
            ratingRepository.Save();
            LoadRating();
        }
        private void AddRatingbutton_Click(object sender, EventArgs e)
        {
            Rating rating = new Rating
            {
                Name = RatingtextBox.Text
            };

            AddRating(rating);
        }

        private void DeleteRating(Guid ratingId)
        {
            Rating rating = ratingRepository.Get(ratingId);
            if (rating != null)
            {
                ratingRepository.Delete(rating);
                ratingRepository.Save();
                LoadRating();
            }
        }
        private void DeleteRatingbutton_Click(object sender, EventArgs e)
        {
            if (RatingdataGridView.SelectedRows.Count > 0)
            {
                Guid ratingId = (Guid)RatingdataGridView.SelectedRows[0].Cells["Id"].Value;
                DeleteRating(ratingId);
            }
        }

        private void UpdateRating(Guid raingId, string newName)
        {
            Rating rating = ratingRepository.Get(raingId);
            if (rating != null)
            {
                rating.Name = newName;
                ratingRepository.Update(rating);
                ratingRepository.Save();
                LoadRating();
            }
        }
        private void UpdataRatingbutton_Click(object sender, EventArgs e)
        {
            if (RatingdataGridView.SelectedRows.Count > 0)
            {
                Guid ratingId = (Guid)RatingdataGridView.SelectedRows[0].Cells["Id"].Value;
                string newName = RatingtextBox.Text;

                UpdateRating(ratingId, newName);
            }
        }
        ///////////////
        private void AddReleaseYear(ReleaseYear rating)
        {
            releaseYearRepository.Create(rating);
            releaseYearRepository.Save();
            LoadReleaseYear();
        }
        private void AddReleaseYearbutton_Click(object sender, EventArgs e)
        {
            ReleaseYear releaseYear = new ReleaseYear
            {
                Year = int.Parse(ReleaseYeartextBox.Text)
            };

            AddReleaseYear(releaseYear);
        }
        ///////////////
        private void DeleteReleaseYear(Guid programTypeId)
        {
            ReleaseYear releaseYear = releaseYearRepository.Get(programTypeId);
            if (releaseYear != null)
            {
                releaseYearRepository.Delete(releaseYear);
                releaseYearRepository.Save();
                LoadReleaseYear();
            }
        }
        private void DeleteReleaseYearbutton_Click(object sender, EventArgs e)
        {
            if (ReleaseYeardataGridView.SelectedRows.Count > 0)
            {
                Guid programTypeId = (Guid)ReleaseYeardataGridView.SelectedRows[0].Cells["Id"].Value;
                DeleteReleaseYear(programTypeId);
            }
        }

        private void UpdateReleaseYear(Guid programTypeId, int newYear)
        {
            ReleaseYear releaseYear = releaseYearRepository.Get(programTypeId);
            if (releaseYear != null)
            {
                releaseYear.Year = newYear;
                releaseYearRepository.Update(releaseYear);
                releaseYearRepository.Save();
                LoadReleaseYear();
            }
        }
        private void UpdataReleaseYearbutton_Click(object sender, EventArgs e)
        {
            if (ReleaseYeardataGridView.SelectedRows.Count > 0)
            {
                Guid yearId = (Guid)ReleaseYeardataGridView.SelectedRows[0].Cells["Id"].Value;
                int newYear = int.Parse(ReleaseYeartextBox.Text);

                UpdateReleaseYear(yearId, newYear);
            }
        }
    }
}
