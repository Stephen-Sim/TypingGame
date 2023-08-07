# Typing Speed Test Game Project

## Overview

This project is a Typing Speed Test Game developed using .NET Web API and WinForms. The game measures the user's words per minute (WPM) by having them type out two sentences from an online article. The project consists of two main components: the .NET Web API for web scraping articles and the WinForms application for the typing game interface.

## Features

- Retrieve online articles for typing tests through web scraping from [Dissent Magazine](https://www.dissentmagazine.org/online-articles).
- Measure the user's typing speed in words per minute (WPM) and record the completion time.
- User-friendly graphical user interface with a start menu, game panel, and completion summary panel.

## Prerequisites

Before you begin, ensure you have met the following requirements:

- Visual Studio (2019 or later) installed.
- Internet connection to fetch online articles.

## Installation

1. Clone the repository: `git clone https://github.com/your-username/typing-speed-game.git`
2. Open the project in Visual Studio.
3. Build the solution to restore NuGet packages.

## Usage

1. Run the project to launch the Typing Speed Test Game.
2. The Start Menu will appear with two buttons: "Start Game" and "Exit Game."
3. Click the "Start Game" button to begin the typing test.
4. The Game Panel will display the selected sentences for typing.
5.  After completing the typing, the Complete Game Panel will show your typing speed (WPM) and completion time.

## Screenshots
### Start Game Menu
![image](https://github.com/Stephen-Sim/TypingGame/assets/74543535/2e8ed4ac-dfcf-43a4-a787-8b7003592082)

### Game Panel
![image](https://github.com/Stephen-Sim/TypingGame/assets/74543535/a72a672d-6398-4f01-a1d8-12b45d580116)

### Complete Game Panel
![image](https://github.com/Stephen-Sim/TypingGame/assets/74543535/cb8a9680-f7fb-4b3d-be78-dd9eadf23d1a)


## Technologies Used

- .NET Web API for web scraping.
- WinForms for the graphical user interface.
- HTMLAgilityPack for parsing HTML content.

## Acknowledgments

- The project was inspired by the need to practice and improve typing skills.
- Article content is sourced from [Dissent Magazine](https://www.dissentmagazine.org/online-articles).

## License

This project is licensed under the [MIT License](LICENSE).
