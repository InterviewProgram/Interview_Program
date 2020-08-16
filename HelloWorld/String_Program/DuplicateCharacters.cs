using System.Text;

namespace String_Interview_Programm
{
    public class DuplicateCharacters
    {
        //Find the duplicate character  
        public StringBuilder GetDuplicateCharacter(string str)
        {
            StringBuilder result = new StringBuilder();
            StringBuilder duplicateChar = new StringBuilder();

            foreach (var item in str)
            {
                if (result.ToString().IndexOf(item.ToString().ToLower()) == -1)
                {
                    result.Append(item);
                }
                else
                {
                    duplicateChar.Append(item);
                }
            }

            return duplicateChar;
        }
    }
}
