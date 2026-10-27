using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015C7 RID: 5575
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KawaiiPhysics.AnimNode_KawaiiPhysicsBase")]
	[UnrealStructLayout(768, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 768)]
	public class FAnimNode_KawaiiPhysicsBase : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014180 RID: 82304 RVA: 0x001D8165 File Offset: 0x001D6365
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_KawaiiPhysicsBase._ScriptStructPtr != 0) ? FAnimNode_KawaiiPhysicsBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KawaiiPhysics.AnimNode_KawaiiPhysicsBase", ref FAnimNode_KawaiiPhysicsBase._ScriptStructPtr);
		}

		// Token: 0x17004EB5 RID: 20149
		// (get) Token: 0x06014181 RID: 82305 RVA: 0x001D818C File Offset: 0x001D638C
		// (set) Token: 0x06014182 RID: 82306 RVA: 0x001D81CF File Offset: 0x001D63CF
		public TArray<FBoneReference> ExcludeBones
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBoneReference> result;
				if ((result = this._ExcludeBones) == null)
				{
					result = (this._ExcludeBones = new TArray<FBoneReference>(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_ExcludeBones, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ExcludeBones.CopyAssign(value);
			}
		}

		// Token: 0x17004EB6 RID: 20150
		// (get) Token: 0x06014183 RID: 82307 RVA: 0x001D81DD File Offset: 0x001D63DD
		// (set) Token: 0x06014184 RID: 82308 RVA: 0x001D81ED File Offset: 0x001D63ED
		public unsafe int TargetFramerate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_TargetFramerate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_TargetFramerate) = value;
			}
		}

		// Token: 0x17004EB7 RID: 20151
		// (get) Token: 0x06014185 RID: 82309 RVA: 0x001D81FE File Offset: 0x001D63FE
		// (set) Token: 0x06014186 RID: 82310 RVA: 0x001D820E File Offset: 0x001D640E
		public unsafe bool OverrideTargetFramerate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_OverrideTargetFramerate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_OverrideTargetFramerate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EB8 RID: 20152
		// (get) Token: 0x06014187 RID: 82311 RVA: 0x001D821F File Offset: 0x001D641F
		// (set) Token: 0x06014188 RID: 82312 RVA: 0x001D822F File Offset: 0x001D642F
		public unsafe int IgnoreMechanicsLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_IgnoreMechanicsLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_IgnoreMechanicsLevel) = value;
			}
		}

		// Token: 0x17004EB9 RID: 20153
		// (get) Token: 0x06014189 RID: 82313 RVA: 0x001D8240 File Offset: 0x001D6440
		// (set) Token: 0x0601418A RID: 82314 RVA: 0x001D8250 File Offset: 0x001D6450
		public unsafe bool bNewIgnoreMechanics
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_bNewIgnoreMechanics) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_bNewIgnoreMechanics) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EBA RID: 20154
		// (get) Token: 0x0601418B RID: 82315 RVA: 0x001D8264 File Offset: 0x001D6464
		// (set) Token: 0x0601418C RID: 82316 RVA: 0x001D82A7 File Offset: 0x001D64A7
		public FKawaiiPhysicsSettings PhysicsSettings
		{
			get
			{
				base.FastCheckIsValid();
				FKawaiiPhysicsSettings result;
				if ((result = this._PhysicsSettings) == null)
				{
					result = (this._PhysicsSettings = new FKawaiiPhysicsSettings(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_PhysicsSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKawaiiPhysicsSettings.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_PhysicsSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004EBB RID: 20155
		// (get) Token: 0x0601418D RID: 82317 RVA: 0x001D82C8 File Offset: 0x001D64C8
		// (set) Token: 0x0601418E RID: 82318 RVA: 0x001D82DC File Offset: 0x001D64DC
		[Nullable(2)]
		public unsafe UCurveFloat DampingCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_KawaiiPhysicsBase.__PropertyOffset_DampingCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_KawaiiPhysicsBase.__PropertyOffset_DampingCurve, value);
			}
		}

		// Token: 0x17004EBC RID: 20156
		// (get) Token: 0x0601418F RID: 82319 RVA: 0x001D82F1 File Offset: 0x001D64F1
		// (set) Token: 0x06014190 RID: 82320 RVA: 0x001D8305 File Offset: 0x001D6505
		[Nullable(2)]
		public unsafe UCurveFloat WorldDampingLocationCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_KawaiiPhysicsBase.__PropertyOffset_WorldDampingLocationCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_KawaiiPhysicsBase.__PropertyOffset_WorldDampingLocationCurve, value);
			}
		}

		// Token: 0x17004EBD RID: 20157
		// (get) Token: 0x06014191 RID: 82321 RVA: 0x001D831A File Offset: 0x001D651A
		// (set) Token: 0x06014192 RID: 82322 RVA: 0x001D832E File Offset: 0x001D652E
		[Nullable(2)]
		public unsafe UCurveFloat WorldDampingRotationCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_KawaiiPhysicsBase.__PropertyOffset_WorldDampingRotationCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_KawaiiPhysicsBase.__PropertyOffset_WorldDampingRotationCurve, value);
			}
		}

		// Token: 0x17004EBE RID: 20158
		// (get) Token: 0x06014193 RID: 82323 RVA: 0x001D8343 File Offset: 0x001D6543
		// (set) Token: 0x06014194 RID: 82324 RVA: 0x001D8357 File Offset: 0x001D6557
		[Nullable(2)]
		public unsafe UCurveFloat StiffnessCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_KawaiiPhysicsBase.__PropertyOffset_StiffnessCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_KawaiiPhysicsBase.__PropertyOffset_StiffnessCurve, value);
			}
		}

		// Token: 0x17004EBF RID: 20159
		// (get) Token: 0x06014195 RID: 82325 RVA: 0x001D836C File Offset: 0x001D656C
		// (set) Token: 0x06014196 RID: 82326 RVA: 0x001D8380 File Offset: 0x001D6580
		[Nullable(2)]
		public unsafe UCurveFloat RadiusCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_KawaiiPhysicsBase.__PropertyOffset_RadiusCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_KawaiiPhysicsBase.__PropertyOffset_RadiusCurve, value);
			}
		}

		// Token: 0x17004EC0 RID: 20160
		// (get) Token: 0x06014197 RID: 82327 RVA: 0x001D8395 File Offset: 0x001D6595
		// (set) Token: 0x06014198 RID: 82328 RVA: 0x001D83A9 File Offset: 0x001D65A9
		[Nullable(2)]
		public unsafe UCurveFloat HalfWidthCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_KawaiiPhysicsBase.__PropertyOffset_HalfWidthCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_KawaiiPhysicsBase.__PropertyOffset_HalfWidthCurve, value);
			}
		}

		// Token: 0x17004EC1 RID: 20161
		// (get) Token: 0x06014199 RID: 82329 RVA: 0x001D83BE File Offset: 0x001D65BE
		// (set) Token: 0x0601419A RID: 82330 RVA: 0x001D83D2 File Offset: 0x001D65D2
		[Nullable(2)]
		public unsafe UCurveFloat LimitAngleCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_KawaiiPhysicsBase.__PropertyOffset_LimitAngleCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_KawaiiPhysicsBase.__PropertyOffset_LimitAngleCurve, value);
			}
		}

		// Token: 0x17004EC2 RID: 20162
		// (get) Token: 0x0601419B RID: 82331 RVA: 0x001D83E7 File Offset: 0x001D65E7
		// (set) Token: 0x0601419C RID: 82332 RVA: 0x001D83F7 File Offset: 0x001D65F7
		public unsafe bool bUpdatePhysicsSettingsInGame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_bUpdatePhysicsSettingsInGame) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_bUpdatePhysicsSettingsInGame) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EC3 RID: 20163
		// (get) Token: 0x0601419D RID: 82333 RVA: 0x001D8408 File Offset: 0x001D6608
		// (set) Token: 0x0601419E RID: 82334 RVA: 0x001D8418 File Offset: 0x001D6618
		public unsafe float DummyBoneLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_DummyBoneLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_DummyBoneLength) = value;
			}
		}

		// Token: 0x17004EC4 RID: 20164
		// (get) Token: 0x0601419F RID: 82335 RVA: 0x001D8429 File Offset: 0x001D6629
		// (set) Token: 0x060141A0 RID: 82336 RVA: 0x001D8439 File Offset: 0x001D6639
		public unsafe EBoneForwardAxis BoneForwardAxis
		{
			get
			{
				return (EBoneForwardAxis)(*(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_BoneForwardAxis));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_BoneForwardAxis) = (byte)value;
			}
		}

		// Token: 0x17004EC5 RID: 20165
		// (get) Token: 0x060141A1 RID: 82337 RVA: 0x001D844A File Offset: 0x001D664A
		// (set) Token: 0x060141A2 RID: 82338 RVA: 0x001D845A File Offset: 0x001D665A
		public unsafe EPlanarConstraint PlanarConstraint
		{
			get
			{
				return (EPlanarConstraint)(*(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_PlanarConstraint));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_PlanarConstraint) = (byte)value;
			}
		}

		// Token: 0x17004EC6 RID: 20166
		// (get) Token: 0x060141A3 RID: 82339 RVA: 0x001D846C File Offset: 0x001D666C
		// (set) Token: 0x060141A4 RID: 82340 RVA: 0x001D84AF File Offset: 0x001D66AF
		public TArray<FSphericalLimit> SphericalLimits
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSphericalLimit> result;
				if ((result = this._SphericalLimits) == null)
				{
					result = (this._SphericalLimits = new TArray<FSphericalLimit>(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_SphericalLimits, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SphericalLimits.CopyAssign(value);
			}
		}

		// Token: 0x17004EC7 RID: 20167
		// (get) Token: 0x060141A5 RID: 82341 RVA: 0x001D84C0 File Offset: 0x001D66C0
		// (set) Token: 0x060141A6 RID: 82342 RVA: 0x001D8503 File Offset: 0x001D6703
		public TArray<FCapsuleLimit> CapsuleLimits
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCapsuleLimit> result;
				if ((result = this._CapsuleLimits) == null)
				{
					result = (this._CapsuleLimits = new TArray<FCapsuleLimit>(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_CapsuleLimits, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CapsuleLimits.CopyAssign(value);
			}
		}

		// Token: 0x17004EC8 RID: 20168
		// (get) Token: 0x060141A7 RID: 82343 RVA: 0x001D8514 File Offset: 0x001D6714
		// (set) Token: 0x060141A8 RID: 82344 RVA: 0x001D8557 File Offset: 0x001D6757
		public TArray<FPlanarLimit> PlanarLimits
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPlanarLimit> result;
				if ((result = this._PlanarLimits) == null)
				{
					result = (this._PlanarLimits = new TArray<FPlanarLimit>(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_PlanarLimits, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PlanarLimits.CopyAssign(value);
			}
		}

		// Token: 0x17004EC9 RID: 20169
		// (get) Token: 0x060141A9 RID: 82345 RVA: 0x001D8565 File Offset: 0x001D6765
		// (set) Token: 0x060141AA RID: 82346 RVA: 0x001D8579 File Offset: 0x001D6779
		[Nullable(2)]
		public unsafe UKawaiiPhysicsLimitsDataAsset LimitsDataAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKawaiiPhysicsLimitsDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_KawaiiPhysicsBase.__PropertyOffset_LimitsDataAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_KawaiiPhysicsBase.__PropertyOffset_LimitsDataAsset, value);
			}
		}

		// Token: 0x17004ECA RID: 20170
		// (get) Token: 0x060141AB RID: 82347 RVA: 0x001D8590 File Offset: 0x001D6790
		// (set) Token: 0x060141AC RID: 82348 RVA: 0x001D85D3 File Offset: 0x001D67D3
		public TArray<FSphericalLimit> SphericalLimitsData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSphericalLimit> result;
				if ((result = this._SphericalLimitsData) == null)
				{
					result = (this._SphericalLimitsData = new TArray<FSphericalLimit>(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_SphericalLimitsData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SphericalLimitsData.CopyAssign(value);
			}
		}

		// Token: 0x17004ECB RID: 20171
		// (get) Token: 0x060141AD RID: 82349 RVA: 0x001D85E4 File Offset: 0x001D67E4
		// (set) Token: 0x060141AE RID: 82350 RVA: 0x001D8627 File Offset: 0x001D6827
		public TArray<FCapsuleLimit> CapsuleLimitsData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCapsuleLimit> result;
				if ((result = this._CapsuleLimitsData) == null)
				{
					result = (this._CapsuleLimitsData = new TArray<FCapsuleLimit>(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_CapsuleLimitsData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CapsuleLimitsData.CopyAssign(value);
			}
		}

		// Token: 0x17004ECC RID: 20172
		// (get) Token: 0x060141AF RID: 82351 RVA: 0x001D8638 File Offset: 0x001D6838
		// (set) Token: 0x060141B0 RID: 82352 RVA: 0x001D867B File Offset: 0x001D687B
		public TArray<FPlanarLimit> PlanarLimitsData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPlanarLimit> result;
				if ((result = this._PlanarLimitsData) == null)
				{
					result = (this._PlanarLimitsData = new TArray<FPlanarLimit>(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_PlanarLimitsData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PlanarLimitsData.CopyAssign(value);
			}
		}

		// Token: 0x17004ECD RID: 20173
		// (get) Token: 0x060141B1 RID: 82353 RVA: 0x001D8689 File Offset: 0x001D6889
		// (set) Token: 0x060141B2 RID: 82354 RVA: 0x001D8699 File Offset: 0x001D6899
		public unsafe float TeleportDistanceThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_TeleportDistanceThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_TeleportDistanceThreshold) = value;
			}
		}

		// Token: 0x17004ECE RID: 20174
		// (get) Token: 0x060141B3 RID: 82355 RVA: 0x001D86AA File Offset: 0x001D68AA
		// (set) Token: 0x060141B4 RID: 82356 RVA: 0x001D86BA File Offset: 0x001D68BA
		public unsafe float TeleportRotationThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_TeleportRotationThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_TeleportRotationThreshold) = value;
			}
		}

		// Token: 0x17004ECF RID: 20175
		// (get) Token: 0x060141B5 RID: 82357 RVA: 0x001D86CB File Offset: 0x001D68CB
		// (set) Token: 0x060141B6 RID: 82358 RVA: 0x001D86DF File Offset: 0x001D68DF
		public unsafe FVector Gravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_Gravity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_Gravity) = value;
			}
		}

		// Token: 0x17004ED0 RID: 20176
		// (get) Token: 0x060141B7 RID: 82359 RVA: 0x001D86F4 File Offset: 0x001D68F4
		// (set) Token: 0x060141B8 RID: 82360 RVA: 0x001D8704 File Offset: 0x001D6904
		public unsafe bool bEnableWind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_bEnableWind) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_bEnableWind) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004ED1 RID: 20177
		// (get) Token: 0x060141B9 RID: 82361 RVA: 0x001D8715 File Offset: 0x001D6915
		// (set) Token: 0x060141BA RID: 82362 RVA: 0x001D8725 File Offset: 0x001D6925
		public unsafe float WindScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_WindScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_WindScale) = value;
			}
		}

		// Token: 0x17004ED2 RID: 20178
		// (get) Token: 0x060141BB RID: 82363 RVA: 0x001D8738 File Offset: 0x001D6938
		// (set) Token: 0x060141BC RID: 82364 RVA: 0x001D877B File Offset: 0x001D697B
		public TArray<FKawaiiPhysicsModifyBone> ModifyBones
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKawaiiPhysicsModifyBone> result;
				if ((result = this._ModifyBones) == null)
				{
					result = (this._ModifyBones = new TArray<FKawaiiPhysicsModifyBone>(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_ModifyBones, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ModifyBones.CopyAssign(value);
			}
		}

		// Token: 0x17004ED3 RID: 20179
		// (get) Token: 0x060141BD RID: 82365 RVA: 0x001D8789 File Offset: 0x001D6989
		// (set) Token: 0x060141BE RID: 82366 RVA: 0x001D8799 File Offset: 0x001D6999
		public unsafe bool bEnableSimulate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_bEnableSimulate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_bEnableSimulate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004ED4 RID: 20180
		// (get) Token: 0x060141BF RID: 82367 RVA: 0x001D87AA File Offset: 0x001D69AA
		// (set) Token: 0x060141C0 RID: 82368 RVA: 0x001D87BA File Offset: 0x001D69BA
		public unsafe float AlphaScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_AlphaScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_AlphaScale) = value;
			}
		}

		// Token: 0x17004ED5 RID: 20181
		// (get) Token: 0x060141C1 RID: 82369 RVA: 0x001D87CB File Offset: 0x001D69CB
		// (set) Token: 0x060141C2 RID: 82370 RVA: 0x001D87DB File Offset: 0x001D69DB
		public unsafe float TotalBoneLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_TotalBoneLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_TotalBoneLength) = value;
			}
		}

		// Token: 0x17004ED6 RID: 20182
		// (get) Token: 0x060141C3 RID: 82371 RVA: 0x001D87EC File Offset: 0x001D69EC
		// (set) Token: 0x060141C4 RID: 82372 RVA: 0x001D8800 File Offset: 0x001D6A00
		public unsafe FTransform PreSkelCompTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_PreSkelCompTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_PreSkelCompTransform) = value;
			}
		}

		// Token: 0x17004ED7 RID: 20183
		// (get) Token: 0x060141C5 RID: 82373 RVA: 0x001D8815 File Offset: 0x001D6A15
		// (set) Token: 0x060141C6 RID: 82374 RVA: 0x001D8825 File Offset: 0x001D6A25
		public unsafe bool bInitPhysicsSettings
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_bInitPhysicsSettings) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsBase.__PropertyOffset_bInitPhysicsSettings) = (value ? 1 : 0);
			}
		}

		// Token: 0x060141C7 RID: 82375 RVA: 0x001D8836 File Offset: 0x001D6A36
		public FAnimNode_KawaiiPhysicsBase()
		{
		}

		// Token: 0x060141C8 RID: 82376 RVA: 0x001D8840 File Offset: 0x001D6A40
		public FAnimNode_KawaiiPhysicsBase(TArray<FBoneReference> ExcludeBones, bool bDebugEnableAdjustBone, int TargetFramerate, bool OverrideTargetFramerate, int IgnoreMechanicsLevel, bool bNewIgnoreMechanics, FKawaiiPhysicsSettings PhysicsSettings, UCurveFloat DampingCurve, UCurveFloat WorldDampingLocationCurve, UCurveFloat WorldDampingRotationCurve, UCurveFloat StiffnessCurve, UCurveFloat RadiusCurve, UCurveFloat HalfWidthCurve, UCurveFloat LimitAngleCurve, bool bUpdatePhysicsSettingsInGame, float DummyBoneLength, EBoneForwardAxis BoneForwardAxis, EPlanarConstraint PlanarConstraint, TArray<FSphericalLimit> SphericalLimits, TArray<FCapsuleLimit> CapsuleLimits, TArray<FPlanarLimit> PlanarLimits, UKawaiiPhysicsLimitsDataAsset LimitsDataAsset, TArray<FSphericalLimit> SphericalLimitsData, TArray<FCapsuleLimit> CapsuleLimitsData, TArray<FPlanarLimit> PlanarLimitsData, float TeleportDistanceThreshold, float TeleportRotationThreshold, FVector Gravity, bool bEnableWind, float WindScale, TArray<FKawaiiPhysicsModifyBone> ModifyBones, bool bEnableSimulate, float AlphaScale, float TotalBoneLength, FTransform PreSkelCompTransform, bool bInitPhysicsSettings, bool bEditing, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.ExcludeBones = ExcludeBones;
			this.TargetFramerate = TargetFramerate;
			this.OverrideTargetFramerate = OverrideTargetFramerate;
			this.IgnoreMechanicsLevel = IgnoreMechanicsLevel;
			this.bNewIgnoreMechanics = bNewIgnoreMechanics;
			this.PhysicsSettings = PhysicsSettings;
			this.DampingCurve = DampingCurve;
			this.WorldDampingLocationCurve = WorldDampingLocationCurve;
			this.WorldDampingRotationCurve = WorldDampingRotationCurve;
			this.StiffnessCurve = StiffnessCurve;
			this.RadiusCurve = RadiusCurve;
			this.HalfWidthCurve = HalfWidthCurve;
			this.LimitAngleCurve = LimitAngleCurve;
			this.bUpdatePhysicsSettingsInGame = bUpdatePhysicsSettingsInGame;
			this.DummyBoneLength = DummyBoneLength;
			this.BoneForwardAxis = BoneForwardAxis;
			this.PlanarConstraint = PlanarConstraint;
			this.SphericalLimits = SphericalLimits;
			this.CapsuleLimits = CapsuleLimits;
			this.PlanarLimits = PlanarLimits;
			this.LimitsDataAsset = LimitsDataAsset;
			this.SphericalLimitsData = SphericalLimitsData;
			this.CapsuleLimitsData = CapsuleLimitsData;
			this.PlanarLimitsData = PlanarLimitsData;
			this.TeleportDistanceThreshold = TeleportDistanceThreshold;
			this.TeleportRotationThreshold = TeleportRotationThreshold;
			this.Gravity = Gravity;
			this.bEnableWind = bEnableWind;
			this.WindScale = WindScale;
			this.ModifyBones = ModifyBones;
			this.bEnableSimulate = bEnableSimulate;
			this.AlphaScale = AlphaScale;
			this.TotalBoneLength = TotalBoneLength;
			this.PreSkelCompTransform = PreSkelCompTransform;
			this.bInitPhysicsSettings = bInitPhysicsSettings;
			base.ComponentPose = ComponentPose;
			base.LODThreshold = LODThreshold;
			base.KuroLODMask = KuroLODMask;
			base.ActualAlpha = ActualAlpha;
			base.AlphaInputType = AlphaInputType;
			base.bAlphaBoolEnabled = bAlphaBoolEnabled;
			base.bParallelEvalEnabled = bParallelEvalEnabled;
			base.bEnableOnMobile = bEnableOnMobile;
			base.Alpha = Alpha;
			base.AlphaScaleBias = AlphaScaleBias;
			base.AlphaBoolBlend = AlphaBoolBlend;
			base.AlphaCurveName = AlphaCurveName;
			base.AlphaScaleBiasClamp = AlphaScaleBiasClamp;
		}

		// Token: 0x060141C9 RID: 82377 RVA: 0x001D89D1 File Offset: 0x001D6BD1
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_KawaiiPhysicsBase.StaticStruct();
		}

		// Token: 0x060141CA RID: 82378 RVA: 0x001D89DD File Offset: 0x001D6BDD
		[NullableContext(2)]
		public FAnimNode_KawaiiPhysicsBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060141CB RID: 82379 RVA: 0x001D89E7 File Offset: 0x001D6BE7
		public FAnimNode_KawaiiPhysicsBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060141CC RID: 82380 RVA: 0x001D89F2 File Offset: 0x001D6BF2
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_KawaiiPhysicsBase(Pointer, false, true);
		}

		// Token: 0x060141CD RID: 82381 RVA: 0x001D89FC File Offset: 0x001D6BFC
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_KawaiiPhysicsBase(Pointer, MemoryOwner);
		}

		// Token: 0x0400AECF RID: 44751
		public new const string __ObjectPath = "/Script/KawaiiPhysics.AnimNode_KawaiiPhysicsBase";

		// Token: 0x0400AED0 RID: 44752
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400AED1 RID: 44753
		internal static int __PropertyOffset_ExcludeBones;

		// Token: 0x0400AED2 RID: 44754
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBoneReference> _ExcludeBones;

		// Token: 0x0400AED3 RID: 44755
		internal static int __PropertyOffset_TargetFramerate;

		// Token: 0x0400AED4 RID: 44756
		internal static int __PropertyOffset_OverrideTargetFramerate;

		// Token: 0x0400AED5 RID: 44757
		internal static int __PropertyOffset_IgnoreMechanicsLevel;

		// Token: 0x0400AED6 RID: 44758
		internal static int __PropertyOffset_bNewIgnoreMechanics;

		// Token: 0x0400AED7 RID: 44759
		internal static int __PropertyOffset_PhysicsSettings;

		// Token: 0x0400AED8 RID: 44760
		[Nullable(2)]
		private FKawaiiPhysicsSettings _PhysicsSettings;

		// Token: 0x0400AED9 RID: 44761
		internal static int __PropertyOffset_DampingCurve;

		// Token: 0x0400AEDA RID: 44762
		internal static int __PropertyOffset_WorldDampingLocationCurve;

		// Token: 0x0400AEDB RID: 44763
		internal static int __PropertyOffset_WorldDampingRotationCurve;

		// Token: 0x0400AEDC RID: 44764
		internal static int __PropertyOffset_StiffnessCurve;

		// Token: 0x0400AEDD RID: 44765
		internal static int __PropertyOffset_RadiusCurve;

		// Token: 0x0400AEDE RID: 44766
		internal static int __PropertyOffset_HalfWidthCurve;

		// Token: 0x0400AEDF RID: 44767
		internal static int __PropertyOffset_LimitAngleCurve;

		// Token: 0x0400AEE0 RID: 44768
		internal static int __PropertyOffset_bUpdatePhysicsSettingsInGame;

		// Token: 0x0400AEE1 RID: 44769
		internal static int __PropertyOffset_DummyBoneLength;

		// Token: 0x0400AEE2 RID: 44770
		internal static int __PropertyOffset_BoneForwardAxis;

		// Token: 0x0400AEE3 RID: 44771
		internal static int __PropertyOffset_PlanarConstraint;

		// Token: 0x0400AEE4 RID: 44772
		internal static int __PropertyOffset_SphericalLimits;

		// Token: 0x0400AEE5 RID: 44773
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSphericalLimit> _SphericalLimits;

		// Token: 0x0400AEE6 RID: 44774
		internal static int __PropertyOffset_CapsuleLimits;

		// Token: 0x0400AEE7 RID: 44775
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCapsuleLimit> _CapsuleLimits;

		// Token: 0x0400AEE8 RID: 44776
		internal static int __PropertyOffset_PlanarLimits;

		// Token: 0x0400AEE9 RID: 44777
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPlanarLimit> _PlanarLimits;

		// Token: 0x0400AEEA RID: 44778
		internal static int __PropertyOffset_LimitsDataAsset;

		// Token: 0x0400AEEB RID: 44779
		internal static int __PropertyOffset_SphericalLimitsData;

		// Token: 0x0400AEEC RID: 44780
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSphericalLimit> _SphericalLimitsData;

		// Token: 0x0400AEED RID: 44781
		internal static int __PropertyOffset_CapsuleLimitsData;

		// Token: 0x0400AEEE RID: 44782
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCapsuleLimit> _CapsuleLimitsData;

		// Token: 0x0400AEEF RID: 44783
		internal static int __PropertyOffset_PlanarLimitsData;

		// Token: 0x0400AEF0 RID: 44784
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPlanarLimit> _PlanarLimitsData;

		// Token: 0x0400AEF1 RID: 44785
		internal static int __PropertyOffset_TeleportDistanceThreshold;

		// Token: 0x0400AEF2 RID: 44786
		internal static int __PropertyOffset_TeleportRotationThreshold;

		// Token: 0x0400AEF3 RID: 44787
		internal static int __PropertyOffset_Gravity;

		// Token: 0x0400AEF4 RID: 44788
		internal static int __PropertyOffset_bEnableWind;

		// Token: 0x0400AEF5 RID: 44789
		internal static int __PropertyOffset_WindScale;

		// Token: 0x0400AEF6 RID: 44790
		internal static int __PropertyOffset_ModifyBones;

		// Token: 0x0400AEF7 RID: 44791
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKawaiiPhysicsModifyBone> _ModifyBones;

		// Token: 0x0400AEF8 RID: 44792
		internal static int __PropertyOffset_bEnableSimulate;

		// Token: 0x0400AEF9 RID: 44793
		internal static int __PropertyOffset_AlphaScale;

		// Token: 0x0400AEFA RID: 44794
		internal static int __PropertyOffset_TotalBoneLength;

		// Token: 0x0400AEFB RID: 44795
		internal static int __PropertyOffset_PreSkelCompTransform;

		// Token: 0x0400AEFC RID: 44796
		internal static int __PropertyOffset_bInitPhysicsSettings;
	}
}
