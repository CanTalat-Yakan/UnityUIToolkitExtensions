using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEssentials
{
    public static class UIToolkitExtensions
    {
        // StyleSheet
        public static void AddStyleSheet(this UIDocument document, StyleSheet styleSheet)
        {
            if (styleSheet != null && !document.rootVisualElement.styleSheets.Contains(styleSheet))
                document.rootVisualElement.styleSheets.Add(styleSheet);
        }

        // Size
        public static void SetSize(this VisualElement element, Vector2 size) => SetSize(element, size.x, size.y);
        public static void SetSize(this VisualElement element, float widthPercent, float heightPercent)
        {
            SetWidth(element, widthPercent);
            SetHeight(element, heightPercent);
        }
        public static void SetSize(this VisualElement element, int width, int height)
        {
            SetWidth(element, width);
            SetHeight(element, height);
        }
        public static void SetWidth(this VisualElement element, float widthPercent) => element.style.width = Length.Percent(widthPercent);
        public static void SetWidth(this VisualElement element, int width) => element.style.width = width;
        public static void SetHeight(this VisualElement element, float heightPercent) => element.style.height = Length.Percent(heightPercent);
        public static void SetHeight(this VisualElement element, int height) => element.style.height = height;


        // Color
        public static void SetColor(this VisualElement element, Color color) => element.style.color = color;
        public static Color SetColorAlpha(this Color color, float alpha) => new Color(color.r, color.g, color.b, alpha);
        public static Color GetColor(this VisualElement element) => element.resolvedStyle.color;
        public static void SetBackgroundColor(this VisualElement element, Color color) => element.style.backgroundColor = color.SetColorAlpha(1);
        public static void SetBackgroundColorWithAlpha(this VisualElement element, Color color) => element.style.backgroundColor = color;
        public static Color GetBackgroundColor(this VisualElement element) => element.resolvedStyle.backgroundColor;

        // Image
        public static void SetBackgroundImage(this VisualElement element, Texture2D texture)
        {
            if (texture != null)
                element.style.backgroundImage = new StyleBackground(texture);
        }
        public static void SetBackgroundImage(this VisualElement element, RenderTexture renderTexture)
        {
            if (renderTexture != null)
                element.style.backgroundImage = new StyleBackground(Background.FromRenderTexture(renderTexture));
        }

        // Display
        public static void SetDisplayEnabled(this VisualElement element, bool enabled) => element.style.display = enabled ? DisplayStyle.Flex : DisplayStyle.None;
        public static bool GetDisplayEnabled(this VisualElement element) => element.resolvedStyle.display != DisplayStyle.None;
    }
}