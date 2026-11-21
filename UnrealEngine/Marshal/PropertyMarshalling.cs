using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Marshal
{
	// Token: 0x020008BB RID: 2235
	[NullableContext(2)]
	[Nullable(0)]
	internal static class PropertyMarshalling
	{
		// Token: 0x0600BE5E RID: 48734 RVA: 0x0012FF48 File Offset: 0x0012E148
		internal static int SizeOf<T>()
		{
			Type typeFromHandle = typeof(T);
			if (typeFromHandle.IsValueType || typeFromHandle.StructLayoutAttribute != null)
			{
				return UnmanagedTypeMarshallingProcessor<T>.Size;
			}
			if (typeFromHandle.IsSubclassOf(typeof(UnrealUObject)))
			{
				return UnrealUObjectMarshallingProcessor<T>.Size;
			}
			if (typeFromHandle.IsSubclassOf(typeof(UnrealProxyObject)))
			{
				return UnrealStructObjectMarshallingProcessor<T>.Size;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
			defaultInterpolatedStringHandler.AppendFormatted<Type>(typeFromHandle);
			defaultInterpolatedStringHandler.AppendLiteral(" is not supported");
			throw new NotSupportedException(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x0600BE5F RID: 48735 RVA: 0x0012FFD0 File Offset: 0x0012E1D0
		internal static int SizeOf<T1, T2>()
		{
			return PropertyMarshalling.SizeOf<T1>() + PropertyMarshalling.SizeOf<T2>();
		}

		// Token: 0x0600BE60 RID: 48736 RVA: 0x0012FFDD File Offset: 0x0012E1DD
		internal static int SizeOf<T1, T2, T3>()
		{
			return PropertyMarshalling.SizeOf<T1>() + PropertyMarshalling.SizeOf<T2>() + PropertyMarshalling.SizeOf<T3>();
		}

		// Token: 0x0600BE61 RID: 48737 RVA: 0x0012FFF0 File Offset: 0x0012E1F0
		internal static int SizeOf<T1, T2, T3, T4>()
		{
			return PropertyMarshalling.SizeOf<T1>() + PropertyMarshalling.SizeOf<T2>() + PropertyMarshalling.SizeOf<T3>() + PropertyMarshalling.SizeOf<T4>();
		}

		// Token: 0x0600BE62 RID: 48738 RVA: 0x00130009 File Offset: 0x0012E209
		internal static int SizeOf<T1, T2, T3, T4, T5>()
		{
			return PropertyMarshalling.SizeOf<T1>() + PropertyMarshalling.SizeOf<T2>() + PropertyMarshalling.SizeOf<T3>() + PropertyMarshalling.SizeOf<T4>() + PropertyMarshalling.SizeOf<T5>();
		}

		// Token: 0x0600BE63 RID: 48739 RVA: 0x00130028 File Offset: 0x0012E228
		internal static int SizeOf<T1, T2, T3, T4, T5, T6>()
		{
			return PropertyMarshalling.SizeOf<T1>() + PropertyMarshalling.SizeOf<T2>() + PropertyMarshalling.SizeOf<T3>() + PropertyMarshalling.SizeOf<T4>() + PropertyMarshalling.SizeOf<T5>() + PropertyMarshalling.SizeOf<T6>();
		}

		// Token: 0x0600BE64 RID: 48740 RVA: 0x0013004D File Offset: 0x0012E24D
		internal static int SizeOf<T1, T2, T3, T4, T5, T6, T7>()
		{
			return PropertyMarshalling.SizeOf<T1>() + PropertyMarshalling.SizeOf<T2>() + PropertyMarshalling.SizeOf<T3>() + PropertyMarshalling.SizeOf<T4>() + PropertyMarshalling.SizeOf<T5>() + PropertyMarshalling.SizeOf<T6>() + PropertyMarshalling.SizeOf<T7>();
		}

		// Token: 0x0600BE65 RID: 48741 RVA: 0x00130078 File Offset: 0x0012E278
		internal static int SizeOf<T1, T2, T3, T4, T5, T6, T7, T8>()
		{
			return PropertyMarshalling.SizeOf<T1>() + PropertyMarshalling.SizeOf<T2>() + PropertyMarshalling.SizeOf<T3>() + PropertyMarshalling.SizeOf<T4>() + PropertyMarshalling.SizeOf<T5>() + PropertyMarshalling.SizeOf<T6>() + PropertyMarshalling.SizeOf<T7>() + PropertyMarshalling.SizeOf<T8>();
		}

		// Token: 0x0600BE66 RID: 48742 RVA: 0x001300A9 File Offset: 0x0012E2A9
		internal static int SizeOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>()
		{
			return PropertyMarshalling.SizeOf<T1>() + PropertyMarshalling.SizeOf<T2>() + PropertyMarshalling.SizeOf<T3>() + PropertyMarshalling.SizeOf<T4>() + PropertyMarshalling.SizeOf<T5>() + PropertyMarshalling.SizeOf<T6>() + PropertyMarshalling.SizeOf<T7>() + PropertyMarshalling.SizeOf<T8>() + PropertyMarshalling.SizeOf<T9>();
		}

		// Token: 0x0600BE67 RID: 48743 RVA: 0x001300E0 File Offset: 0x0012E2E0
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal unsafe static void Write<[Nullable(2)] T>(byte* buffer, ref int offset, [Nullable(1)] in T value)
		{
			Type typeFromHandle = typeof(T);
			if (typeFromHandle.IsValueType || typeFromHandle.StructLayoutAttribute != null)
			{
				UnmanagedTypeMarshallingProcessor<T>.Write(buffer, ref offset, value);
				return;
			}
			if (typeFromHandle.IsSubclassOf(typeof(UnrealUObject)))
			{
				UnrealUObjectMarshallingProcessor<T>.Write(buffer, ref offset, value);
				return;
			}
			if (typeFromHandle.IsSubclassOf(typeof(UnrealProxyObject)))
			{
				UnrealStructObjectMarshallingProcessor<T>.Write(buffer, ref offset, value);
			}
		}

		// Token: 0x0600BE68 RID: 48744 RVA: 0x00130146 File Offset: 0x0012E346
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal unsafe static void Write<[Nullable(2)] T1, [Nullable(2)] T2>([Nullable(0)] byte* buffer, ref int offset, in T1 v1, in T2 v2)
		{
			PropertyMarshalling.Write<T1>(buffer, ref offset, v1);
			PropertyMarshalling.Write<T2>(buffer, ref offset, v2);
		}

		// Token: 0x0600BE69 RID: 48745 RVA: 0x00130158 File Offset: 0x0012E358
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal unsafe static void Write<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3>([Nullable(0)] byte* buffer, ref int offset, in T1 v1, in T2 v2, in T3 v3)
		{
			PropertyMarshalling.Write<T1>(buffer, ref offset, v1);
			PropertyMarshalling.Write<T2>(buffer, ref offset, v2);
			PropertyMarshalling.Write<T3>(buffer, ref offset, v3);
		}

		// Token: 0x0600BE6A RID: 48746 RVA: 0x00130173 File Offset: 0x0012E373
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal unsafe static void Write<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4>([Nullable(0)] byte* buffer, ref int offset, in T1 v1, in T2 v2, in T3 v3, in T4 v4)
		{
			PropertyMarshalling.Write<T1>(buffer, ref offset, v1);
			PropertyMarshalling.Write<T2>(buffer, ref offset, v2);
			PropertyMarshalling.Write<T3>(buffer, ref offset, v3);
			PropertyMarshalling.Write<T4>(buffer, ref offset, v4);
		}

		// Token: 0x0600BE6B RID: 48747 RVA: 0x00130197 File Offset: 0x0012E397
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal unsafe static void Write<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5>([Nullable(0)] byte* buffer, ref int offset, in T1 v1, in T2 v2, in T3 v3, in T4 v4, in T5 v5)
		{
			PropertyMarshalling.Write<T1>(buffer, ref offset, v1);
			PropertyMarshalling.Write<T2>(buffer, ref offset, v2);
			PropertyMarshalling.Write<T3>(buffer, ref offset, v3);
			PropertyMarshalling.Write<T4>(buffer, ref offset, v4);
			PropertyMarshalling.Write<T5>(buffer, ref offset, v5);
		}

		// Token: 0x0600BE6C RID: 48748 RVA: 0x001301C4 File Offset: 0x0012E3C4
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal unsafe static void Write<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5, [Nullable(2)] T6>([Nullable(0)] byte* buffer, ref int offset, in T1 v1, in T2 v2, in T3 v3, in T4 v4, in T5 v5, in T6 v6)
		{
			PropertyMarshalling.Write<T1>(buffer, ref offset, v1);
			PropertyMarshalling.Write<T2>(buffer, ref offset, v2);
			PropertyMarshalling.Write<T3>(buffer, ref offset, v3);
			PropertyMarshalling.Write<T4>(buffer, ref offset, v4);
			PropertyMarshalling.Write<T5>(buffer, ref offset, v5);
			PropertyMarshalling.Write<T6>(buffer, ref offset, v6);
		}

		// Token: 0x0600BE6D RID: 48749 RVA: 0x001301FA File Offset: 0x0012E3FA
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal unsafe static void Write<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5, [Nullable(2)] T6, [Nullable(2)] T7>([Nullable(0)] byte* buffer, ref int offset, in T1 v1, in T2 v2, in T3 v3, in T4 v4, in T5 v5, in T6 v6, in T7 v7)
		{
			PropertyMarshalling.Write<T1>(buffer, ref offset, v1);
			PropertyMarshalling.Write<T2>(buffer, ref offset, v2);
			PropertyMarshalling.Write<T3>(buffer, ref offset, v3);
			PropertyMarshalling.Write<T4>(buffer, ref offset, v4);
			PropertyMarshalling.Write<T5>(buffer, ref offset, v5);
			PropertyMarshalling.Write<T6>(buffer, ref offset, v6);
			PropertyMarshalling.Write<T7>(buffer, ref offset, v7);
		}

		// Token: 0x0600BE6E RID: 48750 RVA: 0x0013023C File Offset: 0x0012E43C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal unsafe static void Write<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5, [Nullable(2)] T6, [Nullable(2)] T7, [Nullable(2)] T8>([Nullable(0)] byte* buffer, ref int offset, in T1 v1, in T2 v2, in T3 v3, in T4 v4, in T5 v5, in T6 v6, in T7 v7, in T8 v8)
		{
			PropertyMarshalling.Write<T1>(buffer, ref offset, v1);
			PropertyMarshalling.Write<T2>(buffer, ref offset, v2);
			PropertyMarshalling.Write<T3>(buffer, ref offset, v3);
			PropertyMarshalling.Write<T4>(buffer, ref offset, v4);
			PropertyMarshalling.Write<T5>(buffer, ref offset, v5);
			PropertyMarshalling.Write<T6>(buffer, ref offset, v6);
			PropertyMarshalling.Write<T7>(buffer, ref offset, v7);
			PropertyMarshalling.Write<T8>(buffer, ref offset, v8);
		}

		// Token: 0x0600BE6F RID: 48751 RVA: 0x00130290 File Offset: 0x0012E490
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal unsafe static void Write<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5, [Nullable(2)] T6, [Nullable(2)] T7, [Nullable(2)] T8, [Nullable(2)] T9>([Nullable(0)] byte* buffer, ref int offset, in T1 v1, in T2 v2, in T3 v3, in T4 v4, in T5 v5, in T6 v6, in T7 v7, in T8 v8, in T9 v9)
		{
			PropertyMarshalling.Write<T1>(buffer, ref offset, v1);
			PropertyMarshalling.Write<T2>(buffer, ref offset, v2);
			PropertyMarshalling.Write<T3>(buffer, ref offset, v3);
			PropertyMarshalling.Write<T4>(buffer, ref offset, v4);
			PropertyMarshalling.Write<T5>(buffer, ref offset, v5);
			PropertyMarshalling.Write<T6>(buffer, ref offset, v6);
			PropertyMarshalling.Write<T7>(buffer, ref offset, v7);
			PropertyMarshalling.Write<T8>(buffer, ref offset, v8);
			PropertyMarshalling.Write<T9>(buffer, ref offset, v9);
		}

		// Token: 0x0600BE70 RID: 48752 RVA: 0x001302EC File Offset: 0x0012E4EC
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal unsafe static void Read<T>([Nullable(0)] byte* buffer, ref int offset, out T value)
		{
			Type typeFromHandle = typeof(T);
			if (typeFromHandle.IsValueType || typeFromHandle.StructLayoutAttribute != null)
			{
				value = UnmanagedTypeMarshallingProcessor<T>.Read(buffer, ref offset);
			}
			else if (typeFromHandle.IsSubclassOf(typeof(UnrealUObject)))
			{
				value = UnrealUObjectMarshallingProcessor<T>.Read(buffer, ref offset);
			}
			else if (typeFromHandle.IsSubclassOf(typeof(UnrealProxyObject)))
			{
				value = UnrealStructObjectMarshallingProcessor<T>.Read(buffer, ref offset);
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
			defaultInterpolatedStringHandler.AppendFormatted<Type>(typeFromHandle);
			defaultInterpolatedStringHandler.AppendLiteral(" is not supported");
			throw new NotSupportedException(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x0600BE71 RID: 48753 RVA: 0x0013038D File Offset: 0x0012E58D
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal unsafe static void Read<T1, T2>([Nullable(0)] byte* buffer, ref int offset, out T1 v1, out T2 v2)
		{
			PropertyMarshalling.Read<T1>(buffer, ref offset, out v1);
			PropertyMarshalling.Read<T2>(buffer, ref offset, out v2);
		}

		// Token: 0x0600BE72 RID: 48754 RVA: 0x0013039F File Offset: 0x0012E59F
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal unsafe static void Read<T1, T2, T3>([Nullable(0)] byte* buffer, ref int offset, out T1 v1, out T2 v2, out T3 v3)
		{
			PropertyMarshalling.Read<T1>(buffer, ref offset, out v1);
			PropertyMarshalling.Read<T2>(buffer, ref offset, out v2);
			PropertyMarshalling.Read<T3>(buffer, ref offset, out v3);
		}

		// Token: 0x0600BE73 RID: 48755 RVA: 0x001303BA File Offset: 0x0012E5BA
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal unsafe static void Read<T1, T2, T3, T4>([Nullable(0)] byte* buffer, ref int offset, out T1 v1, out T2 v2, out T3 v3, out T4 v4)
		{
			PropertyMarshalling.Read<T1>(buffer, ref offset, out v1);
			PropertyMarshalling.Read<T2>(buffer, ref offset, out v2);
			PropertyMarshalling.Read<T3>(buffer, ref offset, out v3);
			PropertyMarshalling.Read<T4>(buffer, ref offset, out v4);
		}

		// Token: 0x0600BE74 RID: 48756 RVA: 0x001303DE File Offset: 0x0012E5DE
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal unsafe static void Read<T1, T2, T3, T4, T5>([Nullable(0)] byte* buffer, ref int offset, out T1 v1, out T2 v2, out T3 v3, out T4 v4, out T5 v5)
		{
			PropertyMarshalling.Read<T1>(buffer, ref offset, out v1);
			PropertyMarshalling.Read<T2>(buffer, ref offset, out v2);
			PropertyMarshalling.Read<T3>(buffer, ref offset, out v3);
			PropertyMarshalling.Read<T4>(buffer, ref offset, out v4);
			PropertyMarshalling.Read<T5>(buffer, ref offset, out v5);
		}

		// Token: 0x0600BE75 RID: 48757 RVA: 0x0013040B File Offset: 0x0012E60B
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal unsafe static void Read<T1, T2, T3, T4, T5, T6>([Nullable(0)] byte* buffer, ref int offset, out T1 v1, out T2 v2, out T3 v3, out T4 v4, out T5 v5, out T6 v6)
		{
			PropertyMarshalling.Read<T1>(buffer, ref offset, out v1);
			PropertyMarshalling.Read<T2>(buffer, ref offset, out v2);
			PropertyMarshalling.Read<T3>(buffer, ref offset, out v3);
			PropertyMarshalling.Read<T4>(buffer, ref offset, out v4);
			PropertyMarshalling.Read<T5>(buffer, ref offset, out v5);
			PropertyMarshalling.Read<T6>(buffer, ref offset, out v6);
		}

		// Token: 0x0600BE76 RID: 48758 RVA: 0x00130441 File Offset: 0x0012E641
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal unsafe static void Read<T1, T2, T3, T4, T5, T6, T7>([Nullable(0)] byte* buffer, ref int offset, out T1 v1, out T2 v2, out T3 v3, out T4 v4, out T5 v5, out T6 v6, out T7 v7)
		{
			PropertyMarshalling.Read<T1>(buffer, ref offset, out v1);
			PropertyMarshalling.Read<T2>(buffer, ref offset, out v2);
			PropertyMarshalling.Read<T3>(buffer, ref offset, out v3);
			PropertyMarshalling.Read<T4>(buffer, ref offset, out v4);
			PropertyMarshalling.Read<T5>(buffer, ref offset, out v5);
			PropertyMarshalling.Read<T6>(buffer, ref offset, out v6);
			PropertyMarshalling.Read<T7>(buffer, ref offset, out v7);
		}

		// Token: 0x0600BE77 RID: 48759 RVA: 0x00130480 File Offset: 0x0012E680
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal unsafe static void Read<T1, T2, T3, T4, T5, T6, T7, T8>([Nullable(0)] byte* buffer, ref int offset, out T1 v1, out T2 v2, out T3 v3, out T4 v4, out T5 v5, out T6 v6, out T7 v7, out T8 v8)
		{
			PropertyMarshalling.Read<T1>(buffer, ref offset, out v1);
			PropertyMarshalling.Read<T2>(buffer, ref offset, out v2);
			PropertyMarshalling.Read<T3>(buffer, ref offset, out v3);
			PropertyMarshalling.Read<T4>(buffer, ref offset, out v4);
			PropertyMarshalling.Read<T5>(buffer, ref offset, out v5);
			PropertyMarshalling.Read<T6>(buffer, ref offset, out v6);
			PropertyMarshalling.Read<T7>(buffer, ref offset, out v7);
			PropertyMarshalling.Read<T8>(buffer, ref offset, out v8);
		}

		// Token: 0x0600BE78 RID: 48760 RVA: 0x001304D4 File Offset: 0x0012E6D4
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal unsafe static void Read<T1, T2, T3, T4, T5, T6, T7, T8, T9>([Nullable(0)] byte* buffer, ref int offset, out T1 v1, out T2 v2, out T3 v3, out T4 v4, out T5 v5, out T6 v6, out T7 v7, out T8 v8, out T9 v9)
		{
			PropertyMarshalling.Read<T1>(buffer, ref offset, out v1);
			PropertyMarshalling.Read<T2>(buffer, ref offset, out v2);
			PropertyMarshalling.Read<T3>(buffer, ref offset, out v3);
			PropertyMarshalling.Read<T4>(buffer, ref offset, out v4);
			PropertyMarshalling.Read<T5>(buffer, ref offset, out v5);
			PropertyMarshalling.Read<T6>(buffer, ref offset, out v6);
			PropertyMarshalling.Read<T7>(buffer, ref offset, out v7);
			PropertyMarshalling.Read<T8>(buffer, ref offset, out v8);
			PropertyMarshalling.Read<T9>(buffer, ref offset, out v9);
		}
	}
}
