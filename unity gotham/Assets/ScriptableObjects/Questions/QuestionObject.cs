using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionObject : ScriptableObject
{
    [TextArea(1, 5)]
    [SerializeField] string m_Question;


}
