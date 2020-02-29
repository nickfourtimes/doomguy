using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doomguy : MonoBehaviour {

	public float refreshInterval = 1f;

	IEnumerator Start() {
		var animComp = GetComponent<Animator>();

		while(true) {
			if(Input.GetKeyDown(KeyCode.Escape)) {
				break;
			}

			animComp.SetFloat("doomguy", Random.value);
			yield return null;
			animComp.SetFloat("doomguy", 0.5f);

			yield return new WaitForSeconds(refreshInterval);
		}

		yield break;
	}
}
