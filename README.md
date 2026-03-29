# AI Sentiment Analyzer (.NET 10)

## 1. Project Overview
The **AI Sentiment Analyzer** is an automated tool developed to categorize customer feedback and reviews efficiently. In the modern digital era, businesses receive thousands of entries daily, making manual categorization time-consuming and prone to human error. This application provides instant sentiment feedback to improve business intelligence.

## 2. Key Features
* **Automated Classification:** Uses machine learning to classify raw text into binary categories: **Positive** or **Negative**.
* **High Performance:** Built on the latest **.NET 10** ecosystem for fast processing.
* **Confidence Scoring:** Provides a specific confidence score for every prediction made.
* **Container Ready:** Includes a specialized Dockerfile for cross-platform deployment.

## 3. System Architecture
The application follows a **Three-Tier Architecture**:
1. **Presentation Layer:** A Console-based UI for user interaction.
2. **Business Logic Layer:** C# backend that manages string processing and the prediction engine.
3. **Data/AI Layer:** The trained ML.NET model that performs the sentiment classification.

## 4. Tools & Technologies
* **Framework:** .NET 10.0
* **AI Library:** Microsoft.ML (ML.NET)
* **Algorithm:** FastTreeOva
* **IDE:** Visual Studio 2026

## 5. Setup & Installation

### Running Locally
1. Clone the repository to your local machine.
2. Ensure you have the **.NET 10 SDK** installed.
3. Open the solution in **Visual Studio 2026**.
4. Build and run the project.
5. Input a sentence when prompted to see the AI result.

### Running with Docker
A **Dockerfile** is provided to run the application in a containerized environment:

```bash
# Build the image
docker build -t ai-sentiment-app .

# Run the application
docker run -it ai-sentiment-app
