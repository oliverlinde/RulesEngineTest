using FAQ.models;

namespace FAQ.bll;



public interface IFAQController
{
	List<QuestionAnswer> GetFAQ();
	void PopulateFAQ(List<QuestionAnswer> listOfQuestionAnswers);
}

