using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006BC RID: 1724
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SetControlTransform")]
	[UnrealStructLayout(208, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 208)]
	public class FRigUnit_SetControlTransform : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005C1F RID: 23583 RVA: 0x00084405 File Offset: 0x00082605
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SetControlTransform._ScriptStructPtr != 0) ? FRigUnit_SetControlTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SetControlTransform", ref FRigUnit_SetControlTransform._ScriptStructPtr);
		}

		// Token: 0x170015FD RID: 5629
		// (get) Token: 0x06005C20 RID: 23584 RVA: 0x00084429 File Offset: 0x00082629
		// (set) Token: 0x06005C21 RID: 23585 RVA: 0x0008443D File Offset: 0x0008263D
		public unsafe FName Control
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetControlTransform.__PropertyOffset_Control);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetControlTransform.__PropertyOffset_Control) = value;
			}
		}

		// Token: 0x170015FE RID: 5630
		// (get) Token: 0x06005C22 RID: 23586 RVA: 0x00084452 File Offset: 0x00082652
		// (set) Token: 0x06005C23 RID: 23587 RVA: 0x00084462 File Offset: 0x00082662
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetControlTransform.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetControlTransform.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x170015FF RID: 5631
		// (get) Token: 0x06005C24 RID: 23588 RVA: 0x00084473 File Offset: 0x00082673
		// (set) Token: 0x06005C25 RID: 23589 RVA: 0x00084487 File Offset: 0x00082687
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetControlTransform.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetControlTransform.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x17001600 RID: 5632
		// (get) Token: 0x06005C26 RID: 23590 RVA: 0x0008449C File Offset: 0x0008269C
		// (set) Token: 0x06005C27 RID: 23591 RVA: 0x000844AC File Offset: 0x000826AC
		public unsafe EBoneGetterSetterMode Space
		{
			get
			{
				return (EBoneGetterSetterMode)(*(base.NativePtr + (IntPtr)FRigUnit_SetControlTransform.__PropertyOffset_Space));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetControlTransform.__PropertyOffset_Space) = (byte)value;
			}
		}

		// Token: 0x17001601 RID: 5633
		// (get) Token: 0x06005C28 RID: 23592 RVA: 0x000844C0 File Offset: 0x000826C0
		// (set) Token: 0x06005C29 RID: 23593 RVA: 0x00084503 File Offset: 0x00082703
		public FCachedRigElement CachedControlIndex
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedControlIndex) == null)
				{
					result = (this._CachedControlIndex = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_SetControlTransform.__PropertyOffset_CachedControlIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SetControlTransform.__PropertyOffset_CachedControlIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005C2A RID: 23594 RVA: 0x00084524 File Offset: 0x00082724
		public FRigUnit_SetControlTransform()
		{
		}

		// Token: 0x06005C2B RID: 23595 RVA: 0x0008452C File Offset: 0x0008272C
		public FRigUnit_SetControlTransform(FName Control, float Weight, FTransform Transform, EBoneGetterSetterMode Space, FCachedRigElement CachedControlIndex, FControlRigExecuteContext ExecuteContext)
		{
			this.Control = Control;
			this.Weight = Weight;
			this.Transform = Transform;
			this.Space = Space;
			this.CachedControlIndex = CachedControlIndex;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005C2C RID: 23596 RVA: 0x00084561 File Offset: 0x00082761
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SetControlTransform.StaticStruct();
		}

		// Token: 0x06005C2D RID: 23597 RVA: 0x0008456D File Offset: 0x0008276D
		[NullableContext(2)]
		public FRigUnit_SetControlTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005C2E RID: 23598 RVA: 0x00084577 File Offset: 0x00082777
		public FRigUnit_SetControlTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005C2F RID: 23599 RVA: 0x00084582 File Offset: 0x00082782
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SetControlTransform(Pointer, false, true);
		}

		// Token: 0x06005C30 RID: 23600 RVA: 0x0008458C File Offset: 0x0008278C
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SetControlTransform(Pointer, MemoryOwner);
		}

		// Token: 0x04002B1F RID: 11039
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_SetControlTransform";

		// Token: 0x04002B20 RID: 11040
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002B21 RID: 11041
		internal static int __PropertyOffset_Control;

		// Token: 0x04002B22 RID: 11042
		internal static int __PropertyOffset_Weight;

		// Token: 0x04002B23 RID: 11043
		internal static int __PropertyOffset_Transform;

		// Token: 0x04002B24 RID: 11044
		internal static int __PropertyOffset_Space;

		// Token: 0x04002B25 RID: 11045
		internal static int __PropertyOffset_CachedControlIndex;

		// Token: 0x04002B26 RID: 11046
		[Nullable(2)]
		private FCachedRigElement _CachedControlIndex;
	}
}
