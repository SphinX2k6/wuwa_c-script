using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FC4 RID: 4036
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleSystem")]
	[UnrealStructLayout(392, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 392)]
	public class UParticleSystem : UFXSystemAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D937 RID: 55607 RVA: 0x00140A48 File Offset: 0x0013EC48
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleSystem._ClassPtr;
		}

		// Token: 0x0600D938 RID: 55608 RVA: 0x00140A54 File Offset: 0x0013EC54
		public UParticleSystem() : this(BuiltinUtils.AllocNativeUObject(UParticleSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D939 RID: 55609 RVA: 0x00140A7C File Offset: 0x0013EC7C
		public UParticleSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003335 RID: 13109
		// (get) Token: 0x0600D93A RID: 55610 RVA: 0x00140AAF File Offset: 0x0013ECAF
		// (set) Token: 0x0600D93B RID: 55611 RVA: 0x00140ABF File Offset: 0x0013ECBF
		public unsafe float UpdateTime_FPS
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_UpdateTime_FPS);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_UpdateTime_FPS) = value;
			}
		}

		// Token: 0x17003336 RID: 13110
		// (get) Token: 0x0600D93C RID: 55612 RVA: 0x00140AD0 File Offset: 0x0013ECD0
		// (set) Token: 0x0600D93D RID: 55613 RVA: 0x00140AE0 File Offset: 0x0013ECE0
		public unsafe float UpdateTime_Delta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_UpdateTime_Delta);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_UpdateTime_Delta) = value;
			}
		}

		// Token: 0x17003337 RID: 13111
		// (get) Token: 0x0600D93E RID: 55614 RVA: 0x00140AF1 File Offset: 0x0013ECF1
		// (set) Token: 0x0600D93F RID: 55615 RVA: 0x00140B01 File Offset: 0x0013ED01
		public unsafe float WarmupTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_WarmupTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_WarmupTime) = value;
			}
		}

		// Token: 0x17003338 RID: 13112
		// (get) Token: 0x0600D940 RID: 55616 RVA: 0x00140B12 File Offset: 0x0013ED12
		// (set) Token: 0x0600D941 RID: 55617 RVA: 0x00140B22 File Offset: 0x0013ED22
		public unsafe float WarmupTickRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_WarmupTickRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_WarmupTickRate) = value;
			}
		}

		// Token: 0x17003339 RID: 13113
		// (get) Token: 0x0600D942 RID: 55618 RVA: 0x00140B34 File Offset: 0x0013ED34
		// (set) Token: 0x0600D943 RID: 55619 RVA: 0x00140B6D File Offset: 0x0013ED6D
		public TArray<UParticleEmitter> Emitters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UParticleEmitter> result;
				if ((result = this._Emitters) == null)
				{
					result = (this._Emitters = new TArray<UParticleEmitter>(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_Emitters, this));
				}
				return result;
			}
			set
			{
				this.Emitters.CopyAssign(value);
			}
		}

		// Token: 0x1700333A RID: 13114
		// (get) Token: 0x0600D944 RID: 55620 RVA: 0x00140B7B File Offset: 0x0013ED7B
		// (set) Token: 0x0600D945 RID: 55621 RVA: 0x00140B8F File Offset: 0x0013ED8F
		[Nullable(2)]
		public unsafe UParticleSystemComponent PreviewComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UParticleSystemComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UParticleSystem.__PropertyOffset_PreviewComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UParticleSystem.__PropertyOffset_PreviewComponent, value);
			}
		}

		// Token: 0x1700333B RID: 13115
		// (get) Token: 0x0600D946 RID: 55622 RVA: 0x00140BA4 File Offset: 0x0013EDA4
		// (set) Token: 0x0600D947 RID: 55623 RVA: 0x00140BB8 File Offset: 0x0013EDB8
		[Nullable(2)]
		public unsafe UInterpCurveEdSetup CurveEdSetup
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInterpCurveEdSetup>(base.NativePtr / (IntPtr)sizeof(void*) + UParticleSystem.__PropertyOffset_CurveEdSetup);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UParticleSystem.__PropertyOffset_CurveEdSetup, value);
			}
		}

		// Token: 0x1700333C RID: 13116
		// (get) Token: 0x0600D948 RID: 55624 RVA: 0x00140BCD File Offset: 0x0013EDCD
		// (set) Token: 0x0600D949 RID: 55625 RVA: 0x00140BDD File Offset: 0x0013EDDD
		public unsafe float LODDistanceCheckTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_LODDistanceCheckTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_LODDistanceCheckTime) = value;
			}
		}

		// Token: 0x1700333D RID: 13117
		// (get) Token: 0x0600D94A RID: 55626 RVA: 0x00140BEE File Offset: 0x0013EDEE
		// (set) Token: 0x0600D94B RID: 55627 RVA: 0x00140BFE File Offset: 0x0013EDFE
		public unsafe float MacroUVRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_MacroUVRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_MacroUVRadius) = value;
			}
		}

		// Token: 0x1700333E RID: 13118
		// (get) Token: 0x0600D94C RID: 55628 RVA: 0x00140C10 File Offset: 0x0013EE10
		// (set) Token: 0x0600D94D RID: 55629 RVA: 0x00140C49 File Offset: 0x0013EE49
		public TArray<float> LODDistances
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._LODDistances) == null)
				{
					result = (this._LODDistances = new TArray<float>(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_LODDistances, this));
				}
				return result;
			}
			set
			{
				this.LODDistances.CopyAssign(value);
			}
		}

		// Token: 0x1700333F RID: 13119
		// (get) Token: 0x0600D94E RID: 55630 RVA: 0x00140C58 File Offset: 0x0013EE58
		// (set) Token: 0x0600D94F RID: 55631 RVA: 0x00140C91 File Offset: 0x0013EE91
		public TArray<FParticleSystemLOD> LODSettings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FParticleSystemLOD> result;
				if ((result = this._LODSettings) == null)
				{
					result = (this._LODSettings = new TArray<FParticleSystemLOD>(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_LODSettings, this));
				}
				return result;
			}
			set
			{
				this.LODSettings.CopyAssign(value);
			}
		}

		// Token: 0x17003340 RID: 13120
		// (get) Token: 0x0600D950 RID: 55632 RVA: 0x00140C9F File Offset: 0x0013EE9F
		// (set) Token: 0x0600D951 RID: 55633 RVA: 0x00140CB3 File Offset: 0x0013EEB3
		public unsafe FBox FixedRelativeBoundingBox
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_FixedRelativeBoundingBox);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_FixedRelativeBoundingBox) = value;
			}
		}

		// Token: 0x17003341 RID: 13121
		// (get) Token: 0x0600D952 RID: 55634 RVA: 0x00140CC8 File Offset: 0x0013EEC8
		// (set) Token: 0x0600D953 RID: 55635 RVA: 0x00140CD8 File Offset: 0x0013EED8
		public unsafe float SecondsBeforeInactive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_SecondsBeforeInactive);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_SecondsBeforeInactive) = value;
			}
		}

		// Token: 0x17003342 RID: 13122
		// (get) Token: 0x0600D954 RID: 55636 RVA: 0x00140CE9 File Offset: 0x0013EEE9
		// (set) Token: 0x0600D955 RID: 55637 RVA: 0x00140CF9 File Offset: 0x0013EEF9
		public unsafe float Delay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_Delay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_Delay) = value;
			}
		}

		// Token: 0x17003343 RID: 13123
		// (get) Token: 0x0600D956 RID: 55638 RVA: 0x00140D0A File Offset: 0x0013EF0A
		// (set) Token: 0x0600D957 RID: 55639 RVA: 0x00140D1A File Offset: 0x0013EF1A
		public unsafe float DelayLow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_DelayLow);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_DelayLow) = value;
			}
		}

		// Token: 0x17003344 RID: 13124
		// (get) Token: 0x0600D958 RID: 55640 RVA: 0x00140D2B File Offset: 0x0013EF2B
		// (set) Token: 0x0600D959 RID: 55641 RVA: 0x00140D44 File Offset: 0x0013EF44
		public unsafe bool bOrientZAxisTowardCamera
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_bOrientZAxisTowardCamera) & UParticleSystem.__PropertyMask_bOrientZAxisTowardCamera) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_bOrientZAxisTowardCamera) = ((*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_bOrientZAxisTowardCamera) & ~UParticleSystem.__PropertyMask_bOrientZAxisTowardCamera) | (value ? UParticleSystem.__PropertyMask_bOrientZAxisTowardCamera : 0));
			}
		}

		// Token: 0x17003345 RID: 13125
		// (get) Token: 0x0600D95A RID: 55642 RVA: 0x00140D74 File Offset: 0x0013EF74
		// (set) Token: 0x0600D95B RID: 55643 RVA: 0x00140D8D File Offset: 0x0013EF8D
		public unsafe bool bUseFixedRelativeBoundingBox
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_bUseFixedRelativeBoundingBox) & UParticleSystem.__PropertyMask_bUseFixedRelativeBoundingBox) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_bUseFixedRelativeBoundingBox) = ((*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_bUseFixedRelativeBoundingBox) & ~UParticleSystem.__PropertyMask_bUseFixedRelativeBoundingBox) | (value ? UParticleSystem.__PropertyMask_bUseFixedRelativeBoundingBox : 0));
			}
		}

		// Token: 0x17003346 RID: 13126
		// (get) Token: 0x0600D95C RID: 55644 RVA: 0x00140DBD File Offset: 0x0013EFBD
		// (set) Token: 0x0600D95D RID: 55645 RVA: 0x00140DD6 File Offset: 0x0013EFD6
		public unsafe bool bShouldResetPeakCounts
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_bShouldResetPeakCounts) & UParticleSystem.__PropertyMask_bShouldResetPeakCounts) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_bShouldResetPeakCounts) = ((*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_bShouldResetPeakCounts) & ~UParticleSystem.__PropertyMask_bShouldResetPeakCounts) | (value ? UParticleSystem.__PropertyMask_bShouldResetPeakCounts : 0));
			}
		}

		// Token: 0x17003347 RID: 13127
		// (get) Token: 0x0600D95E RID: 55646 RVA: 0x00140E06 File Offset: 0x0013F006
		// (set) Token: 0x0600D95F RID: 55647 RVA: 0x00140E1F File Offset: 0x0013F01F
		public unsafe bool bHasPhysics
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_bHasPhysics) & UParticleSystem.__PropertyMask_bHasPhysics) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_bHasPhysics) = ((*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_bHasPhysics) & ~UParticleSystem.__PropertyMask_bHasPhysics) | (value ? UParticleSystem.__PropertyMask_bHasPhysics : 0));
			}
		}

		// Token: 0x17003348 RID: 13128
		// (get) Token: 0x0600D960 RID: 55648 RVA: 0x00140E4F File Offset: 0x0013F04F
		// (set) Token: 0x0600D961 RID: 55649 RVA: 0x00140E68 File Offset: 0x0013F068
		public unsafe bool bUseRealtimeThumbnail
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_bUseRealtimeThumbnail) & UParticleSystem.__PropertyMask_bUseRealtimeThumbnail) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_bUseRealtimeThumbnail) = ((*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_bUseRealtimeThumbnail) & ~UParticleSystem.__PropertyMask_bUseRealtimeThumbnail) | (value ? UParticleSystem.__PropertyMask_bUseRealtimeThumbnail : 0));
			}
		}

		// Token: 0x17003349 RID: 13129
		// (get) Token: 0x0600D962 RID: 55650 RVA: 0x00140E98 File Offset: 0x0013F098
		// (set) Token: 0x0600D963 RID: 55651 RVA: 0x00140EB1 File Offset: 0x0013F0B1
		public unsafe bool ThumbnailImageOutOfDate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_ThumbnailImageOutOfDate) & UParticleSystem.__PropertyMask_ThumbnailImageOutOfDate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_ThumbnailImageOutOfDate) = ((*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_ThumbnailImageOutOfDate) & ~UParticleSystem.__PropertyMask_ThumbnailImageOutOfDate) | (value ? UParticleSystem.__PropertyMask_ThumbnailImageOutOfDate : 0));
			}
		}

		// Token: 0x1700334A RID: 13130
		// (get) Token: 0x0600D964 RID: 55652 RVA: 0x00140EE1 File Offset: 0x0013F0E1
		// (set) Token: 0x0600D965 RID: 55653 RVA: 0x00140EFA File Offset: 0x0013F0FA
		public unsafe bool bUseDelayRange
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_bUseDelayRange) & UParticleSystem.__PropertyMask_bUseDelayRange) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_bUseDelayRange) = ((*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_bUseDelayRange) & ~UParticleSystem.__PropertyMask_bUseDelayRange) | (value ? UParticleSystem.__PropertyMask_bUseDelayRange : 0));
			}
		}

		// Token: 0x1700334B RID: 13131
		// (get) Token: 0x0600D966 RID: 55654 RVA: 0x00140F2A File Offset: 0x0013F12A
		// (set) Token: 0x0600D967 RID: 55655 RVA: 0x00140F43 File Offset: 0x0013F143
		public unsafe bool bAllowManagedTicking
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_bAllowManagedTicking) & UParticleSystem.__PropertyMask_bAllowManagedTicking) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_bAllowManagedTicking) = ((*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_bAllowManagedTicking) & ~UParticleSystem.__PropertyMask_bAllowManagedTicking) | (value ? UParticleSystem.__PropertyMask_bAllowManagedTicking : 0));
			}
		}

		// Token: 0x1700334C RID: 13132
		// (get) Token: 0x0600D968 RID: 55656 RVA: 0x00140F73 File Offset: 0x0013F173
		// (set) Token: 0x0600D969 RID: 55657 RVA: 0x00140F8C File Offset: 0x0013F18C
		public unsafe bool bAutoDeactivate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_bAutoDeactivate) & UParticleSystem.__PropertyMask_bAutoDeactivate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_bAutoDeactivate) = ((*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_bAutoDeactivate) & ~UParticleSystem.__PropertyMask_bAutoDeactivate) | (value ? UParticleSystem.__PropertyMask_bAutoDeactivate : 0));
			}
		}

		// Token: 0x1700334D RID: 13133
		// (get) Token: 0x0600D96A RID: 55658 RVA: 0x00140FBC File Offset: 0x0013F1BC
		// (set) Token: 0x0600D96B RID: 55659 RVA: 0x00140FD5 File Offset: 0x0013F1D5
		public unsafe bool bRegenerateLODDuplicate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_bRegenerateLODDuplicate) & UParticleSystem.__PropertyMask_bRegenerateLODDuplicate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_bRegenerateLODDuplicate) = ((*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_bRegenerateLODDuplicate) & ~UParticleSystem.__PropertyMask_bRegenerateLODDuplicate) | (value ? UParticleSystem.__PropertyMask_bRegenerateLODDuplicate : 0));
			}
		}

		// Token: 0x1700334E RID: 13134
		// (get) Token: 0x0600D96C RID: 55660 RVA: 0x00141005 File Offset: 0x0013F205
		// (set) Token: 0x0600D96D RID: 55661 RVA: 0x00141019 File Offset: 0x0013F219
		[Nullable(0)]
		public unsafe TEnumAsByte<EParticleSystemUpdateMode> SystemUpdateMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_SystemUpdateMode);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_SystemUpdateMode) = value;
			}
		}

		// Token: 0x1700334F RID: 13135
		// (get) Token: 0x0600D96E RID: 55662 RVA: 0x0014102E File Offset: 0x0013F22E
		// (set) Token: 0x0600D96F RID: 55663 RVA: 0x00141042 File Offset: 0x0013F242
		[Nullable(0)]
		public unsafe TEnumAsByte<ParticleSystemLODMethod> LODMethod
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_LODMethod);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_LODMethod) = value;
			}
		}

		// Token: 0x17003350 RID: 13136
		// (get) Token: 0x0600D970 RID: 55664 RVA: 0x00141057 File Offset: 0x0013F257
		// (set) Token: 0x0600D971 RID: 55665 RVA: 0x00141067 File Offset: 0x0013F267
		public unsafe EParticleSystemInsignificanceReaction InsignificantReaction
		{
			get
			{
				return (EParticleSystemInsignificanceReaction)(*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_InsignificantReaction));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_InsignificantReaction) = (byte)value;
			}
		}

		// Token: 0x17003351 RID: 13137
		// (get) Token: 0x0600D972 RID: 55666 RVA: 0x00141078 File Offset: 0x0013F278
		// (set) Token: 0x0600D973 RID: 55667 RVA: 0x0014108C File Offset: 0x0013F28C
		[Nullable(0)]
		public unsafe TEnumAsByte<EParticleSystemOcclusionBoundsMethod> OcclusionBoundsMethod
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_OcclusionBoundsMethod);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_OcclusionBoundsMethod) = value;
			}
		}

		// Token: 0x17003352 RID: 13138
		// (get) Token: 0x0600D974 RID: 55668 RVA: 0x001410A1 File Offset: 0x0013F2A1
		// (set) Token: 0x0600D975 RID: 55669 RVA: 0x001410B1 File Offset: 0x0013F2B1
		public unsafe EParticleSignificanceLevel MaxSignificanceLevel
		{
			get
			{
				return (EParticleSignificanceLevel)(*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_MaxSignificanceLevel));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_MaxSignificanceLevel) = (byte)value;
			}
		}

		// Token: 0x17003353 RID: 13139
		// (get) Token: 0x0600D976 RID: 55670 RVA: 0x001410C2 File Offset: 0x0013F2C2
		// (set) Token: 0x0600D977 RID: 55671 RVA: 0x001410D2 File Offset: 0x0013F2D2
		public unsafe uint MinTimeBetweenTicks
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_MinTimeBetweenTicks);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_MinTimeBetweenTicks) = (int)value;
			}
		}

		// Token: 0x17003354 RID: 13140
		// (get) Token: 0x0600D978 RID: 55672 RVA: 0x001410E3 File Offset: 0x0013F2E3
		// (set) Token: 0x0600D979 RID: 55673 RVA: 0x001410F3 File Offset: 0x0013F2F3
		public unsafe float InsignificanceDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_InsignificanceDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_InsignificanceDelay) = value;
			}
		}

		// Token: 0x17003355 RID: 13141
		// (get) Token: 0x0600D97A RID: 55674 RVA: 0x00141104 File Offset: 0x0013F304
		// (set) Token: 0x0600D97B RID: 55675 RVA: 0x00141118 File Offset: 0x0013F318
		public unsafe FVector MacroUVPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_MacroUVPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_MacroUVPosition) = value;
			}
		}

		// Token: 0x17003356 RID: 13142
		// (get) Token: 0x0600D97C RID: 55676 RVA: 0x0014112D File Offset: 0x0013F32D
		// (set) Token: 0x0600D97D RID: 55677 RVA: 0x00141141 File Offset: 0x0013F341
		public unsafe FBox CustomOcclusionBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_CustomOcclusionBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_CustomOcclusionBounds) = value;
			}
		}

		// Token: 0x17003357 RID: 13143
		// (get) Token: 0x0600D97E RID: 55678 RVA: 0x00141158 File Offset: 0x0013F358
		// (set) Token: 0x0600D97F RID: 55679 RVA: 0x00141191 File Offset: 0x0013F391
		public TArray<FLODSoloTrack> SoloTracking
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLODSoloTrack> result;
				if ((result = this._SoloTracking) == null)
				{
					result = (this._SoloTracking = new TArray<FLODSoloTrack>(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_SoloTracking, this));
				}
				return result;
			}
			set
			{
				this.SoloTracking.CopyAssign(value);
			}
		}

		// Token: 0x17003358 RID: 13144
		// (get) Token: 0x0600D980 RID: 55680 RVA: 0x001411A0 File Offset: 0x0013F3A0
		// (set) Token: 0x0600D981 RID: 55681 RVA: 0x001411D9 File Offset: 0x0013F3D9
		public TArray<FNamedEmitterMaterial> NamedMaterialSlots
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNamedEmitterMaterial> result;
				if ((result = this._NamedMaterialSlots) == null)
				{
					result = (this._NamedMaterialSlots = new TArray<FNamedEmitterMaterial>(base.NativePtr + (IntPtr)UParticleSystem.__PropertyOffset_NamedMaterialSlots, this));
				}
				return result;
			}
			set
			{
				this.NamedMaterialSlots.CopyAssign(value);
			}
		}

		// Token: 0x0600D982 RID: 55682 RVA: 0x001411E8 File Offset: 0x0013F3E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool ContainsEmitterType(UClassStackOnlyPtr TypeData)
		{
			UParticleSystem.__ContainsEmitterType_FunctionParams* ptr = stackalloc UParticleSystem.__ContainsEmitterType_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UParticleSystem.__ContainsEmitterType_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UParticleSystem.__ContainsEmitterType_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TypeData = TypeData;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UParticleSystem.__ContainsEmitterType_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0600D983 RID: 55683 RVA: 0x00141235 File Offset: 0x0013F435
		static UParticleSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleSystem");
		}

		// Token: 0x0600D984 RID: 55684 RVA: 0x00141243 File Offset: 0x0013F443
		protected UParticleSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040075C4 RID: 30148
		public new const string __ObjectPath = "/Script/Engine.ParticleSystem";

		// Token: 0x040075C5 RID: 30149
		private static IntPtr _ClassPtr;

		// Token: 0x040075C6 RID: 30150
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040075C7 RID: 30151
		internal static int __PropertyOffset_UpdateTime_FPS;

		// Token: 0x040075C8 RID: 30152
		internal static int __PropertyOffset_UpdateTime_Delta;

		// Token: 0x040075C9 RID: 30153
		internal static int __PropertyOffset_WarmupTime;

		// Token: 0x040075CA RID: 30154
		internal static int __PropertyOffset_WarmupTickRate;

		// Token: 0x040075CB RID: 30155
		internal static int __PropertyOffset_Emitters;

		// Token: 0x040075CC RID: 30156
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UParticleEmitter> _Emitters;

		// Token: 0x040075CD RID: 30157
		internal static int __PropertyOffset_PreviewComponent;

		// Token: 0x040075CE RID: 30158
		internal static int __PropertyOffset_CurveEdSetup;

		// Token: 0x040075CF RID: 30159
		internal static int __PropertyOffset_LODDistanceCheckTime;

		// Token: 0x040075D0 RID: 30160
		internal static int __PropertyOffset_MacroUVRadius;

		// Token: 0x040075D1 RID: 30161
		internal static int __PropertyOffset_LODDistances;

		// Token: 0x040075D2 RID: 30162
		[Nullable(2)]
		private TArray<float> _LODDistances;

		// Token: 0x040075D3 RID: 30163
		internal static int __PropertyOffset_LODSettings;

		// Token: 0x040075D4 RID: 30164
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FParticleSystemLOD> _LODSettings;

		// Token: 0x040075D5 RID: 30165
		internal static int __PropertyOffset_FixedRelativeBoundingBox;

		// Token: 0x040075D6 RID: 30166
		internal static int __PropertyOffset_SecondsBeforeInactive;

		// Token: 0x040075D7 RID: 30167
		internal static int __PropertyOffset_Delay;

		// Token: 0x040075D8 RID: 30168
		internal static int __PropertyOffset_DelayLow;

		// Token: 0x040075D9 RID: 30169
		internal static int __PropertyOffset_bOrientZAxisTowardCamera;

		// Token: 0x040075DA RID: 30170
		internal static byte __PropertyMask_bOrientZAxisTowardCamera;

		// Token: 0x040075DB RID: 30171
		internal static int __PropertyOffset_bUseFixedRelativeBoundingBox;

		// Token: 0x040075DC RID: 30172
		internal static byte __PropertyMask_bUseFixedRelativeBoundingBox;

		// Token: 0x040075DD RID: 30173
		internal static int __PropertyOffset_bShouldResetPeakCounts;

		// Token: 0x040075DE RID: 30174
		internal static byte __PropertyMask_bShouldResetPeakCounts;

		// Token: 0x040075DF RID: 30175
		internal static int __PropertyOffset_bHasPhysics;

		// Token: 0x040075E0 RID: 30176
		internal static byte __PropertyMask_bHasPhysics;

		// Token: 0x040075E1 RID: 30177
		internal static int __PropertyOffset_bUseRealtimeThumbnail;

		// Token: 0x040075E2 RID: 30178
		internal static byte __PropertyMask_bUseRealtimeThumbnail;

		// Token: 0x040075E3 RID: 30179
		internal static int __PropertyOffset_ThumbnailImageOutOfDate;

		// Token: 0x040075E4 RID: 30180
		internal static byte __PropertyMask_ThumbnailImageOutOfDate;

		// Token: 0x040075E5 RID: 30181
		internal static int __PropertyOffset_bUseDelayRange;

		// Token: 0x040075E6 RID: 30182
		internal static byte __PropertyMask_bUseDelayRange;

		// Token: 0x040075E7 RID: 30183
		internal static int __PropertyOffset_bAllowManagedTicking;

		// Token: 0x040075E8 RID: 30184
		internal static byte __PropertyMask_bAllowManagedTicking;

		// Token: 0x040075E9 RID: 30185
		internal static int __PropertyOffset_bAutoDeactivate;

		// Token: 0x040075EA RID: 30186
		internal static byte __PropertyMask_bAutoDeactivate;

		// Token: 0x040075EB RID: 30187
		internal static int __PropertyOffset_bRegenerateLODDuplicate;

		// Token: 0x040075EC RID: 30188
		internal static byte __PropertyMask_bRegenerateLODDuplicate;

		// Token: 0x040075ED RID: 30189
		internal static int __PropertyOffset_SystemUpdateMode;

		// Token: 0x040075EE RID: 30190
		internal static int __PropertyOffset_LODMethod;

		// Token: 0x040075EF RID: 30191
		internal static int __PropertyOffset_InsignificantReaction;

		// Token: 0x040075F0 RID: 30192
		internal static int __PropertyOffset_OcclusionBoundsMethod;

		// Token: 0x040075F1 RID: 30193
		internal static int __PropertyOffset_MaxSignificanceLevel;

		// Token: 0x040075F2 RID: 30194
		internal static int __PropertyOffset_MinTimeBetweenTicks;

		// Token: 0x040075F3 RID: 30195
		internal static int __PropertyOffset_InsignificanceDelay;

		// Token: 0x040075F4 RID: 30196
		internal static int __PropertyOffset_MacroUVPosition;

		// Token: 0x040075F5 RID: 30197
		internal static int __PropertyOffset_CustomOcclusionBounds;

		// Token: 0x040075F6 RID: 30198
		internal static int __PropertyOffset_SoloTracking;

		// Token: 0x040075F7 RID: 30199
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FLODSoloTrack> _SoloTracking;

		// Token: 0x040075F8 RID: 30200
		internal static int __PropertyOffset_NamedMaterialSlots;

		// Token: 0x040075F9 RID: 30201
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNamedEmitterMaterial> _NamedMaterialSlots;

		// Token: 0x040075FA RID: 30202
		private static IntPtr __ContainsEmitterType_NativeFunctionPtr;

		// Token: 0x02002DBC RID: 11708
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ContainsEmitterType_FunctionParams
		{
			// Token: 0x040167F3 RID: 92147
			[FieldOffset(0)]
			public UClassStackOnlyPtr TypeData;

			// Token: 0x040167F4 RID: 92148
			[FieldOffset(8)]
			public bool __Result;
		}
	}
}
