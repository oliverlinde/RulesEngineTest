using system;
using FAQ.models;

namespace FAQ.dal {

	public interface IQuestionAnswerRepository {
		public void CreateQuestionAnswer();
		public void DeleteQuestionAnswea(int id);
		public List<QuestionAnswear> GetAllQuestionAnswers();
		public QuestionAnswer GetQuestionAnswer(int id);
		public QuestionAnswer UpdateQuestionAnswer(QuestionAnswer questionAnswer);

	}
}