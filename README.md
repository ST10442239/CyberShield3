# CyberShield3
Overview

CyberShield3 is a simple cybersecurity awareness chatbot written in C#. It interacts with users via a console interface, providing tips and information on safe online practices.

Features

Greeting Audio: Plays an audio greeting when the program starts.

ASCII Art Display: Shows a cybersecurity-themed ASCII banner.

User Interaction: Engages users in conversation about cybersecurity topics.

Typing Effect: Simulates real-time text output for better user experience.

Installation

Prerequisites

Ensure you have the following installed on your system:

.NET SDK (6.0 or later)

A console terminal (Command Prompt, PowerShell, or equivalent)

A valid greeting.wav audio file in the same directory as the executable

Steps to Run

Clone the repository or download the source code.

Open a terminal and navigate to the project directory.

Build the project using:

dotnet build

Run the application with:

dotnet run

How It Works

The program starts with a voice greeting and displays an ASCII art banner.

It prompts the user for their name and welcomes them.

The user can ask cybersecurity-related questions.

The chatbot responds based on predefined topics.

The user can type 'exit' to terminate the conversation.

Available Commands

Command

Response

how are you?

"I'm just a bot, but I'm here to help you stay safe online!"

what’s your purpose?

"I provide cybersecurity awareness and tips to help you stay safe from online threats."

what can i ask you about?

"You can ask me about phishing, password safety, safe browsing, and more."

what is phishing?

"Phishing is a scam where attackers trick you into giving personal info via fake emails or websites."

how do i create a strong password?

"Use a mix of uppercase, lowercase, numbers, and symbols. Avoid common words and never reuse passwords!"

how do i browse safely?

"Keep your browser updated, avoid suspicious links, and always use HTTPS websites."

Notes

If the greeting.wav file is missing, an error message will be displayed.

The chatbot only recognizes predefined questions; unrecognized inputs will prompt a rephrase request.

The ASCII art and colored text are optimized for Windows command-line interfaces.

License

This project is released under the MIT License. Feel free to modify and distribute it.

Contributions

Contributions and suggestions are welcome! Feel free to submit a pull request or report issues.

Contact

For any queries, reach out to the developer via email or GitHub issues.

