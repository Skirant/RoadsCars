using TMPro;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text1;
    [SerializeField] TextMeshProUGUI _text2;

    [SerializeField] CoinManager _coinManager;
    [SerializeField] int _price;
    
    PlayerModifier _playerModifier;

    private void Start()
    {
        _playerModifier = FindObjectOfType<PlayerModifier>();
        _text1.text = _price.ToString();
        _text2.text = _price.ToString();
    }

    public void BuyWidth()
    {
        if(_coinManager.NumberOfCoins >= 20)
        {
            _coinManager.SpendMoney(_price);
            Progress.Instance.Coins = _coinManager.NumberOfCoins;
            Progress.Instance.Width += 25;
            _playerModifier.SetWeight(Progress.Instance.Width);

        }
    }
}
