using Microsoft.AspNetCore.Identity;

namespace MovieTickets.Models
{
    public class ApplicationUser : IdentityUser
    {
        public List<Movie> UsersMovies { get; set; }
        public string? ImageUrl { get; set; }

        public string? Address { get; set; }
    }
}
