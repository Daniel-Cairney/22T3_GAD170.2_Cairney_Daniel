using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
namespace CairneyDaniel
{


    public class Aquarium : MonoBehaviour
    {
        [SerializeField] private GameObject fishPrefab;
        private GameObject newFishGO;
        private Fish newFish;
        [SerializeField] private List<Fish> fishList = new List<Fish>();
        private Fish smallestFish;
        [SerializeField] private TextDisplay textDisplay;
        //this is where i declare my variables for my fish gameoject as the spawnfish method below will work of of this variable
        // this is the same for my smallestfish that is used to go through the list and check the smallest fish in the list where 
        //the caught fish are stored
        private void Start()
        {
            textDisplay.ClearText();
        }
        // clears the UI of text 

        public void SpawnFish()
        {
            newFishGO = Instantiate(fishPrefab, transform);
            newFish = newFishGO.GetComponent<Fish>();
            textDisplay.ClearText();
            textDisplay.AddText("You reeled in a " + newFish.species + " That is " + newFish.length + " CM long and is worth $" + newFish.value);
            // the instantiate created a fish game object that come with the data values from the fish script
            // the text displays make it so the player can see the species length and worth on the UI 
        }
        
        public void KeepFish()
        {
           if (fishList.Any())
            {
                if (newFish.length >= smallestFish.length * 2)
                {
                    fishList.Remove(smallestFish);
                    Destroy(smallestFish.gameObject);
                    Debug.Log("That tiny fish just got rolled and munched get gud");
                    textDisplay.ClearText();
                    textDisplay.AddText("That tiny fish just got rolled and munched get gud");
                
                   // this part of the keepfish method is for if the smallest fish is two times smaller then the fihs you caught 
                   //it will check the list and destory that fish gameoject from the list whilst saying get gud :) 

                
                }
              
                fishList.Add(newFish);
                Debug.Log("The fish just got DUNKED in the aquarium");
                
                textDisplay.AddText("A " + newFish.length + "cm long " + newFish.species + " was DUNKED to your aquarium");
                smallestFish = null;
                // this part of the method is when the player keeps the fish and adds it to the aquarium (the list), it shows the player on the UI the fish species and length when it enters the aquarium
                
                foreach (Fish fish in fishList)
               
                {
                    if (smallestFish == null || fish.length < smallestFish.length)
                    {
                        smallestFish = fish;
                       
                        // this if statement is for the first fish that is put into the aquarium (the null for no fish in the aqarium)
                        // and it checks the other fishes in the list for the smallest size and assigns it as the smallest fish
                    }
                }
            
            }
            else
            {
                fishList.Add(newFish);
                smallestFish = newFish;
                Debug.Log("Your first fish has been DUNKED in the aqarium");
         
            }   

      
        }   
        
        public void DiscardFish()
        {
            Destroy(newFishGO);
            Debug.Log("You YEETED that fish back into the wet waters");
            textDisplay.ClearText();
            textDisplay.AddText("You YEETED that fish back into the wet waters");
        } // if the player does not keep the fish it destoys the game object and tells the player on the UI that they threw the fish away

    
    
    
    
    }   




}