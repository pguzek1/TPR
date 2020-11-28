﻿using System;
using System.Runtime.Serialization;

namespace ModelClasses
{
    [Serializable]
    class Class3 : ISerializable
    {
        private Class1 Class1 { get; set; }
        private Class2 Class2 { get; set; }
        private string Text { get; set; }
        private DateTime DateTime { get; set; }
        private double Number { get; set; }
        public Class3(string text, DateTime dateTime, double number)
        {
            Text = text;
            DateTime = dateTime;
            Number = number;
        }
        protected Class3(SerializationInfo info, StreamingContext context)
        {
            Class1 = (Class1)info.GetValue("class1", typeof(Class1));
            Class2 = (Class2)info.GetValue("class2", typeof(Class2));
            Text = (string)info.GetValue("text", typeof(string));
            DateTime = (DateTime)info.GetValue("datetime", typeof(DateTime));
            Number = (double)info.GetValue("number", typeof(double));
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("class1", Class1);
            info.AddValue("class2", Class2);
            info.AddValue("text", Text);
            info.AddValue("datetime", DateTime);
            info.AddValue("number", Number);
        }
    }
}
