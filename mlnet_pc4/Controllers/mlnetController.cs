using Microsoft.AspNetCore.Mvc;

using mlnet_pc4;




namespace mlnet_pc4.Controllers

{

	public class mlnetController : Controller

	{

		public IActionResult Index()

		{

			return View();

		}




		[HttpPost]

		public IActionResult mlnet(string text)

		{

            //Load sample data

            var sampleData = new SentimentModel.ModelInput()

            {

                Col0 = text

            };







            //Load model and predict output

            var result = SentimentModel.Predict(sampleData);

			Console.WriteLine(result.PredictedLabel);

            return View("Index", result);

		}




	}

}