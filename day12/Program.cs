classDiagram

Player --> IPlayer
Player"1" -- "1"RackScribble
RackScribble -- Letter
Board --> IBoard
Square -- Board
Letter -- Square
Letter"ordered"-- Word
Bag "1"--"ordered (0 - 7)" RackScribble 
Word  "string"-- Dictionary
  class IPlayer {
    << interface>>
    + int GetId();
    + string GetName();
    + void SetID();  
    + void SetName();

  }
  class Player {
    - int _playerID
    - string _playerName  
    + int GetId(): int
    + string GetName(): string
    + void SetID (int playerId);
    + void SetName (string playerName);
  }
   class IBoard {
    <<interface>>
    + int GetSquare();
  }
   class Square{
    + bool IsOccupied() : bolean
    + int GetLetterScore() : int
    + string PlaceLatter() : string
   }
  class Board {
    - int _square;
    + int GetSquare(x : 15 y: 15) : Square
  }
  class Letter{
    + char;
    + Score -readOnly-
    + stirng SetWord(char char) : string
  }
  class Word{
    - int score 
    + starx [1-15]
    + endx [1-15]
    + stary [1-15]
    = endy [1-15]
  }
  class Dictionary{
    lookUp( W : Word) : boolean
  }
   class RackScribble{
    + char[7] rack ;
    + AddChar(c : char);
    + RemoveChar( c : char); 
   }
   class Bag{
    - bagSize [0 - 100]
    + bool IsEmpety() : Boolean
    + GiveLetters(int EmpetyRack) : set
   }

  
