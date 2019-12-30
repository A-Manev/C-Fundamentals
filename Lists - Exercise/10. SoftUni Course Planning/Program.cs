using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessonsAndExercises = Console.ReadLine().Split(", ").ToList();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "course start")
            {
                string[] tokens = input.Split(":");
                string command = tokens[0];

                if (command == "Add")
                {
                    string lessonTitle = tokens[1];
                    AddLesson(lessonsAndExercises, lessonTitle);
                }
                else if (command == "Insert")
                {
                    string lessonTitle = tokens[1];
                    int index = int.Parse(tokens[2]);
                    InsertLesson(lessonsAndExercises, lessonTitle, index);
                }
                else if (command == "Remove")
                {
                    string lessonTitle = tokens[1];
                    RemoveLessonsAndExercises(lessonsAndExercises, lessonTitle);
                }
                else if (command == "Swap")
                {
                    string lessonTitleOne = tokens[1];
                    string lessonTitleTwo = tokens[2];
                    SwapLessonsAndExercises(lessonsAndExercises, lessonTitleOne, lessonTitleTwo, tokens);
                }
                else if (command == "Exercise")
                {
                    string lessonTitle = tokens[1];
                    AddExercise(lessonsAndExercises, lessonTitle);
                }
            }

            PrintCoursePlan(lessonsAndExercises);
        }

        static void AddLesson(List<string> lessonsAndExercises, string lessonTitle)
        {
            if (!(lessonsAndExercises.Contains(lessonTitle)))
            {
                lessonsAndExercises.Add(lessonTitle);
            }
        }

        static void InsertLesson(List<string> lessonsAndExercises, string lessonTitle, int index)
        {
            if (!(lessonsAndExercises.Contains(lessonTitle)))
            {
                lessonsAndExercises.Insert(index, lessonTitle);
            }
        }

        static void RemoveLessonsAndExercises(List<string> lessonsAndExercises, string lessonTitle)
        {
            if (lessonsAndExercises.Contains(lessonTitle))
            {
                lessonsAndExercises.Remove(lessonTitle);
                if (lessonsAndExercises.Contains($"{lessonTitle}-Exercise"))
                {
                    int exerciseIndex = lessonsAndExercises.IndexOf($"{lessonTitle}-Exercise");
                    lessonsAndExercises.RemoveAt(exerciseIndex);
                }
            }
        }

        static void SwapLessonsAndExercises(List<string> lessonsAndExercises, string lessonTitleOne, string lessonTitleTwo, string[] tokens)
        {
            if (lessonsAndExercises.Contains(lessonTitleOne) && lessonsAndExercises.Contains(lessonTitleTwo))
            {
                int lessonOneIndex = lessonsAndExercises.IndexOf(lessonTitleOne);
                int lessonTwoIndex = lessonsAndExercises.IndexOf(lessonTitleTwo);
                string lessonOne = tokens[1];
                string lessonTwo = tokens[2];
                lessonsAndExercises[lessonOneIndex] = lessonTwo;
                lessonsAndExercises[lessonTwoIndex] = lessonOne;
                if (lessonsAndExercises.Contains($"{lessonTitleOne}-Exercise"))
                {
                    lessonsAndExercises.Remove($"{lessonTitleOne}-Exercise");
                    int exerciseIndex = lessonsAndExercises.IndexOf(lessonTitleOne);
                    lessonsAndExercises.Insert(exerciseIndex + 1, $"{lessonTitleOne}-Exercise");
                }
                if (lessonsAndExercises.Contains($"{lessonTitleTwo}-Exercise"))
                {
                    lessonsAndExercises.Remove($"{lessonTitleTwo}-Exercise");
                    int exerciseIndex = lessonsAndExercises.IndexOf(lessonTitleTwo);
                    lessonsAndExercises.Insert(exerciseIndex + 1, $"{lessonTitleTwo}-Exercise");
                }
            }
        }

        static void AddExercise(List<string> lessonsAndExercises, string lessonTitle)
        {
            if (lessonsAndExercises.Contains(lessonTitle))
            {
                if (!(lessonsAndExercises.Contains($"{lessonTitle}-Exercise")))
                {
                    int indexExercise = lessonsAndExercises.IndexOf(lessonTitle);
                    if (indexExercise >= 0 && indexExercise < lessonsAndExercises.Count - 1)
                    {
                        lessonsAndExercises.Insert(indexExercise + 1, $"{lessonTitle}-Exercise");
                    }
                    else
                    {
                        lessonsAndExercises.Add($"{lessonTitle}-Exercise");
                    }
                }
            }
            else
            {
                lessonsAndExercises.Add(lessonTitle);
                lessonsAndExercises.Add($"{lessonTitle}-Exercise");
            }
        }

        static void PrintCoursePlan(List<string> lessonsAndExercises)
        {
            for (int i = 0; i < lessonsAndExercises.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessonsAndExercises[i]}");
            }
        }
    }
}
