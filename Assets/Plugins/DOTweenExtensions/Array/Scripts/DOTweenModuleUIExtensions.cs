using System.Collections.Generic;
using System.Globalization;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace DOTweenExtensions.Array
{
    public static class DOTweenModuleUIExtensions
    {
        #region CanvasGroup

        public static Sequence DOFade(this CanvasGroup[] targetArray,
            float endValue, float eachDuration, float eachInterval = 0)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DOFade(endValue, eachDuration).SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DOFade(this List<CanvasGroup> targetArray,
            float endValue, float eachDuration, float eachInterval = 0)
        {
            return targetArray.ToArray().DOFade(endValue, eachDuration, eachInterval);
        }

        #endregion
    
        #region Graphic

        public static Sequence DOColor(this Graphic[] targetArray,
            Color endValue, float eachDuration, float eachInterval = 0)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DOColor(endValue, eachDuration).SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DOColor(this List<Graphic> targetArray,
            Color endValue, float eachDuration, float eachInterval = 0)
        {
            return targetArray.ToArray().DOColor(endValue, eachDuration, eachInterval);
        }

        public static Sequence DOFade(this Graphic[] targetArray,
            float endValue, float eachDuration, float eachInterval = 0)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DOFade(endValue, eachDuration).SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DOFade(this List<Graphic> targetArray,
            float endValue, float eachDuration, float eachInterval = 0)
        {
            return targetArray.ToArray().DOFade(endValue, eachDuration, eachInterval);
        }

        #endregion

        #region Image

        public static Sequence DOColor(this Image[] targetArray,
            Color endValue, float eachDuration, float eachInterval = 0)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DOColor(endValue, eachDuration).SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DOColor(this List<Image> targetArray,
            Color endValue, float eachDuration, float eachInterval = 0)
        {
            return targetArray.ToArray().DOColor(endValue, eachDuration, eachInterval);
        }

        public static Sequence DOFade(this Image[] targetArray,
            float endValue, float eachDuration, float eachInterval = 0)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DOFade(endValue, eachDuration).SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DOFade(this List<Image> targetArray,
            float endValue, float eachDuration, float eachInterval = 0)
        {
            return targetArray.ToArray().DOFade(endValue, eachDuration, eachInterval);
        }

        public static Sequence DOFillAmount(this Image[] targetArray,
            float endValue, float eachDuration, float eachInterval = 0)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DOFillAmount(endValue, eachDuration).SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DOFillAmount(this List<Image> targetArray,
            float endValue, float eachDuration, float eachInterval = 0)
        {
            return targetArray.ToArray().DOFillAmount(endValue, eachDuration, eachInterval);
        }

        public static Sequence DOGradientColor(this Image[] targetArray,
            Gradient endValue, float eachDuration, float eachInterval = 0)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DOGradientColor(endValue, eachDuration).SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DOGradientColor(this List<Image> targetArray,
            Gradient endValue, float eachDuration, float eachInterval = 0)
        {
            return targetArray.ToArray().DOGradientColor(endValue, eachDuration, eachInterval);
        }

        #endregion
    
        #region RectTransform

        public static Sequence DOAnchorPos(this RectTransform[] targetArray,
            Vector2 endValue, float eachDuration, float eachInterval = 0, bool snapping = false)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DOAnchorPos(endValue, eachDuration, snapping).SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DOAnchorPos(this List<RectTransform> targetArray,
            Vector2 endValue, float eachDuration, float eachInterval = 0, bool snapping = false)
        {
            return targetArray.ToArray().DOAnchorPos(endValue, eachDuration, eachInterval, snapping);
        }

        public static Sequence DOAnchorPosX(this RectTransform[] targetArray,
            float endValue, float eachDuration, float eachInterval = 0, bool snapping = false)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DOAnchorPosX(endValue, eachDuration, snapping).SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DOAnchorPosX(this List<RectTransform> targetArray,
            float endValue, float eachDuration, float eachInterval = 0, bool snapping = false)
        {
            return targetArray.ToArray().DOAnchorPosX(endValue, eachDuration, eachInterval, snapping);
        }

        public static Sequence DOAnchorPosY(this RectTransform[] targetArray,
            float endValue, float eachDuration, float eachInterval = 0, bool snapping = false)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DOAnchorPosY(endValue, eachDuration, snapping).SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DOAnchorPosY(this List<RectTransform> targetArray,
            float endValue, float eachDuration, float eachInterval = 0, bool snapping = false)
        {
            return targetArray.ToArray().DOAnchorPosY(endValue, eachDuration, eachInterval, snapping);
        }

        public static Sequence DOAnchorMax(this RectTransform[] targetArray,
            Vector2 endValue, float eachDuration, float eachInterval = 0, bool snapping = false)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DOAnchorMax(endValue, eachDuration, snapping).SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DOAnchorMax(this List<RectTransform> targetArray,
            Vector2 endValue, float eachDuration, float eachInterval = 0, bool snapping = false)
        {
            return targetArray.ToArray().DOAnchorMax(endValue, eachDuration, eachInterval, snapping);
        }

        public static Sequence DOAnchorMin(this RectTransform[] targetArray,
            Vector2 endValue, float eachDuration, float eachInterval = 0, bool snapping = false)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DOAnchorMin(endValue, eachDuration, snapping).SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DOAnchorMin(this List<RectTransform> targetArray,
            Vector2 endValue, float eachDuration, float eachInterval = 0, bool snapping = false)
        {
            return targetArray.ToArray().DOAnchorMin(endValue, eachDuration, eachInterval, snapping);
        }

        public static Sequence DOPivot(this RectTransform[] targetArray,
            Vector2 endValue, float eachDuration, float eachInterval = 0)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DOPivot(endValue, eachDuration).SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DOPivot(this List<RectTransform> targetArray,
            Vector2 endValue, float eachDuration, float eachInterval = 0)
        {
            return targetArray.ToArray().DOPivot(endValue, eachDuration, eachInterval);
        }

        public static Sequence DOPivotX(this RectTransform[] targetArray,
            float endValue, float eachDuration, float eachInterval = 0)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DOPivotX(endValue, eachDuration).SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DOPivotX(this List<RectTransform> targetArray,
            float endValue, float eachDuration, float eachInterval = 0)
        {
            return targetArray.ToArray().DOPivotX(endValue, eachDuration, eachInterval);
        }

        public static Sequence DOPivotY(this RectTransform[] targetArray,
            float endValue, float eachDuration, float eachInterval = 0)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DOPivotY(endValue, eachDuration).SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DOPivotY(this List<RectTransform> targetArray,
            float endValue, float eachDuration, float eachInterval = 0)
        {
            return targetArray.ToArray().DOPivotY(endValue, eachDuration, eachInterval);
        }

        public static Sequence DOSizeDelta(this RectTransform[] targetArray,
            Vector2 endValue, float eachDuration, float eachInterval = 0)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DOSizeDelta(endValue, eachDuration).SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DOSizeDelta(this List<RectTransform> targetArray,
            Vector2 endValue, float eachDuration, float eachInterval = 0)
        {
            return targetArray.ToArray().DOSizeDelta(endValue, eachDuration, eachInterval);
        }


        #endregion

        #region Text

        public static Sequence DOColor(this Text[] targetArray,
            Color endValue, float eachDuration, float eachInterval = 0)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DOColor(endValue, eachDuration).SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DOColor(this List<Text> targetArray,
            Color endValue, float eachDuration, float eachInterval = 0)
        {
            return targetArray.ToArray().DOColor(endValue, eachDuration, eachInterval);
        }

        public static Sequence DOFade(this Text[] targetArray,
            float endValue, float eachDuration, float eachInterval = 0)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DOFade(endValue, eachDuration).SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DOFade(this List<Text> targetArray,
            float endValue, float eachDuration, float eachInterval = 0)
        {
            return targetArray.ToArray().DOFade(endValue, eachDuration, eachInterval);
        }


        public static Sequence DOCounter(this Text[] targetArray, 
            int fromValue, int endValue, float duration, float eachInterval, bool addThousandsSeparator = true, CultureInfo culture = null)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DOCounter(fromValue, endValue, duration, addThousandsSeparator, culture).SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DOCounter(this List<Text> targetArray,
            int fromValue, int endValue, float duration, float eachInterval, bool addThousandsSeparator = true, CultureInfo culture = null)
        {
            return targetArray.ToArray().DOCounter(fromValue, endValue, duration, eachInterval, addThousandsSeparator, culture);
        }

        public static Sequence DOText(this Text[] targetArray,
            string endValue, float duration, float eachInterval, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, string scrambleChars = null)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DOText(endValue, duration, richTextEnabled, scrambleMode, scrambleChars).SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DOText(this List<Text> targetArray,
            string endValue, float duration, float eachInterval, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, string scrambleChars = null)
        {
            return targetArray.ToArray().DOText(endValue, duration, eachInterval, richTextEnabled, scrambleMode, scrambleChars);
        }

        #endregion
    }
}