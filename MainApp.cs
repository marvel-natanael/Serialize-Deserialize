using System;
using Serializer;
using Deserializer;

namespace Program{
	public class MyProgram{
		static void Main()
		{
          SerializerApp serializerApp = new SerializerApp();
		  DeserializerApp deserializerApp = new DeserializerApp();
          serializerApp.Serialize();
		  deserializerApp.Deserialize();
          Console.ReadLine();
		}
	}
}