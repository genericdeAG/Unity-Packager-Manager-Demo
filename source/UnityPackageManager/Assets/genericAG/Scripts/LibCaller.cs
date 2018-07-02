using TMPro;
using UnityDotNetLibrary;
using UnityEngine;

namespace genericAG.Scripts
{
    public class LibCaller : MonoBehaviour
    {
        [SerializeField]
        private TextMeshProUGUI _constantContent;
        [SerializeField]
        private TextMeshProUGUI _methodContent;

        private void Start()
        {
            _constantContent.text = Library.Constant;
            var val1 = Random.Range(0f, 500f);
            var val2 = Random.Range(0f, 500f);
            _methodContent.text = $"{val1:.##} + {val2:.##} = {Library.Add(val1, val2):.##}";
        }
    }
}
