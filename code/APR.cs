using Editor;

public static class APR
{
	[Menu( "Editor", "AssetPartyRefresher/Refresh", "refresh" )]
	public static void Refresh() => Utility.ClearPackageCache();
}
