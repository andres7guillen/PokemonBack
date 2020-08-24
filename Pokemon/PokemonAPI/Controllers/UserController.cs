using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PokemonAPI.Models;
using PokemonData.Context;
using PokemonDomain.Entities.Security;

namespace PokemonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        public UserController(UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        [HttpPost("UserRol")]
        public async Task<IActionResult> AsignarRolUsuario(EditRolModel model)
        {
            var usuario = await _userManager.FindByIdAsync(model.UserId);
            if (usuario == null) { return NotFound(); }
            await _userManager.AddClaimAsync(usuario, new Claim(ClaimTypes.Role, model.RolName));
            await _userManager.AddToRoleAsync(usuario, model.RolName);
            string Mensaje = $"Rol = {model.RolName} was assigned to {usuario.UserName} ";
            return Ok(Mensaje);
        }

        [HttpPost("RemoveUserRol")]
        public async Task<IActionResult> RemoverRolUsuario(EditRolModel model)
        {
            var usuario = await _userManager.FindByIdAsync(model.UserId);
            if (usuario == null) { return NotFound(); }
            await _userManager.RemoveClaimAsync(usuario, new Claim(ClaimTypes.Role, model.RolName));
            await _userManager.RemoveFromRoleAsync(usuario, model.RolName);
            string Mensaje = $"Rol = {model.RolName} was removed with {usuario.UserName} ";
            return Ok(Mensaje);
        }


    }
}