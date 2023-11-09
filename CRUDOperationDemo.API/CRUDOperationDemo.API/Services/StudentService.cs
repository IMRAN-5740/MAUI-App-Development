using CRUDOperationDemo.API.Data;
using CRUDOperationDemo.API.Models;
using CRUDOperationDemo.API.Responces;
using CRUDOperationDemo.API.Services.Base;
using CRUDOperationDemo.API.ViewModels.StudentViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace CRUDOperationDemo.API.Services
{
    public class StudentService : IStudentService
    {
        private readonly ApplicationDbContext _dbContext;
        public StudentService(ApplicationDbContext dbContext)
        {
                _dbContext= dbContext;
        }
        public async Task<MainResponse> AddStudent(AddStudentDTO entity)
            
        {
            var response= new MainResponse();
            try
            {
                if(_dbContext.Students.Any(data=>data.Email.ToLower()==entity.Email.ToLower())) 
                {
                    response.IsSuccess = false;
                    response.ErrorMessage = "Student is already exists with this email";
                }
                else
                {
                    var stdResponse = _dbContext.Add(new Student
                    {
                        FirstName = entity.FirstName,
                        LastName = entity.LastName,
                        Email = entity.Email,
                        PhonNo = entity.PhonNo,
                        Address = entity.Address
                    });
                  
                    await _dbContext.SaveChangesAsync();
                    response.IsSuccess = true;
                    response.Content = "Student Added Successfully";
                }
              
            }
            catch (Exception ex) 
            {
                response.IsSuccess = false;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }

        public async Task<MainResponse> DeleteStudent(DeleteStudentDTO entity)
        {
            var response = new MainResponse();
            try
            {
                var existingEntity = _dbContext.Students.Where(data => data.Id == entity.Id).FirstOrDefault();
                if (existingEntity != null)
                {
                    _dbContext.Students.Remove(existingEntity);
                    await _dbContext.SaveChangesAsync();

                    response.IsSuccess = true;
                    response.Content = "Student Deteled Successfully";
                }
                else
                {
                    response.IsSuccess = false;
                    response.Content = "Student not found with this corresponding Student ID";
                }

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }

        public async Task<MainResponse> GetAllStudent(Expression<Func<Student, bool>>? predicate =null)
        {
            var response = new MainResponse();
            try
            {
                if (predicate != null)
                {
                    response.Content = await _dbContext.Students.Where(predicate).ToListAsync();
                    
                    response.IsSuccess = true;
                }
                else if (predicate==null)
                {
                    response.Content = await _dbContext.Students.ToListAsync();
                    response.IsSuccess = true;
                }
                else
                {
                    response.IsSuccess = false;
                    response.Content = "No Student Available Now";
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.ErrorMessage= ex.Message;
            }

            return   response;
        }

        public async Task<MainResponse> GetStudentById(Expression<Func<Student, bool>>? predicate =null)
        {
            var response = new MainResponse();
            try
            {
                if (predicate != null)
                {
                    response.Content = await _dbContext.Students.Where(predicate).FirstOrDefaultAsync(predicate);
                    response.IsSuccess = true;
                }
                else if (predicate == null)
                {
                    response.Content = await _dbContext.Students.FirstOrDefaultAsync();
                    response.IsSuccess = true;
                }
                else
                {
                    response.IsSuccess = false;
                    response.Content = "No Student Available Now";
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.ErrorMessage = ex.Message;
            }

            return response;
        }

        public async Task<MainResponse> UpdateStudent(UpdateStudentDTO entity)
        {
            var response = new MainResponse();
            try
            {
                var existingEntity=_dbContext.Students.Where(data=>data.Id == entity.Id).FirstOrDefault();
                if(existingEntity != null)
                {
                    existingEntity.FirstName= entity.FirstName;
                    existingEntity.LastName= entity.LastName;
                    existingEntity.PhonNo= entity.PhonNo;
                    existingEntity.Address= entity.Address;

                    await _dbContext.SaveChangesAsync();
                    response.IsSuccess = true;
                    response.Content = "Student Info Updated Successfully";
                }
                else
                {
                    response.IsSuccess = false;
                    response.Content = "Student not found with this corresponding Student ID";
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess =false;
                response.Content = ex.Message;  
            }

            return response;
        }
    }
}
