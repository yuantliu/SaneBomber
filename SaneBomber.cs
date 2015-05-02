using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaneBomber
{
    public class SaneBomber : Hearthstone_Deck_Tracker.Plugins.IPlugin
    {

        //SaneBomberMainPanel panel;

        public string Name
        {
            get { return "Sane Bomber"; }
        }

        public string Description
        {
            get { return "Calculate RNG odds for Mad Bomber, Arcane Missiles, Knife Juggler, etc."; }
        }

        public string ButtonText
        {
            get { return "Sane Bomber v0.1"; }
        }

        public string Author
        {
            get { return "bestmalphite"; }
        }

        public Version Version
        {
            get { return new Version("0.1"); }
        }

        public System.Windows.Controls.MenuItem MenuItem
        {
            get { return new System.Windows.Controls.MenuItem(); }
        }

        public void OnLoad()
        {
            Console.WriteLine("Attempting to load my MadBomber");

            //try
            //{
            //    panel = new SaneBomberMainPanel();
            //    panel.Show();
            //} catch (Exception e) {
            //    Console.WriteLine("+++++++ " + e.Message);
            //}
        }

        public void OnUnload()
        {
            //panel.Close();
        }

        public void OnButtonPress()
        {
            throw new NotImplementedException();
        }

        public void OnUpdate()
        {
            throw new NotImplementedException();
        }
    }
}
