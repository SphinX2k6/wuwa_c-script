using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001099 RID: 4249
	[UnrealObjectPath("/Script/Engine.RigTransformConstraint")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FRigTransformConstraint : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F2DA RID: 62170 RVA: 0x001683EE File Offset: 0x001665EE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigTransformConstraint._ScriptStructPtr != 0) ? FRigTransformConstraint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RigTransformConstraint", ref FRigTransformConstraint._ScriptStructPtr);
		}

		// Token: 0x17003B25 RID: 15141
		// (get) Token: 0x0600F2DB RID: 62171 RVA: 0x00168412 File Offset: 0x00166612
		// (set) Token: 0x0600F2DC RID: 62172 RVA: 0x00168426 File Offset: 0x00166626
		public unsafe TEnumAsByte<EConstraintTransform> TranformType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigTransformConstraint.__PropertyOffset_TranformType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigTransformConstraint.__PropertyOffset_TranformType) = value;
			}
		}

		// Token: 0x17003B26 RID: 15142
		// (get) Token: 0x0600F2DD RID: 62173 RVA: 0x0016843B File Offset: 0x0016663B
		// (set) Token: 0x0600F2DE RID: 62174 RVA: 0x0016844F File Offset: 0x0016664F
		public unsafe FName ParentSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigTransformConstraint.__PropertyOffset_ParentSpace);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigTransformConstraint.__PropertyOffset_ParentSpace) = value;
			}
		}

		// Token: 0x17003B27 RID: 15143
		// (get) Token: 0x0600F2DF RID: 62175 RVA: 0x00168464 File Offset: 0x00166664
		// (set) Token: 0x0600F2E0 RID: 62176 RVA: 0x00168474 File Offset: 0x00166674
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigTransformConstraint.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigTransformConstraint.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x0600F2E1 RID: 62177 RVA: 0x00168485 File Offset: 0x00166685
		public FRigTransformConstraint()
		{
		}

		// Token: 0x0600F2E2 RID: 62178 RVA: 0x0016848D File Offset: 0x0016668D
		public FRigTransformConstraint(TEnumAsByte<EConstraintTransform> TranformType, FName ParentSpace, float Weight)
		{
			this.TranformType = TranformType;
			this.ParentSpace = ParentSpace;
			this.Weight = Weight;
		}

		// Token: 0x0600F2E3 RID: 62179 RVA: 0x001684AA File Offset: 0x001666AA
		protected override IntPtr GetUStructPtr()
		{
			return FRigTransformConstraint.StaticStruct();
		}

		// Token: 0x0600F2E4 RID: 62180 RVA: 0x001684B6 File Offset: 0x001666B6
		[NullableContext(2)]
		public FRigTransformConstraint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F2E5 RID: 62181 RVA: 0x001684C0 File Offset: 0x001666C0
		public FRigTransformConstraint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F2E6 RID: 62182 RVA: 0x001684CB File Offset: 0x001666CB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigTransformConstraint(Pointer, false, true);
		}

		// Token: 0x0600F2E7 RID: 62183 RVA: 0x001684D5 File Offset: 0x001666D5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigTransformConstraint(Pointer, MemoryOwner);
		}

		// Token: 0x040083BC RID: 33724
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.RigTransformConstraint";

		// Token: 0x040083BD RID: 33725
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040083BE RID: 33726
		internal static int __PropertyOffset_TranformType;

		// Token: 0x040083BF RID: 33727
		internal static int __PropertyOffset_ParentSpace;

		// Token: 0x040083C0 RID: 33728
		internal static int __PropertyOffset_Weight;
	}
}
