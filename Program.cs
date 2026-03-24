using AISmartAnalyzer; 

Console.WriteLine("--- AI Sentiment Analyzer ---");
Console.WriteLine("write sentence (for checking):");

string input = Console.ReadLine();

// AI model 
var sampleData = new SentimentModel.ModelInput()
{
    SentimentText = input,
};

// Prediction 
var result = SentimentModel.Predict(sampleData);

// Result 
string sentiment = result.PredictedLabel == "1" ? "Positive 😊" : "Negative ☹️";
Console.WriteLine($"AI Result: {sentiment}");
Console.WriteLine($"Confidence: {result.Score[0]}");