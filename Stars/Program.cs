using Stars.WithTemplateMethod;

var star1 = new BlinkingStar(1, 1);
var star2 = new MovingStar(2, 2);
var star3 = new Star(3, 3);
var star4 = new BlinkingAndMovingStar(4,4);

var stars = new Star[] { star1, star2, star3, star4 };

while (true)
{
    Console.Clear();
    foreach (var star in stars)
    {
        star.Update();
        star.Show();
    }
    Console.SetCursorPosition(1, 20);
    Thread.Sleep(300);
}