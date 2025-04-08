using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using PersonInfoApp.DataBusiness;
using System.Data;
using System.Threading.Tasks;
using System.Diagnostics;


namespace PersonInfoApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApplicantViewController : Controller
    {
        private readonly ApplicantRepository _applicantRepository;
        public ApplicantViewController(ApplicantRepository applicantRepository, IConfiguration configuration) 
        {
            _applicantRepository = applicantRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetApplicants()
        {
            var result=_applicantRepository.GetAllApplicantsAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetApplicantDetails(int id)
        {


            var applicant = _applicantRepository.GetApplicantByIdAsync(id);
            if (applicant == null)
            {
                return NotFound();
            }
            var photos = ((byte[])applicant.Result.Photos).Select(photo => System.Convert.ToBase64String(applicant.Result.Photos)).ToList();
            var videos = ((byte[])applicant.Result.Videos).Select(video => System.Convert.ToBase64String(applicant.Result.Videos)).ToList();

            var result = new
            {
                id = id,
                name = applicant.Result.Name,
                age = applicant.Result.Age,
                phone = applicant.Result.Phone,
                talents = applicant.Result.Talents,
                photos = photos,
                videos = videos
            };

            return Ok(result);

        }
    }
}
