using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Extension
{
	// Token: 0x02000892 RID: 2194
	public static class SoftObjectPtrExtension
	{
		// Token: 0x0600BDB7 RID: 48567 RVA: 0x0012ED9B File Offset: 0x0012CF9B
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static string ToAssetPathName<[Nullable(0)] T>(this TSoftObjectPtr<T> Ptr) where T : UnrealUObject
		{
			return Ptr.ToSoftObjectPath().GetAssetPathString();
		}
	}
}
