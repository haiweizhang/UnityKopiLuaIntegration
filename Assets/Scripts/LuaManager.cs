using UnityEngine;
using System.Collections;
using LuaInterface;

public class LuaManager : MonoBehaviour {
	//Reference to the Lua virtual machine
	private Lua luaVirtualMachine;
	//Filename of the Lua file to load in the Streaming Assets folder
	public string LuaFileToLoad = "";
	public void Start(){
		//Init LuaBinding class that demonstrates communication
		LuaBinding binding = new LuaBinding();
		
		//Init instance of Lua virtual machine (Note: Can only init ONCE)
		luaVirtualMachine = new Lua();
		//Tell Lua about the LuaBinding object to allow Lua to call C# functions
		luaVirtualMachine["luabinding"] = binding;
		
		//test luabinding test
		LuaBindingTest bindingTest = new LuaBindingTest();
		bindingTest.name = "name1";
		luaVirtualMachine["LuaBindingTest"] = bindingTest;
		//luaVirtualMachine[""] = ;
		
		Debug.LogError("LuaManager: " + Application.persistentDataPath);
		
		//Run the code contained within the file
#if UNITY_ANDROID
		luaVirtualMachine.DoFile("/sdcard/Download/"+LuaFileToLoad);		
#else
		luaVirtualMachine.DoFile(Application.streamingAssetsPath+"/"+LuaFileToLoad);		
#endif
		//Trigger binding in c# to call the bound Lua function
		
		binding.MessageToLua();
	}
}
