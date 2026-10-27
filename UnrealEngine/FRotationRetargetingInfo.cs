using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000340 RID: 832
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.RotationRetargetingInfo")]
	[UnrealStructLayout(304, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 304)]
	public class FRotationRetargetingInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002E67 RID: 11879 RVA: 0x000471E2 File Offset: 0x000453E2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRotationRetargetingInfo._ScriptStructPtr != 0) ? FRotationRetargetingInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.RotationRetargetingInfo", ref FRotationRetargetingInfo._ScriptStructPtr);
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x06002E68 RID: 11880 RVA: 0x00047206 File Offset: 0x00045406
		// (set) Token: 0x06002E69 RID: 11881 RVA: 0x00047216 File Offset: 0x00045416
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRotationRetargetingInfo.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRotationRetargetingInfo.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x06002E6A RID: 11882 RVA: 0x00047227 File Offset: 0x00045427
		// (set) Token: 0x06002E6B RID: 11883 RVA: 0x0004723B File Offset: 0x0004543B
		public unsafe FTransform Source
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRotationRetargetingInfo.__PropertyOffset_Source);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRotationRetargetingInfo.__PropertyOffset_Source) = value;
			}
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x06002E6C RID: 11884 RVA: 0x00047250 File Offset: 0x00045450
		// (set) Token: 0x06002E6D RID: 11885 RVA: 0x00047264 File Offset: 0x00045464
		public unsafe FTransform Target
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRotationRetargetingInfo.__PropertyOffset_Target);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRotationRetargetingInfo.__PropertyOffset_Target) = value;
			}
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x06002E6E RID: 11886 RVA: 0x00047279 File Offset: 0x00045479
		// (set) Token: 0x06002E6F RID: 11887 RVA: 0x00047289 File Offset: 0x00045489
		public unsafe ERotationComponent RotationComponent
		{
			get
			{
				return (ERotationComponent)(*(base.NativePtr + (IntPtr)FRotationRetargetingInfo.__PropertyOffset_RotationComponent));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRotationRetargetingInfo.__PropertyOffset_RotationComponent) = (byte)value;
			}
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x06002E70 RID: 11888 RVA: 0x0004729A File Offset: 0x0004549A
		// (set) Token: 0x06002E71 RID: 11889 RVA: 0x000472AE File Offset: 0x000454AE
		public unsafe FVector TwistAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRotationRetargetingInfo.__PropertyOffset_TwistAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRotationRetargetingInfo.__PropertyOffset_TwistAxis) = value;
			}
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x06002E72 RID: 11890 RVA: 0x000472C3 File Offset: 0x000454C3
		// (set) Token: 0x06002E73 RID: 11891 RVA: 0x000472D3 File Offset: 0x000454D3
		public unsafe bool bUseAbsoluteAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRotationRetargetingInfo.__PropertyOffset_bUseAbsoluteAngle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRotationRetargetingInfo.__PropertyOffset_bUseAbsoluteAngle) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x06002E74 RID: 11892 RVA: 0x000472E4 File Offset: 0x000454E4
		// (set) Token: 0x06002E75 RID: 11893 RVA: 0x000472F4 File Offset: 0x000454F4
		public unsafe float SourceMinimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRotationRetargetingInfo.__PropertyOffset_SourceMinimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRotationRetargetingInfo.__PropertyOffset_SourceMinimum) = value;
			}
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x06002E76 RID: 11894 RVA: 0x00047305 File Offset: 0x00045505
		// (set) Token: 0x06002E77 RID: 11895 RVA: 0x00047315 File Offset: 0x00045515
		public unsafe float SourceMaximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRotationRetargetingInfo.__PropertyOffset_SourceMaximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRotationRetargetingInfo.__PropertyOffset_SourceMaximum) = value;
			}
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x06002E78 RID: 11896 RVA: 0x00047326 File Offset: 0x00045526
		// (set) Token: 0x06002E79 RID: 11897 RVA: 0x00047336 File Offset: 0x00045536
		public unsafe float TargetMinimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRotationRetargetingInfo.__PropertyOffset_TargetMinimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRotationRetargetingInfo.__PropertyOffset_TargetMinimum) = value;
			}
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x06002E7A RID: 11898 RVA: 0x00047347 File Offset: 0x00045547
		// (set) Token: 0x06002E7B RID: 11899 RVA: 0x00047357 File Offset: 0x00045557
		public unsafe float TargetMaximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRotationRetargetingInfo.__PropertyOffset_TargetMaximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRotationRetargetingInfo.__PropertyOffset_TargetMaximum) = value;
			}
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x06002E7C RID: 11900 RVA: 0x00047368 File Offset: 0x00045568
		// (set) Token: 0x06002E7D RID: 11901 RVA: 0x00047378 File Offset: 0x00045578
		public unsafe EEasingFuncType EasingType
		{
			get
			{
				return (EEasingFuncType)(*(base.NativePtr + (IntPtr)FRotationRetargetingInfo.__PropertyOffset_EasingType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRotationRetargetingInfo.__PropertyOffset_EasingType) = (byte)value;
			}
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x06002E7E RID: 11902 RVA: 0x0004738C File Offset: 0x0004558C
		// (set) Token: 0x06002E7F RID: 11903 RVA: 0x000473CF File Offset: 0x000455CF
		public FRuntimeFloatCurve CustomCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRuntimeFloatCurve result;
				if ((result = this._CustomCurve) == null)
				{
					result = (this._CustomCurve = new FRuntimeFloatCurve(base.NativePtr + (IntPtr)FRotationRetargetingInfo.__PropertyOffset_CustomCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRuntimeFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)FRotationRetargetingInfo.__PropertyOffset_CustomCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x06002E80 RID: 11904 RVA: 0x000473F0 File Offset: 0x000455F0
		// (set) Token: 0x06002E81 RID: 11905 RVA: 0x00047400 File Offset: 0x00045600
		public unsafe bool bFlipEasing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRotationRetargetingInfo.__PropertyOffset_bFlipEasing) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRotationRetargetingInfo.__PropertyOffset_bFlipEasing) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x06002E82 RID: 11906 RVA: 0x00047411 File Offset: 0x00045611
		// (set) Token: 0x06002E83 RID: 11907 RVA: 0x00047421 File Offset: 0x00045621
		public unsafe float EasingWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRotationRetargetingInfo.__PropertyOffset_EasingWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRotationRetargetingInfo.__PropertyOffset_EasingWeight) = value;
			}
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x06002E84 RID: 11908 RVA: 0x00047432 File Offset: 0x00045632
		// (set) Token: 0x06002E85 RID: 11909 RVA: 0x00047442 File Offset: 0x00045642
		public unsafe bool bClamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRotationRetargetingInfo.__PropertyOffset_bClamp) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRotationRetargetingInfo.__PropertyOffset_bClamp) = (value ? 1 : 0);
			}
		}

		// Token: 0x06002E86 RID: 11910 RVA: 0x00047453 File Offset: 0x00045653
		public FRotationRetargetingInfo()
		{
		}

		// Token: 0x06002E87 RID: 11911 RVA: 0x0004745C File Offset: 0x0004565C
		public FRotationRetargetingInfo(bool bEnabled, FTransform Source, FTransform Target, ERotationComponent RotationComponent, FVector TwistAxis, bool bUseAbsoluteAngle, float SourceMinimum, float SourceMaximum, float TargetMinimum, float TargetMaximum, EEasingFuncType EasingType, FRuntimeFloatCurve CustomCurve, bool bFlipEasing, float EasingWeight, bool bClamp)
		{
			this.bEnabled = bEnabled;
			this.Source = Source;
			this.Target = Target;
			this.RotationComponent = RotationComponent;
			this.TwistAxis = TwistAxis;
			this.bUseAbsoluteAngle = bUseAbsoluteAngle;
			this.SourceMinimum = SourceMinimum;
			this.SourceMaximum = SourceMaximum;
			this.TargetMinimum = TargetMinimum;
			this.TargetMaximum = TargetMaximum;
			this.EasingType = EasingType;
			this.CustomCurve = CustomCurve;
			this.bFlipEasing = bFlipEasing;
			this.EasingWeight = EasingWeight;
			this.bClamp = bClamp;
		}

		// Token: 0x06002E88 RID: 11912 RVA: 0x000474E4 File Offset: 0x000456E4
		protected override IntPtr GetUStructPtr()
		{
			return FRotationRetargetingInfo.StaticStruct();
		}

		// Token: 0x06002E89 RID: 11913 RVA: 0x000474F0 File Offset: 0x000456F0
		[NullableContext(2)]
		public FRotationRetargetingInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002E8A RID: 11914 RVA: 0x000474FA File Offset: 0x000456FA
		public FRotationRetargetingInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002E8B RID: 11915 RVA: 0x00047505 File Offset: 0x00045705
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRotationRetargetingInfo(Pointer, false, true);
		}

		// Token: 0x06002E8C RID: 11916 RVA: 0x0004750F File Offset: 0x0004570F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRotationRetargetingInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040013E2 RID: 5090
		public const string __ObjectPath = "/Script/AnimGraphRuntime.RotationRetargetingInfo";

		// Token: 0x040013E3 RID: 5091
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040013E4 RID: 5092
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x040013E5 RID: 5093
		internal static int __PropertyOffset_Source;

		// Token: 0x040013E6 RID: 5094
		internal static int __PropertyOffset_Target;

		// Token: 0x040013E7 RID: 5095
		internal static int __PropertyOffset_RotationComponent;

		// Token: 0x040013E8 RID: 5096
		internal static int __PropertyOffset_TwistAxis;

		// Token: 0x040013E9 RID: 5097
		internal static int __PropertyOffset_bUseAbsoluteAngle;

		// Token: 0x040013EA RID: 5098
		internal static int __PropertyOffset_SourceMinimum;

		// Token: 0x040013EB RID: 5099
		internal static int __PropertyOffset_SourceMaximum;

		// Token: 0x040013EC RID: 5100
		internal static int __PropertyOffset_TargetMinimum;

		// Token: 0x040013ED RID: 5101
		internal static int __PropertyOffset_TargetMaximum;

		// Token: 0x040013EE RID: 5102
		internal static int __PropertyOffset_EasingType;

		// Token: 0x040013EF RID: 5103
		internal static int __PropertyOffset_CustomCurve;

		// Token: 0x040013F0 RID: 5104
		[Nullable(2)]
		private FRuntimeFloatCurve _CustomCurve;

		// Token: 0x040013F1 RID: 5105
		internal static int __PropertyOffset_bFlipEasing;

		// Token: 0x040013F2 RID: 5106
		internal static int __PropertyOffset_EasingWeight;

		// Token: 0x040013F3 RID: 5107
		internal static int __PropertyOffset_bClamp;
	}
}
