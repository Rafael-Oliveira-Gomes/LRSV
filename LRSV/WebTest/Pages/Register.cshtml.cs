using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebTest.ViewModels;

namespace WebTest.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        [BindProperty]
        public Register Model { get; set; }
        public class Register
        {
            [Required]
            [Display(Name = "Email Address")]
            [EmailAddress]
            public string Email { get; set; }
            [Display(Name = "Nome do Usuário")] // Adicione uma propriedade para o nome do usuário
            public string UserName { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Compare("Password", ErrorMessage = "As senhas não conferem.")]
            [DataType(DataType.Password)]
            [Display(Name = "Confirme sua Senha")]
            public string ConfirmPassword { get; set; }
        }

        public RegisterModel(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public void OnGet()
        {
        }

        public async Task<ActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser()
                {

                    UserName = Model.Email,
                    Email = Model.Email
                };

                var result = await userManager.CreateAsync(user, Model.Password);
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, false);
                    return RedirectToPage("Index");
                }

                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return Page();
        } 
    }
}
