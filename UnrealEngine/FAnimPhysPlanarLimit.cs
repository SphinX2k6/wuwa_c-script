using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200030C RID: 780
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimPhysPlanarLimit")]
	[UnrealStructLayout(80, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FAnimPhysPlanarLimit : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002D13 RID: 11539 RVA: 0x0004530C File Offset: 0x0004350C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimPhysPlanarLimit._ScriptStructPtr != 0) ? FAnimPhysPlanarLimit._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimPhysPlanarLimit", ref FAnimPhysPlanarLimit._ScriptStructPtr);
		}

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x06002D14 RID: 11540 RVA: 0x00045330 File Offset: 0x00043530
		// (set) Token: 0x06002D15 RID: 11541 RVA: 0x00045373 File Offset: 0x00043573
		public FBoneReference DrivingBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._DrivingBone) == null)
				{
					result = (this._DrivingBone = new FBoneReference(base.NativePtr + (IntPtr)FAnimPhysPlanarLimit.__PropertyOffset_DrivingBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimPhysPlanarLimit.__PropertyOffset_DrivingBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x06002D16 RID: 11542 RVA: 0x00045394 File Offset: 0x00043594
		// (set) Token: 0x06002D17 RID: 11543 RVA: 0x000453A8 File Offset: 0x000435A8
		public unsafe FTransform PlaneTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimPhysPlanarLimit.__PropertyOffset_PlaneTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimPhysPlanarLimit.__PropertyOffset_PlaneTransform) = value;
			}
		}

		// Token: 0x06002D18 RID: 11544 RVA: 0x000453BD File Offset: 0x000435BD
		public FAnimPhysPlanarLimit()
		{
		}

		// Token: 0x06002D19 RID: 11545 RVA: 0x000453C5 File Offset: 0x000435C5
		public FAnimPhysPlanarLimit(FBoneReference DrivingBone, FTransform PlaneTransform)
		{
			this.DrivingBone = DrivingBone;
			this.PlaneTransform = PlaneTransform;
		}

		// Token: 0x06002D1A RID: 11546 RVA: 0x000453DB File Offset: 0x000435DB
		protected override IntPtr GetUStructPtr()
		{
			return FAnimPhysPlanarLimit.StaticStruct();
		}

		// Token: 0x06002D1B RID: 11547 RVA: 0x000453E7 File Offset: 0x000435E7
		[NullableContext(2)]
		public FAnimPhysPlanarLimit(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002D1C RID: 11548 RVA: 0x000453F1 File Offset: 0x000435F1
		public FAnimPhysPlanarLimit(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002D1D RID: 11549 RVA: 0x000453FC File Offset: 0x000435FC
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimPhysPlanarLimit(Pointer, false, true);
		}

		// Token: 0x06002D1E RID: 11550 RVA: 0x00045406 File Offset: 0x00043606
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimPhysPlanarLimit(Pointer, MemoryOwner);
		}

		// Token: 0x040012A6 RID: 4774
		public const string __ObjectPath = "/Script/AnimGraphRuntime.AnimPhysPlanarLimit";

		// Token: 0x040012A7 RID: 4775
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040012A8 RID: 4776
		internal static int __PropertyOffset_DrivingBone;

		// Token: 0x040012A9 RID: 4777
		[Nullable(2)]
		private FBoneReference _DrivingBone;

		// Token: 0x040012AA RID: 4778
		internal static int __PropertyOffset_PlaneTransform;
	}
}
