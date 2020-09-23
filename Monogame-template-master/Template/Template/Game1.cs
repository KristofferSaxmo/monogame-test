using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Template
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Texture2D player;
        Vector2 playerPos = new Vector2(GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width/10, GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height-124);

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            base.Initialize();

            graphics.PreferredBackBufferWidth = graphics.GraphicsDevice.DisplayMode.Width;
            graphics.PreferredBackBufferHeight = graphics.GraphicsDevice.DisplayMode.Height;

            graphics.IsFullScreen = true;

            graphics.ApplyChanges();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            player = Content.Load<Texture2D>("player");
        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

            spriteBatch.Draw(player, playerPos, Color.White);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
