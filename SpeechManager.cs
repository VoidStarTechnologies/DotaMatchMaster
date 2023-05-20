using System.Speech.Synthesis;
using System.Collections.Generic;
using System.Threading;

namespace DotaMatchMaster
{
    internal class SpeechManager
    {
        private static SpeechManager _instance;
        private SpeechSynthesizer _speechSynthesizer;
        private static object _lock = new object();
        private SpeechManager()
        {
            _speechSynthesizer = new SpeechSynthesizer();
            _speechSynthesizer.SelectVoice("Microsoft Zira Desktop");
        }

        public static SpeechManager GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SpeechManager();
                    }
                }
            }
            return _instance;
        }

        public void Speak(string text)
        {
            _speechSynthesizer.Speak(text);
        }
    }
}
