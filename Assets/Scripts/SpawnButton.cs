﻿using UnityEngine;
using System.Collections;

public class SpawnButton : MonoBehaviour
{
	public void SpawnKnight() {
		Character initialCharacter = Instantiate (GameResources.knightCharacter).GetComponent<Character>();
		initialCharacter.name = Time.time.ToString();
		GameInformation.SpawnCharacter (initialCharacter);
	}

	public void SpawnWolf() {
		Character initialCharacter = Instantiate (GameResources.wolfCharacter).GetComponent<Character>();
		initialCharacter.name = Time.time.ToString();
		GameInformation.SpawnCharacter (initialCharacter);
	}
}

