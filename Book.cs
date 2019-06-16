﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINKI_Adventures
{
    class Book : Enemy
    {
        public static int Reward = 5;

        public Book()
        {
            this.Health = 150;
            this.Velocity = 30;
            this.X = 640;
            this.Y = 1400;
            this.width = 100;
            this.height = 100;
            dead = remove = false;
            animation = AllAnimations.book;//.book sprite needed
        }
        public override void Move(Player player)
        {
            if (X > player.X)
            {
                X -= Velocity;
                if (animation != AllAnimations.book)
                {
                    animation = AllAnimations.book;
                    animation.Restart();
                }
                else
                {
                    if (animation.isAnimFinished())
                    {
                        animation.Restart();
                    }
                }
            }

            if (Y > player.Y)
            {
                Y -= Velocity;
                if (animation != AllAnimations.book)
                {
                    animation = AllAnimations.book;
                    animation.Restart();
                }
                else
                {
                    if (animation.isAnimFinished())
                    {
                        animation.Restart();
                    }
                }
            }
            if (X < player.X)
            {
                X += Velocity;
                if (animation != AllAnimations.book)
                {
                    animation = AllAnimations.book;
                    animation.Restart();
                }
                else
                {
                    if (animation.isAnimFinished())
                    {
                        animation.Restart();
                    }
                }
            }
            if (Y < player.Y)
            {
                Y += Velocity;
                if (animation != AllAnimations.book)
                {
                    animation = AllAnimations.book;
                    animation.Restart();
                }
                else
                {
                    if (animation.isAnimFinished())
                    {
                        animation.Restart();
                    }
                }
            }
        }
    }
}
