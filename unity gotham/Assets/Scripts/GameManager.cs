using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    Question m_Questions;

    [SerializeField]
    private QuestionData[] m_QuestionsData;
    private int m_CurrentQuestion = 0;//m_CurrentQuestion = index = element
    #region properties

    private bool IsThereANextQuestion
    {
        get
        {
            return m_CurrentQuestion >= m_QuestionsData.Length - 1;
        }
    }

    #endregion
    #region MonoBehaviour Methods

    private void Start()
    {
        AnswerButton.OnAnswered = GoToNextQuestion;
        m_Questions.Initialize(m_QuestionsData[m_CurrentQuestion]);
    }
    #endregion
    #region
    private void GoToNextQuestion()
    {
        if (IsThereANextQuestion)
        {
            m_CurrentQuestion++;
            m_Questions.Initialize(m_QuestionsData[m_CurrentQuestion]);
        }
    }


    #endregion
}
