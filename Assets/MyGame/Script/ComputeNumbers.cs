using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ComputeNumbers : MonoBehaviour
{ 
    public TextMeshProUGUI result;

    public TMP_InputField leftNumber;
    public TMP_InputField rightNumber;

    public Button btnReset;
    public Button btnResult;


public void SetResult()
{
    result.text = AddNumbers().ToString();

        leftNumber.interactable = false;
        rightNumber.interactable = false;

            btnResult.interactable = false;
            btnReset.interactable = true;
}

public void Reset()
{
    leftNumber.text = "";
    rightNumber.text = "";

        leftNumber.interactable = true;
        rightNumber.interactable = true;

           btnResult.interactable = true;
           btnReset.interactable = false;

    result.text = "Result";
}

private float AddNumbers()
{
    float tempResult = float.Parse(leftNumber.text) - float.Parse(rightNumber.text);
    
    return tempResult;
}
}