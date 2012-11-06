using System;
using UnityEngine;


public class BSoundPlayer:MonoBehaviour
{

	static public void PlayBananaSound()
	{
		FSoundManager.PlaySound("BananaSound", 0.95f);
	}
	
	static public void PlayVictoryMusic() 
	{
		PureData.openFile("test.pd");
		PureData.initPd(44100,32,2,2);
		PureData.startAudio();
		//FSoundManager.PlayMusic("VictorySound", 0.2f);
	}
	
	static public void PlayRegularMusic()
	{
		FSoundManager.PlayMusic("Music", 0.3f);
	}
	
	static public void PlayPd()
	{
		
		PureData.initPd(44100, 32, 2, 2);
		PureData.openFile("BasicSynth.pd");
		PureData.startAudio();

	}
	
	static public void PlayNote(int note) {
		PureData.sendFloat(note + 48, "note");
		
	}

	
}

