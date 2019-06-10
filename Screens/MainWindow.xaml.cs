using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System.Timers;

namespace KARE8080
{
    public class MainWindow : Window
    {
        private IArcadeGame _game;

        public Timer aTimer;

        public MainWindow()
        {
            InitializeComponent();
            _game = new SpaceInvaders.SpaceInvaders();
            _game.Load();
            SetupTimer();
            aTimer.Start();
        }

        private void ATimerTick(Object source, ElapsedEventArgs e)
        {
             = _game.GetScreen();
        }

        private void RunSpaceInvaders()
        {
            _game.Run();
        }

        public override void KeyDown()
        {
            
        }

        private void ExitQ()
        {
            Environment.Exit(0);
        }

        public void SetupTimer()
        {
            aTimer = new Timer(100);
            aTimer.Elapsed += ATimerTick;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}