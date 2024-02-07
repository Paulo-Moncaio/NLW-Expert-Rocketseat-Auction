using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using RocketseatAuction.API.Comminucation.Requests;

namespace RocketseatAuction.API.Controllers;
[Route("[controller]")]
[ApiController]
public class OfferController : RocketseatAuctionBaseController
{
    [HttpPost]
    [Route("{itemId}")]
    public IActionResult CreateOffer([FromRoute]int itemId, [FromBody] RequestCreateOfferJson request)
    {
        return Created();
    }
    //[ProducesResponseType(StatusCodes.Status201Created)]
    //[ProducesResponseType(StatusCodes.Status400BadRequest)]
    //public IActionResult CreateOffer([FromBody] Offer offer)
    //{
    //    var repository = new RocketseatAuctionDbContext();

    //    var auction = repository.Auctions.Include(auction => auction.Items).FirstOrDefault(auction => auction.Id == offer.AuctionId);

    //    if (auction == null)
    //    {
    //        return BadRequest("Auction not found");
    //    }

    //    var item = auction.Items.FirstOrDefault(item => item.Id == offer.ItemId);

    //    if (item == null)
    //    {
    //        return BadRequest("Item not found");
    //    }

    //    if (offer.Value < item.BasePrice)
    //    {
    //        return BadRequest("Offer value is lower than the base price");
    //    }

    //    repository.Offers.Add(offer);
    //    repository.SaveChanges();

    //    return CreatedAtAction(nameof(GetOffer), new { id = offer.Id }, offer);
    //}

    //[HttpGet("{id}")]
    //[ProducesResponseType(typeof(Offer), StatusCodes.Status200OK)]
    //[ProducesResponseType(StatusCodes.Status404NotFound)]
    //public IActionResult GetOffer(int id)
    //{
    //    var repository = new RocketseatAuctionDbContext();

    //    var offer = repository.Offers.FirstOrDefault(offer => offer.Id == id);

    //    if (offer == null)
    //    {
    //        return NotFound();
    //    }

    //    return Ok(offer);
    //}
}
