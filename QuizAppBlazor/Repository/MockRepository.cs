using Moq;
using QuizAppBlazor.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizAppBlazor.Repository
{
    public class MockRepository
    {
        public MockRepository()
        {
            
            List<QuestionClass> questions = new List<QuestionClass>
            {
                new QuestionClass {QuestionNumber = 1, Question = "What is my name?", Answer = "Jade" }
            };

            //Creating the instance of IEmpRepository interface
            Mock<MockRepository> mockQuestionRepo = new Mock<MockRepository>();

        }

        private void FetchAll()
        {
            throw new NotImplementedException();
        }
    }
}
