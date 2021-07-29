using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace DOTweenExtensions.Array
{
    public static class DOTweenTransformExtensions
    {
        #region Move
    
        public static Sequence DOMove(this Transform[] targetArray,
            Vector3 endValue, float eachDuration, float eachInterval = 0, bool snapping = false)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DOMove(endValue, eachDuration, snapping).SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DOMove(this List<Transform> targetArray,
            Vector3 endValue, float eachDuration, float eachInterval = 0, bool snapping = false)
        {
            return targetArray.ToArray().DOMove(endValue, eachDuration, eachInterval, snapping);
        }

        public static Sequence DOMoveX(this Transform[] targetArray,
            float endValue, float eachDuration, float eachInterval = 0, bool snapping = false)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DOMoveX(endValue, eachDuration, snapping).SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DOMoveX(this List<Transform> targetArray,
            float endValue, float eachDuration, float eachInterval = 0, bool snapping = false)
        {
            return targetArray.ToArray().DOMoveX(endValue, eachDuration, eachInterval, snapping);
        }

        public static Sequence DOMoveY(this Transform[] targetArray,
            float endValue, float eachDuration, float eachInterval = 0, bool snapping = false)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DOMoveY(endValue, eachDuration, snapping).SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DOMoveY(this List<Transform> targetArray,
            float endValue, float eachDuration, float eachInterval = 0, bool snapping = false)
        {
            return targetArray.ToArray().DOMoveY(endValue, eachDuration, eachInterval, snapping);
        }

        public static Sequence DOMoveZ(this Transform[] targetArray,
            float endValue, float eachDuration, float eachInterval = 0, bool snapping = false)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DOMoveZ(endValue, eachDuration, snapping).SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DOMoveZ(this List<Transform> targetArray,
            float endValue, float eachDuration, float eachInterval = 0, bool snapping = false)
        {
            return targetArray.ToArray().DOMoveZ(endValue, eachDuration, eachInterval, snapping);
        }
    
        #endregion
        #region LocalMove
    
        public static Sequence DOLocalMove(this Transform[] targetArray,
            Vector3 endValue, float eachDuration, float eachInterval = 0, bool snapping = false)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DOLocalMove(endValue, eachDuration, snapping).SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DOLocalMove(this List<Transform> targetArray,
            Vector3 endValue, float eachDuration, float eachInterval = 0, bool snapping = false)
        {
            return targetArray.ToArray().DOLocalMove(endValue, eachDuration, eachInterval, snapping);
        }

        public static Sequence DOLocalMoveX(this Transform[] targetArray,
            float endValue, float eachDuration, float eachInterval = 0, bool snapping = false)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DOLocalMoveX(endValue, eachDuration, snapping).SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DOLocalMoveX(this List<Transform> targetArray,
            float endValue, float eachDuration, float eachInterval = 0, bool snapping = false)
        {
            return targetArray.ToArray().DOLocalMoveX(endValue, eachDuration, eachInterval, snapping);
        }

        public static Sequence DOLocalMoveY(this Transform[] targetArray,
            float endValue, float eachDuration, float eachInterval = 0, bool snapping = false)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DOMoveY(endValue, eachDuration, snapping).SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DOLocalMoveY(this List<Transform> targetArray,
            float endValue, float eachDuration, float eachInterval = 0, bool snapping = false)
        {
            return targetArray.ToArray().DOMoveY(endValue, eachDuration, eachInterval, snapping);
        }

        public static Sequence DOLocalMoveZ(this Transform[] targetArray,
            float endValue, float eachDuration, float eachInterval = 0, bool snapping = false)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DOLocalMoveZ(endValue, eachDuration, snapping).SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DOLocalMoveZ(this List<Transform> targetArray,
            float endValue, float eachDuration, float eachInterval = 0, bool snapping = false)
        {
            return targetArray.ToArray().DOLocalMoveZ(endValue, eachDuration, eachInterval, snapping);
        }
    
        #endregion
    
        #region Rotate
    
        public static Sequence DORotate(this Transform[] targetArray,
            Vector3 endValue, float eachDuration, float eachInterval = 0, RotateMode mode = RotateMode.Fast)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DORotate(endValue, eachDuration, mode).SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DORotate(this List<Transform> targetArray,
            Vector3 endValue, float eachDuration, float eachInterval = 0, RotateMode mode = RotateMode.Fast)
        {
            return targetArray.ToArray().DORotate(endValue, eachDuration, eachInterval, mode);
        }

        public static Sequence DORotateQuaternion(this Transform[] targetArray,
            Quaternion endValue, float eachDuration, float eachInterval = 0)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DORotateQuaternion(endValue, eachDuration).SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DORotateQuaternion(this List<Transform> targetArray,
            Quaternion endValue, float eachDuration, float eachInterval = 0, RotateMode mode = RotateMode.Fast)
        {
            return targetArray.ToArray().DORotateQuaternion(endValue, eachDuration, eachInterval);
        }
    
        #endregion
        #region LocalRotate

        public static Sequence DOLocalRotate(this Transform[] targetArray,
            Vector3 endValue, float eachDuration, float eachInterval = 0, RotateMode mode = RotateMode.Fast)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DOLocalRotate(endValue, eachDuration, mode).SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DOLocalRotate(this List<Transform> targetArray,
            Vector3 endValue, float eachDuration, float eachInterval = 0, RotateMode mode = RotateMode.Fast)
        {
            return targetArray.ToArray().DOLocalRotate(endValue, eachDuration, eachInterval, mode);
        }

        public static Sequence DOLocalRotateQuaternion(this Transform[] targetArray,
            Quaternion endValue, float eachDuration, float eachInterval = 0)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DOLocalRotateQuaternion(endValue, eachDuration).SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DOLocalRotateQuaternion(this List<Transform> targetArray,
            Quaternion endValue, float eachDuration, float eachInterval = 0, RotateMode mode = RotateMode.Fast)
        {
            return targetArray.ToArray().DOLocalRotateQuaternion(endValue, eachDuration, eachInterval);
        }

        #endregion
    
        #region Scale
    
        public static Sequence DOScale(this Transform[] targetArray,
            Vector3 endValue, float eachDuration, float eachInterval = 0)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DOScale(endValue, eachDuration).SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DOScale(this List<Transform> targetArray,
            Vector3 endValue, float eachDuration, float eachInterval = 0)
        {
            return targetArray.ToArray().DOScale(endValue, eachDuration, eachInterval);
        }

        public static Sequence DOScaleX(this Transform[] targetArray,
            float endValue, float eachDuration, float eachInterval = 0)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DOScaleX(endValue, eachDuration).SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DOScaleX(this List<Transform> targetArray,
            float endValue, float eachDuration, float eachInterval = 0)
        {
            return targetArray.ToArray().DOScaleX(endValue, eachDuration, eachInterval);
        }

        public static Sequence DOScaleY(this Transform[] targetArray,
            float endValue, float eachDuration, float eachInterval = 0)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DOScaleY(endValue, eachDuration).SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DOScaleY(this List<Transform> targetArray,
            float endValue, float eachDuration, float eachInterval = 0)
        {
            return targetArray.ToArray().DOScaleY(endValue, eachDuration, eachInterval);
        }

        public static Sequence DOScaleZ(this Transform[] targetArray,
            float endValue, float eachDuration, float eachInterval = 0)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DOScaleZ(endValue, eachDuration).SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DOScaleZ(this List<Transform> targetArray,
            float endValue, float eachDuration, float eachInterval = 0)
        {
            return targetArray.ToArray().DOScaleZ(endValue, eachDuration, eachInterval);
        }
    
        #endregion

        #region Other
    
        public static Sequence DOLookAt(this Transform[] targetArray,
            Vector3 towards, float duration, float eachInterval, AxisConstraint axisConstraint = AxisConstraint.None, Vector3? up = null)
        {
            var sequence = DOTween.Sequence();

            foreach (var target in targetArray)
            {
                sequence.Join(target.DOLookAt(towards, duration, axisConstraint, up).SetDelay(eachInterval));
            }

            return sequence;
        }

        public static Sequence DOLookAt(this List<Transform> targetArray,
            Vector3 towards, float duration, float eachInterval, AxisConstraint axisConstraint = AxisConstraint.None, Vector3? up = null)
        {
            return targetArray.ToArray().DOLookAt(towards, duration, eachInterval, axisConstraint, up);
        }
    
        #endregion
    }
}