## create list of topics you want to learn

## get list of courses offered
## for each course in list of courses, check if it contains any of the topics you want to learn
## if it does, add it to a list of courses you want to take


```C#
// create list of topics you want to learn
string[] myCourseTopics = new string[] { "Computer Science", "Intro to A.I.", "Robotics", "Machine Learning" };


// create a list of courses
string[] courses = new string[] { "Computer Science", "Intro to A.I.", "Robotics", "Machine Learning","Cooking","Physical Health and Nutrition Science" };

// loop thru myCourseTopics and check if it is in courses
foreach (string topic in myCourseTopics)
{
    for (int i = 0; i < courses.Length; i++)
    {
        if (topic == courses[i])
        {
            Console.WriteLine("You are now enrolled in " + topic);
        }
    }
}


```