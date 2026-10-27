using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000A1 RID: 161
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class UnrealScriptStructProxy : UnrealProxyObject
	{
		// Token: 0x06001096 RID: 4246 RVA: 0x00018EF3 File Offset: 0x000170F3
		protected UnrealScriptStructProxy()
		{
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x00018EFB File Offset: 0x000170FB
		protected UnrealScriptStructProxy(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
			this.GetUStructPtr();
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x00018F0C File Offset: 0x0001710C
		protected UnrealScriptStructProxy(IntPtr NativePtr, bool bWithMoveConstruct, bool bWithCopyConstructIfCannotMove) : base(NativePtr, bWithMoveConstruct, bWithCopyConstructIfCannotMove)
		{
		}

		// Token: 0x06001099 RID: 4249
		protected abstract IntPtr GetUStructPtr();

		// Token: 0x0600109A RID: 4250 RVA: 0x00018F17 File Offset: 0x00017117
		protected sealed override IntPtr AllocNativePtr()
		{
			return UnrealReflectionUtils.AllocNativeStruct(this.GetUStructPtr());
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x00018F29 File Offset: 0x00017129
		protected sealed override void DeallocNativePtr()
		{
			UnrealReflectionUtils.DestroyAndDeallocNativeStruct(this.GetUStructPtr(), this._NativePtr, 1);
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x0600109C RID: 4252 RVA: 0x00018F42 File Offset: 0x00017142
		public sealed override bool AllowMoveAssign
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x0600109D RID: 4253 RVA: 0x00018F45 File Offset: 0x00017145
		public sealed override bool AllowCopyAssign
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x00018F48 File Offset: 0x00017148
		public sealed override void CopyAssign(IntPtr FromNativePtr)
		{
			UnrealReflectionUtils.CopyNativeStruct(this.GetUStructPtr(), this._NativePtr, FromNativePtr, 1, false);
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x00018F63 File Offset: 0x00017163
		public sealed override void CopyTo(IntPtr DestPtr, UScriptStructStackOnlyPtr NativeUStructPtr = default(UScriptStructStackOnlyPtr))
		{
			UnrealReflectionUtils.CopyNativeStruct(NativeUStructPtr, DestPtr, this._NativePtr, 1, false);
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x00018F74 File Offset: 0x00017174
		public static bool operator ==(UnrealScriptStructProxy Self, UnrealScriptStructProxy Other)
		{
			return Self == Other || (Self != null && Other != null && (Self._NativePtr == Other._NativePtr || (Self._NativePtr != IntPtr.Zero && Other._NativePtr != IntPtr.Zero && UnrealReflectionUtils.CompareNativeStruct(Self.GetUStructPtr(), Self._NativePtr, Other._NativePtr))));
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x00018FD7 File Offset: 0x000171D7
		public static bool operator !=(UnrealScriptStructProxy Self, UnrealScriptStructProxy Other)
		{
			return !(Self == Other);
		}
	}
}
