class Ventilator
{
    public int Speed;
    public List<Button> Buttons;

    public Ventilator() => Buttons = new List<Button>()
        { new Button(), new Button(), new Button(), new Button() };

    public void PressButton(int number)
    {
        if (number < 0 || number > 3) return;
        for (int i = 0; i < Buttons.Count; i++)
        {
            Buttons[number].IsPressed = number != i || number == 0 ? false : true;
            Speed = number;
        }
    }

    public string Blow() => Speed switch
    {
        <= 0 => "Off",
           1 => "~~~",
           2 => "^^^",
        >= 3 => "===",
    };
}