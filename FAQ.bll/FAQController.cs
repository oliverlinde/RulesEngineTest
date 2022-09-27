using System;
using FAQ.models;

namespace FAQ.bll
{



	public class FAQController : IFAQController
	{
		public models.FAQ Faq { get; set; }
		public FAQController()
		{
			List<QuestionAnswer> list = new List<QuestionAnswer>();
			Faq = new models.FAQ(list);
		}

		public List<QuestionAnswer> GetFAQ()
		{
			return Faq.listOfQuestionAnswers;
		}

		public void PopulateFAQ(List<QuestionAnswer> listOfQuestionAnswers)
		{
			Faq.listOfQuestionAnswers = listOfQuestionAnswers;
		}

	}
}