using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;

namespace UnrealEngine.Extension
{
	// Token: 0x02002AE4 RID: 10980
	public static class TSoftClassPtrExtension
	{
		// Token: 0x06028403 RID: 164867 RVA: 0x003D3A98 File Offset: 0x003D1C98
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static string ToAssetPathName<[Nullable(0)] T>(this TSoftClassPtr<T> Ptr) where T : UnrealUObject, IUnrealUObject
		{
			return Ptr.ToSoftObjectPath().GetAssetPathString();
		}
	}
}
