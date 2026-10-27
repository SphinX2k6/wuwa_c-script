using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200167E RID: 5758
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.RibbonChainConfig")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FRibbonChainConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014E44 RID: 85572 RVA: 0x001EB6E7 File Offset: 0x001E98E7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRibbonChainConfig._ScriptStructPtr != 0) ? FRibbonChainConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.RibbonChainConfig", ref FRibbonChainConfig._ScriptStructPtr);
		}

		// Token: 0x170052C2 RID: 21186
		// (get) Token: 0x06014E45 RID: 85573 RVA: 0x001EB70C File Offset: 0x001E990C
		// (set) Token: 0x06014E46 RID: 85574 RVA: 0x001EB74F File Offset: 0x001E994F
		public FBoneReference RootBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._RootBone) == null)
				{
					result = (this._RootBone = new FBoneReference(base.NativePtr + (IntPtr)FRibbonChainConfig.__PropertyOffset_RootBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FRibbonChainConfig.__PropertyOffset_RootBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170052C3 RID: 21187
		// (get) Token: 0x06014E47 RID: 85575 RVA: 0x001EB770 File Offset: 0x001E9970
		// (set) Token: 0x06014E48 RID: 85576 RVA: 0x001EB780 File Offset: 0x001E9980
		public unsafe bool bAppendVirtualEndBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRibbonChainConfig.__PropertyOffset_bAppendVirtualEndBone) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRibbonChainConfig.__PropertyOffset_bAppendVirtualEndBone) = (value ? 1 : 0);
			}
		}

		// Token: 0x170052C4 RID: 21188
		// (get) Token: 0x06014E49 RID: 85577 RVA: 0x001EB791 File Offset: 0x001E9991
		// (set) Token: 0x06014E4A RID: 85578 RVA: 0x001EB7A1 File Offset: 0x001E99A1
		public unsafe ERibbonDepenetrationBoneSelectType BoneSelectType
		{
			get
			{
				return (ERibbonDepenetrationBoneSelectType)(*(base.NativePtr + (IntPtr)FRibbonChainConfig.__PropertyOffset_BoneSelectType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRibbonChainConfig.__PropertyOffset_BoneSelectType) = (byte)value;
			}
		}

		// Token: 0x170052C5 RID: 21189
		// (get) Token: 0x06014E4B RID: 85579 RVA: 0x001EB7B2 File Offset: 0x001E99B2
		// (set) Token: 0x06014E4C RID: 85580 RVA: 0x001EB7C2 File Offset: 0x001E99C2
		public unsafe float HeightLimitValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRibbonChainConfig.__PropertyOffset_HeightLimitValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRibbonChainConfig.__PropertyOffset_HeightLimitValue) = value;
			}
		}

		// Token: 0x170052C6 RID: 21190
		// (get) Token: 0x06014E4D RID: 85581 RVA: 0x001EB7D3 File Offset: 0x001E99D3
		// (set) Token: 0x06014E4E RID: 85582 RVA: 0x001EB7E3 File Offset: 0x001E99E3
		public unsafe int TailBoneCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRibbonChainConfig.__PropertyOffset_TailBoneCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRibbonChainConfig.__PropertyOffset_TailBoneCount) = value;
			}
		}

		// Token: 0x170052C7 RID: 21191
		// (get) Token: 0x06014E4F RID: 85583 RVA: 0x001EB7F4 File Offset: 0x001E99F4
		// (set) Token: 0x06014E50 RID: 85584 RVA: 0x001EB804 File Offset: 0x001E9A04
		public unsafe float DetectRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRibbonChainConfig.__PropertyOffset_DetectRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRibbonChainConfig.__PropertyOffset_DetectRadius) = value;
			}
		}

		// Token: 0x170052C8 RID: 21192
		// (get) Token: 0x06014E51 RID: 85585 RVA: 0x001EB815 File Offset: 0x001E9A15
		// (set) Token: 0x06014E52 RID: 85586 RVA: 0x001EB829 File Offset: 0x001E9A29
		[Nullable(2)]
		public unsafe UCurveFloat RadiusCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FRibbonChainConfig.__PropertyOffset_RadiusCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FRibbonChainConfig.__PropertyOffset_RadiusCurve, value);
			}
		}

		// Token: 0x170052C9 RID: 21193
		// (get) Token: 0x06014E53 RID: 85587 RVA: 0x001EB83E File Offset: 0x001E9A3E
		// (set) Token: 0x06014E54 RID: 85588 RVA: 0x001EB84E File Offset: 0x001E9A4E
		public unsafe float MaxDetectDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRibbonChainConfig.__PropertyOffset_MaxDetectDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRibbonChainConfig.__PropertyOffset_MaxDetectDistance) = value;
			}
		}

		// Token: 0x170052CA RID: 21194
		// (get) Token: 0x06014E55 RID: 85589 RVA: 0x001EB85F File Offset: 0x001E9A5F
		// (set) Token: 0x06014E56 RID: 85590 RVA: 0x001EB86F File Offset: 0x001E9A6F
		public unsafe float MaxCorrectionAngleDeg
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRibbonChainConfig.__PropertyOffset_MaxCorrectionAngleDeg);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRibbonChainConfig.__PropertyOffset_MaxCorrectionAngleDeg) = value;
			}
		}

		// Token: 0x06014E57 RID: 85591 RVA: 0x001EB880 File Offset: 0x001E9A80
		public FRibbonChainConfig()
		{
		}

		// Token: 0x06014E58 RID: 85592 RVA: 0x001EB888 File Offset: 0x001E9A88
		public FRibbonChainConfig(FBoneReference RootBone, bool bAppendVirtualEndBone, ERibbonDepenetrationBoneSelectType BoneSelectType, float HeightLimitValue, int TailBoneCount, float DetectRadius, UCurveFloat RadiusCurve, float MaxDetectDistance, float MaxCorrectionAngleDeg)
		{
			this.RootBone = RootBone;
			this.bAppendVirtualEndBone = bAppendVirtualEndBone;
			this.BoneSelectType = BoneSelectType;
			this.HeightLimitValue = HeightLimitValue;
			this.TailBoneCount = TailBoneCount;
			this.DetectRadius = DetectRadius;
			this.RadiusCurve = RadiusCurve;
			this.MaxDetectDistance = MaxDetectDistance;
			this.MaxCorrectionAngleDeg = MaxCorrectionAngleDeg;
		}

		// Token: 0x06014E59 RID: 85593 RVA: 0x001EB8E0 File Offset: 0x001E9AE0
		protected override IntPtr GetUStructPtr()
		{
			return FRibbonChainConfig.StaticStruct();
		}

		// Token: 0x06014E5A RID: 85594 RVA: 0x001EB8EC File Offset: 0x001E9AEC
		[NullableContext(2)]
		public FRibbonChainConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014E5B RID: 85595 RVA: 0x001EB8F6 File Offset: 0x001E9AF6
		public FRibbonChainConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014E5C RID: 85596 RVA: 0x001EB901 File Offset: 0x001E9B01
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRibbonChainConfig(Pointer, false, true);
		}

		// Token: 0x06014E5D RID: 85597 RVA: 0x001EB90B File Offset: 0x001E9B0B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRibbonChainConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0400B621 RID: 46625
		public const string __ObjectPath = "/Script/KuroAnim.RibbonChainConfig";

		// Token: 0x0400B622 RID: 46626
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B623 RID: 46627
		internal static int __PropertyOffset_RootBone;

		// Token: 0x0400B624 RID: 46628
		[Nullable(2)]
		private FBoneReference _RootBone;

		// Token: 0x0400B625 RID: 46629
		internal static int __PropertyOffset_bAppendVirtualEndBone;

		// Token: 0x0400B626 RID: 46630
		internal static int __PropertyOffset_BoneSelectType;

		// Token: 0x0400B627 RID: 46631
		internal static int __PropertyOffset_HeightLimitValue;

		// Token: 0x0400B628 RID: 46632
		internal static int __PropertyOffset_TailBoneCount;

		// Token: 0x0400B629 RID: 46633
		internal static int __PropertyOffset_DetectRadius;

		// Token: 0x0400B62A RID: 46634
		internal static int __PropertyOffset_RadiusCurve;

		// Token: 0x0400B62B RID: 46635
		internal static int __PropertyOffset_MaxDetectDistance;

		// Token: 0x0400B62C RID: 46636
		internal static int __PropertyOffset_MaxCorrectionAngleDeg;
	}
}
