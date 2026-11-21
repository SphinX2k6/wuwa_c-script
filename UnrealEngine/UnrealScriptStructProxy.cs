using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000086 RID: 134
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class UnrealScriptStructProxy : UnrealProxyObject
	{
		// Token: 0x06000C29 RID: 3113 RVA: 0x00013C17 File Offset: 0x00011E17
		protected UnrealScriptStructProxy()
		{
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x00013C1F File Offset: 0x00011E1F
		protected UnrealScriptStructProxy(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
			this.GetUStructPtr();
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x00013C30 File Offset: 0x00011E30
		protected UnrealScriptStructProxy(IntPtr NativePtr, bool bWithMoveConstruct, bool bWithCopyConstructIfCannotMove) : base(NativePtr, bWithMoveConstruct, bWithCopyConstructIfCannotMove)
		{
		}

		// Token: 0x06000C2C RID: 3116
		protected abstract IntPtr GetUStructPtr();

		// Token: 0x06000C2D RID: 3117 RVA: 0x00013C3B File Offset: 0x00011E3B
		protected sealed override IntPtr AllocNativePtr()
		{
			return UnrealReflectionUtils.AllocNativeStruct(this.GetUStructPtr());
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x00013C4D File Offset: 0x00011E4D
		protected sealed override void DeallocNativePtr()
		{
			UnrealReflectionUtils.DestroyAndDeallocNativeStruct(this.GetUStructPtr(), this._NativePtr, 1);
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000C2F RID: 3119 RVA: 0x00013C66 File Offset: 0x00011E66
		public sealed override bool AllowMoveAssign
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000C30 RID: 3120 RVA: 0x00013C69 File Offset: 0x00011E69
		public sealed override bool AllowCopyAssign
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x00013C6C File Offset: 0x00011E6C
		public sealed override void CopyAssign(IntPtr FromNativePtr)
		{
			UnrealReflectionUtils.CopyNativeStruct(this.GetUStructPtr(), this._NativePtr, FromNativePtr, 1, false);
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x00013C87 File Offset: 0x00011E87
		public sealed override void CopyTo(IntPtr DestPtr, UScriptStructStackOnlyPtr NativeUStructPtr = default(UScriptStructStackOnlyPtr))
		{
			UnrealReflectionUtils.CopyNativeStruct(NativeUStructPtr, DestPtr, this._NativePtr, 1, false);
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x00013C98 File Offset: 0x00011E98
		public static bool operator ==(UnrealScriptStructProxy Self, UnrealScriptStructProxy Other)
		{
			return Self == Other || (Self != null && Other != null && (Self._NativePtr == Other._NativePtr || (Self._NativePtr != IntPtr.Zero && Other._NativePtr != IntPtr.Zero && UnrealReflectionUtils.CompareNativeStruct(Self.GetUStructPtr(), Self._NativePtr, Other._NativePtr))));
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x00013CFB File Offset: 0x00011EFB
		public static bool operator !=(UnrealScriptStructProxy Self, UnrealScriptStructProxy Other)
		{
			return !(Self == Other);
		}
	}
}
