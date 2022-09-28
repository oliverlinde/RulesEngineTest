using System.Collections.Generic;
using FAQ.bll;
using FAQ.models;
using FAQ.dal;
using Moq;
using Xunit;

namespace Test.Test.bll {
	public class FAQTest
    {

        public Mock<IFAQController> mock = new Mock<IFAQController>();

        [Fact]
        public void PopulateFAQTest()
        {
			//Arrange
			List<Tag> tags = new List<Tag>();
            QuestionAnswer q1 = new QuestionAnswer(1, tags, "Q1", "A1");
            QuestionAnswer q2 = new QuestionAnswer(2, tags, "Q2", "A2");
            List<QuestionAnswer> list = new List<QuestionAnswer>();
            list.Add(q1);
            list.Add(q2);

			// Act
            FAQModule faqModule = new FAQModule(list);
			var controller = new FAQController(faqModule, null);

			//Assert
			Assert.Equal(controller.GetFAQ(), faqModule);
		}

        [Fact]
        public void GetQAFromRepo()
        {
            //Arrange
            List<Tag> tags = new List<Tag>();
            QuestionAnswer q1 = new QuestionAnswer(1, tags, "Q1", "A1");
            QuestionAnswer q2 = new QuestionAnswer(2, tags, "Q2", "A2");
            List<QuestionAnswer> list = new List<QuestionAnswer>();
            //Act
            var mockRepo = new Mock<IQuestionAnswerRepository>();
            mockRepo.Setup(repo=>repo.CreateQuestionAnswer(It.IsAny<QuestionAnswer>()));
            //Assert
            Assert.NotEmpty(mockRepo.Object.GetAllQuestionAnswers());
        }

        [Fact]
        public void TestSortFAQ()
        {
            //Arrange
            Tag userTag1 = new Tag("Indflytter");
            Tag userTag2 = new Tag("Bolig1");
            List<Tag> userTags = new List<Tag>();
            userTags.Add(userTag1);
            userTags.Add(userTag2);
            User user = new User(userTags);

            Tag qaTag1 = new Tag("Indflytter");
            Tag qaTag2 = new Tag("Bolig2");
            List<Tag> tags1 = new List<Tag>();
            List<Tag> tags2 = new List<Tag>();
            tags1.Add(qaTag1);
            tags2.Add(qaTag2);
            QuestionAnswer q1 = new QuestionAnswer(1, tags1, "Q1", "A1");
            QuestionAnswer q2 = new QuestionAnswer(2, tags2, "Q2", "A2");
            List<QuestionAnswer> list = new List<QuestionAnswer>();
            list.Add(q1);
            list.Add(q2);
            FAQModule faqModule = new FAQModule(list);

            //Act
            var controller = new FAQController(faqModule, user);
            FAQModule sortedFaqModule = controller.SortFAQ(faqModule);

            //Assert
            Assert.Contains(q1, sortedFaqModule.listOfQuestionAnswers);
            Assert.DoesNotContain(q2, sortedFaqModule.listOfQuestionAnswers);
        }
	}
}

