using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006BD RID: 1725
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SetControlVector")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 168)]
	public class FRigUnit_SetControlVector : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005C31 RID: 23601 RVA: 0x00084595 File Offset: 0x00082795
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SetControlVector._ScriptStructPtr != 0) ? FRigUnit_SetControlVector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SetControlVector", ref FRigUnit_SetControlVector._ScriptStructPtr);
		}

		// Token: 0x17001602 RID: 5634
		// (get) Token: 0x06005C32 RID: 23602 RVA: 0x000845B9 File Offset: 0x000827B9
		// (set) Token: 0x06005C33 RID: 23603 RVA: 0x000845CD File Offset: 0x000827CD
		public unsafe FName Control
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetControlVector.__PropertyOffset_Control);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetControlVector.__PropertyOffset_Control) = value;
			}
		}

		// Token: 0x17001603 RID: 5635
		// (get) Token: 0x06005C34 RID: 23604 RVA: 0x000845E2 File Offset: 0x000827E2
		// (set) Token: 0x06005C35 RID: 23605 RVA: 0x000845F2 File Offset: 0x000827F2
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetControlVector.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetControlVector.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x17001604 RID: 5636
		// (get) Token: 0x06005C36 RID: 23606 RVA: 0x00084603 File Offset: 0x00082803
		// (set) Token: 0x06005C37 RID: 23607 RVA: 0x00084617 File Offset: 0x00082817
		public unsafe FVector Vector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetControlVector.__PropertyOffset_Vector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetControlVector.__PropertyOffset_Vector) = value;
			}
		}

		// Token: 0x17001605 RID: 5637
		// (get) Token: 0x06005C38 RID: 23608 RVA: 0x0008462C File Offset: 0x0008282C
		// (set) Token: 0x06005C39 RID: 23609 RVA: 0x0008463C File Offset: 0x0008283C
		public unsafe EBoneGetterSetterMode Space
		{
			get
			{
				return (EBoneGetterSetterMode)(*(base.NativePtr + (IntPtr)FRigUnit_SetControlVector.__PropertyOffset_Space));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetControlVector.__PropertyOffset_Space) = (byte)value;
			}
		}

		// Token: 0x17001606 RID: 5638
		// (get) Token: 0x06005C3A RID: 23610 RVA: 0x00084650 File Offset: 0x00082850
		// (set) Token: 0x06005C3B RID: 23611 RVA: 0x00084693 File Offset: 0x00082893
		public FCachedRigElement CachedControlIndex
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedControlIndex) == null)
				{
					result = (this._CachedControlIndex = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_SetControlVector.__PropertyOffset_CachedControlIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SetControlVector.__PropertyOffset_CachedControlIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005C3C RID: 23612 RVA: 0x000846B4 File Offset: 0x000828B4
		public FRigUnit_SetControlVector()
		{
		}

		// Token: 0x06005C3D RID: 23613 RVA: 0x000846BC File Offset: 0x000828BC
		public FRigUnit_SetControlVector(FName Control, float Weight, FVector Vector, EBoneGetterSetterMode Space, FCachedRigElement CachedControlIndex, FControlRigExecuteContext ExecuteContext)
		{
			this.Control = Control;
			this.Weight = Weight;
			this.Vector = Vector;
			this.Space = Space;
			this.CachedControlIndex = CachedControlIndex;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005C3E RID: 23614 RVA: 0x000846F1 File Offset: 0x000828F1
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SetControlVector.StaticStruct();
		}

		// Token: 0x06005C3F RID: 23615 RVA: 0x000846FD File Offset: 0x000828FD
		[NullableContext(2)]
		public FRigUnit_SetControlVector(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005C40 RID: 23616 RVA: 0x00084707 File Offset: 0x00082907
		public FRigUnit_SetControlVector(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005C41 RID: 23617 RVA: 0x00084712 File Offset: 0x00082912
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SetControlVector(Pointer, false, true);
		}

		// Token: 0x06005C42 RID: 23618 RVA: 0x0008471C File Offset: 0x0008291C
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SetControlVector(Pointer, MemoryOwner);
		}

		// Token: 0x04002B27 RID: 11047
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_SetControlVector";

		// Token: 0x04002B28 RID: 11048
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002B29 RID: 11049
		internal static int __PropertyOffset_Control;

		// Token: 0x04002B2A RID: 11050
		internal static int __PropertyOffset_Weight;

		// Token: 0x04002B2B RID: 11051
		internal static int __PropertyOffset_Vector;

		// Token: 0x04002B2C RID: 11052
		internal static int __PropertyOffset_Space;

		// Token: 0x04002B2D RID: 11053
		internal static int __PropertyOffset_CachedControlIndex;

		// Token: 0x04002B2E RID: 11054
		[Nullable(2)]
		private FCachedRigElement _CachedControlIndex;
	}
}
