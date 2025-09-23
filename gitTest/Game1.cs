using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace gitTest
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private int a;
        private int b;
        private int c;
        private int d;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            a = 5;
            b = 9;
            c = 2;
            d = 8;
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            Console.WriteLine("feature 1:");
            Console.WriteLine("Sum is "+sum(a, b));
            Console.WriteLine("feature 2:");
            Console.WriteLine("Subtract is " + subtract(a, c));
            Console.WriteLine("feature 3:");
            Console.WriteLine("Multiply is " + multiply(b, c));

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }

        private int sum (int a, int b)
        {
            return a + b;
        }

        private int subtract (int a, int b)
        {
            return a - b;
        }

        private int multiply (int a, int b)
        {
            return a * b;
        }
    }
}
