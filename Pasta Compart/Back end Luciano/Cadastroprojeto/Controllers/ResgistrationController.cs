using FluentAssertions.Common;
using IndianoChato.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace IndianoChato.Controllers
{
    public class ResgistrationController : Controller
    {
    
        private readonly IConfiguration _configuration;

        public ResgistrationController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        [Route("registrtion")]

        public string registration(Registration registration)
        {
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("ToysCon").ToString());
            SqlCommand cmd = new SqlCommand("INSERT INTO Registration(Username,Password,Email,isActive) VALUES('"+registration.Username+ "','"+registration.Password+"','"+registration.Email+"','"+registration.IsActive+"' )", con);
            int i = cmd.ExecuteNonQuery();
            if (i > 0) 
            {
                return "Data inserted";
            }
            else
            {
                return "Error";
            }
            return "";
        }
            
    }
}
