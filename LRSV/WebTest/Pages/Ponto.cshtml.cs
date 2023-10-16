using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System;
using WebTest.Interface;
using WebTest.Model;

namespace WebTest.Pages
{
    public class PontoModel : PageModel
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IPontoService pontoService;

        public PontoModel(UserManager<ApplicationUser> userManager, IPontoService pontoService)
        {
            this.userManager = userManager;
            this.pontoService = pontoService;
        }

        public void OnGet()
        {
        }

        [HttpPost]
        public async Task<IActionResult> OnPost()
        {
            // Verifique se o usuário está autenticado
            var user = await userManager.GetUserAsync(User);
            if (user == null)
            {
                return RedirectToPage("/Login"); // Redirecione para a página de login se o usuário não estiver autenticado
            }

            try
            {
                // Chame o serviço de bater ponto
                var userId = userManager.GetUserId(User);
                await pontoService.AdicionarPonto(userId);
                TempData["Message"] = "Ponto registrado com sucesso!";
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Erro ao bater o ponto: " + ex.Message;
            }

            return Page();
        }
    }
}
