using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200030E RID: 782
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimPhysSphericalLimit")]
	[UnrealStructLayout(40, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FAnimPhysSphericalLimit : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002D1F RID: 11551 RVA: 0x0004540F File Offset: 0x0004360F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimPhysSphericalLimit._ScriptStructPtr != 0) ? FAnimPhysSphericalLimit._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimPhysSphericalLimit", ref FAnimPhysSphericalLimit._ScriptStructPtr);
		}

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x06002D20 RID: 11552 RVA: 0x00045434 File Offset: 0x00043634
		// (set) Token: 0x06002D21 RID: 11553 RVA: 0x00045477 File Offset: 0x00043677
		public FBoneReference DrivingBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._DrivingBone) == null)
				{
					result = (this._DrivingBone = new FBoneReference(base.NativePtr + (IntPtr)FAnimPhysSphericalLimit.__PropertyOffset_DrivingBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimPhysSphericalLimit.__PropertyOffset_DrivingBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x06002D22 RID: 11554 RVA: 0x00045498 File Offset: 0x00043698
		// (set) Token: 0x06002D23 RID: 11555 RVA: 0x000454AC File Offset: 0x000436AC
		public unsafe FVector SphereLocalOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimPhysSphericalLimit.__PropertyOffset_SphereLocalOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimPhysSphericalLimit.__PropertyOffset_SphereLocalOffset) = value;
			}
		}

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x06002D24 RID: 11556 RVA: 0x000454C1 File Offset: 0x000436C1
		// (set) Token: 0x06002D25 RID: 11557 RVA: 0x000454D1 File Offset: 0x000436D1
		public unsafe float LimitRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimPhysSphericalLimit.__PropertyOffset_LimitRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimPhysSphericalLimit.__PropertyOffset_LimitRadius) = value;
			}
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x06002D26 RID: 11558 RVA: 0x000454E2 File Offset: 0x000436E2
		// (set) Token: 0x06002D27 RID: 11559 RVA: 0x000454F2 File Offset: 0x000436F2
		public unsafe ESphericalLimitType LimitType
		{
			get
			{
				return (ESphericalLimitType)(*(base.NativePtr + (IntPtr)FAnimPhysSphericalLimit.__PropertyOffset_LimitType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimPhysSphericalLimit.__PropertyOffset_LimitType) = (byte)value;
			}
		}

		// Token: 0x06002D28 RID: 11560 RVA: 0x00045503 File Offset: 0x00043703
		public FAnimPhysSphericalLimit()
		{
		}

		// Token: 0x06002D29 RID: 11561 RVA: 0x0004550B File Offset: 0x0004370B
		public FAnimPhysSphericalLimit(FBoneReference DrivingBone, FVector SphereLocalOffset, float LimitRadius, ESphericalLimitType LimitType)
		{
			this.DrivingBone = DrivingBone;
			this.SphereLocalOffset = SphereLocalOffset;
			this.LimitRadius = LimitRadius;
			this.LimitType = LimitType;
		}

		// Token: 0x06002D2A RID: 11562 RVA: 0x00045530 File Offset: 0x00043730
		protected override IntPtr GetUStructPtr()
		{
			return FAnimPhysSphericalLimit.StaticStruct();
		}

		// Token: 0x06002D2B RID: 11563 RVA: 0x0004553C File Offset: 0x0004373C
		[NullableContext(2)]
		public FAnimPhysSphericalLimit(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002D2C RID: 11564 RVA: 0x00045546 File Offset: 0x00043746
		public FAnimPhysSphericalLimit(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002D2D RID: 11565 RVA: 0x00045551 File Offset: 0x00043751
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimPhysSphericalLimit(Pointer, false, true);
		}

		// Token: 0x06002D2E RID: 11566 RVA: 0x0004555B File Offset: 0x0004375B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimPhysSphericalLimit(Pointer, MemoryOwner);
		}

		// Token: 0x040012B2 RID: 4786
		public const string __ObjectPath = "/Script/AnimGraphRuntime.AnimPhysSphericalLimit";

		// Token: 0x040012B3 RID: 4787
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040012B4 RID: 4788
		internal static int __PropertyOffset_DrivingBone;

		// Token: 0x040012B5 RID: 4789
		[Nullable(2)]
		private FBoneReference _DrivingBone;

		// Token: 0x040012B6 RID: 4790
		internal static int __PropertyOffset_SphereLocalOffset;

		// Token: 0x040012B7 RID: 4791
		internal static int __PropertyOffset_LimitRadius;

		// Token: 0x040012B8 RID: 4792
		internal static int __PropertyOffset_LimitType;
	}
}
