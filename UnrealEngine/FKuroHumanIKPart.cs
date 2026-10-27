using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001664 RID: 5732
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.KuroHumanIKPart")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 152)]
	public class FKuroHumanIKPart : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014C1B RID: 85019 RVA: 0x001E85EE File Offset: 0x001E67EE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroHumanIKPart._ScriptStructPtr != 0) ? FKuroHumanIKPart._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.KuroHumanIKPart", ref FKuroHumanIKPart._ScriptStructPtr);
		}

		// Token: 0x17005213 RID: 21011
		// (get) Token: 0x06014C1C RID: 85020 RVA: 0x001E8612 File Offset: 0x001E6812
		// (set) Token: 0x06014C1D RID: 85021 RVA: 0x001E8622 File Offset: 0x001E6822
		public unsafe EIKPartType PartType
		{
			get
			{
				return (EIKPartType)(*(base.NativePtr + (IntPtr)FKuroHumanIKPart.__PropertyOffset_PartType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHumanIKPart.__PropertyOffset_PartType) = (byte)value;
			}
		}

		// Token: 0x17005214 RID: 21012
		// (get) Token: 0x06014C1E RID: 85022 RVA: 0x001E8634 File Offset: 0x001E6834
		// (set) Token: 0x06014C1F RID: 85023 RVA: 0x001E8677 File Offset: 0x001E6877
		public FBoneReference IKBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._IKBone) == null)
				{
					result = (this._IKBone = new FBoneReference(base.NativePtr + (IntPtr)FKuroHumanIKPart.__PropertyOffset_IKBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FKuroHumanIKPart.__PropertyOffset_IKBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005215 RID: 21013
		// (get) Token: 0x06014C20 RID: 85024 RVA: 0x001E8698 File Offset: 0x001E6898
		// (set) Token: 0x06014C21 RID: 85025 RVA: 0x001E86DB File Offset: 0x001E68DB
		public FBoneReference TipBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._TipBone) == null)
				{
					result = (this._TipBone = new FBoneReference(base.NativePtr + (IntPtr)FKuroHumanIKPart.__PropertyOffset_TipBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FKuroHumanIKPart.__PropertyOffset_TipBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005216 RID: 21014
		// (get) Token: 0x06014C22 RID: 85026 RVA: 0x001E86FC File Offset: 0x001E68FC
		// (set) Token: 0x06014C23 RID: 85027 RVA: 0x001E870C File Offset: 0x001E690C
		public unsafe float TipEndOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHumanIKPart.__PropertyOffset_TipEndOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHumanIKPart.__PropertyOffset_TipEndOffset) = value;
			}
		}

		// Token: 0x17005217 RID: 21015
		// (get) Token: 0x06014C24 RID: 85028 RVA: 0x001E871D File Offset: 0x001E691D
		// (set) Token: 0x06014C25 RID: 85029 RVA: 0x001E872D File Offset: 0x001E692D
		public unsafe bool bUseCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHumanIKPart.__PropertyOffset_bUseCurve) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHumanIKPart.__PropertyOffset_bUseCurve) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005218 RID: 21016
		// (get) Token: 0x06014C26 RID: 85030 RVA: 0x001E873E File Offset: 0x001E693E
		// (set) Token: 0x06014C27 RID: 85031 RVA: 0x001E8752 File Offset: 0x001E6952
		public unsafe FName BaseAngleCurveName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHumanIKPart.__PropertyOffset_BaseAngleCurveName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHumanIKPart.__PropertyOffset_BaseAngleCurveName) = value;
			}
		}

		// Token: 0x17005219 RID: 21017
		// (get) Token: 0x06014C28 RID: 85032 RVA: 0x001E8767 File Offset: 0x001E6967
		// (set) Token: 0x06014C29 RID: 85033 RVA: 0x001E877B File Offset: 0x001E697B
		public unsafe string LocationCurveName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroHumanIKPart.__PropertyOffset_LocationCurveName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroHumanIKPart.__PropertyOffset_LocationCurveName)), value);
			}
		}

		// Token: 0x1700521A RID: 21018
		// (get) Token: 0x06014C2A RID: 85034 RVA: 0x001E8790 File Offset: 0x001E6990
		// (set) Token: 0x06014C2B RID: 85035 RVA: 0x001E87A4 File Offset: 0x001E69A4
		public unsafe FName AlphaCurveName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHumanIKPart.__PropertyOffset_AlphaCurveName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHumanIKPart.__PropertyOffset_AlphaCurveName) = value;
			}
		}

		// Token: 0x1700521B RID: 21019
		// (get) Token: 0x06014C2C RID: 85036 RVA: 0x001E87B9 File Offset: 0x001E69B9
		// (set) Token: 0x06014C2D RID: 85037 RVA: 0x001E87CD File Offset: 0x001E69CD
		public unsafe FName LandingTimeCurveName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHumanIKPart.__PropertyOffset_LandingTimeCurveName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHumanIKPart.__PropertyOffset_LandingTimeCurveName) = value;
			}
		}

		// Token: 0x1700521C RID: 21020
		// (get) Token: 0x06014C2E RID: 85038 RVA: 0x001E87E2 File Offset: 0x001E69E2
		// (set) Token: 0x06014C2F RID: 85039 RVA: 0x001E87F2 File Offset: 0x001E69F2
		public unsafe float MaxIkDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHumanIKPart.__PropertyOffset_MaxIkDist);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHumanIKPart.__PropertyOffset_MaxIkDist) = value;
			}
		}

		// Token: 0x1700521D RID: 21021
		// (get) Token: 0x06014C30 RID: 85040 RVA: 0x001E8804 File Offset: 0x001E6A04
		// (set) Token: 0x06014C31 RID: 85041 RVA: 0x001E8848 File Offset: 0x001E6A48
		public TFixedArray<float> LowerLimits
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<float> result;
				if ((result = this._LowerLimits) == null)
				{
					result = (this._LowerLimits = new TFixedArray<float>(base.NativePtr + (IntPtr)FKuroHumanIKPart.__PropertyOffset_LowerLimits, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LowerLimits.CopyAssign(value);
			}
		}

		// Token: 0x1700521E RID: 21022
		// (get) Token: 0x06014C32 RID: 85042 RVA: 0x001E8858 File Offset: 0x001E6A58
		// (set) Token: 0x06014C33 RID: 85043 RVA: 0x001E889C File Offset: 0x001E6A9C
		public TFixedArray<float> EndBoneLimits
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<float> result;
				if ((result = this._EndBoneLimits) == null)
				{
					result = (this._EndBoneLimits = new TFixedArray<float>(base.NativePtr + (IntPtr)FKuroHumanIKPart.__PropertyOffset_EndBoneLimits, 6, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EndBoneLimits.CopyAssign(value);
			}
		}

		// Token: 0x1700521F RID: 21023
		// (get) Token: 0x06014C34 RID: 85044 RVA: 0x001E88AC File Offset: 0x001E6AAC
		// (set) Token: 0x06014C35 RID: 85045 RVA: 0x001E88F0 File Offset: 0x001E6AF0
		public TFixedArray<float> TipAngleLimit
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<float> result;
				if ((result = this._TipAngleLimit) == null)
				{
					result = (this._TipAngleLimit = new TFixedArray<float>(base.NativePtr + (IntPtr)FKuroHumanIKPart.__PropertyOffset_TipAngleLimit, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TipAngleLimit.CopyAssign(value);
			}
		}

		// Token: 0x17005220 RID: 21024
		// (get) Token: 0x06014C36 RID: 85046 RVA: 0x001E88FE File Offset: 0x001E6AFE
		// (set) Token: 0x06014C37 RID: 85047 RVA: 0x001E890E File Offset: 0x001E6B0E
		public unsafe EndBoneIKMode EndBoneIKMode
		{
			get
			{
				return (EndBoneIKMode)(*(base.NativePtr + (IntPtr)FKuroHumanIKPart.__PropertyOffset_EndBoneIKMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHumanIKPart.__PropertyOffset_EndBoneIKMode) = (byte)value;
			}
		}

		// Token: 0x17005221 RID: 21025
		// (get) Token: 0x06014C38 RID: 85048 RVA: 0x001E891F File Offset: 0x001E6B1F
		// (set) Token: 0x06014C39 RID: 85049 RVA: 0x001E892F File Offset: 0x001E6B2F
		public unsafe bool bDebugPrint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHumanIKPart.__PropertyOffset_bDebugPrint) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHumanIKPart.__PropertyOffset_bDebugPrint) = (value ? 1 : 0);
			}
		}

		// Token: 0x06014C3A RID: 85050 RVA: 0x001E8940 File Offset: 0x001E6B40
		public FKuroHumanIKPart()
		{
		}

		// Token: 0x06014C3B RID: 85051 RVA: 0x001E8948 File Offset: 0x001E6B48
		public FKuroHumanIKPart(EIKPartType PartType, FBoneReference IKBone, FBoneReference TipBone, float TipEndOffset, bool bUseCurve, FName BaseAngleCurveName, string LocationCurveName, FName AlphaCurveName, FName LandingTimeCurveName, float MaxIkDist, TFixedArray<float> LowerLimits, TFixedArray<float> EndBoneLimits, TFixedArray<float> TipAngleLimit, EndBoneIKMode EndBoneIKMode, bool bDebugPrint)
		{
			this.PartType = PartType;
			this.IKBone = IKBone;
			this.TipBone = TipBone;
			this.TipEndOffset = TipEndOffset;
			this.bUseCurve = bUseCurve;
			this.BaseAngleCurveName = BaseAngleCurveName;
			this.LocationCurveName = LocationCurveName;
			this.AlphaCurveName = AlphaCurveName;
			this.LandingTimeCurveName = LandingTimeCurveName;
			this.MaxIkDist = MaxIkDist;
			this.LowerLimits = LowerLimits;
			this.EndBoneLimits = EndBoneLimits;
			this.TipAngleLimit = TipAngleLimit;
			this.EndBoneIKMode = EndBoneIKMode;
			this.bDebugPrint = bDebugPrint;
		}

		// Token: 0x06014C3C RID: 85052 RVA: 0x001E89D0 File Offset: 0x001E6BD0
		protected override IntPtr GetUStructPtr()
		{
			return FKuroHumanIKPart.StaticStruct();
		}

		// Token: 0x06014C3D RID: 85053 RVA: 0x001E89DC File Offset: 0x001E6BDC
		[NullableContext(2)]
		public FKuroHumanIKPart(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014C3E RID: 85054 RVA: 0x001E89E6 File Offset: 0x001E6BE6
		public FKuroHumanIKPart(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014C3F RID: 85055 RVA: 0x001E89F1 File Offset: 0x001E6BF1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroHumanIKPart(Pointer, false, true);
		}

		// Token: 0x06014C40 RID: 85056 RVA: 0x001E89FB File Offset: 0x001E6BFB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroHumanIKPart(Pointer, MemoryOwner);
		}

		// Token: 0x0400B512 RID: 46354
		public const string __ObjectPath = "/Script/KuroAnim.KuroHumanIKPart";

		// Token: 0x0400B513 RID: 46355
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B514 RID: 46356
		internal static int __PropertyOffset_PartType;

		// Token: 0x0400B515 RID: 46357
		internal static int __PropertyOffset_IKBone;

		// Token: 0x0400B516 RID: 46358
		[Nullable(2)]
		private FBoneReference _IKBone;

		// Token: 0x0400B517 RID: 46359
		internal static int __PropertyOffset_TipBone;

		// Token: 0x0400B518 RID: 46360
		[Nullable(2)]
		private FBoneReference _TipBone;

		// Token: 0x0400B519 RID: 46361
		internal static int __PropertyOffset_TipEndOffset;

		// Token: 0x0400B51A RID: 46362
		internal static int __PropertyOffset_bUseCurve;

		// Token: 0x0400B51B RID: 46363
		internal static int __PropertyOffset_BaseAngleCurveName;

		// Token: 0x0400B51C RID: 46364
		internal static int __PropertyOffset_LocationCurveName;

		// Token: 0x0400B51D RID: 46365
		internal static int __PropertyOffset_AlphaCurveName;

		// Token: 0x0400B51E RID: 46366
		internal static int __PropertyOffset_LandingTimeCurveName;

		// Token: 0x0400B51F RID: 46367
		internal static int __PropertyOffset_MaxIkDist;

		// Token: 0x0400B520 RID: 46368
		internal static int __PropertyOffset_LowerLimits;

		// Token: 0x0400B521 RID: 46369
		[Nullable(2)]
		private TFixedArray<float> _LowerLimits;

		// Token: 0x0400B522 RID: 46370
		internal static int __PropertyOffset_EndBoneLimits;

		// Token: 0x0400B523 RID: 46371
		[Nullable(2)]
		private TFixedArray<float> _EndBoneLimits;

		// Token: 0x0400B524 RID: 46372
		internal static int __PropertyOffset_TipAngleLimit;

		// Token: 0x0400B525 RID: 46373
		[Nullable(2)]
		private TFixedArray<float> _TipAngleLimit;

		// Token: 0x0400B526 RID: 46374
		internal static int __PropertyOffset_EndBoneIKMode;

		// Token: 0x0400B527 RID: 46375
		internal static int __PropertyOffset_bDebugPrint;
	}
}
