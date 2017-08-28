
using UnityEngine;

public class PlayerColision : MonoBehaviour {
	public PlayerMovement movement;
	void OnCollisionEnter (Collision cInfo)
	{
		if (cInfo.collider.tag == "Obstacle") {
			//Ako se igrac sudari pokret kocke se prekida
			movement.enabled = false;
			FindObjectOfType<GameManager>().EndGame();
		}

	}


}
