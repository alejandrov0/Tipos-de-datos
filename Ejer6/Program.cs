﻿using System;
using System.IO;
namespace ejer6
{
    class Program
    {
        public static void Main (string[] args)
        {
           string s;

           using (TextWriter w = File.CreateText("log.txt"))
           {
               w.WriteLine("linea uno");
               w.WriteLine("linea dos");
           }
           using (TextReader r = File.OpenText("log.txt"))
           {
               while ((s = r.ReadLine()) != null)
               {
                   Console.WriteLine(s);
               }
    }}}}

