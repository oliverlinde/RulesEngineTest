using System;
using FAQ.models;

namespace FAQ.dal {

	public interface IQuestionAnswerRepository {
		public void CreateQuestionAnswer(QuestionAnswer questionAnswer);
		public void DeleteQuestionAnswer(int id);
		public List<QuestionAnswer> GetAllQuestionAnswers();
		public QuestionAnswer GetQuestionAnswer(int id);
		public QuestionAnswer UpdateQuestionAnswer(QuestionAnswer questionAnswer);

	}
}