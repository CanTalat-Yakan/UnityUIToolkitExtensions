using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEssentials
{
    public static class UIToolkitExtensions
    {
        public static VisualElement SetSize(this VisualElement element, Vector2 size) =>
            SetSize(element, size.x, size.y);

        public static VisualElement SetSize(this VisualElement element, float widthPercent, float heightPercent)
        {
            SetWidth(element, widthPercent);
            SetHeight(element, heightPercent);

            return element;
        }

        public static VisualElement SetSize(this VisualElement element, int width, int height)
        {
            SetWidth(element, width);
            SetHeight(element, height);

            return element;
        }

        public static VisualElement SetWidth(this VisualElement element, float widthPercent)
        {
            element.style.width = Length.Percent(widthPercent);

            return element;
        }

        public static VisualElement SetWidth(this VisualElement element, int width)
        {
            element.style.width = width;

            return element;
        }

        public static VisualElement SetHeight(this VisualElement element, float heightPercent)
        {
            element.style.height = Length.Percent(heightPercent);

            return element;
        }

        public static VisualElement SetHeight(this VisualElement element, int height)
        {
            element.style.height = height;

            return element;
        }

        public static VisualElement SetBackgroundColor(this VisualElement element, Color color)
        {
            element.style.backgroundColor = color;

            return element;
        }

        public static VisualElement SetImage(this VisualElement element, Texture2D texture)
        {
            element.style.backgroundImage = new StyleBackground(texture);

            return element;
        }

        public static VisualElement SetImage(this VisualElement element, RenderTexture renderTexture)
        {
            element.style.backgroundImage = new StyleBackground(Background.FromRenderTexture(renderTexture));
            return element;
        }

        public static void AddStyleSheet(this UIDocument document, StyleSheet styleSheet) =>
            document.rootVisualElement.styleSheets.Add(styleSheet);
    }
}