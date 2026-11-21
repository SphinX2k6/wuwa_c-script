using System;

namespace UnrealEngine
{
	// Token: 0x0200008C RID: 140
	public readonly struct UStructStackOnlyPtr
	{
		// Token: 0x06000C61 RID: 3169 RVA: 0x000140B3 File Offset: 0x000122B3
		public UStructStackOnlyPtr(IntPtr NativePtr)
		{
			this.StructPtr = new IntPtr((long)NativePtr);
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000C62 RID: 3170 RVA: 0x000140C2 File Offset: 0x000122C2
		public IntPtr StructPtr { get; }

		// Token: 0x06000C63 RID: 3171 RVA: 0x000140CA File Offset: 0x000122CA
		public bool IsValid()
		{
			return this.StructPtr != IntPtr.Zero;
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x000140DC File Offset: 0x000122DC
		public static implicit operator UStructStackOnlyPtr(IntPtr Ptr)
		{
			return new UStructStackOnlyPtr(Ptr);
		}
	}
}
