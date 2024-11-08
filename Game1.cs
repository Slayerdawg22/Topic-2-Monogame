using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Topic_2_Monogame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D circle;
        Texture2D rectangle;
        Rectangle circleRect;
        SpriteFont textFont;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            circleRect = new Rectangle(350, 200, 300, 150);
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 800;
            _graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            circle = Content.Load<Texture2D>("circle");
            rectangle = Content.Load<Texture2D>("rectangle");
            textFont = Content.Load<SpriteFont>("TextFont");
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
            GraphicsDevice.Clear(Color.Beige);
            _spriteBatch.Begin();
            
            _spriteBatch.Draw(rectangle, new Rectangle(1, 1, 100, 100), Color. Brown);
            _spriteBatch.Draw(rectangle, new Rectangle(1, 200, 100, 100), Color.Brown);
            _spriteBatch.Draw(rectangle, new Rectangle(1, 400, 100, 100), Color.Brown);
            _spriteBatch.Draw(rectangle, new Rectangle(1, 600, 100, 100), Color.Brown);
            _spriteBatch.Draw(rectangle, new Rectangle(200, 1, 100, 100), Color.Brown);
            _spriteBatch.Draw(rectangle, new Rectangle(200, 200, 100, 100), Color.Brown);
            _spriteBatch.Draw(rectangle, new Rectangle(200, 400, 100, 100), Color.Brown);
            _spriteBatch.Draw(rectangle, new Rectangle(200, 600, 100, 100), Color.Brown);
            _spriteBatch.Draw(rectangle, new Rectangle(400, 1, 100, 100), Color.Brown);
            _spriteBatch.Draw(rectangle, new Rectangle(400, 200, 100, 100), Color.Brown);
            _spriteBatch.Draw(rectangle, new Rectangle(400, 400, 100, 100), Color.Brown);
            _spriteBatch.Draw(rectangle, new Rectangle(400, 600, 100, 100), Color.Brown);
            _spriteBatch.Draw(rectangle, new Rectangle(600, 1, 100, 100), Color.Brown);
            _spriteBatch.Draw(rectangle, new Rectangle(600, 200, 100, 100), Color.Brown);
            _spriteBatch.Draw(rectangle, new Rectangle(600, 400, 100, 100), Color.Brown);
            _spriteBatch.Draw(rectangle, new Rectangle(600, 600, 100, 100), Color.Brown);
            _spriteBatch.Draw(rectangle, new Rectangle(100, 100, 100, 100), Color.Brown);
            _spriteBatch.Draw(rectangle, new Rectangle(100, 300, 100, 100), Color.Brown);
            _spriteBatch.Draw(rectangle, new Rectangle(100, 500, 100, 100), Color.Brown);
            _spriteBatch.Draw(rectangle, new Rectangle(100, 700, 100, 100), Color.Brown);
            _spriteBatch.Draw(rectangle, new Rectangle(300, 100, 100, 100), Color.Brown);
            _spriteBatch.Draw(rectangle, new Rectangle(300, 300, 100, 100), Color.Brown);
            _spriteBatch.Draw(rectangle, new Rectangle(300, 500, 100, 100), Color.Brown);
            _spriteBatch.Draw(rectangle, new Rectangle(300, 700, 100, 100), Color.Brown);
            _spriteBatch.Draw(rectangle, new Rectangle(500, 100, 100, 100), Color.Brown);
            _spriteBatch.Draw(rectangle, new Rectangle(500, 300, 100, 100), Color.Brown);
            _spriteBatch.Draw(rectangle, new Rectangle(500, 500, 100, 100), Color.Brown);
            _spriteBatch.Draw(rectangle, new Rectangle(500, 700, 100, 100), Color.Brown);
            _spriteBatch.Draw(rectangle, new Rectangle(700, 100, 100, 100), Color.Brown);
            _spriteBatch.Draw(rectangle, new Rectangle(700, 300, 100, 100), Color.Brown);
            _spriteBatch.Draw(rectangle, new Rectangle(700, 500, 100, 100), Color.Brown);
            _spriteBatch.Draw(rectangle, new Rectangle(700, 700, 100, 100), Color.Brown);
            _spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
