using System.Data.SqlClient;
using LoginRegistrationApp.Controllers.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoginRegistrationApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public RegistrationController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpPost]
        [Route("registration")]
        public string registration(Registration registration)
        {
            SqlConnection con= new SqlConnection(_configuration.GetConnectionString("GSAM").ToString());
            SqlCommand cmd = new SqlCommand("INSERT INTO SYS_USERS(PF_NO,USER_NAME,EMAIL_ID,PASSWORD,IS_ACTIVE) VALUES('" + registration.PF_NO + "','" + registration.USER_NAME + "','" + registration.EMAIL_ID + "','" + registration.PASSWORD + "','" + registration.IS_ACTIVE + "')", con);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
                {
                return "Data Inserted";
            }
            else 
            {
                return "Error";
            }
            
      }
    }
    
}
