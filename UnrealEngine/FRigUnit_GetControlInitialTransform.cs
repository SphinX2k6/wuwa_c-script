using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005B2 RID: 1458
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_GetControlInitialTransform")]
	[UnrealStructLayout(112, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FRigUnit_GetControlInitialTransform : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004E97 RID: 20119 RVA: 0x000741A5 File Offset: 0x000723A5
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_GetControlInitialTransform._ScriptStructPtr != 0) ? FRigUnit_GetControlInitialTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_GetControlInitialTransform", ref FRigUnit_GetControlInitialTransform._ScriptStructPtr);
		}

		// Token: 0x17001359 RID: 4953
		// (get) Token: 0x06004E98 RID: 20120 RVA: 0x000741C9 File Offset: 0x000723C9
		// (set) Token: 0x06004E99 RID: 20121 RVA: 0x000741DD File Offset: 0x000723DD
		public unsafe FName Control
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetControlInitialTransform.__PropertyOffset_Control);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetControlInitialTransform.__PropertyOffset_Control) = value;
			}
		}

		// Token: 0x1700135A RID: 4954
		// (get) Token: 0x06004E9A RID: 20122 RVA: 0x000741F2 File Offset: 0x000723F2
		// (set) Token: 0x06004E9B RID: 20123 RVA: 0x00074202 File Offset: 0x00072402
		public unsafe EBoneGetterSetterMode Space
		{
			get
			{
				return (EBoneGetterSetterMode)(*(base.NativePtr + (IntPtr)FRigUnit_GetControlInitialTransform.__PropertyOffset_Space));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetControlInitialTransform.__PropertyOffset_Space) = (byte)value;
			}
		}

		// Token: 0x1700135B RID: 4955
		// (get) Token: 0x06004E9C RID: 20124 RVA: 0x00074213 File Offset: 0x00072413
		// (set) Token: 0x06004E9D RID: 20125 RVA: 0x00074227 File Offset: 0x00072427
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetControlInitialTransform.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetControlInitialTransform.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x1700135C RID: 4956
		// (get) Token: 0x06004E9E RID: 20126 RVA: 0x0007423C File Offset: 0x0007243C
		// (set) Token: 0x06004E9F RID: 20127 RVA: 0x0007427F File Offset: 0x0007247F
		public FCachedRigElement CachedControlIndex
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedControlIndex) == null)
				{
					result = (this._CachedControlIndex = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_GetControlInitialTransform.__PropertyOffset_CachedControlIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_GetControlInitialTransform.__PropertyOffset_CachedControlIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004EA0 RID: 20128 RVA: 0x000742A0 File Offset: 0x000724A0
		public FRigUnit_GetControlInitialTransform()
		{
		}

		// Token: 0x06004EA1 RID: 20129 RVA: 0x000742A8 File Offset: 0x000724A8
		public FRigUnit_GetControlInitialTransform(FName Control, EBoneGetterSetterMode Space, FTransform Transform, FCachedRigElement CachedControlIndex)
		{
			this.Control = Control;
			this.Space = Space;
			this.Transform = Transform;
			this.CachedControlIndex = CachedControlIndex;
		}

		// Token: 0x06004EA2 RID: 20130 RVA: 0x000742CD File Offset: 0x000724CD
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_GetControlInitialTransform.StaticStruct();
		}

		// Token: 0x06004EA3 RID: 20131 RVA: 0x000742D9 File Offset: 0x000724D9
		[NullableContext(2)]
		public FRigUnit_GetControlInitialTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004EA4 RID: 20132 RVA: 0x000742E3 File Offset: 0x000724E3
		public FRigUnit_GetControlInitialTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004EA5 RID: 20133 RVA: 0x000742EE File Offset: 0x000724EE
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_GetControlInitialTransform(Pointer, false, true);
		}

		// Token: 0x06004EA6 RID: 20134 RVA: 0x000742F8 File Offset: 0x000724F8
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_GetControlInitialTransform(Pointer, MemoryOwner);
		}

		// Token: 0x040025F8 RID: 9720
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_GetControlInitialTransform";

		// Token: 0x040025F9 RID: 9721
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040025FA RID: 9722
		internal static int __PropertyOffset_Control;

		// Token: 0x040025FB RID: 9723
		internal static int __PropertyOffset_Space;

		// Token: 0x040025FC RID: 9724
		internal static int __PropertyOffset_Transform;

		// Token: 0x040025FD RID: 9725
		internal static int __PropertyOffset_CachedControlIndex;

		// Token: 0x040025FE RID: 9726
		[Nullable(2)]
		private FCachedRigElement _CachedControlIndex;
	}
}
