using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace movie_tracker_wf2
{
/**
Author: Mitchell Aninyang
*/
    public partial class _default : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">Page</param>
        /// <param name="e">Event Data</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            titleTextBox.Focus();
            outputLiteral.Text = "";

            if (!IsPostBack)
            {
                List<Movie> movies = new List<Movie>();
                Session["movies"] = movies;
            } // (!IsPostBack)
        }

        /// <summary>
        /// Retreive the existing movies from the session variable
        /// Instantiate a new movie and add it to the list of movies
        /// Reset TextBoxes
        /// </summary>
        /// <param name="sender">addButton</param>
        /// <param name="e">EventData</param>
        protected void addButton_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                List<Movie> movies = (List<Movie>)Session["movies"];
                DateTime date;
                int rating;

                DateTime.TryParse(dateTextBox.Text, out date);
                int.TryParse(ratingTextBox.Text, out rating);
                if (date.Date <= DateTime.Today)
                {
                    movies.Add(new Movie
                    {
                        Title = titleTextBox.Text,
                        DateSeen = date,
                        Genre = genreDropDownList.SelectedValue,
                        Rating = rating
                    });

                    titleTextBox.Text = "";
                    dateTextBox.Text = "";
                    genreDropDownList.SelectedIndex = 0;
                    ratingTextBox.Text = "";
                } //(date.Date <= DateTime.Today)
                else
                {
                    outputLiteral.Text += "<p style=\"color:red;\">Date cannot be in the future</p>";
                    RequiredFieldValidator2.Text = "<p style=\"color:red;\">Date cannot be in the future</p>";
                    dateTextBox.Focus();
                }

            } //(IsValid)

        } //addButton_Click

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_PreRender(object sender, EventArgs e)
        {
            List<Movie> movies = (List<Movie>)Session["movies"];

            if(movies.Count > 0)
            {
                outputLiteral.Text += @"<table class=""striped"">
                                            <tr>
                                                <th>Title</th>
                                                <th>Date</th>
                                                <th>Genre</th>
                                                <th>Rating</th>
                                            </tr>";
                foreach (var  movie in movies)
                {
                    outputLiteral.Text += $@"<tr>
                                            <td>{movie.Title}</td>
                                            <td>{movie.DateSeen.ToShortDateString()}</td>
                                            <td>{movie.Genre}</td>
                                            <td style=""text-align: center;"">{movie.Rating}</td>
                                        </tr>";
                }
                outputLiteral.Text += "</table>";

            } //(movies.Count > 0)
        }
    }
}
