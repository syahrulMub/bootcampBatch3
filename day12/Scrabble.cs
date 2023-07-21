classDiagram
Player "2-4" --* "1" GameRunner

Board --* GameRunner
IPlayer --> Player
Bag "1"--|>"ordered (0 - 7)" RackScrabble 
Player"1" --|> "1"RackScrabble
Player "1" -- "1" Move

IBoard --> Board
GameRunner -- Move

RackScrabble -- Word
Square -- Board
Move -- Word
Square <|--|> Word
Word  <|--|>Dictionary: string
  class GameRunner{
    + List ~PLayer~ players;
    - Move : 1 -4;
    + GameStart();
    + GameEnd();
    + EndMove(); bool
    + StartMove(); bool
  }
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
    + bool IsOccupied() : bool
    + int GetLetterScore() : int
    + string PlaceLatter() : string
   }
  class Board {
    - int _square;
    + int GetSquare(x : 15 y: 15) : interface
    + void SetSquare();
    + PlaceMove();
  }
   class Move{
    - Score : int
    + bool ValidateMove(); bool
    + int CalculateScore( score) : int
   }
  class Word{
    - int score 
    + starx [1-15]
    + endx [1-15]
    + stary [1-15]
    + endy [1-15]
    + int GetScore( int: score) : int
  }
  class Dictionary{
    lookUp( W : Word) : boolean
  }
   class RackScrabble{
    + char[7] rack ;
    + AddChar(c : char);
    + RemoveChar( c : char); 
    + SetWord(char char) : string
   }
   class Bag{
    - bagSize [0 - 100]
    + bool IsEmpety() : Boolean
    + GiveLetters(int EmpetyRack) : set
   }