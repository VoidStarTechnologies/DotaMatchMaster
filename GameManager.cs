using Dota2GSI;
using System.Windows.Forms;

namespace DotaMatchMaster
{
    internal class GameManager
    {
        public DotaMatchMasterForm DotaMatchMasterForm { get; set; }
        private static GameManager _instance;
        private GameStateListener _gameStateListener;
        private static object _lock = new object();

        private GameManager()
        {
        }

        public static GameManager GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new GameManager();
                    }
                }
            }
            return _instance;
        }

        public void Start()
        {
            _gameStateListener = new GameStateListener(3000);

            if (!_gameStateListener.Start())
            {
                MessageBox.Show("Couldn't start Game State Listener.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(1);
            }

            DotaMatchMasterForm = new DotaMatchMasterForm();

            Log($"Listener is running on port {_gameStateListener.Port}");
        }

        public void RegisterObserver(Observer.IObserver observer)
        {
            _gameStateListener.NewGameState += observer.Observe;
        }

        public void UnregisterObserver(Observer.IObserver observer)
        {
            _gameStateListener.NewGameState -= observer.Observe;
        }

        public void Log(string message)
        {
            DotaMatchMasterForm.Log(message);
        }

        public void Notify(string message)
        {
            Clock clock = new Clock(_gameStateListener.CurrentGameState.Map.ClockTime);
            Log($"[{clock.Stringify()}] {message}");
            SpeechManager.GetInstance().Speak(message);
        }
    }
}
