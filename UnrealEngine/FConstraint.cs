using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000313 RID: 787
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.Constraint")]
	[UnrealStructLayout(32, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FConstraint : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002D5C RID: 11612 RVA: 0x0004596D File Offset: 0x00043B6D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FConstraint._ScriptStructPtr != 0) ? FConstraint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.Constraint", ref FConstraint._ScriptStructPtr);
		}

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x06002D5D RID: 11613 RVA: 0x00045994 File Offset: 0x00043B94
		// (set) Token: 0x06002D5E RID: 11614 RVA: 0x000459D7 File Offset: 0x00043BD7
		public FBoneReference TargetBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._TargetBone) == null)
				{
					result = (this._TargetBone = new FBoneReference(base.NativePtr + (IntPtr)FConstraint.__PropertyOffset_TargetBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FConstraint.__PropertyOffset_TargetBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x06002D5F RID: 11615 RVA: 0x000459F8 File Offset: 0x00043BF8
		// (set) Token: 0x06002D60 RID: 11616 RVA: 0x00045A08 File Offset: 0x00043C08
		public unsafe EConstraintOffsetOption OffsetOption
		{
			get
			{
				return (EConstraintOffsetOption)(*(base.NativePtr + (IntPtr)FConstraint.__PropertyOffset_OffsetOption));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraint.__PropertyOffset_OffsetOption) = (byte)value;
			}
		}

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x06002D61 RID: 11617 RVA: 0x00045A19 File Offset: 0x00043C19
		// (set) Token: 0x06002D62 RID: 11618 RVA: 0x00045A29 File Offset: 0x00043C29
		public unsafe ETransformConstraintType TransformType
		{
			get
			{
				return (ETransformConstraintType)(*(base.NativePtr + (IntPtr)FConstraint.__PropertyOffset_TransformType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraint.__PropertyOffset_TransformType) = (byte)value;
			}
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x06002D63 RID: 11619 RVA: 0x00045A3C File Offset: 0x00043C3C
		// (set) Token: 0x06002D64 RID: 11620 RVA: 0x00045A7F File Offset: 0x00043C7F
		public FFilterOptionPerAxis PerAxis
		{
			get
			{
				base.FastCheckIsValid();
				FFilterOptionPerAxis result;
				if ((result = this._PerAxis) == null)
				{
					result = (this._PerAxis = new FFilterOptionPerAxis(base.NativePtr + (IntPtr)FConstraint.__PropertyOffset_PerAxis, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFilterOptionPerAxis.StaticStruct(), base.NativePtr + (IntPtr)FConstraint.__PropertyOffset_PerAxis, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06002D65 RID: 11621 RVA: 0x00045AA0 File Offset: 0x00043CA0
		public FConstraint()
		{
		}

		// Token: 0x06002D66 RID: 11622 RVA: 0x00045AA8 File Offset: 0x00043CA8
		public FConstraint(FBoneReference TargetBone, EConstraintOffsetOption OffsetOption, ETransformConstraintType TransformType, FFilterOptionPerAxis PerAxis)
		{
			this.TargetBone = TargetBone;
			this.OffsetOption = OffsetOption;
			this.TransformType = TransformType;
			this.PerAxis = PerAxis;
		}

		// Token: 0x06002D67 RID: 11623 RVA: 0x00045ACD File Offset: 0x00043CCD
		protected override IntPtr GetUStructPtr()
		{
			return FConstraint.StaticStruct();
		}

		// Token: 0x06002D68 RID: 11624 RVA: 0x00045AD9 File Offset: 0x00043CD9
		[NullableContext(2)]
		public FConstraint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002D69 RID: 11625 RVA: 0x00045AE3 File Offset: 0x00043CE3
		public FConstraint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002D6A RID: 11626 RVA: 0x00045AEE File Offset: 0x00043CEE
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FConstraint(Pointer, false, true);
		}

		// Token: 0x06002D6B RID: 11627 RVA: 0x00045AF8 File Offset: 0x00043CF8
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FConstraint(Pointer, MemoryOwner);
		}

		// Token: 0x040012CF RID: 4815
		public const string __ObjectPath = "/Script/AnimGraphRuntime.Constraint";

		// Token: 0x040012D0 RID: 4816
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040012D1 RID: 4817
		internal static int __PropertyOffset_TargetBone;

		// Token: 0x040012D2 RID: 4818
		[Nullable(2)]
		private FBoneReference _TargetBone;

		// Token: 0x040012D3 RID: 4819
		internal static int __PropertyOffset_OffsetOption;

		// Token: 0x040012D4 RID: 4820
		internal static int __PropertyOffset_TransformType;

		// Token: 0x040012D5 RID: 4821
		internal static int __PropertyOffset_PerAxis;

		// Token: 0x040012D6 RID: 4822
		[Nullable(2)]
		private FFilterOptionPerAxis _PerAxis;
	}
}
