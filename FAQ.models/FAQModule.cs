namespace FAQ.models
{
    public class FAQModule
    {
	    public List<QuestionAnswer> listOfQuestionAnswers { get; set; }

	    public FAQModule(List<QuestionAnswer> listOfQuestionAnswers)
	    {
			this.listOfQuestionAnswers = listOfQuestionAnswers;
	    }
    }
}

