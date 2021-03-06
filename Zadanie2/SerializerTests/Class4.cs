﻿using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace SerializerTests.Model
{
    [Serializable]
    [JsonObject]
    public class Class4 : ISerializable
    {
        public Class4 class4 { get; set; }
        public string Text { get; set; }
        public bool Boolean { get; set; }
        public double Number { get; set; }
        public Class4() { }

        public Class4(string text, bool boolean, double number)
        {
            Text = text;
            Boolean = boolean;
            Number = number;
        }

        public Class4(SerializationInfo info, StreamingContext context)
        {
            class4 = (Class4)info.GetValue("Class4", typeof(Class4));
            Text = (string)info.GetValue("Text", typeof(string));
            Boolean = (bool)info.GetValue("Boolean", typeof(bool));
            Number = (double)info.GetValue("Number", typeof(double));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Class4", class4);
            info.AddValue("Text", Text);
            info.AddValue("Boolean", Boolean);
            info.AddValue("Number", Number);
        }
    }
}
