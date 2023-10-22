// using System;

// public class Reference {
//      private List<Word> wordList = new List<Word>();
//     public Reference() {
//         string scrip = "Therefore, fear not, little flock; do good; let earth and hell combine against you, for if ye are built upon my rock, they cannot prevail";
//         string[] words = scrip.Split(' ');
//         foreach (var word in words)
//         {
//             Word wordToAdd = new Word();
//             wordToAdd.newWord = word;
//             wordList.Add(wordToAdd);
//         }
//     }

//     public void Display() {
//      Console.Write("Docterine and Covenants 6:35-36 ");
//         foreach (var word in wordList)
//         {
//             word.Display();
//         }
//      Console.Write("\n\nPress enter to continue or type 'quit' to finish :");
//     }

//     public void EnterPressed() {
//         wordList[0].shouldShowUnderscore = true;
//         wordList[1].shouldShowUnderscore = true;
//         wordList[2].shouldShowUnderscore = true;
//     }
// }