using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using OpenTK.Input;
namespace testOpenTK
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer clock;
        private GamePadState oldgstate;
        private JoystickState oldjstate;
        private int activeGamepad = 0;
        private int activeJoystick = 0;
        public MainWindow()
        {
            InitializeComponent();
            createNewTimer();
            oldgstate = GamePad.GetState(activeGamepad);
            oldjstate = Joystick.GetState(activeJoystick);
            this.Loaded += initializeController;


        }
        private void createNewTimer() {
            clock = new DispatcherTimer();
            clock.Tick += new EventHandler(checkGamePads);
            clock.Interval = new TimeSpan(0,0,0,0,25);
            clock.Start();
        }

        private void checkGamePads(Object sender, EventArgs e){
                var gState = GamePad.GetState(activeGamepad);
                if (!gState.Equals(oldgstate))
                {
                    txtGamePadStateDebug.Text = gState.ToString();
                    
                }
                var jState = Joystick.GetState(activeJoystick);
                if (!gState.Equals(oldjstate))
                {
                    txtJoystickStateDebug.Text = jState.ToString();

                }

        }

        private void initializeController(Object sender, EventArgs e) {
            var gCapabilities = GamePad.GetCapabilities(activeGamepad);
            var jCapabilities = Joystick.GetCapabilities(activeJoystick);
            txtGamePadCapabilitiesDebug.Text = gCapabilities.ToString();
            txtJoystickCapabilitiesDebug.Text = jCapabilities.ToString();

        }



    }
    
}
