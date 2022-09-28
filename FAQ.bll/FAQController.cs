using System;
using FAQ.models;
using FAQ.dal;

namespace FAQ.bll
{
    public class FAQController : IFAQController
	{
        public FAQModule FaqModule { get; set; }
        public User CurrentUser { get; set; }

        public FAQController(FAQModule faqModule, User currentUser)
        {
            FaqModule = faqModule;
            CurrentUser = currentUser;
        }

		public FAQModule GetFAQ()
        {
            return FaqModule;
        }

        public void PopulateFAQ(List<QuestionAnswer> listOfQuestionAnswers)
        {
            FaqModule.listOfQuestionAnswers = listOfQuestionAnswers;
        }

        public FAQModule SortFAQ(FAQModule unsortedFaqModule)
        {
            List<QuestionAnswer> sortedQAs = new List<QuestionAnswer>();
            foreach (QuestionAnswer qa in unsortedFaqModule.listOfQuestionAnswers)
            {
                if (qa.tags.Any().Equals(CurrentUser.Tags.Any()))
                {
                    sortedQAs.Add(qa);
                }
            }

            FAQModule sortedFaqModule = new FAQModule(sortedQAs);
            return sortedFaqModule;
        }
    }
}