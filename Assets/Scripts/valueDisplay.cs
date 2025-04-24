using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace TowerDefense
{
    // Require text component!
    [RequireComponent(typeof(Text))]
    public class ValueDisplay : MonoBehaviour
    {
        public static UnityEvent<string, object> OnValueChanged = new UnityEvent<string, object>();
    }

    [SerializeField] private string valueName = ""; // Name of value for this script
    private Text displayText; // UI component to display value

    private void Awake()
    {
        displayText = GetComponent<Text>();
        OnValueChanged.AddListener(ValueChanged);
    }

    void ValueChanged(string valueName, object value)
    {
        if (this.valueName == valueName)
        {
            displayText.text = value.ToString();
        }
    }
}
