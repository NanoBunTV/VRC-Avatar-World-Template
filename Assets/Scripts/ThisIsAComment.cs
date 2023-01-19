using UnityEngine;
// Attach this script to any GameObject for which you want to put a note.
public class ThisIsAComment : MonoBehaviour
{
    [TextArea]
    public string Comment = "";
}