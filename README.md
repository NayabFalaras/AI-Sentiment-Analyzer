# AI Sentiment Analyzer (.NET 10)

## 1. Project Overview
[cite_start]The **AI Sentiment Analyzer** is an automated tool developed to categorize customer feedback and reviews efficiently[cite: 17, 18]. [cite_start]In the modern digital era, businesses receive thousands of entries daily, making manual categorization time-consuming and prone to human error[cite: 18]. [cite_start]This application provides instant sentiment feedback to improve business intelligence[cite: 19].

## 2. Key Features
* [cite_start]**Automated Classification:** Uses machine learning to classify raw text into binary categories: **Positive** or **Negative**[cite: 22].
* [cite_start]**High Performance:** Built on the latest **.NET 10** ecosystem for fast processing[cite: 21, 34].
* [cite_start]**Confidence Scoring:** Provides a specific confidence score for every prediction made[cite: 31, 178].
* [cite_start]**Container Ready:** Includes a specialized Dockerfile for cross-platform deployment[cite: 198, 199].

## 3. System Architecture
[cite_start]The application follows a **Three-Tier Architecture**[cite: 25]:
1. [cite_start]**Presentation Layer:** A Console-based UI for user interaction[cite: 26].
2. [cite_start]**Business Logic Layer:** C# backend that manages string processing and the prediction engine[cite: 27].
3. [cite_start]**Data/AI Layer:** The trained ML.NET model that performs the sentiment classification[cite: 28].

## 4. Tools & Technologies
* [cite_start]**Framework:** .NET 10.0 [cite: 34]
* [cite_start]**AI Library:** Microsoft.ML (ML.NET Model Builder) [cite: 35]
* [cite_start]**Algorithm:** FastTreeOva [cite: 102, 129]
* [cite_start]**IDE:** Visual Studio 2026 [cite: 36]

## 5. Setup & Installation

### Running Locally
1. Clone the repository to your local machine.
2. [cite_start]Ensure you have the **.NET 10 SDK** installed[cite: 34].
3. [cite_start]Open the solution in **Visual Studio 2026**[cite: 36].
4. Build the project using `dotnet build`.
5. [cite_start]Run the project and input a sentence when prompted to see the AI result[cite: 31, 154].

### Running with Docker
[cite_start]A **Dockerfile** is provided to run the application in a containerized environment[cite: 199]:

```bash
# Build the image
docker build -t ai-sentiment-app .

# Run the application
docker run -it ai-sentiment-app
