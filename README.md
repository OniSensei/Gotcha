# Gotcha
### Auto spammer / catcher for discord bot pokecord

## Please check the (FAQ)[https://github.com/Zydratex/Gotcha/wiki/F.A.Q] before posing an issue.

This is a VB.NET application to automate catching / leveling pokemon in Pokecord the discord bot. This will also send email notifications if selected for the following:
* Legendary
* Mythic
* Ultra Beast
* Alola

This bot also has quick commands for pokecord to simplify the need for typing. ex:
* Toggle detailed view for p!info
* Order p!info by
  * Alphabetical
  * Number
  * Level
  * IV
* Select Latest pokemon caught
* Info via p!info <selected/latest>
* Pokemon [p!pokemon] by
  * All
  * Shiny
  * Alolan
  * Mega
  * Legendary
  * Mythical
  * Ultra Beast
* Pokedex via p!pokedex <owned/unowned>
* Nickname change
* Favorites list
* Check ballance
* Claim pokedex rewards
 
 The bot also saves your output logs to /logs/ so you can quick search if you need to. 
 
## Download Latest version of Gotcha!
>  [v1.0.0.12](https://github.com/Zydratex/Gotcha/releases/tag/1.0.0.12)

_Please keep in mind if you use multiple monitors, this only scans your *primary monitor*_
_You will have to play with the window size of the discord app, you want it big enough for the bot to try more than once if there is no catch, but enough to bump the pokemon off the screen if there is a catch, but not a level. It's tricky but doable, somewhere near 1117 x 647 on my monitor._

### THIS BOT IS NOT PERFECT AND DEPENDS HEAVILY ON IMAGE DETECTION ###

## Step by Step ##
1. Download
   - >  [v1.0.0.12](https://github.com/Zydratex/Gotcha/releases/tag/1.0.0.12)
   - >  [Discord](https://discordapp.com/download)
 
2. Extract bot zip to folder
   - ![Folder View](https://i.imgur.com/vOMaNvl.png)
   
3. Run
   - Discord and login.
   - Gotcha.exe
   
4. Set basic settings
   - Click 'Basic' tab, located under the 'Settings' section
   - Select the pokemon you would like to catch
   - Add text strings you would like the bot to use
   - Set bot interval (suggested is 1000 - 1500 to avoid discords spam delay)
   - Click Save

5. Set advanced settings
   - Click 'Advanced' tab, located under the 'Settings' section
   - Set catch delay (suggested is 1500)
   - Set discord channel names (this bot looks for the window name for discord, and that include the channel name. The first box with 'general' is the bot you want to watch for pokemon spawns and to spam. The one labeled pokebag is for your quick commands
   - Set the directory for the /img/ folder
   
   ![Img Dir](https://i.imgur.com/TDvWiNC.png)
   
   - If you want email notifications, set your email (gmail only supported)
   
   ![Email Settings](https://i.imgur.com/sDAJ25z.png)
   
     - Set password to email
     - Dont edit the 'SMTP Port' or 'SMTP Host'
     - Set subject for notifications
     - Check 'Send to alternate email?' if you would like to send the logs to a second email, otherwise they will be sent to the email that is also sending.
     
     ![Alt Email](https://i.imgur.com/vIQ9ba0.png)
     
     - Set pokemon types you would like to be notified about
     - Click "Send test email" button to test that the settings are correct
     
     ![Test Email](https://i.imgur.com/5vo7Hrp.png)
     
     
  6. Create Discord channels if not yet made (these are set to work with basic settings)
     - Create channel named 'general' (note variations work for this ex: general2, general3 etc.)
     - Create channel named 'store'
     - Create channel named 'pokebag'
     
  7. Click 'Image Scrape' button    
     - Click 'Image Scrape' tab
     
     ![Image Scrape Tab](https://i.imgur.com/65DsTLl.png)
     
     - Select the 'store' channel in discord
       - Send message > p!market search --name bulbasaur
       - Send message > p!market view idOfPokemonAbove
       - Click the Gotcha image scraper form from before.
       - Make sure discord and the bulbasaur from before is still visible
        - Hover the mouse in the center of the ear on the left side of the image of bulbasaur
         
         ![Bulbasaur Ear Example](https://i.imgur.com/x0rbZb5.png)
         
         - Press F5 with your mouse still in position. This will update the x and y coordinates in the textboxes on the image scraper form
     - Click 'Invite Bot' button
     
     ![Invite Bot](https://i.imgur.com/JyVjpDZ.png)
     
       - This will invite the gotcha image scraper bot to your server.
     - Select the server you want to invite the bot to and click 'Authorize'
     
     ![Authorize Bot](https://i.imgur.com/93SyOrn.png)
     
   8. Click start on the image scraper
      - This will start the image scraper in the 'store' channel. This is a long process, just wait for it to finish.
      - ### CHECK THE /IMG/ FOLDER ONCE THIS IS COMPLETED AND ENSURE THERE ARE NO ALL GREY SQUARES. IF THERE ARE THEN YOU WILL NEED TO CHANGE THE LOCATION OF WHERE THE BOT IS SCREEN SHOTTING FOR THOSE, SO THIS IS THE PROCESS. ###
        - Write the names of the pokemon you need to delete in a notepad or somewhere in person.
        - Delete the images from the /img/ folder.
        - Repeat in 'store' channel the command p!market search --name NameOfPokemonDeleted and then p!market view idOfPokemonFromList
        - Go to image scraper window with discord visible in background
        - Press F5 with your cursor in the top left of a distinct 50x50 pixel space on a pokemon (see other pokemon in /img/ for examples).
        - Delete Melmetal.png from /img/ folder
        - Restart image scraper
        - Repeat with each pokemon as needed
        
   9. Download lightshot (or other desktop screenshot software)
      - [lightshot](https://app.prntscr.com/en/index.html)
   
   10. Screen shot 3 things in discord 50x50 pixel image and save them in the bots main folder. (not the /img/ folder)
       - A level up
       
       ![Level Up](https://i.imgur.com/93Vzv1X.png)
       
       - A pokemon encounter
       
       ![Encounter](https://i.imgur.com/iTDBGfB.png)
       
       - A pokemon evolution
       
       ![Evolution](https://i.imgur.com/FUnGyWs.png)
    
   11. Select 'general' channel in discord
   
   12. Press 'Start' button on 'Home' tab
   
   
   ### Important notes; Please use discord on your primary monitor if you use more than one monitor. If this bot stops tracking levels or evolutions or encounters then you will need new screen shots. To test your pokemon screen shots use the 'Image tester' in advanced settings. ###
   
   > [Switching your primary monitors in windows 10](https://appuals.com/how-to-change-the-primary-monitor-on-windows-10/)
   
# Gotcha! About #
![Gotcha! About](https://i.imgur.com/67BwUhu.gif)

# Gotcha! Logs #
![Gotcha! Logs](https://i.imgur.com/6AIvGn9.gif)

# Gotcha! Advanced Settings #
![Gotcha! Advanced Settings](https://imgur.com/BE2BafN.gif)

# Gotcha! BasicSettings #
### Gotcha! Search ###
![Gotcha! Basic - Search](https://imgur.com/nAccCbv.gif)
### Gotcha! Select / Deselect ###
![Gotcha! Basic - Select / Deselect](https://imgur.com/bD2rf7I.gif)
### Gotcha! Add / Remove ###
![Gotcha! Basic - Add / Remove](https://imgur.com/eJ6hDDY.gif)

# Gotcha! Quick Commands #
![Gotcha! Quick Commands](https://imgur.com/LS0ZsJd.gif)

# Gotcha! Stats #
![Gotcha! Stats](https://imgur.com/kdABShB.gif)

# Gotcha! Home #
![Gotcha! Home](https://imgur.com/vlSQMUL.gif)

