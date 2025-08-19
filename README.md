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

<img width="830" height="488" alt="image" src="https://github.com/user-attachments/assets/4b3fb7b8-f81f-435f-b017-a9dd042fc9d3" />


# OOP Calculator

A simple object-oriented calculator in C# that supports addition, subtraction, multiplication, and division.

## Features

- **Perform basic arithmetic operations: add, subtract, multiply, divide**
- **Uses interfaces and classes to implement operations**
- **Handles division by zero gracefully**
- **Looping input for continuous calculations**

<img width="355" height="132" alt="image" src="https://github.com/user-attachments/assets/9491cbba-fd6d-4ff5-b5e1-cadeaf5f9eca" />


# How to Run the App

This guide explains how to run both the **Calc-U-Later AI Calculator** and the **OOP Calculator** console applications.

---

## Prerequisites

- **.NET 9 SDK** installed: [Download here](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- For **Calc-U-Later**, The Azure Credentials will be available for the next 72 hours only. 

---

## 1. Clone the Repository

```bash
1) git clone https://github.com/malanfcm/Calculators.git
2) dotnet build
3) cd AgentCalculator / OOPCalculator
4) dotnet run
