using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000542 RID: 1346
	[UnrealObjectPath("/Script/ControlRig.RigUnit_AimBone_Target")]
	[UnrealStructLayout(44, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 44)]
	public class FRigUnit_AimBone_Target : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060046D8 RID: 18136 RVA: 0x000692C0 File Offset: 0x000674C0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_AimBone_Target._ScriptStructPtr != 0) ? FRigUnit_AimBone_Target._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_AimBone_Target", ref FRigUnit_AimBone_Target._ScriptStructPtr);
		}

		// Token: 0x17001138 RID: 4408
		// (get) Token: 0x060046D9 RID: 18137 RVA: 0x000692E4 File Offset: 0x000674E4
		// (set) Token: 0x060046DA RID: 18138 RVA: 0x000692F4 File Offset: 0x000674F4
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AimBone_Target.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AimBone_Target.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x17001139 RID: 4409
		// (get) Token: 0x060046DB RID: 18139 RVA: 0x00069305 File Offset: 0x00067505
		// (set) Token: 0x060046DC RID: 18140 RVA: 0x00069319 File Offset: 0x00067519
		public unsafe FVector Axis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AimBone_Target.__PropertyOffset_Axis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AimBone_Target.__PropertyOffset_Axis) = value;
			}
		}

		// Token: 0x1700113A RID: 4410
		// (get) Token: 0x060046DD RID: 18141 RVA: 0x0006932E File Offset: 0x0006752E
		// (set) Token: 0x060046DE RID: 18142 RVA: 0x00069342 File Offset: 0x00067542
		public unsafe FVector Target
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AimBone_Target.__PropertyOffset_Target);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AimBone_Target.__PropertyOffset_Target) = value;
			}
		}

		// Token: 0x1700113B RID: 4411
		// (get) Token: 0x060046DF RID: 18143 RVA: 0x00069357 File Offset: 0x00067557
		// (set) Token: 0x060046E0 RID: 18144 RVA: 0x00069367 File Offset: 0x00067567
		public unsafe EControlRigVectorKind Kind
		{
			get
			{
				return (EControlRigVectorKind)(*(base.NativePtr + (IntPtr)FRigUnit_AimBone_Target.__PropertyOffset_Kind));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AimBone_Target.__PropertyOffset_Kind) = (byte)value;
			}
		}

		// Token: 0x1700113C RID: 4412
		// (get) Token: 0x060046E1 RID: 18145 RVA: 0x00069378 File Offset: 0x00067578
		// (set) Token: 0x060046E2 RID: 18146 RVA: 0x0006938C File Offset: 0x0006758C
		public unsafe FName Space
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AimBone_Target.__PropertyOffset_Space);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AimBone_Target.__PropertyOffset_Space) = value;
			}
		}

		// Token: 0x060046E3 RID: 18147 RVA: 0x000693A1 File Offset: 0x000675A1
		public FRigUnit_AimBone_Target()
		{
		}

		// Token: 0x060046E4 RID: 18148 RVA: 0x000693A9 File Offset: 0x000675A9
		public FRigUnit_AimBone_Target(float Weight, FVector Axis, FVector Target, EControlRigVectorKind Kind, FName Space)
		{
			this.Weight = Weight;
			this.Axis = Axis;
			this.Target = Target;
			this.Kind = Kind;
			this.Space = Space;
		}

		// Token: 0x060046E5 RID: 18149 RVA: 0x000693D6 File Offset: 0x000675D6
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_AimBone_Target.StaticStruct();
		}

		// Token: 0x060046E6 RID: 18150 RVA: 0x000693E2 File Offset: 0x000675E2
		[NullableContext(2)]
		public FRigUnit_AimBone_Target(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060046E7 RID: 18151 RVA: 0x000693EC File Offset: 0x000675EC
		public FRigUnit_AimBone_Target(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060046E8 RID: 18152 RVA: 0x000693F7 File Offset: 0x000675F7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_AimBone_Target(Pointer, false, true);
		}

		// Token: 0x060046E9 RID: 18153 RVA: 0x00069401 File Offset: 0x00067601
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_AimBone_Target(Pointer, MemoryOwner);
		}

		// Token: 0x04002269 RID: 8809
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_AimBone_Target";

		// Token: 0x0400226A RID: 8810
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400226B RID: 8811
		internal static int __PropertyOffset_Weight;

		// Token: 0x0400226C RID: 8812
		internal static int __PropertyOffset_Axis;

		// Token: 0x0400226D RID: 8813
		internal static int __PropertyOffset_Target;

		// Token: 0x0400226E RID: 8814
		internal static int __PropertyOffset_Kind;

		// Token: 0x0400226F RID: 8815
		internal static int __PropertyOffset_Space;
	}
}
