using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class ViewChanger : MonoBehaviour
    {
        UIstateMachineManager UIstateMachineManager;

        private void Start()
        {
            UIstateMachineManager = FindObjectOfType<UIstateMachineManager>();
             
        }

        public void MainMenu()
        {
            UIstateMachineManager.changeState(UIstateMachineManager.GameState.MainMenu);
        }

        public void Option()
        {
            UIstateMachineManager.changeState(UIstateMachineManager.GameState.OptionMenu);
        }

        public void SinglePlayer()
        {
            UIstateMachineManager.changeState(UIstateMachineManager.GameState.SinglePlayerMenu);
        }

        public void Quit()
        {
            Debug.Log("You Quit Unity");
            Application.Quit();
        }
    }
}