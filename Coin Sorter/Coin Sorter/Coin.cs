using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Coin_Sorter
{
    class Coin : AnimatedSprite
    {
        protected Game myGame;

        public int ScoreWorth { get; set; }
        public bool Clicked { get; set; }

        public Coin(Game gameIn, int scoreWorthIn, bool clickedStatusIn, Texture2D image, Vector2 position, Color tint, int frameCountIn) : base(image, position, tint, frameCountIn)
        {
            myGame = gameIn;
            ScoreWorth = scoreWorthIn;
            Clicked = clickedStatusIn;
        }

        public void Update(GameTime gameTime)
        {
            CheckMouseState();
            CheckClicked();        
        }

        public void CheckMouseState()
        {
            // Declare variable to keep track of mouse state.
            var mouseState = Mouse.GetState();

            var mousePosition = new Point(mouseState.X, mouseState.Y);

            // If the user clicks on the menu option...
            if (mouseState.LeftButton == ButtonState.Pressed && Bounds.Contains(mousePosition))
            {
                // ...This option has been selected by the player.
                Clicked = true;
            }
        }

        public void CheckClicked()
        {
            // Test click.
            if (Clicked == true)
            {
                Tint = Color.Red;
                Clicked = false;
            }

            else
            {
                Tint = Color.White;
            }
        }

    }
}
