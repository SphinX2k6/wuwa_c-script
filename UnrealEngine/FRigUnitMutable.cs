using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200052F RID: 1327
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnitMutable")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FRigUnitMutable : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004586 RID: 17798 RVA: 0x0006775A File Offset: 0x0006595A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnitMutable._ScriptStructPtr != 0) ? FRigUnitMutable._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnitMutable", ref FRigUnitMutable._ScriptStructPtr);
		}

		// Token: 0x170010DB RID: 4315
		// (get) Token: 0x06004587 RID: 17799 RVA: 0x00067780 File Offset: 0x00065980
		// (set) Token: 0x06004588 RID: 17800 RVA: 0x000677C3 File Offset: 0x000659C3
		public FControlRigExecuteContext ExecuteContext
		{
			get
			{
				base.FastCheckIsValid();
				FControlRigExecuteContext result;
				if ((result = this._ExecuteContext) == null)
				{
					result = (this._ExecuteContext = new FControlRigExecuteContext(base.NativePtr + (IntPtr)FRigUnitMutable.__PropertyOffset_ExecuteContext, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FControlRigExecuteContext.StaticStruct(), base.NativePtr + (IntPtr)FRigUnitMutable.__PropertyOffset_ExecuteContext, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004589 RID: 17801 RVA: 0x000677E4 File Offset: 0x000659E4
		public FRigUnitMutable()
		{
		}

		// Token: 0x0600458A RID: 17802 RVA: 0x000677EC File Offset: 0x000659EC
		public FRigUnitMutable(FControlRigExecuteContext ExecuteContext)
		{
			this.ExecuteContext = ExecuteContext;
		}

		// Token: 0x0600458B RID: 17803 RVA: 0x000677FB File Offset: 0x000659FB
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnitMutable.StaticStruct();
		}

		// Token: 0x0600458C RID: 17804 RVA: 0x00067807 File Offset: 0x00065A07
		[NullableContext(2)]
		public FRigUnitMutable(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600458D RID: 17805 RVA: 0x00067811 File Offset: 0x00065A11
		public FRigUnitMutable(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600458E RID: 17806 RVA: 0x0006781C File Offset: 0x00065A1C
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnitMutable(Pointer, false, true);
		}

		// Token: 0x0600458F RID: 17807 RVA: 0x00067826 File Offset: 0x00065A26
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnitMutable(Pointer, MemoryOwner);
		}

		// Token: 0x040021D9 RID: 8665
		public new const string __ObjectPath = "/Script/ControlRig.RigUnitMutable";

		// Token: 0x040021DA RID: 8666
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040021DB RID: 8667
		internal static int __PropertyOffset_ExecuteContext;

		// Token: 0x040021DC RID: 8668
		[Nullable(2)]
		private FControlRigExecuteContext _ExecuteContext;
	}
}
