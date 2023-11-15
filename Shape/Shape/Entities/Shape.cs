using Shape.Entities.Enum;
                   

namespace Shape.Entities
{
    abstract class Shapee
    {




        public Color Color { get; set; }


        public Shapee() { }
        public Shapee(Color color)
        {
            Color = color;

        }






        public abstract double Area();


    }
                 
        
        
}
