using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    Question m_Questions;

    [SerializeField]
    private List<QuestionData> m_QuestionsData;

    private int m_CurrentQuestion = 0; //m_CurrentQuestion = index = element
    private IEnumerator m_GoToNextQuestionCoroutine;

    #region properties

    private int CurrentQuestion
    {
        get => m_CurrentQuestion + 1;
    }
    private bool IsThereANextQuestion
    {
        get
        {
            return CurrentQuestion < m_QuestionsData.Count;
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
        if (IsThereANextQuestion && m_GoToNextQuestionCoroutine == null)
        {
            m_GoToNextQuestionCoroutine = GoToNextQuestionCoroutine();
            StartCoroutine(m_GoToNextQuestionCoroutine);
        }
    }
    private IEnumerator GoToNextQuestionCoroutine()
    {
        //A function that can yield when others cant
        yield return new WaitForSecondsRealtime(5);
        m_CurrentQuestion++;
        m_Questions.Initialize(m_QuestionsData[m_CurrentQuestion]);
        m_GoToNextQuestionCoroutine = null;
    }


    #endregion
}