using CRUDOperationDemo.API.Services;
using CRUDOperationDemo.API.Services.Base;
using CRUDOperationDemo.API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDOperationDemo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController( IStudentService studentService)
        {
            _studentService = studentService;
        }
        [HttpGet("GetAllStudent")]
        public async Task<IActionResult> GetAllStudent()
        {
            try
            {
                var response = await _studentService.GetAllStudent();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpGet("GetStudentById/{Id}")]
        public async Task<IActionResult> GetStudentById(int Id)
        {
            try
            {
                var response = await _studentService.GetStudentById(data=>data.Id==Id);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


        [HttpPost("AddStudent")]
        public async Task< IActionResult> AddStudent([FromBody] AddStudentDTO studentDTO)
        {
            try
            {
                var response=await  _studentService.AddStudent(studentDTO);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);  
            }
        }
        [HttpPut("UpdateStudent")]
        public async Task<IActionResult> UpdateStudent([FromBody] UpdateStudentDTO studentDTO)
        {
            try
            {
                if(studentDTO.Id>0)
                {
                    var response = await _studentService.UpdateStudent(studentDTO);
                    return Ok(response);
                }
                else
                {
                    return BadRequest("Please Provide  Correct Student ID");
                }
                
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteStudent")]
        public async Task<IActionResult> DeleteStudent([FromBody] DeleteStudentDTO studentDTO)
        {
            try
            {
                if (studentDTO.Id > 0)
                {
                    var response = await _studentService.DeleteStudent(studentDTO);
                    return Ok(response);
                }
                else
                {
                    return BadRequest("Please Provide  Correct Student ID");
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

       

    }
}
