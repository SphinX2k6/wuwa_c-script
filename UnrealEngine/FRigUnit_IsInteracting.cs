using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005CC RID: 1484
	[UnrealObjectPath("/Script/ControlRig.RigUnit_IsInteracting")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_IsInteracting : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600502B RID: 20523 RVA: 0x00076661 File Offset: 0x00074861
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_IsInteracting._ScriptStructPtr != 0) ? FRigUnit_IsInteracting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_IsInteracting", ref FRigUnit_IsInteracting._ScriptStructPtr);
		}

		// Token: 0x170013BC RID: 5052
		// (get) Token: 0x0600502C RID: 20524 RVA: 0x00076685 File Offset: 0x00074885
		// (set) Token: 0x0600502D RID: 20525 RVA: 0x00076695 File Offset: 0x00074895
		public unsafe bool bIsInteracting
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_IsInteracting.__PropertyOffset_bIsInteracting) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_IsInteracting.__PropertyOffset_bIsInteracting) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600502E RID: 20526 RVA: 0x000766A6 File Offset: 0x000748A6
		public FRigUnit_IsInteracting()
		{
		}

		// Token: 0x0600502F RID: 20527 RVA: 0x000766AE File Offset: 0x000748AE
		public FRigUnit_IsInteracting(bool bIsInteracting)
		{
			this.bIsInteracting = bIsInteracting;
		}

		// Token: 0x06005030 RID: 20528 RVA: 0x000766BD File Offset: 0x000748BD
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_IsInteracting.StaticStruct();
		}

		// Token: 0x06005031 RID: 20529 RVA: 0x000766C9 File Offset: 0x000748C9
		[NullableContext(2)]
		public FRigUnit_IsInteracting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005032 RID: 20530 RVA: 0x000766D3 File Offset: 0x000748D3
		public FRigUnit_IsInteracting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005033 RID: 20531 RVA: 0x000766DE File Offset: 0x000748DE
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_IsInteracting(Pointer, false, true);
		}

		// Token: 0x06005034 RID: 20532 RVA: 0x000766E8 File Offset: 0x000748E8
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_IsInteracting(Pointer, MemoryOwner);
		}

		// Token: 0x040026B2 RID: 9906
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_IsInteracting";

		// Token: 0x040026B3 RID: 9907
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040026B4 RID: 9908
		internal static int __PropertyOffset_bIsInteracting;
	}
}
