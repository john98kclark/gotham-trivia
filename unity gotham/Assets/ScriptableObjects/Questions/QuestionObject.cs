using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Question")]
public class QuestionObject : ScriptableObject
{
    [TextArea(1, 5)]
   public  string m_Question;

    public AnswerObject[] m_AnswerObjects;
}
