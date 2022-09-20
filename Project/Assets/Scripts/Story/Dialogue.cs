using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{
    [TextArea(1, 10)]
    public string[] Names;
    [TextArea(3, 10)]
    public string[] Sentences;
}
