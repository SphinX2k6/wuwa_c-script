using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002B8 RID: 696
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimationCore.ConstraintData")]
	[UnrealStructLayout(128, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FConstraintData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060026BE RID: 9918 RVA: 0x0003A3E2 File Offset: 0x000385E2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FConstraintData._ScriptStructPtr != 0) ? FConstraintData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimationCore.ConstraintData", ref FConstraintData._ScriptStructPtr);
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x060026BF RID: 9919 RVA: 0x0003A408 File Offset: 0x00038608
		// (set) Token: 0x060026C0 RID: 9920 RVA: 0x0003A44B File Offset: 0x0003864B
		public FConstraintDescriptor Constraint
		{
			get
			{
				base.FastCheckIsValid();
				FConstraintDescriptor result;
				if ((result = this._Constraint) == null)
				{
					result = (this._Constraint = new FConstraintDescriptor(base.NativePtr + (IntPtr)FConstraintData.__PropertyOffset_Constraint, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FConstraintDescriptor.StaticStruct(), base.NativePtr + (IntPtr)FConstraintData.__PropertyOffset_Constraint, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x060026C1 RID: 9921 RVA: 0x0003A46C File Offset: 0x0003866C
		// (set) Token: 0x060026C2 RID: 9922 RVA: 0x0003A47C File Offset: 0x0003867C
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstraintData.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintData.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x060026C3 RID: 9923 RVA: 0x0003A48D File Offset: 0x0003868D
		// (set) Token: 0x060026C4 RID: 9924 RVA: 0x0003A49D File Offset: 0x0003869D
		public unsafe bool bMaintainOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstraintData.__PropertyOffset_bMaintainOffset) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintData.__PropertyOffset_bMaintainOffset) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x060026C5 RID: 9925 RVA: 0x0003A4AE File Offset: 0x000386AE
		// (set) Token: 0x060026C6 RID: 9926 RVA: 0x0003A4C2 File Offset: 0x000386C2
		public unsafe FTransform Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstraintData.__PropertyOffset_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintData.__PropertyOffset_Offset) = value;
			}
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x060026C7 RID: 9927 RVA: 0x0003A4D7 File Offset: 0x000386D7
		// (set) Token: 0x060026C8 RID: 9928 RVA: 0x0003A4EB File Offset: 0x000386EB
		public unsafe FTransform CurrentTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstraintData.__PropertyOffset_CurrentTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintData.__PropertyOffset_CurrentTransform) = value;
			}
		}

		// Token: 0x060026C9 RID: 9929 RVA: 0x0003A500 File Offset: 0x00038700
		public FConstraintData()
		{
		}

		// Token: 0x060026CA RID: 9930 RVA: 0x0003A508 File Offset: 0x00038708
		public FConstraintData(FConstraintDescriptor Constraint, float Weight, bool bMaintainOffset, FTransform Offset, FTransform CurrentTransform)
		{
			this.Constraint = Constraint;
			this.Weight = Weight;
			this.bMaintainOffset = bMaintainOffset;
			this.Offset = Offset;
			this.CurrentTransform = CurrentTransform;
		}

		// Token: 0x060026CB RID: 9931 RVA: 0x0003A535 File Offset: 0x00038735
		protected override IntPtr GetUStructPtr()
		{
			return FConstraintData.StaticStruct();
		}

		// Token: 0x060026CC RID: 9932 RVA: 0x0003A541 File Offset: 0x00038741
		[NullableContext(2)]
		public FConstraintData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060026CD RID: 9933 RVA: 0x0003A54B File Offset: 0x0003874B
		public FConstraintData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060026CE RID: 9934 RVA: 0x0003A556 File Offset: 0x00038756
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FConstraintData(Pointer, false, true);
		}

		// Token: 0x060026CF RID: 9935 RVA: 0x0003A560 File Offset: 0x00038760
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FConstraintData(Pointer, MemoryOwner);
		}

		// Token: 0x04000F38 RID: 3896
		public const string __ObjectPath = "/Script/AnimationCore.ConstraintData";

		// Token: 0x04000F39 RID: 3897
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000F3A RID: 3898
		internal static int __PropertyOffset_Constraint;

		// Token: 0x04000F3B RID: 3899
		[Nullable(2)]
		private FConstraintDescriptor _Constraint;

		// Token: 0x04000F3C RID: 3900
		internal static int __PropertyOffset_Weight;

		// Token: 0x04000F3D RID: 3901
		internal static int __PropertyOffset_bMaintainOffset;

		// Token: 0x04000F3E RID: 3902
		internal static int __PropertyOffset_Offset;

		// Token: 0x04000F3F RID: 3903
		internal static int __PropertyOffset_CurrentTransform;
	}
}
