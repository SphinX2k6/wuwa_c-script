using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x02000075 RID: 117
	[NullableContext(1)]
	[Nullable(0)]
	public static class TMapExtensions
	{
		// Token: 0x06000E4C RID: 3660 RVA: 0x0001534A File Offset: 0x0001354A
		public static void CopyTo<K, [Nullable(2)] V>(this TMap<K, V> Self, IntPtr Dest)
		{
			FCScriptMapHelperWrapper.CopyTo(Dest, Self.NativePtr);
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x00015358 File Offset: 0x00013558
		public static void MoveTo<K, [Nullable(2)] V>(this TMap<K, V> Self, IntPtr Dest)
		{
			FCScriptMapHelperWrapper.MoveTo(Dest, Self.NativePtr);
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x00015366 File Offset: 0x00013566
		public static void CopyTo<K, [Nullable(2)] V>(this TMap<K, V> Self, TMap<K, V> Dest)
		{
			FCScriptMapHelperWrapper.CopyTo(Dest.NativeMapPtr, Self.NativePtr);
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x00015379 File Offset: 0x00013579
		public static void CopyAssign<K, [Nullable(2)] V>(this TMap<K, V> Self, TMap<K, V> Src)
		{
			FCScriptMapHelperWrapper.CopyTo(Self.NativeMapPtr, Src.NativePtr);
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x0001538C File Offset: 0x0001358C
		public static void MoveTo<K, [Nullable(2)] V>(this TMap<K, V> Self, TMap<K, V> Dest)
		{
			FCScriptMapHelperWrapper.MoveTo(Dest.NativeMapPtr, Self.NativePtr);
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x0001539F File Offset: 0x0001359F
		public static void MoveAssign<K, [Nullable(2)] V>(this TMap<K, V> Self, TMap<K, V> Src)
		{
			FCScriptMapHelperWrapper.MoveTo(Self.NativeMapPtr, Src.NativePtr);
		}
	}
}
