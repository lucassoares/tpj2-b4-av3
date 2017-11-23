using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class PontuacaoUi : MonoBehaviour
{
	public Pontuacao pontuacao;

	public Text pontuacaoText;
	public Text puloText;

	public string pontuacaoFormat = "Pontuacao: {0}";
	public string puloFormat = "Pontuacao: {0}";

	private void Update()
	{
		pontuacaoText.text = string.Format( pontuacaoFormat, pontuacao.pontos );
		puloText.text = string.Format( puloFormat, pontuacao.pulos );
	}
}
