using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AnswerButton : MonoBehaviour
{

    #region SerializeFields
    //serialisedField expose a private variable to the inspector window in unity.
    [SerializeField] private Text m_AnswerText;
    [SerializeField] private Image m_Image;
    [SerializeField] private Sprite m_CheckMarkSprite;
    [SerializeField] private Sprite m_ExMarkSprite;

    #endregion


    #region Private/Internal Fields

    private AnswerObject m_AnswerObject;

    #endregion


    #region Public Methods/Functions

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
            ApplingCheckMark();
        }
        else {
            Debug.Log("Wrong");
            ApplingExMark();
        }
    }

    #endregion
    #region Internal Methods/Functions
    private void ApplingCheckMark() {
        m_Image.sprite = m_CheckMarkSprite;
        m_AnswerText.text = string.Empty;
    }
    private void ApplingExMark() {
        m_Image.sprite = m_ExMarkSprite;
        m_AnswerText.text = "";
    }
    #endregion
}
