using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Vuforia; 

public class VirtualButton : MonoBehaviour, IVirtualButtonEventHandler
{
	public Animation anim1,anim2;

	void Start() {
		VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
		for (int i = 0; i < vbs.Length; ++i)
		{
			vbs[i].RegisterEventHandler(this);
		}
	}

	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb) {
		if (vb.VirtualButtonName.Equals ("Fire1")) 
			anim1.Play ("Attack");
			//p1anim.CrossFadeInFixedTime ("Attack", 0.1f);
		
		if (vb.VirtualButtonName.Equals ("Fire2"))
			anim2.Play ("Attack");
	}

	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb) { 
		if (vb.VirtualButtonName.Equals ("Fire1")) 
			anim1.Play ("idle");

		if (vb.VirtualButtonName.Equals ("Fire2"))
			anim2.Play ("idle");
	}
}
