<h1>🍅 Pomodoro Timer</h1>

<p>
<strong>
A lightweight and customizable Pomodoro Timer for Windows, designed to make focus sessions and breaks work around your personal productivity habits.

Unlike traditional Pomodoro timers, this application allows you to extend your focus sessions when you need a little extra time, while automatically adjusting your break duration to compensate for the additional effort.

Built to solve real-life productivity problems and provide a more flexible focusing experience.
</strong>
</p>
<h2>📸 Screenshots</h2>

<!-- Replace these paths with your actual screenshot locations -->

<h3>Main Screen</h3>
<img width="1920" height="1080" alt="Screenshot 2026-11-20 140852" src="https://github.com/user-attachments/assets/d4767649-6422-41cd-9a54-18ff292326b4" />


<h3>Settings</h3>
<img width="1920" height="1080" alt="Screenshot 2026-11-20 141019" src="https://github.com/user-attachments/assets/c18373a2-fbda-4323-af2b-d8ac5a12a290" />


<h3>Extra Time Notification</h3>
<img width="587" height="309" alt="image" src="https://github.com/user-attachments/assets/6ea24bc3-3365-4008-86d6-e2a1f5e538a6" />


<h2>✨ Features</h2>

<h3>⏱️ Customizable Pomodoro Sessions</h3>
- Set your preferred focus session duration.
- Customize short and long break durations.
- Choose how many focus sessions to complete before taking a long break.
- Start and pause your sessions whenever you need.

<h3>➕ Extra Focus Time</h3>
Need a few more minutes to finish what you're working on?

- Get a small notification when a focus session ends.
- Add extra minutes to your current session instead of immediately starting a break.
- Customize the default extra time.
- The notification automatically disappears after 15 seconds.
- Continue controlling your timer through the main window.

<h3>⚖️ Automatic Break Adjustment</h3>
Extra focus time shouldn't come at the expense of your break!

- Configure how many extra focus minutes are required to earn one additional break minute.
- Automatically calculate the adjusted break duration.
- Keep your focus and break time balanced without doing the calculations yourself.

<h3>🔊 Desktop Audio Notifications</h3>
- Play timer alerts through your computer's speakers, even when headphones are connected.
- Get notified when focus sessions and breaks end.

<h3>📈 Elapsed Time Tracking</h3>
Unlike traditional Pomodoro timers that count down to zero, this timer counts up from `00:00` to your target duration.

This approach makes it easier to:
- Track how much time you've actually spent on a session.
- Keep track of extra focus time.
- See the total adjusted session or break duration directly on the main screen.

<h3>⚙️ Customizable Settings</h3>

Configure the application according to your preferences:

| Setting | Default Value |
|---|---:|
| Focus Session | 60 minutes |
| Short Break | 20 minutes |
| Long Break | 60 minutes |
| Sessions Before Long Break | 4 |
| Default Extra Time | 5 minutes |
| Extra Focus Minutes Per Break Minute | 3 minutes |

All settings are saved in the Windows Registry, so your preferences are preserved between application launches.

<h2>🛠️ Built With</h2>

- **C#** – Main programming language.
- **Windows Forms (WinForms)** – Desktop user interface.
- **Windows Registry** – Persistent settings storage.

No database is required.

The application is lightweight, with a current build size of less than 5 MB.

<h2>🚀 Getting Started</h2>

<h3>Download</h3>

Download the latest version from <a href="https://www.mediafire.com/file/1w36qw4p2vwdzpa/PomodoroApp.rar/file">Here</a>

Extract the application files and run the executable.

<h3>Run from Source</h3>

1. Clone the repository:

   ```bash
   git clone https://github.com/Zeyad-Ammar/PomodoroApp/
   ```

2. Open the solution file (`.sln`) using Visual Studio.
3. Build the solution.
4. Run the application.

Make sure Visual Studio has the .NET desktop development workload installed.

<h2>💡 Why This Project?</h2>

I have been using the Pomodoro technique for years, and over time, I noticed a few problems with the traditional timer applications I used.

Sometimes, I needed a few extra minutes to finish a task. However, taking that extra time without adjusting my break duration made it harder to maintain a consistent schedule.

I also wanted desktop audio notifications that wouldn't be affected by my headphones.

Instead of continuing to search for an application that addressed these needs, I decided to build one myself.

This project started as a personal solution to everyday productivity problems, and I plan to keep improving it based on my experience and feedback from other users.

<h2>🔮 Future Improvements</h2>

This is an ongoing personal project, and there are more ideas I would like to implement.

Some possible improvements include:

- Productivity statistics and session history.
- Daily and weekly focus-time tracking.
- Customizable notification sounds.
- More notification and reminder options.
- Additional productivity tools.

Suggestions and feature requests are always welcome!

<h2>🤝 Contributions & Feedback</h2>

Have an idea that could make this application better?

Feel free to:
- Open an issue to report bugs or suggest new features.
- Fork the repository and experiment with your own improvements.
- Share your feedback and ideas.

I'm always interested in hearing how other people manage their productivity and what features they would find useful.
