using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT232_Unit_10_Assignment_Jeremy_King
{
  class IT232_Unit_10
  {
    static void Main(string[] args)
    {
      // ##################################################
      // ######     UNIT 10 ASSIGNMENT SECTION 3     ######
      // ##################################################
      
      Console.WriteLine("Assignment 10 - Classes and Inheritance");
      Console.WriteLine(" ");
      Console.WriteLine("Section 3: Base Class Results After Adding");
      Console.WriteLine(" ");
      
      scoreKeeper gameOne = new scoreKeeper("Canasta");
      gameOne.addName("Lary");
      gameOne.addName("Moe");
      gameOne.addName("Curly");
      
      gameOne.addScore("Larry", 20);
      gameOne.addScore("Moe", 35);
      gameOne.addScore("Curlt", 45);
      
      gameOne.listAllScores();
      
      Console.WriteLine(" ");
      
      gameOne.subScore("Moe", 15);
      gameOne.subScore("Curly", 5);
      
      Console.WriteLine("Section 3; Base Class Results After Subtracting");
      Console.WriteLine(" ");
      
      gameOne.listAllScores();
      
      Console.WriteLine(" ");
      Console.WriteLine(" ");
      
      // ##################################################
      // ######     UNIT 10 ASSIGNMENT SECTION 4     ######
      // ##################################################
      
      Console.WriteLine("Section 4: Derived Class Results: Baseball Scoring");
      Console.WriteLine(" ");
      
      baseball gameTwo = new baseball("Cubs", "Braves");
      
      gameTwo.addScore("Cubs", 2);
      gameTwo.advOuts();
      gameTwo.advOuts();
      gameTwo.advOuts();
      gameTwo.addScore("Braves", 3);
      gameTwo.advOuts();
      gameTwo.advStrikes();
      gameTwo.advFouls();
      gameTwo.advFouls();
      gameTwo.advFouls();
      gameTwo.advFouls();
      
      gameTwo.listAllScores();
      
      Console.WriteLine(" ");
      Console.WriteLine("The current inning is " + gameTwo.getInning());
      Console.WriteLine("Outs: " + gameTwo.getOuts());
      Console.WriteLine("Strikes: " + gameTwo.getStrikes);
      Console.WriteLine("Fouls: " + gameTwo.getFouls);
      Console.WriteLine("Balls: " + gameTwo.getBalls);
    }
  }
  
  // ##################################################
  // ######     UNIT 10 ASSIGNMENT SECTION 1     ######
  // ##################################################
  
  class scoreKeeper
  {
    private string gamePlayed; 
    private Dictionary<string, int> players = new Dictionary<string, int>();
    
    public void setGame(string game)
    {
      gamePlayed = name; 
    }
    
    public string getName()
    {
      return gamePlayed;
    }
    
    public void addName(string name)
    {
      players.Add(name, 0);
    }
    
    public string getPlayerName(int playernum)
    {
      return players.Keys.ElementAt(playerNum - 1);
    }
    
    public int addScore(string player, int points)
    {
      players[player] = [players[player] + points;
      return players[player];
    }
    
    public int subScore(string player, int points)
    {
      players[player] = [players[player] - points;
      return players[player];
    }
    
    public int getScore(string name)
    {
    return players[name];
    }
    
    public void listAllScores()
    {
      string name;
      
      Console.WriteLine("The scores for " + gamePlayed + ":");
      
      for (int i = 0; i < players.Count; i++)
      {
        name = getPlayerName(i+1);
        Console.WriteLine(name + "'s score is " getScore(name));
      }
    }
    
    public scoreKeeper()
    { 
    
    }
    
    public scoreKeeper(string game)
    {
      setGame(game);
    }
  }
  
  // ##################################################
  // ######     UNIT 10 ASSIGNMENT SECTION 2     ######
  // ##################################################
  
  class baseball:scoreKeeper
  {
    private double inning = 1;
    private int outs = 0;
    private int strikes = 0;
    private int fouls = 0;
    private int balls = 0;
    
    public void advOuts()
    {
      outs++;
      if (outs >= 3)
      {
        inning = inning + .5;
        outs = 0;
        strikes = 0;
        fouls = 0;
        balls = 0;
      }
    }
    
    public void advStrikes()
    {
      strikes++;
      if (strikes >= 3)
      {
        advOuts();
      }
    }
    
    public void advFouls()
    {
      fouls++;
      if (strikes < 2)
      {
        strikes++;
      }
    }
    
    public void advBalls()
    {
      balls++;
      if (balls >= 4)
      {
        strikes = 0;
        fouls = 0;
        balls = 0;
      }
    }
    
    public double getInning()
    {
      return inning;
    }
    
    public int getOuts()
    {
      return outs;
    }
    
    public int getStrikes()
    {
      return strikes;
    }
    
    public int getFouls()
    {
      return fouls;
    }
    
    public int getBalls()
    {
      return balls;
    }
    
    public baseball()
    {
    
    }
    
    public baseball(string team1, string team2)
    {
      setGame(team1 + " vs " + team2);
      addName(team1);
      addName(team2);
    }
  }  
}
