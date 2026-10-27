using System;

namespace UnrealEngine
{
	// Token: 0x0200009B RID: 155
	public readonly struct UFunctionStackOnlyPtr
	{
		// Token: 0x06001072 RID: 4210 RVA: 0x00018A0F File Offset: 0x00016C0F
		public UFunctionStackOnlyPtr(IntPtr NativePtr)
		{
			this.FunctionPtr = new IntPtr((long)NativePtr);
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06001073 RID: 4211 RVA: 0x00018A1E File Offset: 0x00016C1E
		public IntPtr FunctionPtr { get; }

		// Token: 0x06001074 RID: 4212 RVA: 0x00018A26 File Offset: 0x00016C26
		public bool IsValid()
		{
			return this.FunctionPtr != IntPtr.Zero;
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x00018A38 File Offset: 0x00016C38
		public static implicit operator UFunctionStackOnlyPtr(IntPtr Ptr)
		{
			return new UFunctionStackOnlyPtr(Ptr);
		}
	}
}
