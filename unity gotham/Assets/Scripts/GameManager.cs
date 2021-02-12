using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    int m_CurrentQuestion = 0;
    [SerializeField] QuestionObject[] m_Questions;

    [SerializeField] Text m_QuestionText;


    [SerializeField] AnswerButton[] m_AnswerButtons;

    // Start is called before the first frame update
    void Start()
    {
        //Setting the current question from our m_Questions array to the m_QuestionsText component in the scene.
        m_QuestionText.text = m_Questions[m_CurrentQuestion].m_Question;
        for (int i = 0; i < m_AnswerButtons.Length; i++) 
        {
            m_AnswerButtons[i].Initialized(m_Questions[m_CurrentQuestion].m_AnswerObjects[i]);
           
        }
        Debug.Log("Hello Gotham");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
