using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000088 RID: 136
	public abstract class UnrealUserDefinedStructProxy : UnrealScriptStructProxy
	{
		// Token: 0x06000C49 RID: 3145 RVA: 0x00013E27 File Offset: 0x00012027
		protected UnrealUserDefinedStructProxy()
		{
			BuiltinUtils.AddRefForUUserDefinedStruct(this.GetUStructPtr());
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x00013E3A File Offset: 0x0001203A
		[NullableContext(2)]
		protected UnrealUserDefinedStructProxy(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
			if (base.IsNativePtrAllocated)
			{
				BuiltinUtils.AddRefForUUserDefinedStruct(this.GetUStructPtr());
			}
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x00013E57 File Offset: 0x00012057
		protected UnrealUserDefinedStructProxy(IntPtr NativePtr, bool bWithMoveConstruct, bool bWithCopyConstructIfCannotMove) : base(NativePtr, bWithMoveConstruct, bWithCopyConstructIfCannotMove)
		{
			BuiltinUtils.AddRefForUUserDefinedStruct(this.GetUStructPtr());
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x00013E6D File Offset: 0x0001206D
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
