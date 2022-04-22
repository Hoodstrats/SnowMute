##### Simple Mic Muter
---
This program started out as a solution to the Yeti Snowball's non existing Mute button.
I decided to expand on it, so it now works for any input device and I added some QOL features as well. 

The goals were simple:
- Be able to bind any combination of 2 Keys to Mute/Unmute (work from anywhere as long as the APP is running)
- Run silently in the background (minimize to task bar)
- Provide visual indicator and speech confirmation of Mute/Unmute
- Minimal effort on the user's end

###### Usage
---
By default the Keybinds are (these work even without the program being in focus):
- Ctrl+M = Mute/Unmute
- Ctrl+Q = Quit the program 
- You can also click the APP itself (it's essentially a giant button)

These can be changed under File>Settings, but the program does require a restart after applying changes.
This is due to the way in which the Key binds are set. They are registered in Windows so that they're able to 
work while APP isn't in focus.