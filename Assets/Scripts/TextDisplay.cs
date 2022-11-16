using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
namespace CairneyDaniel
{

    
    public class TextDisplay : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI textField;
        
        public void AddText(string message)
        {
            textField.text += (message + "<br>");
            //to change the text i need to edit the text value of the textfield variable
            // the <br> adds a line break
        }


        public void ClearText()
        {
            textField.text = "";
            //this clears the UI completely every time the cleartext method is called
        }

    }

}