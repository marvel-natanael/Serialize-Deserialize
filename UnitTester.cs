using Xunit;
using Serializer;
using Deserializer;

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
}