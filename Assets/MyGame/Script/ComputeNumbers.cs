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
    private const string FinalResult = "Result";


public void SetResult()
{

// Set Result
    result.text = SubNumbers().ToString();

    
//no interaction with inputfields
        leftNumber.interactable = false;
        rightNumber.interactable = false;

//activate Reset Button
            btnResult.interactable = false;
            btnReset.interactable = true;
}

public void Reset()
{

//Reset both Inputfields back to "Add Number" (reset)
    leftNumber.text = "";
    rightNumber.text = "";

//interact with inputfields
        leftNumber.interactable = true;
        rightNumber.interactable = true;

//activate Buttons
           btnResult.interactable = true;
           btnReset.interactable = false;

// Reset Result Text
    result.text = FinalResult;
}

private float SubNumbers()
{
    float tempResult = float.Parse(leftNumber.text) - float.Parse(rightNumber.text);
    
    return tempResult;
}
}