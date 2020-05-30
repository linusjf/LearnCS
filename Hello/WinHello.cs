using System;
using System.Windows.Forms;

public class HelloWorldWin : Form
{
    static public void Main ()
    {
        Application.Run (new HelloWorldWin ());
    }

    public HelloWorldWin ()
    {
        Text = "Hello Mono World";
    }
}
