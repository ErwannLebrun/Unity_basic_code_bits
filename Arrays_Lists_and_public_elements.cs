/*
* Copyright (c) Erwann Lebrun
* https://www.linkedin.com/in/erwann-lebrun-b1bbb559/
*/

using System.Collections.Generic;   // required to use Lists
using UnityEngine;
using Unity.Entities;   // required for ECS

namespace Erwann
{
    public class Arrays_Lists_and_public_elements : MonoBehaviour
    {
        #region InspectorNONInteractiveElements

        private float privateValue = 15f;       // private means that it is accessible to this script alone        
        
        public int publicValue = 2;             // public means that it is accessible from other scripts (don't forget the namespace though)

        [SerializeField]        // use to be able to show and modify a private value in the Inspector (can be inline with the line below also)
        private string privateText = "This is a test";

        [HideInInspector]       // conversely this would NOT show in the Inspector
        public int publicValue2 = 17;

        #endregion

        #region InspectorInteractiveElements

        // setup to get a dropdown menu in the Inspector:
        public enum dropdownMenuOptions {
        Low = 100,
        Medium = 200,
        High = 300,
        SuperHard = 400,
        DeathNow = 500,
        }
        public dropdownMenuOptions selectedOption;
//-------------------------------------------------------------------------------------------------------------
        // Checkbox (boolean):
        public bool checkbox;
//-------------------------------------------------------------------------------------------------------------
        // declares an array that is 4 elements long (size is NOT adjustable, or not easily)
        public string[] ArrayName = new string[4];

        // Audio clips as array (but can be anything; e.g., GameObjects/cubes!!):
        public AudioClip[] sounds;

        public GameObject[] cubes = new GameObject[4];
//-------------------------------------------------------------------------------------------------------------
        // declares a new List of string that can be any lenght (size is adjustable)
        public List<string> familyNamesList = new List<string>();

        #endregion

        // EXAMPLE OF HOW TO USE LISTS:
        void Start()
        {
            // very easy to add items to a list:
            familyNamesList.Add("Bob");
            familyNamesList.Add("Greg");
            
            // Add: This adds an object at the end of List.
            // Remove: This removes the first occurrence of a specific object from List.
            // Clear: This removes all elements from List.
            // Contains: This determines whether an element is in List or not. It is very useful to check whether an element is stored in the list.
            // Insert: This inserts an element into List at the specified index.
            // ToArray: This copies the elements of List to a new array.

            string listElementUpdated = familyNamesList[0];
            Debug.Log("List element [0] after Start() = " + listElementUpdated);
        }
    }
}
