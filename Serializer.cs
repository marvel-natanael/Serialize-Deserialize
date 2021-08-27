using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using Troop;
namespace Serializer{
  public class SerializerApp
  {
    public int Serialize()
    {
      bool isDone = true;
      //Assign data from user input
      MyTroop myTroop = new MyTroop();
      Console.WriteLine("What's the troop type?");
      myTroop.type = Console.ReadLine();
      Console.WriteLine("What's the troop level?");
      myTroop.level = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("What's the troop skin?");
      myTroop.skin = Console.ReadLine();
      Console.WriteLine("What's the troop weapon?");
      myTroop.weapon = Console.ReadLine();
      Console.WriteLine("What's the troop cards? Enter 3!");
      myTroop.cards = new List<string>();
      for(int i = 0; i< 3; i++){
        myTroop.cards.Add(Console.ReadLine());
      }

      FileStream fs = new FileStream("C:/Users/natan/Serialization/ReadThis.txt", FileMode.Create);

      //Serialize to binary
      BinaryFormatter formatter = new BinaryFormatter();
      try
      {
        formatter.Serialize(fs, myTroop);
      }
      catch (SerializationException e)
      {
        isDone = false;
        Console.WriteLine("Failed to serialize. Reason: " + e.Message);
        throw;
      }
      finally
      {
          fs.Close();
      }

      if(isDone){
        return 1;
      }
      else{
        return 0;
      }
    }
  }
}
