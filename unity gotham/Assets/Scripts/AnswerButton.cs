using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AnswerButton : MonoBehaviour
{

    #region SerializeFields

    [SerializeField] private Text m_AnswerText;

    #endregion


    #region Private/Internal Fields

    private AnswerObject m_AnswerObject;

    #endregion


    #region Internal Methods/Functions

    public void Initialized(AnswerObject answerObject)
    {
        m_AnswerObject = answerObject;
        m_AnswerText.text = answerObject.Answer;
    }

    #endregion
    #region public methods  
    public void AnswerClicked() {
        if (m_AnswerObject.IsCorrect)
        {
            Debug.Log("Correct");
        }
        else {
            Debug.Log("Wrong");
        }  
    }

    #endregion
}
