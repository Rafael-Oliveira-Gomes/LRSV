using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebTest.Model;
using Microsoft.AspNetCore.Identity;
using System.Globalization;

namespace WebTest.Pages
{
    public class PagamentoModel : PageModel
    {
        private readonly AuthDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public PagamentoModel(AuthDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public decimal Salario { get; set; }
        public string Nome { get;set; }

        public void OnGet()
        {
            var user = _userManager.GetUserAsync(User).Result;
            Nome = user.Nome;
            Salario = user.Salario;
        }
    }
}
