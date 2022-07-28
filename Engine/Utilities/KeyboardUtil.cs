namespace RZEngine.Core.Utilities
{
    public class KeyboardUtil
    {
        private static Microsoft.Xna.Framework.Input.KeyboardState _currentKeyState;
        private static Microsoft.Xna.Framework.Input.KeyboardState _previousKeyState;

        public static Microsoft.Xna.Framework.Input.KeyboardState GetState()
        {
            _previousKeyState = _currentKeyState;
            _currentKeyState = Microsoft.Xna.Framework.Input.Keyboard.GetState();
            return _currentKeyState;
        }

        public static bool GetKeyDown(Microsoft.Xna.Framework.Input.Keys key)
        {
            return _currentKeyState.IsKeyDown(key);
        }

        public static bool GetKeyPressed(Microsoft.Xna.Framework.Input.Keys key)
        {
            return _currentKeyState.IsKeyDown(key) && !_previousKeyState.IsKeyDown(key);
        }
    }
}
