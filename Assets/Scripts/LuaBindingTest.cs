using UnityEngine;
using System.Collections;

public class LuaBindingTest {

	public string name = "";
	public void PrintMessage(string message)
	{
		Debug.Log("LuaBindingTest:" + name + "  " + message);
	}
	public static void StaticPrintMessage(string message)
	{
		Debug.Log("LuaBindingTest:" + "  " + message);
	}
}
