using System.Collections;
using UnityEngine;

namespace Assets.Scripts.StartScrene
{
    [System.Serializable]
    public class Dialogue
    {
        public string nname;
        [TextArea(1,200)]
        public string[] sentences; 
    }
}