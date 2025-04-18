using UnityEngine;

public class Village : MonoBehaviour
{
    /* Village State */
    [SerializeField] Color _inactiveColor = new Color(0.5f, 0.5f, 0.5f, 1f);
    [SerializeField] Color _activeColor = Color.yellow;

    public bool IsActived { get; private set; } = false;

    [SerializeField] int _minValue = 0;
    [SerializeField] int _maxValue = 10;

    public int MinValue => _minValue;
    public int MaxValue => _maxValue;

    [SerializeField] string _resourceType = "Wood";
    [SerializeField] int _resourcePerSecond = 1;

    [SerializeField] string _purchaseResourceType = "Wood";
    [SerializeField] int _purchaseResourceCost = 5;

    public string ResourceType => _resourceType;
    public int ResourcePerSecond => _resourcePerSecond;
    public string PurchaseResourceType => _purchaseResourceType;
    public int PurchaseResourceCost => _purchaseResourceCost;

    /* Assign in inspector */



    /* Assign in script */



    /* Own Components */
    SpriteRenderer _spriteRenderer;


    

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        UpdateVisual();
    }


    public void Activate()
    {
        IsActived = true;
        UpdateVisual();
    }

    private void UpdateVisual()
    {
        _spriteRenderer.color = IsActived ? _activeColor : _inactiveColor;
    }
}
