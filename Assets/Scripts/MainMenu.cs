using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour {
	public void StertGame(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}
	public void QuitGame(){
		Application.Quit ();
	}

}
