using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000099 RID: 153
	[NullableContext(1)]
	[Nullable(0)]
	public struct UClassStackOnlyPtr : IEquatable<UClassStackOnlyPtr>
	{
		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x0600105C RID: 4188 RVA: 0x000188DE File Offset: 0x00016ADE
		public IntPtr NativePtr
		{
			get
			{
				return this._NativePtr;
			}
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x000188E6 File Offset: 0x00016AE6
		public UClassStackOnlyPtr(IntPtr NativePtr)
		{
			this._NativePtr = NativePtr;
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x000188EF File Offset: 0x00016AEF
		public static implicit operator UClassStackOnlyPtr(IntPtr Ptr)
		{
			return new UClassStackOnlyPtr(Ptr);
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x000188F7 File Offset: 0x00016AF7
		public bool Equals(UClassStackOnlyPtr Other)
		{
			return this == Other;
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x00018905 File Offset: 0x00016B05
		public override int GetHashCode()
		{
			return this._NativePtr.GetHashCode();
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x00018912 File Offset: 0x00016B12
		public static bool operator ==(UClassStackOnlyPtr Left, UClassStackOnlyPtr Right)
		{
			return Left._NativePtr == Right._NativePtr;
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x00018922 File Offset: 0x00016B22
		public static bool operator !=(UClassStackOnlyPtr Left, UClassStackOnlyPtr Right)
		{
			return Left._NativePtr != Right._NativePtr;
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x00018935 File Offset: 0x00016B35
		public bool IsValid()
		{
			return this._NativePtr != IntPtr.Zero && UClass.IsValid(this);
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x00018951 File Offset: 0x00016B51
		public bool IsChildOf(UClassStackOnlyPtr B)
		{
			return UClass.IsChildOf(this, B);
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x0001895F File Offset: 0x00016B5F
		public bool IsA(UClassStackOnlyPtr B)
		{
			return UClass.IsA(this, B);
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x0001896D File Offset: 0x00016B6D
		public FName GetFName()
		{
			return UClass.GetFName(this);
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x0001897A File Offset: 0x00016B7A
		public string GetName()
		{
			return UClass.GetName(this);
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x00018987 File Offset: 0x00016B87
		public string GetPathName()
		{
			return UClass.GetPathName(this);
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x00018994 File Offset: 0x00016B94
		public UClassStackOnlyPtr GetClass()
		{
			return UClass.GetClass(this);
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x0600106A RID: 4202 RVA: 0x000189A1 File Offset: 0x00016BA1
		public int ObjectIndex
		{
			get
			{
				return UClass.GetObjectIndex(this);
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x0600106B RID: 4203 RVA: 0x000189AE File Offset: 0x00016BAE
		public int ObjectSerialNumber
		{
			get
			{
				return UClass.GetObjectSerialNumber(this);
			}
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x000189BB File Offset: 0x00016BBB
		[NullableContext(2)]
		public UClass ToUClass()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UClass>(this._NativePtr);
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x000189C8 File Offset: 0x00016BC8
		public override string ToString()
		{
			if (!this.IsValid())
			{
				return "InvalidClass";
			}
			return this.GetName();
		}

		// Token: 0x04000200 RID: 512
		public IntPtr _NativePtr;
	}
}
