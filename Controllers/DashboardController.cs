using management_candidates.DataContext;
using management_candidates.Dtos.Dashboard;
using management_candidates.Dtos.Error;
using management_candidates.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Serilog;
using System.Collections.Generic;
using System.Linq;

namespace management_candidates.Controllers
{
    [Route("api/dashboards")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly AppDataContext _context;
        private readonly ILogger<DashboardController> _logger;

        public DashboardController(AppDataContext context, ILogger<DashboardController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet("achievements")]
        public async Task<IActionResult> GetAchivement()
        {
            try
            {
                var result = await 
                    (from c in _context.Candidates
                    join s in _context.Applications on c.Id equals s.CandidateId
                    where s.UpdatedAt.Value.Year == DateTime.Now.Year && s.StatusCode == "HIRED"
                    group new {c, s} by new {c.Id} into st
                    select new AchievementDto
                    {
                        Total_hired = st.Count(),
                        Target = 300
                    }).FirstOrDefaultAsync();
                if (result == null)
                {
                    _logger.Log(LogLevel.Error, "Total hired = 0");
                    return NotFound(new ResponseErrorDto { Message = "Not Found" });
                }

                //var generatedSql = _context.GetService<ILoggerFactory>().CreateLogger("Microsoft.EntityFrameworkCore.Database.Command").ToString();
                //_logger.Log(LogLevel.Error, generatedSql);

                var response = new ResponseAchievementDto()
                    {
                        Data = result,
                    };
                    

                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex.Message);
                return StatusCode(500, new ResponseErrorDto { Message = "Internal server error"} );
            }
        }

        [HttpGet("clients")]
        public async Task<IActionResult> GetClient()
        {
            try
            {
                var subQuery = 
                    from st in _context.Applications
                    join ca in _context.Candidates on st.CandidateId equals ca.Id
                    join re in _context.Resources on st.ResourceCode equals re.Code
                    join op in _context.Opportunities on re.OpportunityCode equals op.Code
                    join cl2 in _context.Clients on op.ClientCode equals cl2.Code
                    where st.UpdatedAt.Value.Year == DateTime.Now.Year
                    select new { op.ClientCode, op.Id, st.UpdatedAt };

                var query = 
                    from cl in _context.Clients
                    join tp in subQuery on cl.Code equals tp.ClientCode into tpGroup
                    from tp in tpGroup.DefaultIfEmpty()
                    group new { cl, tp } by new { cl.Name, cl.Code } into g
                    orderby g.Count() descending
                    select new ClientTopFiveDto
                    {
                        Client_name = g.Key.Name,
                        Client_code = g.Key.Code,
                        Count = g.Count()
                    };

                var result = await query.Take(5).ToListAsync();

                if (result == null)
                {
                    _logger.Log(LogLevel.Error, "Clients still null in database");
                    return NotFound(new ResponseErrorDto { Message = "Not Found" });
                }

                //var generatedSql = _context.GetService<ILoggerFactory>().CreateLogger("Microsoft.EntityFrameworkCore.Database.Command").ToString();
                //_logger.Log(LogLevel.Error, generatedSql);

                var response = new ResponseClientDto()
                {
                    Data = result,
                };


                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex.Message);
                return StatusCode(500, new ResponseErrorDto { Message = "Internal server error" });
            }
        }

        [HttpGet("recruiters")]
        public async Task<IActionResult> GetRecruiter()
        {
            try
            {
                var subQuery =
                    from c in _context.Candidates
                    join s in _context.Applications on c.Id equals s.CandidateId
                    where s.UpdatedAt.Value.Year == DateTime.Now.Year
                    select new { CandidateId = c.Id, RecruiterId = c.RecruiterId };

                var query = from u in _context.Users
                            join newRecruiters in subQuery on u.Id equals newRecruiters.RecruiterId into joinedData
                            from newRecruiter in joinedData.DefaultIfEmpty()
                            group newRecruiter by new { u.Id, u.Name } into groupedData
                            orderby groupedData.Count() descending
                            select new RecruiterPipelineDto
                            {
                                Recruiter_id = groupedData.Key.Id,
                                Recruiter_name = groupedData.Key.Name,
                                Count = groupedData.Count(item => item.CandidateId != null)
                            };
                var result = await query.Take(8).ToListAsync();

                var response = new ResponseRecruiterDto
                {
                    Data = result
                };

                var generatedSql = _context.GetService<ILoggerFactory>().CreateLogger("Microsoft.EntityFrameworkCore.Database.Command").ToString();
                _logger.Log(LogLevel.Error, generatedSql);
                return Ok(response);
            } catch (Exception ex)
            {
                var message = ex.InnerException?.Message != null?ex.InnerException.Message:ex.Message;
                _logger.Log(LogLevel.Error, ex.Message);
                return StatusCode(500, new ResponseErrorDto { Message = "Internal server error" });
            }
        }
    }
}
