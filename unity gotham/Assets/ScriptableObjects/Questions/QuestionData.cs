using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Question")]
public class QuestionData : ScriptableObject {
	#region SerializeFields

	[SerializeField]
	[TextArea(1, 5)]
	private string m_QuestionMessage;

	[SerializeField]
	private Sprite m_BackgroundImage;

	[SerializeField]
	private AnswerData[] m_AnswersData;

	#endregion


	#region Public Properties

	// Three different styles to write a property
	// that only has a getter that returns a value
	// they are all equivalent to each other

	public string QuestionMessage => m_QuestionMessage;

	public Sprite BackgroundImage {
		get => m_BackgroundImage;
	}

	public AnswerData[] AnswersData {
		get { return m_AnswersData; }
	}

	#endregion
}