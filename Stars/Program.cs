using Stars.WithInheritance;

var star1 = new BlinkingStar(5, 5);
var star2 = new MovingStar(1, 10);
//var star3 = new Star(1, 10);

var stars = new Star[] { star1, star2 };

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