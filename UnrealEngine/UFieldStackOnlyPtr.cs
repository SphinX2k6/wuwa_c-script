using System;

namespace UnrealEngine
{
	// Token: 0x0200007F RID: 127
	public readonly struct UFieldStackOnlyPtr
	{
		// Token: 0x06000C01 RID: 3073 RVA: 0x00013702 File Offset: 0x00011902
		public UFieldStackOnlyPtr(IntPtr NativePtr)
		{
			this.FieldPtr = new IntPtr((long)NativePtr);
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000C02 RID: 3074 RVA: 0x00013711 File Offset: 0x00011911
		public IntPtr FieldPtr { get; }

		// Token: 0x06000C03 RID: 3075 RVA: 0x00013719 File Offset: 0x00011919
		public bool IsValid()
		{
			return this.FieldPtr != IntPtr.Zero;
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x0001372B File Offset: 0x0001192B
		public static implicit operator UFieldStackOnlyPtr(IntPtr Ptr)
		{
			return new UFieldStackOnlyPtr(Ptr);
		}
	}
}
