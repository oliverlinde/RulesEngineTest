using System.Collections.Generic;
using FAQ.bll;
using FAQ.models;
using Moq;
using Xunit;
namespace Test.Test.bll {
	public class FAQTest {
		[Fact]
		public void PopulateFAQTest() {
			//Arrange 
			Mock<IFAQController> iMock = new Mock<IFAQController>();
			List<Tag> tags = new List<Tag>();
			QuestionAnswer q1 = new QuestionAnswer(1, tags, "Q1", "A1");
			QuestionAnswer q2 = new QuestionAnswer(2, tags, "Q2", "A2");
			List<QuestionAnswer> list = new List<QuestionAnswer>();
			list.Add(q1);
			list.Add(q2);
			//Act
			//iMock.Setup(m => m.PopulateFAQ(list));
			iMock.Object.PopulateFAQ(list);
			//Assert
			Assert.NotEmpty(iMock.Object.GetFAQ());
		}
	}
}

