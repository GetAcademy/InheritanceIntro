using TextElements.ElementsWithInheritance;

var centeredHeader = new CenteredHeader("Hei", '*');
var bulletPointA = new BulletPoint("a");
var bulletPointB = new BulletPoint("b");
var bulletPointC = new BulletPoint("c");
var text = string.Concat(Enumerable.Repeat("Det var en gang. ", 22));
var indentedParagraph = new IndentedParagraph(text);
var invertedText = new InvertedText("Terje");

var textElements = new TextElement[]
{
    centeredHeader, bulletPointA, bulletPointB, bulletPointC, indentedParagraph, invertedText
};

foreach (var textElement in textElements)
{
    textElement.Show();
}

