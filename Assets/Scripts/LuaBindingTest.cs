using UnityEngine;
using System.Collections;

namespace LuaBindingTestSP{
	
	public class LuaBindingTest {
	
		public string name = "";
		static LuaBindingTest _instance = null;
		public static LuaBindingTest SharedInstance()
		{
			if(_instance == null)
			{
				_instance = new LuaBindingTest();
			}
			return _instance;
		}
		public void PrintMessage(string message)
		{
			Debug.Log("LuaBindingTest:" + name + "  " + message);
		}
		public static void StaticPrintMessage(string message)
		{
			Debug.Log("StaticPrintMessage:" + "  " + message);
		}
	}
}