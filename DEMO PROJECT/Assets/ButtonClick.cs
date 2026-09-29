using UnityEngine;
using TMPro;

public class ButtonClick : MonoBehaviour
{
    public TextMeshProUGUI textbox;
    private string tempString;
    public void OnClick()
    {
        textbox.text = "i have changed therewasahealing";
    }

}
