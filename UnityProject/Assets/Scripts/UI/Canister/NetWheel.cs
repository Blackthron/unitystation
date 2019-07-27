
using System;
using UnityEngine;

public class NetWheel : NetUIElement
{
	public Wheel Element;

	public override string Value
	{
		set
		{
			externalChange = true;
			Element.RotateToValue(Convert.ToInt32(value));
			externalChange = false;
		}
		get => Element.KPA.ToString();
	}

	public IntEvent ServerMethod;

	public override void ExecuteServer() {
		ServerMethod.Invoke(Convert.ToInt32(Value));
	}
}
