using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using Vorcyc.RoundUI.Presentation;

namespace Vorcyc.RoundUI.Windows.Controls
{
    public class RoundNormalWindow : Window
    {

        public RoundNormalWindow()
        {
            //若ModernNormalWindow的资源样式不设置键，就可以用这个
            //this.DefaultStyleKey = typeof(ModernNormalWindow);
            this.Style = (Style)FindResource("ModernNormalWindowStyle");

            SetCurrentValue(LeftTitleControlsProperty, new TitleControlCollection());
            SetCurrentValue(RightTitleControlsProperty, new TitleControlCollection());

            //SetCurrentValue(LogoFillProperty, new SolidColorBrush(AppearanceManager.Current.AccentColor));

            // associate window commands with this instance 
            this.CommandBindings.Add(new CommandBinding(SystemCommands.CloseWindowCommand, OnCloseWindow));
            this.CommandBindings.Add(new CommandBinding(SystemCommands.MaximizeWindowCommand, OnMaximizeWindow, OnCanResizeWindow));
            this.CommandBindings.Add(new CommandBinding(SystemCommands.MinimizeWindowCommand, OnMinimizeWindow, OnCanMinimizeWindow));
            this.CommandBindings.Add(new CommandBinding(SystemCommands.RestoreWindowCommand, OnRestoreWindow, OnCanResizeWindow));

            AppearanceManager.Current.PropertyChanged += OnAppearanceManagerPropertyChanged;
            //Colors.Transparent
            //WindowChrome.
            
        }

        /// <summary>
        /// Raises the System.Windows.Window.Closed event.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            // detach event handler
            AppearanceManager.Current.PropertyChanged -= OnAppearanceManagerPropertyChanged;
        }

        #region Command Handlers

        private void OnCanResizeWindow(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = this.ResizeMode == ResizeMode.CanResize || this.ResizeMode == ResizeMode.CanResizeWithGrip;
        }

        private void OnCanMinimizeWindow(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = this.ResizeMode != ResizeMode.NoResize;
        }

        private void OnCloseWindow(object target, ExecutedRoutedEventArgs e)
        {
            SystemCommands.CloseWindow(this);
        }

        private void OnMaximizeWindow(object target, ExecutedRoutedEventArgs e)
        {
            SystemCommands.MaximizeWindow(this);
        }

        private void OnMinimizeWindow(object target, ExecutedRoutedEventArgs e)
        {
            SystemCommands.MinimizeWindow(this);
        }

        private void OnRestoreWindow(object target, ExecutedRoutedEventArgs e)
        {
            SystemCommands.RestoreWindow(this);
        }

        #endregion



        /// <summary>
        /// Identifies the TitleLinks dependency property.
        /// </summary>
        public static readonly DependencyProperty LeftTitleControlsProperty =
            DependencyProperty.Register("LeftTitleControls", typeof(TitleControlCollection), typeof(RoundNormalWindow));

        public TitleControlCollection LeftTitleControls
        {
            get { return (TitleControlCollection)GetValue(LeftTitleControlsProperty); }
            set { SetValue(LeftTitleControlsProperty, value); }
        }



        /// <summary>
        /// Identifies the TitleLinks dependency property.
        /// </summary>
        public static readonly DependencyProperty RightTitleControlsProperty =
            DependencyProperty.Register("RightTitleControls", typeof(TitleControlCollection), typeof(RoundNormalWindow));

        public TitleControlCollection RightTitleControls
        {
            get { return (TitleControlCollection)GetValue(RightTitleControlsProperty); }
            set { SetValue(RightTitleControlsProperty, value); }
        }







        private Storyboard backgroundAnimation;
        /// <summary>
        /// When overridden in a derived class, is invoked whenever application code or internal processes call System.Windows.FrameworkElement.ApplyTemplate().
        /// </summary>
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            // retrieve BackgroundAnimation storyboard
            var border = GetTemplateChild("WindowBorder") as Border;
            if (border != null)
            {
                this.backgroundAnimation = border.Resources["BackgroundAnimation"] as Storyboard;

                if (this.backgroundAnimation != null)
                {
                    this.backgroundAnimation.Begin();
                }
            }
        }

        private void OnAppearanceManagerPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            // start background animation if theme has changed
            if (e.PropertyName == "ThemeSource" && this.backgroundAnimation != null)
            {
                this.backgroundAnimation.Begin();
            }
        }


        /// <summary>
        /// Gets or sets the path data for the logo displayed in the title area of the window.
        /// </summary>
        public Geometry LogoData
        {
            get { return (Geometry)GetValue(LogoDataProperty); }
            set { SetValue(LogoDataProperty, value); }
        }

        /// <summary>
        /// Identifies the LogoData dependency property.
        /// </summary>
        public static readonly DependencyProperty LogoDataProperty =
            DependencyProperty.Register("LogoData", typeof(Geometry), typeof(RoundNormalWindow));





        //启用独立的LOGO填充设置
        //public Brush LogoFill
        //{
        //    get { return (Brush)GetValue(LogoFillProperty); }
        //    set { SetValue(LogoFillProperty, value); }
        //}


        //public static readonly DependencyProperty LogoFillProperty =
        //    DependencyProperty.Register("LogoFill", typeof(Brush), typeof(ModernNormalWindow));



        #region Title


        public System.Windows.HorizontalAlignment TitleLocation
        {
            get { return (System.Windows.HorizontalAlignment)GetValue(TitleLocationProperty); }
            set { SetValue(TitleLocationProperty, value); }
        }

        public static readonly DependencyProperty TitleLocationProperty = DependencyProperty.Register
            ("TitleLocation", typeof(System.Windows.HorizontalAlignment), typeof(RoundNormalWindow));



        public Visibility TitleVisibility
        {
            get { return (Visibility)GetValue(TitleVisibilityProperty); }
            set { SetValue(TitleVisibilityProperty, value); }
        }

        public static readonly DependencyProperty TitleVisibilityProperty =
            DependencyProperty.Register("TitleVisibility", typeof(Visibility), typeof(RoundNormalWindow));



        #endregion






        /// <summary>
        /// Gets or sets the background content of this window instance.
        /// </summary>
        public object BackgroundContent
        {
            get { return GetValue(BackgroundContentProperty); }
            set { SetValue(BackgroundContentProperty, value); }
        }


        /// <summary>
        /// Identifies the BackgroundContent dependency property.
        /// </summary>
        public static readonly DependencyProperty BackgroundContentProperty = DependencyProperty.Register("BackgroundContent", typeof(object), typeof(RoundNormalWindow));

    }
}
