using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006E7 RID: 1767
	[UnrealObjectPath("/Script/ControlRig.RigUnit_ToRigSpace_Transform")]
	[UnrealStructLayout(112, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FRigUnit_ToRigSpace_Transform : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005EE4 RID: 24292 RVA: 0x00088138 File Offset: 0x00086338
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_ToRigSpace_Transform._ScriptStructPtr != 0) ? FRigUnit_ToRigSpace_Transform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_ToRigSpace_Transform", ref FRigUnit_ToRigSpace_Transform._ScriptStructPtr);
		}

		// Token: 0x170016B4 RID: 5812
		// (get) Token: 0x06005EE5 RID: 24293 RVA: 0x0008815C File Offset: 0x0008635C
		// (set) Token: 0x06005EE6 RID: 24294 RVA: 0x00088170 File Offset: 0x00086370
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ToRigSpace_Transform.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ToRigSpace_Transform.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x170016B5 RID: 5813
		// (get) Token: 0x06005EE7 RID: 24295 RVA: 0x00088185 File Offset: 0x00086385
		// (set) Token: 0x06005EE8 RID: 24296 RVA: 0x00088199 File Offset: 0x00086399
		public unsafe FTransform Global
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ToRigSpace_Transform.__PropertyOffset_Global);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ToRigSpace_Transform.__PropertyOffset_Global) = value;
			}
		}

		// Token: 0x06005EE9 RID: 24297 RVA: 0x000881AE File Offset: 0x000863AE
		public FRigUnit_ToRigSpace_Transform()
		{
		}

		// Token: 0x06005EEA RID: 24298 RVA: 0x000881B6 File Offset: 0x000863B6
		public FRigUnit_ToRigSpace_Transform(FTransform Transform, FTransform Global)
		{
			this.Transform = Transform;
			this.Global = Global;
		}

		// Token: 0x06005EEB RID: 24299 RVA: 0x000881CC File Offset: 0x000863CC
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_ToRigSpace_Transform.StaticStruct();
		}

		// Token: 0x06005EEC RID: 24300 RVA: 0x000881D8 File Offset: 0x000863D8
		[NullableContext(2)]
		public FRigUnit_ToRigSpace_Transform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005EED RID: 24301 RVA: 0x000881E2 File Offset: 0x000863E2
		public FRigUnit_ToRigSpace_Transform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005EEE RID: 24302 RVA: 0x000881ED File Offset: 0x000863ED
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_ToRigSpace_Transform(Pointer, false, true);
		}

		// Token: 0x06005EEF RID: 24303 RVA: 0x000881F7 File Offset: 0x000863F7
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_ToRigSpace_Transform(Pointer, MemoryOwner);
		}

		// Token: 0x04002C5F RID: 11359
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_ToRigSpace_Transform";

		// Token: 0x04002C60 RID: 11360
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002C61 RID: 11361
		internal static int __PropertyOffset_Transform;

		// Token: 0x04002C62 RID: 11362
		internal static int __PropertyOffset_Global;
	}
}
