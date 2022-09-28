using FAQ.models;

namespace FAQ.bll;



public interface IFAQController
{
	FAQModule GetFAQ();
	void PopulateFAQ(List<QuestionAnswer> listOfQuestionAnswers);

    FAQModule SortFAQ(FAQModule unsortedFaqModule);

}

