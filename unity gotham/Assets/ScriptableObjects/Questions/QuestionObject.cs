using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Question")]
public class QuestionObject : ScriptableObject
{
    [TextArea(1, 5)]
    [SerializeField] string m_Question;

    AnswerObject[] m_AnswerObjects;
}
