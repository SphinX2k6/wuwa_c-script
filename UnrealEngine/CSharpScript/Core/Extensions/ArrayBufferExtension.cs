using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Core.Extensions
{
	// Token: 0x02000003 RID: 3
	public static class ArrayBufferExtension
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte[] ToByteArray(this FArrayBuffer buffer)
		{
			int num = (int)buffer.Length;
			byte[] array = new byte[num];
			Span<byte> span = new Span<byte>(buffer.Data, num);
			span.CopyTo(array);
			return array;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002088 File Offset: 0x00000288
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Span<byte> ToSpan(this FArrayBuffer buffer)
		{
			int length = (int)buffer.Length;
			return new Span<byte>(buffer.Data, length);
		}
	}
}
