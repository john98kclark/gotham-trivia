using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Answer")]
public class AnswerObject : ScriptableObject
{
   public string m_Answer;
    [SerializeField] bool m_IsCorrect;
}
