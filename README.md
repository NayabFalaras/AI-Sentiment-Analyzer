# AI Sentiment Analyzer (.NET 10)

## 1. Project Overview
[cite_start]The **AI Sentiment Analyzer** is an automated tool developed to categorize customer feedback and reviews efficiently[cite: 14, 15]. [cite_start]In the modern digital era, manual categorization is time-consuming and prone to human error; this application provides instant sentiment feedback using Machine Learning[cite: 17, 18, 19].

## 2. Key Features
* [cite_start]**Automated Classification:** Uses ML.NET to classify text into **Positive** or **Negative** categories.
* [cite_start]**High Performance:** Built on the latest **.NET 10** ecosystem[cite: 21, 34].
* [cite_start]**Confidence Scoring:** Provides a specific confidence score for every prediction made[cite: 31, 189].
* [cite_start]**Container Ready:** Includes a specialized Dockerfile for cross-platform deployment[cite: 198, 199].

## 3. System Architecture
[cite_start]The application follows a **Three-Tier Architecture**[cite: 25]:
1. [cite_start]**Presentation Layer:** A Console-based UI for user interaction[cite: 26].
2. [cite_start]**Business Logic Layer:** C# backend that manages string processing and the prediction engine[cite: 27].
3. [cite_start]**Data/AI Layer:** The trained ML.NET model (FastTreeOva) that performs the sentiment classification[cite: 28, 108].

## 4. Tools & Technologies
* [cite_start]**Framework:** .NET 10.0 [cite: 34]
* [cite_start]**AI Library:** Microsoft.ML (ML.NET) [cite: 35]
* [cite_start]**Algorithm:** FastTreeOva [cite: 108]
* [cite_start]**IDE:** Visual Studio 2026 [cite: 36]

## 5. Setup & Installation

### Running Locally
1. Clone the repository to your local machine.
2. Ensure you have the **.NET 10 SDK** installed.
3. Open the solution in **Visual Studio 2026**.
4. Build and run the project using `dotnet run`.

### Running with Docker
[cite_start]A **Dockerfile** is provided to run the application in a containerized environment[cite: 199]:

```bash
# Build the image
docker build -t ai-sentiment-app .

# Run the application
docker run -it ai-sentiment-app
