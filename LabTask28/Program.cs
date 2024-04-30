using LabTask28;

internal class Program
{
    private static void Main(string[] args)
    {

        List<Exam> exams = new List<Exam>();

        Exam exam = new Exam();
        exams.Add(exam.CreatedExam(exam));
        foreach (var item in exams)
        {
            item.GetExam(exams);
        }
    }
}