using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace DOTweenExtensions.Array.Demo
{
    public class DOTweenExtensionsSample : MonoBehaviour
    {
        [SerializeField] private GameObject squareImagePrefab;

        private RectTransform[] squareTransforms;
        private Image[] squareImages;

        private void Start()
        {
            CreateSquares();
            PlayAnimation();
        }

        private void PlayAnimation()
        {
            DOTween.Sequence()
                .Append(squareImages.DOColor(new Color(0.8f, 0.6f, 0.3f), 0.4f, 0.01f))
                .Append(squareTransforms.DOScale(Vector3.zero, 0.4f, 0.02f))
                .Join(squareTransforms.DORotate(Vector3.forward * 90, 0.4f, 0.02f))
                .SetLoops(-1, LoopType.Yoyo);
        }

        private void CreateSquares()
        {
            const int COUNT = 10;

            squareTransforms = new RectTransform[COUNT * COUNT];
            squareImages = new Image[COUNT * COUNT];
        
            for (var row = 0; row < COUNT; row++)
            {
                for (var col = 0; col < COUNT; col++)
                {
                    var idx = row * COUNT + col;
                    var anchorPos = new Vector2(row - (float) COUNT / 2, col - (float) COUNT / 2) * 60f;
                    var instance = Instantiate(squareImagePrefab, transform);
                
                    var rectTransform = instance.GetComponent<RectTransform>();
                    squareTransforms[idx] = rectTransform;
                    rectTransform.anchoredPosition = anchorPos;

                    var image = instance.GetComponent<Image>();
                    squareImages[idx] = image;
                }
            }
        }
    }
}