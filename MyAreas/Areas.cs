using System;

namespace MyAreas
{
    public class Areas
    {
        public float Circle(int radius) {
            float area = (float)Math.PI * radius * radius;            
            return area;
        }
    }
}
