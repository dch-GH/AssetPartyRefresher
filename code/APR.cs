using Editor;

public static class APR
{
	[Menu( "Editor", "AssetPartyRefresher/Refresh", "refresh" )]
	public static void Refresh()
	{
		Log.Info( "AssetPartyRefresher :: Refreshing cloud games..." );
		Utility.ClearPackageCache();
		Utility.PlayRawSound( "sounds/editor/success.wav" );
	}
}
