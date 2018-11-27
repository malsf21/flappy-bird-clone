using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	public GameObject gameOverText;
	public bool gameOver = false;
	public static GameController instance;
	public float scrollSpeed = -1.5f;
	private int score = 0;
	public Text scoreText;

	// Use this for initialization
	private void Awake(){
		if (instance == null){
			instance = this;
		}
		else if (instance != this){
			Destroy(this);
		}
	}

	void Update(){
		if(gameOver && Input.GetMouseButtonDown(0)){
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}

	public void BirdDied(){
		gameOverText.SetActive(true);
		gameOver = true;
	}
	public void BirdScored(){
		if (gameOver){
			return;
		}
		score++;
		scoreText.text = "Score: " + score.ToString();
	}
}
