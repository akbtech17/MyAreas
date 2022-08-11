using System;
using System.Collections.Generic;

namespace MyAreas
{
    public class Areas
    {
        public float Circle(int radius) {
            float area = (float)Math.PI * radius * radius;            
            return area;
        }
        public float Triangle(int b, int height)
        {
            float area = (float)0.5 * b * height;
            return area;
        }
        public int Rectangle(int length, int width)
        {
            int area = length * width;
            return area;
        }
        public string Login(string user, string pwd) {
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pwd))
            {
                return "user or pwd is null";
            }
            else if (user == "Admin" && pwd == "admin") return "Welcome Admin!";
            return "Invalid user and password";
        }
        public List<string> GetNames() { 
            List<string> names = new List<string>();

            names.Add("Anshul");
            names.Add("Jitin");
            names.Add("Aatmic");
            names.Add("Anish");
            names.Add("Prakhar");
            names.Add("Pandit");
            names.Add("Bihari");

            return names;
        }
    }
}
