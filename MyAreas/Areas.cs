using System;

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
    }
}
