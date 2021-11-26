using System;

namespace FinalProject
{
    /// <summary>
    /// This is a set of program wide constants to be used in other classes.
    /// </summary>
    public static class Constants
    {
        public const int MAX_X = 800;
        public const int MAX_Y = 600;
        public const int FRAME_RATE = 30;

        public const int DEFAULT_SQUARE_SIZE = 20;
        public const int DEFAULT_FONT_SIZE = 20;
        public const int DEFAULT_TEXT_OFFSET = 4;

        public const string IMAGE_BRICK = "./Assets/brick-3.png";
        public const string IMAGE_JUMPER = "./Assets/ball.png";
        public const string IMAGE_BALL = "./Assets/ball.png";

        public const string SOUND_START = "./Assets/start.wav";
        public const string SOUND_BOUNCE = "./Assets/boing.wav";
        public const string SOUND_OVER = "./Assets/over.wav";

        public const int BALL_X = MAX_X / 2;
        public const int BALL_Y = MAX_Y - 125;

        public const int BALL_DX = 8;
        public const int BALL_DY = BALL_DX * -1;

        public const int JUMPER_X = MAX_X / 2;
        public const int JUMPER_Y = MAX_Y - 100;

        public const int BRICK_WIDTH = 48;
        public const int BRICK_HEIGHT = 24;

        public const int BRICK_SPACE = 5;

        public const int JUMPER_SPEED = 15;

        public const int JUMPER_WIDTH = 1;
        public const int JUMPER_HEIGHT = 1;

        public const int BALL_WIDTH = 24;
        public const int BALL_HEIGHT = 24;
    }

}