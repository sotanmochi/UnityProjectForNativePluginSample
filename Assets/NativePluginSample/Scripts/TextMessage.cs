using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextMessage : MonoBehaviour
{
	public TextMesh TextMesh;

	void Start()
	{
		int a = 70;
		int b = 7;
		int result = NativePluginSample.AddInt(a,b);
		ShowMessage("NativePluginSample\n" + a + " + " + b + " = " + result);
	}

	private void ShowMessage(string message)
	{
		if(TextMesh != null)
		{
			TextMesh.text = message;
		}
		else
		{
			Debug.Log(message);
		}
	}
}
