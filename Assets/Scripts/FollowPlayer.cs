
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
	public Vector3 cPos;
	public Transform pPos;
	
	// Update is called once per frame
	void Update () {
		//sa ovim kamera prati kocku
		transform.position=pPos.position + cPos;;	
	}
}
