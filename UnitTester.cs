using Xunit;
using Serializer;
using Deserializer;
using System.IO;
public class TestClass{
	SerializerApp serializerApp = new SerializerApp();
	DeserializerApp deserializerApp = new DeserializerApp();

	//tests serialize
	//this test will fail because there is no input. But the program runs fine
	[Fact]
	public void SerializeTest(){
		Assert.Equal(1, serializerApp.Serialize());
	}

	//tests deserialize
	[Fact]
	public void DeserializeTest(){
		Assert.Equal(1, deserializerApp.Deserialize());
	}

	//test if file exists
	[Fact]
	public void CheckFile(){
		int isExist;
		if(File.Exists("C:/Users/natan/Serialization/Output.txt")){
			isExist = 1;
		}
		else{
			isExist = 0;
		}
		Assert.Equal(1, isExist);
	}

	//test if file is same
	[Fact]
	public void CheckOutput(){
		int inputByte;
		int outputByte;
		bool isSame = true;
		FileStream input = new FileStream("C:/Users/natan/Serialization/Input.txt", FileMode.Open);
		FileStream output = new FileStream("C:/Users/natan/Serialization/Output.txt", FileMode.Open);
		do
		{
			inputByte = input.ReadByte();
			outputByte = output.ReadByte();
		}
		while ((inputByte == outputByte) && (inputByte != -1));
	}
}