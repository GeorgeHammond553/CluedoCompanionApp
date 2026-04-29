using System.Collections;
using UnityEngine;
using UnityEngine.UI; 

public class DiceRoller : MonoBehaviour
{
    [Header("UI References")]
    public Image die1Image;
    public Image die2Image;
    public Button rollButton;

    [Header("Dice Art")]
    [Tooltip("Drag your 6 dice sprites here in order (1 to 6)")]
    public Sprite[] diceFaces; 


    public void OnRollButtonClicked()
    {

        StartCoroutine(RollTheDice());
    }

    private IEnumerator RollTheDice()
    {
      
        rollButton.interactable = false;

        float rollDuration = 1.0f; 
        float elapsedTime = 0f;

        
        while (elapsedTime < rollDuration)
        {
            die1Image.sprite = diceFaces[Random.Range(0, 6)];
            die2Image.sprite = diceFaces[Random.Range(0, 6)];

            elapsedTime += 0.1f; 
            yield return new WaitForSeconds(0.1f); 
        }

      
        int finalRoll1 = Random.Range(0, 6);
        int finalRoll2 = Random.Range(0, 6);

        die1Image.sprite = diceFaces[finalRoll1];
        die2Image.sprite = diceFaces[finalRoll2];

    
        Debug.Log("You rolled a " + (finalRoll1 + 1) + " and a " + (finalRoll2 + 1) + "!");

        rollButton.interactable = true;
    }
}
