using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIstateMachineManager : MonoBehaviour
{
    Canvas mainMenuCanvas;
    Canvas OptionCanwas;
    Canvas singlePlayercanvas;

    public enum GameState
    {
        MainMenu,
        OptionMenu,
        SinglePlayerMenu,
    }

    public GameState currentState;

    private void Start()
    {
        mainMenuCanvas = GameObject.Find("MainMenu Canvas").gameObject.GetComponent<Canvas>();
        OptionCanwas = GameObject.Find("Option Canvas").gameObject.GetComponent<Canvas>();
        singlePlayercanvas = GameObject.Find("Single Player Canvas").gameObject.GetComponent<Canvas>();
        changeState(GameState.MainMenu);
    }

    private void Update()
    {
        
    }

    /*------------------Game Statss-----------------------*/
    /*--Main MEnu---------------*/
    IEnumerator MainMenuState()
    {
        mainMenuCanvas.enabled = true;
        while(currentState == GameState.MainMenu)
        {
            yield return null;
        }
        mainMenuCanvas.enabled = false;
    }

    /*--Option Menu---------------*/
    IEnumerator OptionMenuState()
    {
        OptionCanwas.enabled = true;
        while (currentState == GameState.OptionMenu)
        {
            yield return null;
        }
        OptionCanwas.enabled = false;
    }
    
    /*--Single Player Menu---------------*/
    IEnumerator SinglePlayerMenuState()
    {
        singlePlayercanvas.enabled = true;
        while (currentState == GameState.SinglePlayerMenu)
        {
            yield return null;
        }
        singlePlayercanvas.enabled = false;
    }

    public void changeState (GameState newState)
    {
        currentState = newState;
        StartCoroutine(newState.ToString() + "State");
    }
}
