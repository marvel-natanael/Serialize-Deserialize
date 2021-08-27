using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using Troop;
namespace Deserializer{
  public class DeserializerApp
  {
      
	  static void Main()
      {
          DeserializerApp serializerApp = new DeserializerApp();
          serializerApp.Deserialize();
          Console.ReadLine();
      }
	  

      void Deserialize()
      {
          MyTroop myTroop = new MyTroop();

          // Open the serialized file
          FileStream fs = new FileStream("ReadThis.txt", FileMode.Open);
          try
          {
			  //Deserialize
              BinaryFormatter formatter = new BinaryFormatter();

              myTroop = (MyTroop) formatter.Deserialize(fs);
          }
          catch (SerializationException e)
          {
              Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
              throw;
          }
          finally
          {
              fs.Close();
          }
		  //Print output
          myTroop.PrintValue();
      }
  }
}
