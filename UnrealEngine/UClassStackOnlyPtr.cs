using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200007E RID: 126
	[NullableContext(1)]
	[Nullable(0)]
	public struct UClassStackOnlyPtr : IEquatable<UClassStackOnlyPtr>
	{
		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000BEF RID: 3055 RVA: 0x00013602 File Offset: 0x00011802
		public IntPtr NativePtr
		{
			get
			{
				return this._NativePtr;
			}
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x0001360A File Offset: 0x0001180A
		public UClassStackOnlyPtr(IntPtr NativePtr)
		{
			this._NativePtr = NativePtr;
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x00013613 File Offset: 0x00011813
		public static implicit operator UClassStackOnlyPtr(IntPtr Ptr)
		{
			return new UClassStackOnlyPtr(Ptr);
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x0001361B File Offset: 0x0001181B
		public bool Equals(UClassStackOnlyPtr Other)
		{
			return this == Other;
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x00013629 File Offset: 0x00011829
		public override int GetHashCode()
		{
			return this._NativePtr.GetHashCode();
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x00013636 File Offset: 0x00011836
		public static bool operator ==(UClassStackOnlyPtr Left, UClassStackOnlyPtr Right)
		{
			return Left._NativePtr == Right._NativePtr;
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x00013646 File Offset: 0x00011846
		public static bool operator !=(UClassStackOnlyPtr Left, UClassStackOnlyPtr Right)
		{
			return Left._NativePtr != Right._NativePtr;
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x00013659 File Offset: 0x00011859
		public bool IsValid()
		{
			return this._NativePtr != IntPtr.Zero && UClass.IsValid(this);
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x00013675 File Offset: 0x00011875
		public bool IsChildOf(UClassStackOnlyPtr B)
		{
			return UClass.IsChildOf(this, B);
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x00013683 File Offset: 0x00011883
		public bool IsA(UClassStackOnlyPtr B)
		{
			return UClass.IsA(this, B);
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x00013691 File Offset: 0x00011891
		public FName GetFName()
		{
			return UClass.GetFName(this);
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x0001369E File Offset: 0x0001189E
		public string GetName()
		{
			return UClass.GetName(this);
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x000136AB File Offset: 0x000118AB
		public string GetPathName()
		{
			return UClass.GetPathName(this);
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x000136B8 File Offset: 0x000118B8
		public UClassStackOnlyPtr GetClass()
		{
			return UClass.GetClass(this);
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000BFD RID: 3069 RVA: 0x000136C5 File Offset: 0x000118C5
		public int ObjectIndex
		{
			get
			{
				return UClass.GetObjectIndex(this);
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000BFE RID: 3070 RVA: 0x000136D2 File Offset: 0x000118D2
		public int ObjectSerialNumber
		{
			get
			{
				return UClass.GetObjectSerialNumber(this);
			}
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x000136DF File Offset: 0x000118DF
		[NullableContext(2)]
		public UClass ToUClass()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UClass>(this._NativePtr);
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x000136EC File Offset: 0x000118EC
		public override string ToString()
		{
			if (!this.IsValid())
			{
				return "InvalidClass";
			}
			return this.GetName();
		}

		// Token: 0x040001B9 RID: 441
		public IntPtr _NativePtr;
	}
}
