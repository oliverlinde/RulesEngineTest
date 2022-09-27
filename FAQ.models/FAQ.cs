namespace FAQ.models
{
    public class FAQ
    {
	    public List<QuestionAnswer> listOfQuestionAnswers { get; set; }

	    public FAQ(List<QuestionAnswer> listOfQuestionAnswers)
	    {
			this.listOfQuestionAnswers = listOfQuestionAnswers;
	    }
    }
}

