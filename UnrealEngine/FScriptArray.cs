using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x0200004C RID: 76
	public struct FScriptArray
	{
		// Token: 0x060008B9 RID: 2233 RVA: 0x00010828 File Offset: 0x0000EA28
		public FScriptArray()
		{
			this.Data = (IntPtr)0;
			this.ArrayNum = 0;
			this.ArrayMax = 0;
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00010840 File Offset: 0x0000EA40
		[NullableContext(2)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public Span<T> AsSpan<T>()
		{
			return new Span<T>(this.Data, this.ArrayNum);
		}

		// Token: 0x060008BB RID: 2235
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern void* AllocNativeMemory();

		// Token: 0x060008BC RID: 2236
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern void* DeallocNativeMemory(IntPtr ScriptArrayPtr);

		// Token: 0x060008BD RID: 2237
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void MoveAssign(IntPtr DestScriptArrayPtr, IntPtr SrcScriptArrayPtr, int NumBytesPerElement, int AlignmentOfElement);

		// Token: 0x060008BE RID: 2238
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void SetNum(IntPtr ScriptArrayPtr, int NewNum, int NumBytesPerElement, int AlignmentOfElement, bool bAllowShrinking = false);

		// Token: 0x060008BF RID: 2239
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int Insert(IntPtr ScriptArrayPtr, int Index, int Count, int NumBytesPerElement, int AlignmentOfElement);

		// Token: 0x060008C0 RID: 2240
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int InsertZeroed(IntPtr ScriptArrayPtr, int Index, int Count, int NumBytesPerElement, int AlignmentOfElement);

		// Token: 0x060008C1 RID: 2241
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int AddUninitialized(IntPtr ScriptArrayPtr, int Count, int NumBytesPerElement, int AlignmentOfElement);

		// Token: 0x060008C2 RID: 2242
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int AddZeroed(IntPtr ScriptArrayPtr, int Count, int NumBytesPerElement, int AlignmentOfElement);

		// Token: 0x060008C3 RID: 2243
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void RemoveAt(IntPtr ScriptArrayPtr, int Index, int Count, int NumBytesPerElement, int AlignmentOfElement);

		// Token: 0x060008C4 RID: 2244
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Empty(IntPtr ScriptArrayPtr, int NumBytesPerElement, int AlignmentOfElement, int Slack = 0);

		// Token: 0x0400015B RID: 347
		public const int Size = 16;

		// Token: 0x0400015C RID: 348
		public const int Pack = 8;

		// Token: 0x0400015D RID: 349
		public IntPtr Data;

		// Token: 0x0400015E RID: 350
		public int ArrayNum;

		// Token: 0x0400015F RID: 351
		public int ArrayMax;
	}
}
