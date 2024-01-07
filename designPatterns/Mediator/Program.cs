﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediator mediator = new Mediator();
            Teacher nur = new Teacher(mediator);
            nur.Name = "Nur";

            mediator.Teacher = nur;

            Student sude = new Student(mediator);
            sude.Name = "Sude";

            Student rabia = new Student(mediator);
            rabia.Name = "Rabia";

            mediator.Students = new List<Student> { rabia, sude };
            nur.SendNewImageUrl("slide1.jpg");

            nur.ReceiveQuestion("Is it true?", sude);

            Console.ReadLine();

        }
    }

    abstract class CourseMember
    {
        protected Mediator Mediator;
        public CourseMember(Mediator mediator)
        {
            Mediator = mediator;
        }
    }

    class Teacher : CourseMember
    {
        public Teacher(Mediator mediator) : base(mediator)
        {
        }

        public string Name { get; set; }
        public void ReceiveQuestion(string question, Student student)
        {
            Console.WriteLine("Teacher received a question from {0},{1}",student.Name,question);
        }

        public void SendNewImageUrl(string url)
        {
            Console.WriteLine("Teacher changed slide: {0}",url);
            Mediator.UpdateImage(url);

        }

        public void AnswerQuestion(string answer,Student student)
        {
            Console.WriteLine("Teacher answered question {0},{1}",student.Name,answer);
        }


    }

    class Student : CourseMember
    {
        public Student(Mediator mediator) : base(mediator)
        {
        }

        public string Name { get; set; }
        public void ReceiveImage(string url)
        {
            Console.WriteLine("{1} received image {0}", url,Name);
        }

        public void ReceiveAnswer(string answer)
        {
            Console.WriteLine("Student received answer {0}",answer);
        }
    }

    class Mediator
    {
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }

        public void UpdateImage(string url)
        {
            foreach(var student in Students)
            {
                student.ReceiveImage(url);
            }
        }

        public void SendQuestion(string question,Student student)
        {
            Teacher.ReceiveQuestion(question,student);
        }

        public void SendAnswer(string answer,Student student)
        {
            student.ReceiveAnswer(answer);
        }


    }


}
