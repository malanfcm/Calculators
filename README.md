# Calc-U-Later: Agentic Azure Foundry AI Calculator

This project demonstrates a **calculator agent** built with **Azure AI**, **Semantic Kernel**, and **Azure Identity**. The agent can perform arithmetic operations, powers, roots, percentages, and complex expressions with parentheses.
Additionally, the calculator uses **RAG (Retrieval-Augmented Generation) operations** to gain custom knowledge from the included file **BasicMathHandbook.pdf**. Users are encouraged to ask questions about the book to see how the agent applies its content in calculations and explanations.

---

## Technologies Used

- **Azure.AI.Agents.Persistent**
- **Azure.Identity**
- **Microsoft.SemanticKernel**
- **Microsoft.SemanticKernel.Agents**
- **Microsoft.SemanticKernel.Agents.AzureAI**
- **Microsoft.SemanticKernel.ChatCompletion**

## Features
- **Add, subtract, multiply, divide**
- **Powers and roots**
- **Percentages**
- **Complex expressions with parentheses**
- **Interactive chat interface**
- **Exit command with exit**

---

# OOP Calculator

A simple object-oriented calculator in C# that supports addition, subtraction, multiplication, and division.

## Features

- **Perform basic arithmetic operations: add, subtract, multiply, divide**
- **Uses interfaces and classes to implement operations**
- **Handles division by zero gracefully**
- **Looping input for continuous calculations**




# How to Run the App

This guide explains how to run both the **Calc-U-Later AI Calculator** and the **OOP Calculator** console applications.

---

## Prerequisites

- **.NET 9 SDK** installed: [Download here](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- For **Calc-U-Later**, ensure your **Azure credentials** are configured for `DefaultAzureCredential`.

---

## 1. Clone the Repository

```bash
1) git clone https://github.com/<your-username>/<your-repo>.git
2) cd <your-repo>
3) dotnet restore
4) dotnet build
6) dotnet run
