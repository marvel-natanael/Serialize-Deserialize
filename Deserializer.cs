using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using Troop;
namespace Deserializer{
  public class DeserializerApp
  {
      public int Deserialize()
      {
          bool isDone = true;
          MyTroop myTroop = new MyTroop();

          // Open the serialized file
          FileStream fs = new FileStream("C:/Users/natan/Serialization/ReadThis.txt", FileMode.Open);
          try
          {
			  //Deserialize
              BinaryFormatter formatter = new BinaryFormatter();
              myTroop = (MyTroop) formatter.Deserialize(fs);
              myTroop.WriteValue("C:/Users/natan/Serialization/Output.txt");
          }
          catch (SerializationException e)
          {
              isDone = false;
              Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
              throw;
          }
          finally
          {
              fs.Close();
          }

		  //Print output
          myTroop.PrintValue();
          
          if(isDone){
              return 1;
          }
          else{
              return 0;
          }
      }
  }
}
