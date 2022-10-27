//Manuel L.
//10-26-22
//Odd or Even 
//The user will input a number and the code will tell you if it is odd or even
//Peer Review: Mark A Ramirez it certianly works intresting haveing there input be a int rather than a string into an int 




using Microsoft.AspNetCore.Mvc;

namespace LeyvaMOddorEvenEndPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class OddorEvenController : ControllerBase
{
    [HttpGet]
    [Route("MiniCh6/{rNum1}")]
    public string Math(int rNum1)
    {
        int convertNum1 = Convert.ToInt32(rNum1);
        string result = "";
        if (rNum1 % 2 == 0)
        {
            result = $"{rNum1} is an Even Number";
        }
        else
        {
             result = $"{rNum1} is an Odd Number";
        }
        return result;
    }
}
