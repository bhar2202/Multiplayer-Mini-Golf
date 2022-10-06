using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StatusController : MonoBehaviour
{
   public const string WaitingOnMatch = "Waiting on match...";
   public const string YouWon = "You Won!";
   public const string YouLost = "You Lost!";
   public const string Playing = "Match found!";
   public const string GameOver = "Game Over";

   private Text _outcomeText;
   
   public void SetText(string text) {
      _outcomeText.text = text;
        if (text.Equals(Playing))
        {
            SceneManager.LoadScene("Level_01");
        }
   }

   void Start()
   {
      _outcomeText = GetComponent<Text>();
      _outcomeText.text = WaitingOnMatch;
   }

   public bool IsGamePlayActive() {
      return _outcomeText.text == Playing;
   }
}
