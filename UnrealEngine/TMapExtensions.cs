using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x0200005A RID: 90
	[NullableContext(1)]
	[Nullable(0)]
	public static class TMapExtensions
	{
		// Token: 0x060009DE RID: 2526 RVA: 0x00010052 File Offset: 0x0000E252
		public static void CopyTo<K, [Nullable(2)] V>(this TMap<K, V> Self, IntPtr Dest)
		{
			FCScriptMapHelperWrapper.CopyTo(Dest, Self.NativePtr);
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x00010060 File Offset: 0x0000E260
		public static void MoveTo<K, [Nullable(2)] V>(this TMap<K, V> Self, IntPtr Dest)
		{
			FCScriptMapHelperWrapper.MoveTo(Dest, Self.NativePtr);
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x0001006E File Offset: 0x0000E26E
		public static void CopyTo<K, [Nullable(2)] V>(this TMap<K, V> Self, TMap<K, V> Dest)
		{
			FCScriptMapHelperWrapper.CopyTo(Dest.NativeMapPtr, Self.NativePtr);
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x00010081 File Offset: 0x0000E281
		public static void CopyAssign<K, [Nullable(2)] V>(this TMap<K, V> Self, TMap<K, V> Src)
		{
			FCScriptMapHelperWrapper.CopyTo(Self.NativeMapPtr, Src.NativePtr);
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x00010094 File Offset: 0x0000E294
		public static void MoveTo<K, [Nullable(2)] V>(this TMap<K, V> Self, TMap<K, V> Dest)
		{
			FCScriptMapHelperWrapper.MoveTo(Dest.NativeMapPtr, Self.NativePtr);
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x000100A7 File Offset: 0x0000E2A7
		public static void MoveAssign<K, [Nullable(2)] V>(this TMap<K, V> Self, TMap<K, V> Src)
		{
			FCScriptMapHelperWrapper.MoveTo(Self.NativeMapPtr, Src.NativePtr);
		}
	}
}
