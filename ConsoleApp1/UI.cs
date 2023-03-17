﻿using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class UI
    {
        public static void Print(Занятие занятие)
        {
            Console.WriteLine($"Занятие.ДатаПроведения = {занятие.ДатаПроведения}");
            Print(занятие.Дисциплина);
            Print(занятие.Сотрудник);
            Print(занятие.Аудитория);
            Print(занятие.Группа);
            Print(занятие.Пара);
            Print(занятие.ВидЗанятия);
            
        }
        public static void Print(Аудитория аудитория)
        {
            Console.WriteLine($"аудитория.Название = {аудитория.Название}");
            Print(аудитория.Сотрудник);
            Console.WriteLine($"аудитория.количество_посадочных_мест = {аудитория.Количество_посадочных_мест}");
            Console.WriteLine($"аудитория.количество_окон = {аудитория.Количество_окон}");
            Print(аудитория.Оборудование);
        }
        public static void Print(ВидЗанятия видЗанятия)
        {
        }
        public static void Print(Группа группа)
        {
            Console.WriteLine($"группа.Название = {группа.Название}");
            Console.WriteLine($"группа.Сокращение = {группа.Сокращение}");
            Console.WriteLine($"группа.Численность = {группа.Численность}");
            Console.WriteLine($"группа.Год_поступления = { группа.Год_поступления}");
            Print(группа.Специальность);
            Print(группа.Классный_руководитель);
        }
        public static void Print(Дисциплина дисциплина)
        {
            Console.WriteLine($"Дисциплина.Название = {дисциплина.Название}");
            Console.WriteLine($"Дисциплина.Сокращение = {дисциплина.Сокращение}");
        }
        public static void Print(Пара пара)
        {
        }
        public static void Print(Сотрудник сотрудник)
        {
            Console.WriteLine($"сотрудник.Фамилия = {сотрудник.Фамилия}"); 
            Console.WriteLine($"сотрудник.Имя = {сотрудник.Имя}");
            Console.WriteLine($"сотрудник.Отчество = {сотрудник.Отчество}");
            Print(сотрудник.Должность);
        }
        public static void Print(Должность должность)
        {
        }
        public static void Print(Оборудование оборудование)
        {
        }
        public static void Print(Специальность специальность)
        {
            Console.WriteLine($"специальность.Название = {специальность.Название}");
            Console.WriteLine($"специальность.Сокращение = {специальность.Сокращение}");
        }


    }
}