using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x02000031 RID: 49
	public struct FScriptArray
	{
		// Token: 0x0600083E RID: 2110 RVA: 0x0000D094 File Offset: 0x0000B294
		public FScriptArray()
		{
			this.Data = (IntPtr)0;
			this.ArrayNum = 0;
			this.ArrayMax = 0;
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x0000D0AC File Offset: 0x0000B2AC
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

		// Token: 0x06000840 RID: 2112
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern void* AllocNativeMemory();

		// Token: 0x06000841 RID: 2113
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern void* DeallocNativeMemory(IntPtr ScriptArrayPtr);

		// Token: 0x06000842 RID: 2114
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void MoveAssign(IntPtr DestScriptArrayPtr, IntPtr SrcScriptArrayPtr, int NumBytesPerElement, int AlignmentOfElement);

		// Token: 0x06000843 RID: 2115
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void SetNum(IntPtr ScriptArrayPtr, int NewNum, int NumBytesPerElement, int AlignmentOfElement, bool bAllowShrinking = false);

		// Token: 0x06000844 RID: 2116
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int Insert(IntPtr ScriptArrayPtr, int Index, int Count, int NumBytesPerElement, int AlignmentOfElement);

		// Token: 0x06000845 RID: 2117
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int InsertZeroed(IntPtr ScriptArrayPtr, int Index, int Count, int NumBytesPerElement, int AlignmentOfElement);

		// Token: 0x06000846 RID: 2118
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int AddUninitialized(IntPtr ScriptArrayPtr, int Count, int NumBytesPerElement, int AlignmentOfElement);

		// Token: 0x06000847 RID: 2119
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int AddZeroed(IntPtr ScriptArrayPtr, int Count, int NumBytesPerElement, int AlignmentOfElement);

		// Token: 0x06000848 RID: 2120
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void RemoveAt(IntPtr ScriptArrayPtr, int Index, int Count, int NumBytesPerElement, int AlignmentOfElement);

		// Token: 0x06000849 RID: 2121
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Empty(IntPtr ScriptArrayPtr, int NumBytesPerElement, int AlignmentOfElement, int Slack = 0);

		// Token: 0x04000114 RID: 276
		public const int Size = 16;

		// Token: 0x04000115 RID: 277
		public const int Pack = 8;

		// Token: 0x04000116 RID: 278
		public IntPtr Data;

		// Token: 0x04000117 RID: 279
		public int ArrayNum;

		// Token: 0x04000118 RID: 280
		public int ArrayMax;
	}
}
