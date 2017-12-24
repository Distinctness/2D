using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour { 

public Text timerText;
public float secondsCount;
public int minuteCount;
private int hourCount;

void Start (){

		SceneManager.sceneLoaded += ResetOnLevelLoad;
}


void Update(){
		secondsCount += Time.deltaTime;


		if (secondsCount >= 60) {
			secondsCount = 0;
			minuteCount += 1;
		}
			
		if (minuteCount >= 60) {
			minuteCount = 0;
			hourCount += 1;
		}


		int displayCount = (int)secondsCount;
		timerText.text = hourCount+ ":"+ minuteCount + ":"+displayCount;





}
		
void ResetOnLevelLoad(Scene scene, LoadSceneMode mode){
		print ("Level Has been Reset");
	secondsCount = 0;
}
		
}