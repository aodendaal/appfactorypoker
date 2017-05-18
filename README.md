# appfactorypoker
Bot interface and example for playing AppFactory poker

## Steps to use
1. Download or clone this project
2. Open the solution and create a new Class Library (.NET Framework) project for .NET 3.5 **(Very important to use the correct version)**
3. Add **PokerPlayers.Interface** as a project reference
4. Create a new class and inherit from ```PokerPlayers.Interface.ISimplePlayer```
5. Implement the interface
6. Build the library
7. Copy the output DLL to an easy to reference directory
7. Unzip ```pokerplayers.zip``` and run it
8. In any of the player inputs enter the path to the output DLL including the file name
9. Click **Start**

## ISimplePlayer Explained

### PlayerName
This returns the bot name to display in the game.
It is read once when the bot is instantiated.

### DiscardCards
This function must return an array of cards from the bot's hand that you wish to discard.
You can discard any number of cards, from none to all five.
Cards must match the cards assigned to the bot in ```ReceiveCards```
> This is the primary focus of the bot. Write a function to discard the worst cards in the bot's hand for a better chance to win the round.

### ReceiveCards
This function takes in an array of cards when the round begins.
It is called when the rounds starts, after the animation for dealing the cards is complete.

## Card Explained
A card is the only entity used by the interface.
It represents a playing card in poker.
It has 3 properties: A suit, a value and an id.
The suit is an enum of: Clubs, Diamonds, Hearts & Spades.
The value is the number of the suit from 2 to 14. 11 being Jack, 12 Queen, 13 King and 14 Ace.
The id is used internally by the game and should be ignored.