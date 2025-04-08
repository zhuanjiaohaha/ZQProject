using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PersonInfoApp.Models;
using PersonInfoApp.DataBusiness;
using PersonInfoApp.Models;

namespace PersonInfoApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApplicantController : Controller
    {
        private readonly ApplicantRepository _applicantRepository;
        private readonly string _uploadBasePath = "";

        public ApplicantController(ApplicantRepository applicantRepository, IConfiguration configuration)
        {
            _applicantRepository = applicantRepository;
            //_uploadBasePath = configuration.GetValue<string>("UploadSettings:BasePath");
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> SubmitApplicant()
        {
            var form = await Request.ReadFormAsync();

            var phone = form["phone"];
            var name = form["name"];

            // 检查手机号是否已存在
            if (await _applicantRepository.IsPhoneExistsAsync(phone))
            {
                return BadRequest("该手机号已提交过申请，请不要重复提交。");
            }




            var applicant = new Applicant
            {
                Name = form["name"],
                StageName = form["stageName"],
                Age = int.Parse(form["age"]),
                Phone = phone,
                City = form["city"],
                Height = int.Parse(form["height"]),
                Weight = int.Parse(form["weight"]),
                Bust = int.Parse(form["bust"]),
                Waist = int.Parse(form["waist"]),
                Hips = int.Parse(form["hips"]),
                Occupation = form["occupation"],
                WorkYears = int.Parse(form["workYears"]),
                Talents = form["talents"],
                CanDrink = form["canDrink"] == "能"?1:0,
                Sex = form["sex"] == "女" ? 1 : 0
            };

            #region  照片和视频以二进制形式存数据库

            //处理照片
            var photosfiles = form.Files.GetFiles("photo");

            foreach (var photo in photosfiles)
            {
                using (var photoMemoryStream = new MemoryStream())
                {
                    await photo.CopyToAsync(photoMemoryStream);

                    applicant.Photos = photoMemoryStream.ToArray();
                }
            }


            //处理视频
            var videofiles = form.Files.GetFiles("video");

            foreach (var video in videofiles)
            {
                using (var videoMemoryStream = new MemoryStream())
                {
                    await video.CopyToAsync(videoMemoryStream);

                    applicant.Videos = videoMemoryStream.ToArray();
                }
            }

            #endregion

            // 插入申请人信息
            var applicantId = await _applicantRepository.InsertApplicantAsync(applicant);

            #region   以文件形式存储
            // 创建以姓名+手机号命名的文件夹
            //var uploadFolder = Path.Combine(_uploadBasePath, name+phone);
            //if (!Directory.Exists(uploadFolder))
            //{
            //    Directory.CreateDirectory(uploadFolder);
            //}
            //try
            //{
            //    // 保存照片
            //    var photoFiles = form.Files.GetFiles("photo");

            //    foreach (var photo in photoFiles)
            //    {
            //        var photoPath = Path.Combine(uploadFolder, photo.FileName);
            //        using (var stream = new FileStream(photoPath, FileMode.Create))
            //        {
            //            await photo.CopyToAsync(stream);
            //        }

            //    }


            //    // 保存视频
            //    var videoFiles = form.Files.GetFiles("video");
            //    foreach (var video in videoFiles)
            //    {
            //        var videoPath = Path.Combine(uploadFolder, video.FileName);
            //        using (var stream = new FileStream(videoPath, FileMode.Create))
            //        {
            //            await video.CopyToAsync(stream);
            //        }

            //    }

            //}
            //catch (Exception ex) 
            //{
            //    return StatusCode(500, $"文件保存出错：{ex.Message}");
            //}
            #endregion



            return Ok("申请提交成功！");
        }

        [HttpPost("verify")]
        public async Task<IActionResult> Verify([FromBody] VerifyRequest request)
        {
            var exists = await _applicantRepository.IsApplicantExistsAsync(request.Name, request.Phone);
            return Ok(new { exists });
        }


    }
}
