
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;
	public float forwardForce = 4000f;
	public float sidewaysForce = 100f;
	//Zavrsene variable

	

	void FixedUpdate () 
	{
		// pokreti lijevo
		if(Input.GetKey("a")){
			rb.AddForce (0,0, -sidewaysForce*Time.deltaTime, ForceMode.VelocityChange);
		}
		//pokret desno
		if(Input.GetKey("d")){
			rb.AddForce (0,0, sidewaysForce*Time.deltaTime, ForceMode.VelocityChange);
		}
		//pokret naprijed
		if(Input.GetKey("w")){
			rb.AddForce (-forwardForce*Time.deltaTime,0, 0);
	}
		if (rb.position.y < -1f)
		{
			FindObjectOfType<GameManager>().EndGame();
		}

}
}
