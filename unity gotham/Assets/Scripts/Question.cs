using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question : MonoBehaviour
{
	#region SerializeFields

	[SerializeField] Text m_QuestionText;

	[SerializeField] AnswerButton[] m_AnswerButtons;

	[SerializeField] Image m_BackgroundImage;
	
	#endregion


	#region Public Methods

	public void Initialize(QuestionData questionData) {
		m_QuestionText.text = questionData.QuestionMessage;
		m_BackgroundImage.sprite = questionData.BackgroundImage;
		for (int i = 0; i < m_AnswerButtons.Length; i++) 
		{
			m_AnswerButtons[i].Initialized(questionData.AnswersData[i]);
		}
	}

	#endregion
}
