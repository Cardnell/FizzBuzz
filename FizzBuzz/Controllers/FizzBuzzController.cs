using System.Web.Http;

namespace FizzBuzz.Controllers
{
    public class FizzBuzzController : ApiController
    {
        private const string MULTIPLES_OF_THREE = "Fizz";
        private const string MULTIPLES_OF_FIVE = "Buzz";
        
        public string Get(int input)
        {
            string output = string.Empty;

            if (input % 3 == 0)
                output += MULTIPLES_OF_THREE;
            if (input % 5 == 0)
                output += MULTIPLES_OF_FIVE;

            return output.Length == 0 ? input.ToString() : output;
        }
    }
}