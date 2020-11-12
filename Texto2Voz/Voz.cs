using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Texto2Voz{
    class Voz{
        string pronunciar = "";
        public Voz(string texto) {
            pronunciar = texto;
        }
        public bool Hablar() {
            try {
                SpeechSynthesizer synthesizer = new SpeechSynthesizer();
                synthesizer.Volume = 100;  // 0...100
                synthesizer.Rate = -2;     // -10...10
                synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Senior);
                synthesizer.Speak(pronunciar); //synthesizer.SpeakAsync(texto);
                return true;
            }
            catch {
                return false;
            }
        }

    }
}
