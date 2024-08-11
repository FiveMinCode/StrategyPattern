
using StrategyPattern;

var data = new Data("Manish", "Test", "XYZ");

data.Formatter = new CSVFormatter();
data.Format();

data.Formatter = new XMLFormatter();
data.Format();

data.Formatter = new JSONFormatter();
data.Format();

Console.ReadKey();
