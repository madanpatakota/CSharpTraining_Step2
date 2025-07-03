
using System;

/// <summary>
/// Constructor is a special method that is used to initialize objects. 
///It is called when an instance of the class is created.
/// </summary>

class FileDetailsConstructors
{
    string filename = "Student1_Resume.docx";
    string filelocation = @"D:\Students\Resumes";
    string filesize = "2Kb";
    string createddate = "Mar-01-2024";

    DateTime createdDateTime = DateTime.Now;

    public FileDetailsConstructors()
    {

        Console.WriteLine("File object created");


        this.filename = "Employee1_Salary.pdf";
        this.filelocation = @"C:\Employees\Salaries";
        this.filesize = "1Kb";
        this.createddate = "Jan-01-2025";
        this.createdDateTime = DateTime.Now;

        Console.WriteLine(this.filename);
        Console.WriteLine(this.filelocation);
        Console.WriteLine(this.filesize);
        Console.WriteLine(this.createddate);
        //Console.WriteLine("Constructor is called");
    }

    public FileDetailsConstructors(string filename, string filelocation, string filesize, string createddate)
    {

        Console.WriteLine("File object created");

        this.filename = filename;
        this.filelocation = filelocation;
        this.filesize = filesize;
        this.createddate = createddate;
        this.createdDateTime = DateTime.Now;

        Console.WriteLine(this.filename);
        Console.WriteLine(this.filelocation);
        Console.WriteLine(this.filesize);
        Console.WriteLine(this.createddate);
        //Console.WriteLine("Constructor is called");
    }

    //public  FileDetailsConstructors(string demo)
    //{
    //    Console.WriteLine("Parameter Constructor is called");
    //}

    static void Main()
    {
        //FileDetailsConstructors fileDetailsConstructors1 = new FileDetailsConstructors("Test1");
        //FileDetailsConstructors fileDetailsConstructors2 = new FileDetailsConstructors();

        FileDetailsConstructors fileDetailsConstructors3 =
            new FileDetailsConstructors("CreditCardStatementMarch.pdf", "C:\\", "5kb", "1-Mar-2025");
            //what is the goal?????
        //Script..
        //fileDetailsConstructors2.filename; //

    }

}