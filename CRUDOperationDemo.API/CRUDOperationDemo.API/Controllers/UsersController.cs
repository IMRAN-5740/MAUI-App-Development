using Azure;
using CRUDOperationDemo.API.Models;
using CRUDOperationDemo.API.ViewModels.UsersViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CRUDOperationDemo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserManager<Users> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UsersController( UserManager<Users> userManager,RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }




        [HttpPost("RegisterUser")]
        public async Task<IActionResult> RegisterUser(RegisterUserDTO registerUserDTO)
        {
            var userTobeCreated = new Users
            {
                Email = registerUserDTO.Email,
                PhoneNumber = registerUserDTO.PhoneNo,
                FirstName = registerUserDTO.FirstName,
                LastName = registerUserDTO.LastName,
                Gender= registerUserDTO.Gender,
                Address=registerUserDTO.Address,
                UserName=registerUserDTO.Email,
                
                
            };
            var response= await _userManager.CreateAsync(userTobeCreated,registerUserDTO.Password);
            if(response.Succeeded)
            {
                return Ok("User Created");
            }
            else
            {
                return BadRequest(response.Errors );
            }
        }


        [HttpPost("DeleteUser")]
        public async Task<IActionResult> DeleteUser(DeleteUserDTO registerUserDTO)
        {
            var existingUser=await _userManager.FindByEmailAsync(registerUserDTO.Email);
            if(existingUser!=null)
            {
                var response = await _userManager.DeleteAsync(existingUser);
                if (response.Succeeded)
                {
                    return Ok("User Deleted");
                }
                else
                {
                    return BadRequest(response.Errors);
                }
            }
            else
            {
                return BadRequest("No User Found with this email");
            }

        }

        [HttpPost("RegisterRole")]
        public async Task<IActionResult> RegisterRole(CreateRoleDTO createRoleDTO)
        {
            var userRoleCreated = new IdentityRole
            {
                Name = createRoleDTO.RoleName
            };
            var response = await _roleManager.CreateAsync(userRoleCreated);
            if (response.Succeeded)
            {
                return Ok("Role Created");
            }
            else
            {
                return BadRequest(response.Errors);
            }
        }

        [HttpPost("AssignRoleToUser")]
        public async Task<IActionResult> AssignRoleToUser(AssignRoleToUserDTO assignRoleToUserDTO)
        {
            var userDetails = await _userManager.FindByEmailAsync(assignRoleToUserDTO.Email);
            if (userDetails != null)
            {

                var userAssigntoRoleResponse = await _userManager.AddToRoleAsync(userDetails, assignRoleToUserDTO.RoleName);
                if (userAssigntoRoleResponse.Succeeded)
                {
                    return Ok("Role Assiged to the particular User");

                }
                else
                {
                    return BadRequest(userAssigntoRoleResponse.Errors);
                }
            }
            else
            {
                return BadRequest("There is no User Found with this email");
            }

        }

    }
}
