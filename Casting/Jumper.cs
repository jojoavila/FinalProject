using System;

namespace FinalProject.Casting
{
    public class Jumper : Actor
    {
        public Jumper()
        {
            SetWidth(Constants.JUMPER_HEIGHT);
            SetHeight(Constants.JUMPER_HEIGHT);
            SetImage(Constants.IMAGE_JUMPER);
            

            int x = Constants.JUMPER_X;
            int y = Constants.JUMPER_Y;
            Point _position = new Point(x,y);
            SetPosition(_position);

            SetVelocity(new Point(5,0));
        }
    }
}