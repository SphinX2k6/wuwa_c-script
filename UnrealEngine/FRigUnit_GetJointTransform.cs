using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005BB RID: 1467
	[UnrealObjectPath("/Script/ControlRig.RigUnit_GetJointTransform")]
	[UnrealStructLayout(240, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 240)]
	public class FRigUnit_GetJointTransform : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004F2F RID: 20271 RVA: 0x00074E71 File Offset: 0x00073071
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_GetJointTransform._ScriptStructPtr != 0) ? FRigUnit_GetJointTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_GetJointTransform", ref FRigUnit_GetJointTransform._ScriptStructPtr);
		}

		// Token: 0x17001381 RID: 4993
		// (get) Token: 0x06004F30 RID: 20272 RVA: 0x00074E95 File Offset: 0x00073095
		// (set) Token: 0x06004F31 RID: 20273 RVA: 0x00074EA9 File Offset: 0x000730A9
		public unsafe FName Joint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetJointTransform.__PropertyOffset_Joint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetJointTransform.__PropertyOffset_Joint) = value;
			}
		}

		// Token: 0x17001382 RID: 4994
		// (get) Token: 0x06004F32 RID: 20274 RVA: 0x00074EBE File Offset: 0x000730BE
		// (set) Token: 0x06004F33 RID: 20275 RVA: 0x00074ECE File Offset: 0x000730CE
		public unsafe ETransformGetterType Type
		{
			get
			{
				return (ETransformGetterType)(*(base.NativePtr + (IntPtr)FRigUnit_GetJointTransform.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetJointTransform.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x17001383 RID: 4995
		// (get) Token: 0x06004F34 RID: 20276 RVA: 0x00074EDF File Offset: 0x000730DF
		// (set) Token: 0x06004F35 RID: 20277 RVA: 0x00074EEF File Offset: 0x000730EF
		public unsafe ETransformSpaceMode TransformSpace
		{
			get
			{
				return (ETransformSpaceMode)(*(base.NativePtr + (IntPtr)FRigUnit_GetJointTransform.__PropertyOffset_TransformSpace));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetJointTransform.__PropertyOffset_TransformSpace) = (byte)value;
			}
		}

		// Token: 0x17001384 RID: 4996
		// (get) Token: 0x06004F36 RID: 20278 RVA: 0x00074F00 File Offset: 0x00073100
		// (set) Token: 0x06004F37 RID: 20279 RVA: 0x00074F14 File Offset: 0x00073114
		public unsafe FTransform BaseTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetJointTransform.__PropertyOffset_BaseTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetJointTransform.__PropertyOffset_BaseTransform) = value;
			}
		}

		// Token: 0x17001385 RID: 4997
		// (get) Token: 0x06004F38 RID: 20280 RVA: 0x00074F29 File Offset: 0x00073129
		// (set) Token: 0x06004F39 RID: 20281 RVA: 0x00074F3D File Offset: 0x0007313D
		public unsafe FName BaseJoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetJointTransform.__PropertyOffset_BaseJoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetJointTransform.__PropertyOffset_BaseJoint) = value;
			}
		}

		// Token: 0x17001386 RID: 4998
		// (get) Token: 0x06004F3A RID: 20282 RVA: 0x00074F52 File Offset: 0x00073152
		// (set) Token: 0x06004F3B RID: 20283 RVA: 0x00074F66 File Offset: 0x00073166
		public unsafe FTransform Output
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetJointTransform.__PropertyOffset_Output);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetJointTransform.__PropertyOffset_Output) = value;
			}
		}

		// Token: 0x06004F3C RID: 20284 RVA: 0x00074F7B File Offset: 0x0007317B
		public FRigUnit_GetJointTransform()
		{
		}

		// Token: 0x06004F3D RID: 20285 RVA: 0x00074F83 File Offset: 0x00073183
		[NullableContext(1)]
		public FRigUnit_GetJointTransform(FName Joint, ETransformGetterType Type, ETransformSpaceMode TransformSpace, FTransform BaseTransform, FName BaseJoint, FTransform Output, FControlRigExecuteContext ExecuteContext)
		{
			this.Joint = Joint;
			this.Type = Type;
			this.TransformSpace = TransformSpace;
			this.BaseTransform = BaseTransform;
			this.BaseJoint = BaseJoint;
			this.Output = Output;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06004F3E RID: 20286 RVA: 0x00074FC0 File Offset: 0x000731C0
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_GetJointTransform.StaticStruct();
		}

		// Token: 0x06004F3F RID: 20287 RVA: 0x00074FCC File Offset: 0x000731CC
		[NullableContext(2)]
		public FRigUnit_GetJointTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004F40 RID: 20288 RVA: 0x00074FD6 File Offset: 0x000731D6
		public FRigUnit_GetJointTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004F41 RID: 20289 RVA: 0x00074FE1 File Offset: 0x000731E1
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_GetJointTransform(Pointer, false, true);
		}

		// Token: 0x06004F42 RID: 20290 RVA: 0x00074FEB File Offset: 0x000731EB
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_GetJointTransform(Pointer, MemoryOwner);
		}

		// Token: 0x0400263A RID: 9786
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_GetJointTransform";

		// Token: 0x0400263B RID: 9787
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400263C RID: 9788
		internal static int __PropertyOffset_Joint;

		// Token: 0x0400263D RID: 9789
		internal static int __PropertyOffset_Type;

		// Token: 0x0400263E RID: 9790
		internal static int __PropertyOffset_TransformSpace;

		// Token: 0x0400263F RID: 9791
		internal static int __PropertyOffset_BaseTransform;

		// Token: 0x04002640 RID: 9792
		internal static int __PropertyOffset_BaseJoint;

		// Token: 0x04002641 RID: 9793
		internal static int __PropertyOffset_Output;
	}
}
