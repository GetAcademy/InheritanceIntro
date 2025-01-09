using TextElements.ElementsWithTemplateMethod;

var centeredHeader = new CenteredHeader("Hei", '*');
var bulletPointA = new BulletPoint("a");
var bulletPointB = new BulletPoint("b");
var bulletPointC = new BulletPoint("c");
var text = string.Concat(Enumerable.Repeat("Det var en gang. ", 22));
var indentedParagraph = new IndentedParagraph(text);
var invertedText = new InvertedText("Terje");
var text2 = new SimpleText("Terje");

//new TextElement()

var textElements = new TextElement[]
{
    centeredHeader, text2, bulletPointA, bulletPointB, bulletPointC, indentedParagraph, invertedText, text2
};

foreach (var textElement in textElements)
{
    textElement.Show();
}

