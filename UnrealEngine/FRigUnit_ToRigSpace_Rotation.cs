using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006E6 RID: 1766
	[UnrealObjectPath("/Script/ControlRig.RigUnit_ToRigSpace_Rotation")]
	[UnrealStructLayout(48, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_ToRigSpace_Rotation : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005ED8 RID: 24280 RVA: 0x00088070 File Offset: 0x00086270
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_ToRigSpace_Rotation._ScriptStructPtr != 0) ? FRigUnit_ToRigSpace_Rotation._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_ToRigSpace_Rotation", ref FRigUnit_ToRigSpace_Rotation._ScriptStructPtr);
		}

		// Token: 0x170016B2 RID: 5810
		// (get) Token: 0x06005ED9 RID: 24281 RVA: 0x00088094 File Offset: 0x00086294
		// (set) Token: 0x06005EDA RID: 24282 RVA: 0x000880A8 File Offset: 0x000862A8
		public unsafe FQuat Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ToRigSpace_Rotation.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ToRigSpace_Rotation.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x170016B3 RID: 5811
		// (get) Token: 0x06005EDB RID: 24283 RVA: 0x000880BD File Offset: 0x000862BD
		// (set) Token: 0x06005EDC RID: 24284 RVA: 0x000880D1 File Offset: 0x000862D1
		public unsafe FQuat Global
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ToRigSpace_Rotation.__PropertyOffset_Global);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ToRigSpace_Rotation.__PropertyOffset_Global) = value;
			}
		}

		// Token: 0x06005EDD RID: 24285 RVA: 0x000880E6 File Offset: 0x000862E6
		public FRigUnit_ToRigSpace_Rotation()
		{
		}

		// Token: 0x06005EDE RID: 24286 RVA: 0x000880EE File Offset: 0x000862EE
		public FRigUnit_ToRigSpace_Rotation(FQuat Rotation, FQuat Global)
		{
			this.Rotation = Rotation;
			this.Global = Global;
		}

		// Token: 0x06005EDF RID: 24287 RVA: 0x00088104 File Offset: 0x00086304
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_ToRigSpace_Rotation.StaticStruct();
		}

		// Token: 0x06005EE0 RID: 24288 RVA: 0x00088110 File Offset: 0x00086310
		[NullableContext(2)]
		public FRigUnit_ToRigSpace_Rotation(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005EE1 RID: 24289 RVA: 0x0008811A File Offset: 0x0008631A
		public FRigUnit_ToRigSpace_Rotation(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005EE2 RID: 24290 RVA: 0x00088125 File Offset: 0x00086325
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_ToRigSpace_Rotation(Pointer, false, true);
		}

		// Token: 0x06005EE3 RID: 24291 RVA: 0x0008812F File Offset: 0x0008632F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_ToRigSpace_Rotation(Pointer, MemoryOwner);
		}

		// Token: 0x04002C5B RID: 11355
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_ToRigSpace_Rotation";

		// Token: 0x04002C5C RID: 11356
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002C5D RID: 11357
		internal static int __PropertyOffset_Rotation;

		// Token: 0x04002C5E RID: 11358
		internal static int __PropertyOffset_Global;
	}
}
