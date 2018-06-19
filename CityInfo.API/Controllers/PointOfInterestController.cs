using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [Route("api/cities")]
    public class PointOfInterestController : Controller
    {
        [HttpGet("{cityId}/pointsofinterest")]
        public IActionResult GetPointsOfInterest(int cityId)
        {
            var result = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result.PointOfInterest);
        }

        [HttpGet("{cityId}/pointsofinterest/{id}")]
        public IActionResult GetPointsOfInterest(int cityId, int id)
        {
            var result = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);

            if (result == null)
            {
                return NotFound();
            }

            var pointOfInterest = result.PointOfInterest.FirstOrDefault(p => p.Id == id);
            if (pointOfInterest == null)
            {
                return NotFound();
            }
            return Ok(pointOfInterest);
        }
    }
}