using System;

namespace UnrealEngine
{
	// Token: 0x02000080 RID: 128
	public readonly struct UFunctionStackOnlyPtr
	{
		// Token: 0x06000C05 RID: 3077 RVA: 0x00013733 File Offset: 0x00011933
		public UFunctionStackOnlyPtr(IntPtr NativePtr)
		{
			this.FunctionPtr = new IntPtr((long)NativePtr);
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000C06 RID: 3078 RVA: 0x00013742 File Offset: 0x00011942
		public IntPtr FunctionPtr { get; }

		// Token: 0x06000C07 RID: 3079 RVA: 0x0001374A File Offset: 0x0001194A
		public bool IsValid()
		{
			return this.FunctionPtr != IntPtr.Zero;
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x0001375C File Offset: 0x0001195C
		public static implicit operator UFunctionStackOnlyPtr(IntPtr Ptr)
		{
			return new UFunctionStackOnlyPtr(Ptr);
		}
	}
}
