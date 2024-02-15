public class Button
{
    public bool IsPressed;
    public int TimesPressed;
    public Button(bool isPressed = false, int timesPressed = 0)
    {
        this.IsPressed = isPressed;
        this.TimesPressed = timesPressed;
    }


    public void Press()
    {
        this.IsPressed = this.IsPressed  ? false : true;
        this.TimesPressed++;
    }


    public string Info()
    {
        string info = this.IsPressed ? $"Button is pressed\nPressed {this.TimesPressed} times" : $"Button is not pressed\nPressed {this.TimesPressed} times";
        return info;
    }
}