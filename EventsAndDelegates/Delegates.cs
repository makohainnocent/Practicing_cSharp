using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.EventsAndDelegates
{
    public class Delegates
    {

        public static void basicExample1()
        {
            var button= new Button();
            var mainWindow = new MainWindow();
            button.ButtonClicked += mainWindow.onButtonClicked;
            button.button_click();
        }
    }


    public class Button
    {   //create a delegate
        //create an event based off the delegate
        //raise an event
        public Button() { }

        public delegate void ButtonEventHandler(object source,EventArgs args);
        public event ButtonEventHandler ButtonClicked;
        public void button_click()
        {
            Console.WriteLine("button clicked...");

            onButtonClicked();
        }

        protected virtual void onButtonClicked()
        {
            if (ButtonClicked != null)
            {
                ButtonClicked(this, EventArgs.Empty);
            }
        }
    }

    public class MainWindow
    {
        public MainWindow() { }

        public void onButtonClicked(object source,EventArgs e)
        {
            Console.WriteLine("received event button clicked");
        
        }
    }
}
