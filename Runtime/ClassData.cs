using Sirenix.OdinInspector;
using UnityEngine;

namespace UnityRPGEditor.Editor
{
    [CreateAssetMenu(menuName = "RPG Editor/NewClass")]
    public class ClassData : MonoBehaviour
    {
        [field: SerializeField]
        public string Name { get; private set; }

        [field: SerializeField, TextArea]
        public string Description { get; private set; }

        [field: SerializeField, PreviewField(Height = 100)] // sprite preview with editor height of 100px
        public SkillData Icon { get; private set; }

        [field: SerializeField]
        public SkillData[] Skills { get; private set; }

        [field: SerializeField, InlineEditor] // shows foldout editor for asset
        public ClassData Class { get; private set; }
    }
}
