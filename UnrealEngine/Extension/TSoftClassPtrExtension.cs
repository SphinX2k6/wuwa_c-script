using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;

namespace UnrealEngine.Extension
{
	// Token: 0x02000893 RID: 2195
	public static class TSoftClassPtrExtension
	{
		// Token: 0x0600BDB8 RID: 48568 RVA: 0x0012EDA8 File Offset: 0x0012CFA8
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static string ToAssetPathName<[Nullable(0)] T>(this TSoftClassPtr<T> Ptr) where T : UnrealUObject, IUnrealUObject
		{
			return Ptr.ToSoftObjectPath().GetAssetPathString();
		}
	}
}
