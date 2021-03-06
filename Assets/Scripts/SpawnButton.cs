﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SpawnButton : MonoBehaviour
{
	Button spawnKnightButton;
	Button moreManaButton;

	void Start() {
		spawnKnightButton = transform.Find ("Spawn Knight").GetComponent<Button> ();
		moreManaButton = transform.Find ("More Mana").GetComponent<Button> ();
	}

	void Update() {
		if (!GameInformation.SoldierOrMana) {
			spawnKnightButton.interactable = false;
			moreManaButton.interactable = false;
		} else {
			spawnKnightButton.interactable = true;
			moreManaButton.interactable = true;
		}
	}

	public void SpawnKnight() {
		int manaCost = GameResources.knightCharacter.GetComponent<Character> ().manaCost;
		//if(manaCost <= GameInformation.currentMana){
			//Character initialCharacter = Instantiate (GameResources.knightCharacter).GetComponent<Character>();
			//initialCharacter.name = Time.time.ToString();
			//GameInformation.SpawnCharacter (initialCharacter);
			//GameInformation.currentMana -= manaCost;
		if(GameInformation.SoldierOrMana == true){
			Character initialCharacter = Instantiate (GameResources.knightCharacter).GetComponent<Character>();
			initialCharacter.name = Time.time.ToString();
			GameInformation.SpawnCharacter (initialCharacter);
			GameInformation.SoldierOrMana = false;
		}
	}

	public void SpawnWolf() {
		int manaCost = GameResources.wolfCharacter.GetComponent<Character>().manaCost;
		if (GameInformation.player1Turn == true && manaCost <= GameInformation.currentMana1) {
			Character initialCharacter = Instantiate(GameResources.wolfCharacter).GetComponent<Character>();
			initialCharacter.name = Time.time.ToString();
			GameInformation.SpawnCharacter(initialCharacter);
			GameInformation.currentMana1 -= manaCost;
		}
		if (GameInformation.player1Turn == false && manaCost <= GameInformation.currentMana2) {
			Character initialCharacter = Instantiate(GameResources.wolfCharacter).GetComponent<Character>();
			initialCharacter.name = Time.time.ToString();
			GameInformation.SpawnCharacter(initialCharacter);
			GameInformation.currentMana2 -= manaCost;
		}
	}

	public void ManaButton(){ 
		if (GameInformation.SoldierOrMana == true){
            if (GameInformation.player1Turn == true) {
                GameInformation.maximumMana1++;
                GameInformation.SoldierOrMana = false;
            } else {
                GameInformation.maximumMana2++;
                GameInformation.SoldierOrMana = false;
            }
		}
	}
}

