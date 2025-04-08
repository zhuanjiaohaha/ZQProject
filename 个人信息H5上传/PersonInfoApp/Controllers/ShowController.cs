using Microsoft.AspNetCore.Mvc;
using PersonInfoApp.DataBusiness;
using System.Data;


namespace PersonInfoApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShowController : Controller
    {
        private readonly ApplicantRepository _applicantRepository;
        public ShowController(ApplicantRepository applicantRepository)
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
            var result = await _applicantRepository.GetAllApplicantsAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetApplicantDetails(int id)
        {


            var applicant =await _applicantRepository.GetApplicantByIdAsync(id);
            if (applicant == null)
            {
                return NotFound();
            }
            var photos = ((byte[])applicant.Photos).Select(photo => System.Convert.ToBase64String(applicant.Photos)).ToList();
            var videos = ((byte[])applicant.Videos).Select(video => System.Convert.ToBase64String(applicant.Videos)).ToList();

            var result = new
            {
                id = id,
                name = applicant.Name,
                age = applicant.Age,
                phone = applicant.Phone,
                talents = applicant.Talents,
                photos = photos,
                videos = videos
            };

            return Ok(result);

        }
    }
}
