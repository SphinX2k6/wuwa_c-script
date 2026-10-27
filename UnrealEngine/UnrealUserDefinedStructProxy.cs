using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000A3 RID: 163
	public abstract class UnrealUserDefinedStructProxy : UnrealScriptStructProxy
	{
		// Token: 0x060010B6 RID: 4278 RVA: 0x00019103 File Offset: 0x00017303
		protected UnrealUserDefinedStructProxy()
		{
			BuiltinUtils.AddRefForUUserDefinedStruct(this.GetUStructPtr());
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x00019116 File Offset: 0x00017316
		[NullableContext(2)]
		protected UnrealUserDefinedStructProxy(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
			if (base.IsNativePtrAllocated)
			{
				BuiltinUtils.DecRefForUUserDefinedStruct(this.GetUStructPtr());
			}
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x00019133 File Offset: 0x00017333
		protected UnrealUserDefinedStructProxy(IntPtr NativePtr, bool bWithMoveConstruct, bool bWithCopyConstructIfCannotMove) : base(NativePtr, bWithMoveConstruct, bWithCopyConstructIfCannotMove)
		{
			BuiltinUtils.AddRefForUUserDefinedStruct(this.GetUStructPtr());
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x00019149 File Offset: 0x00017349
		protected override void OnScriptObjectDestruct()
		{
			if (this._NativePtr != IntPtr.Zero && base.IsNativePtrAllocated)
			{
				BuiltinUtils.DecRefForUUserDefinedStruct(this.GetUStructPtr());
			}
			base.OnScriptObjectDestruct();
		}
	}
}
