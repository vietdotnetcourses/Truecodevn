using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TrueCodeVn_UT_Lesson2.Test.Tests.StudentServiceTest
{
    [TestClass]
    public class IsExistTest
    {

        [TestMethod]
        public void If_Student_Exists_Return_True()
        {
            //Arrange
            var studentId = "SV1";
            var studentService = new StudentService();

            //Act
            var actual = studentService.IsExist(studentId);

            //Assert
            Assert.IsTrue(actual);

        }

        [TestMethod]
        public void If_Student_Does_Not_Exist_Return_False()
        {
            //Arrange
            var studentId = "SV5";
            var studentService = new StudentService();

            //Act 
            var actual = studentService.IsExist(studentId);

            //Assert
            Assert.IsFalse(actual);

        }

        [TestMethod]
        public void If_Id_Invalid_Throw_Exception()
        {

            Assert.Inconclusive();

        }
    }
}
