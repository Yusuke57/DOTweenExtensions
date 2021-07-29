using System.Collections.Generic;
using System.Globalization;
using DG.Tweening;
using TMPro;
using UnityEngine;

namespace DOTweenExtensions.Array
{
    public static class DOTweenTextMeshProExtensions
    {
        public static Sequence DOColor(this TextMeshProUGUI[] targetArray,
            Color endValue, float eachDuration, float eachInterval = 0)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DOColor(endValue, eachDuration).SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DOColor(this List<TextMeshProUGUI> targetArray,
            Color endValue, float eachDuration, float eachInterval = 0)
        {
            return targetArray.ToArray().DOColor(endValue, eachDuration, eachInterval);
        }

        public static Sequence DOFade(this TextMeshProUGUI[] targetArray,
            float endValue, float eachDuration, float eachInterval = 0)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DOFade(endValue, eachDuration).SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DOFade(this List<TextMeshProUGUI> targetArray,
            float endValue, float eachDuration, float eachInterval = 0)
        {
            return targetArray.ToArray().DOFade(endValue, eachDuration, eachInterval);
        }

        public static Sequence DOCounter(this TextMeshProUGUI[] targetArray,
            int fromValue, int endValue, float duration, float eachInterval, bool addThousandsSeparator = true,
            CultureInfo culture = null)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DOCounter(fromValue, endValue, duration, addThousandsSeparator, culture)
                    .SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DOCounter(this List<TextMeshProUGUI> targetArray,
            int fromValue, int endValue, float duration, float eachInterval, bool addThousandsSeparator = true,
            CultureInfo culture = null)
        {
            return targetArray.ToArray()
                .DOCounter(fromValue, endValue, duration, eachInterval, addThousandsSeparator, culture);
        }

        public static Sequence DOText(this TextMeshProUGUI[] targetArray,
            string endValue, float duration, float eachInterval, bool richTextEnabled = true,
            ScrambleMode scrambleMode = ScrambleMode.None, string scrambleChars = null)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DOText(endValue, duration, richTextEnabled, scrambleMode, scrambleChars)
                    .SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DOText(this List<TextMeshProUGUI> targetArray,
            string endValue, float duration, float eachInterval, bool richTextEnabled = true,
            ScrambleMode scrambleMode = ScrambleMode.None, string scrambleChars = null)
        {
            return targetArray.ToArray()
                .DOText(endValue, duration, eachInterval, richTextEnabled, scrambleMode, scrambleChars);
        }
    }
}