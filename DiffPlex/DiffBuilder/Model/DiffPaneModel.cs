using System.Collections.Generic;

namespace DiffPlex.DiffBuilder.Model
{
    
    /// <summary>
    /// Legacy code testing
    /// </summary>
    /// <description>
    /// ```
    ///  using UnityEngine.Purchasing;
    ///  public class MyStore : IStoreListener
    ///  {
    ///  public void InitializeStore()
    ///  {
    ///  var module = StandardPurchasingModule.Instance();
    ///  var builder = ConfigurationBuilder.Instance(module);
    ///  // Configure CloudMoolah
    ///  builder.Configure().appKey = "d93f4564c41d463ed3d3cd207594ee1b";
    ///  builder.Configure().hashKey = "cc";
    ///  // For server-to-server (also called "online" games) transaction
    ///  // logging, set IMoolahConfiguration.notificationURL.
    ///  builder.Configure().notificationURL = "https://gameserver.example.com/callback";
    ///  builder.Configure().SetMode(CloudMoolahMode.Production);
    ///  // Add purchasable products. The product must be defined in the store.
    ///  // Unity IAP provides the *ProductType* enumeration to specify the durability
    ///  // of a purchasable product. CloudMoolah limits the product type to Consumable.
    ///  builder.AddProduct("100.gold.coins", ProductType.Consumable);
    ///  // Start asynchronous IAP initialization.
    ///  UnityPurchasing.Initialize(this, builder);
    ///  }
    ///  }
    /// ```
    /// </description>
    public class DiffPaneModel
    {
        
        
        public List<DiffPiece> Lines { get; }

        
        
        public DiffPaneModel()
        {
            Lines = new List<DiffPiece>();
        }
    }
}