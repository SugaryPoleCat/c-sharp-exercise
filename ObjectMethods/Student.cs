namespace ObjectMethods
{
    // object methods are methods in a class that can modify the information of the class.
    class Student
    {
        public string studentName;
        public string studentClass;
        public double studentGPA;

        /// <summary>
        /// Construct a studnet.
        /// </summary>
        /// <param name="aName">Student's name</param>
        /// <param name="aClass">Which class they belong to</param>
        /// <param name="aGPA">Their average grade</param>
        public Student(string aName, string aClass, double aGPA)
        {
            studentName = aName;
            studentClass = aClass;
            studentGPA = aGPA;
        }

        /// <summary>
        /// CHeck if a student's GPA is within the honor roll.
        /// </summary>
        /// <returns></returns>
        public bool hasHonors()
        {
            if (studentGPA >= 3.5)
            {
                return true;
            }
            return false;
        }
    }
}
