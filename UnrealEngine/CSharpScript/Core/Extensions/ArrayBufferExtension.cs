using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Core.Extensions
{
	// Token: 0x0200001E RID: 30
	public static class ArrayBufferExtension
	{
		// Token: 0x0600007C RID: 124 RVA: 0x000057E4 File Offset: 0x000039E4
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

		// Token: 0x0600007D RID: 125 RVA: 0x0000581C File Offset: 0x00003A1C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Span<byte> ToSpan(this FArrayBuffer buffer)
		{
			int length = (int)buffer.Length;
			return new Span<byte>(buffer.Data, length);
		}
	}
}
