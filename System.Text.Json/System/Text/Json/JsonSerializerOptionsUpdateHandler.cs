using System;
using System.Collections.Generic;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json
{
	// Token: 0x0200005E RID: 94
	internal static class JsonSerializerOptionsUpdateHandler
	{
		// Token: 0x06000717 RID: 1815 RVA: 0x00022D9C File Offset: 0x00020F9C
		public static void ClearCache(Type[] types)
		{
			foreach (KeyValuePair<JsonSerializerOptions, object> keyValuePair in ((IEnumerable<KeyValuePair<JsonSerializerOptions, object>>)JsonSerializerOptions.TrackedOptionsInstances.All))
			{
				keyValuePair.Key.ClearCaches();
			}
			DefaultJsonTypeInfoResolver.ClearMemberAccessorCaches();
		}
	}
}
