using UnityEngine.Purchasing;
public class MyStore : IStoreListener
{
   public void InitializeStore()
   {
       var module = StandardPurchasingModule.Instance();
       var builder = ConfigurationBuilder.Instance(module);
       builder.Configure<IMoolahConfiguration>().appKey = "d93f4564c41d463ed3d3cd207594ee1b";
       builder.Configure<IMoolahConfiguration>().hashKey = "cc";
       builder.Configure<IMoolahConfiguration>().notificationURL = "https://gameserver.example.com/callback";
       builder.Configure<IMoolahConfiguration>().SetMode(CloudMoolahMode.Production);
       builder.AddProduct("100.gold.coins", ProductType.Consumable);
       UnityPurchasing.Initialize(this, builder);
   }
}
