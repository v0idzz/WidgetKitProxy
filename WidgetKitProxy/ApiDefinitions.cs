using Foundation;

namespace Binding
{
	// @interface WidgetKitProxy : NSObject
	[BaseType (typeof(NSObject))]
	interface WidgetKitProxy
	{
		// -(void)reloadAllTimelines;
		[Export ("reloadAllTimelines")]
		void ReloadAllTimelines ();
	}
}
