using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Extension
{
	// Token: 0x02002AE3 RID: 10979
	public static class SoftObjectPtrExtension
	{
		// Token: 0x06028402 RID: 164866 RVA: 0x003D3A8B File Offset: 0x003D1C8B
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static string ToAssetPathName<[Nullable(0)] T>(this TSoftObjectPtr<T> Ptr) where T : UnrealUObject
		{
			return Ptr.ToSoftObjectPath().GetAssetPathString();
		}
	}
}
