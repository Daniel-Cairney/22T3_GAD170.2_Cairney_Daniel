using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Math;
namespace CairneyDaniel
{
    public class Fish : MonoBehaviour
    {
        public string species;
        public float value;
        public int length;
        // these are the vlaues the script will randomly calculate the species vlaue and lenghth from

        private string[] speciesArray = new string[7] { "Damselfish", "Ebonkoi", "Golden Karp", "Prismite", "Flarekin Koi", "Bass", "Flouder" };
        // this array is a array of fish species that the script picks randomly from these beautiful names have totoally not been stolen from Terraria

        private void SetFishStats()
        {

            species = speciesArray[Random.Range(1, 7)];
            length = Random.Range(27, 306);
            value = (float) System.Math.Round(length * Random.Range(2.0f, 5.0f), 2);
            // this fish stats method picks a random fish species from the array, gives it a random lenght from 27 to 306
            // then the value is calculated with the privously calculated length, then multiplied by a random number from 2 to 5 times. 
            // the numbers are calculated by two decimals as it will be later shown to be in dollars where it would have cents.
        }

        private void Awake()
        {
            SetFishStats();
        }


    }
}