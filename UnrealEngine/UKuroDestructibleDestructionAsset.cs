using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AE3 RID: 6883
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroDestructibleDestructionAsset")]
	[UnrealStructLayout(400, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 400)]
	public class UKuroDestructibleDestructionAsset : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019A65 RID: 105061 RVA: 0x0025E8A2 File Offset: 0x0025CAA2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroDestructibleDestructionAsset._ClassPtr;
		}

		// Token: 0x06019A66 RID: 105062 RVA: 0x0025E8B0 File Offset: 0x0025CAB0
		public UKuroDestructibleDestructionAsset() : this(BuiltinUtils.AllocNativeUObject(UKuroDestructibleDestructionAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019A67 RID: 105063 RVA: 0x0025E8D8 File Offset: 0x0025CAD8
		public UKuroDestructibleDestructionAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroDestructibleDestructionAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006669 RID: 26217
		// (get) Token: 0x06019A68 RID: 105064 RVA: 0x0025E90C File Offset: 0x0025CB0C
		// (set) Token: 0x06019A69 RID: 105065 RVA: 0x0025E945 File Offset: 0x0025CB45
		public FCollisionProfileName CollisionProfileName
		{
			get
			{
				base.FastCheckIsValid();
				FCollisionProfileName result;
				if ((result = this._CollisionProfileName) == null)
				{
					result = (this._CollisionProfileName = new FCollisionProfileName(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_CollisionProfileName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCollisionProfileName.StaticStruct(), base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_CollisionProfileName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700666A RID: 26218
		// (get) Token: 0x06019A6A RID: 105066 RVA: 0x0025E968 File Offset: 0x0025CB68
		// (set) Token: 0x06019A6B RID: 105067 RVA: 0x0025E9A1 File Offset: 0x0025CBA1
		public FCollisionProfileName TriggerCollisionProfileName
		{
			get
			{
				base.FastCheckIsValid();
				FCollisionProfileName result;
				if ((result = this._TriggerCollisionProfileName) == null)
				{
					result = (this._TriggerCollisionProfileName = new FCollisionProfileName(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_TriggerCollisionProfileName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCollisionProfileName.StaticStruct(), base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_TriggerCollisionProfileName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700666B RID: 26219
		// (get) Token: 0x06019A6C RID: 105068 RVA: 0x0025E9C2 File Offset: 0x0025CBC2
		// (set) Token: 0x06019A6D RID: 105069 RVA: 0x0025E9D2 File Offset: 0x0025CBD2
		public unsafe bool bProxyMeshComponentCanHit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bProxyMeshComponentCanHit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bProxyMeshComponentCanHit) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700666C RID: 26220
		// (get) Token: 0x06019A6E RID: 105070 RVA: 0x0025E9E3 File Offset: 0x0025CBE3
		// (set) Token: 0x06019A6F RID: 105071 RVA: 0x0025E9F3 File Offset: 0x0025CBF3
		public unsafe bool bProxyMeshComponentCanOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bProxyMeshComponentCanOverlap) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bProxyMeshComponentCanOverlap) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700666D RID: 26221
		// (get) Token: 0x06019A70 RID: 105072 RVA: 0x0025EA04 File Offset: 0x0025CC04
		// (set) Token: 0x06019A71 RID: 105073 RVA: 0x0025EA14 File Offset: 0x0025CC14
		public unsafe bool bIgnoreBullet
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bIgnoreBullet) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bIgnoreBullet) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700666E RID: 26222
		// (get) Token: 0x06019A72 RID: 105074 RVA: 0x0025EA25 File Offset: 0x0025CC25
		// (set) Token: 0x06019A73 RID: 105075 RVA: 0x0025EA35 File Offset: 0x0025CC35
		public unsafe float BaseForce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_BaseForce);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_BaseForce) = value;
			}
		}

		// Token: 0x1700666F RID: 26223
		// (get) Token: 0x06019A74 RID: 105076 RVA: 0x0025EA46 File Offset: 0x0025CC46
		// (set) Token: 0x06019A75 RID: 105077 RVA: 0x0025EA56 File Offset: 0x0025CC56
		public unsafe float ImpulseFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_ImpulseFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_ImpulseFactor) = value;
			}
		}

		// Token: 0x17006670 RID: 26224
		// (get) Token: 0x06019A76 RID: 105078 RVA: 0x0025EA67 File Offset: 0x0025CC67
		// (set) Token: 0x06019A77 RID: 105079 RVA: 0x0025EA77 File Offset: 0x0025CC77
		public unsafe float ImpulseFactor2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_ImpulseFactor2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_ImpulseFactor2) = value;
			}
		}

		// Token: 0x17006671 RID: 26225
		// (get) Token: 0x06019A78 RID: 105080 RVA: 0x0025EA88 File Offset: 0x0025CC88
		// (set) Token: 0x06019A79 RID: 105081 RVA: 0x0025EA98 File Offset: 0x0025CC98
		public unsafe float DamageThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_DamageThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_DamageThreshold) = value;
			}
		}

		// Token: 0x17006672 RID: 26226
		// (get) Token: 0x06019A7A RID: 105082 RVA: 0x0025EAA9 File Offset: 0x0025CCA9
		// (set) Token: 0x06019A7B RID: 105083 RVA: 0x0025EAB9 File Offset: 0x0025CCB9
		public unsafe bool bUseDamage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bUseDamage) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bUseDamage) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006673 RID: 26227
		// (get) Token: 0x06019A7C RID: 105084 RVA: 0x0025EACA File Offset: 0x0025CCCA
		// (set) Token: 0x06019A7D RID: 105085 RVA: 0x0025EADA File Offset: 0x0025CCDA
		public unsafe float TotalDamageAmount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_TotalDamageAmount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_TotalDamageAmount) = value;
			}
		}

		// Token: 0x17006674 RID: 26228
		// (get) Token: 0x06019A7E RID: 105086 RVA: 0x0025EAEB File Offset: 0x0025CCEB
		// (set) Token: 0x06019A7F RID: 105087 RVA: 0x0025EAFB File Offset: 0x0025CCFB
		public unsafe bool bUseAttenuation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bUseAttenuation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bUseAttenuation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006675 RID: 26229
		// (get) Token: 0x06019A80 RID: 105088 RVA: 0x0025EB0C File Offset: 0x0025CD0C
		// (set) Token: 0x06019A81 RID: 105089 RVA: 0x0025EB1C File Offset: 0x0025CD1C
		public unsafe bool bUseAutoDamageRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bUseAutoDamageRadius) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bUseAutoDamageRadius) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006676 RID: 26230
		// (get) Token: 0x06019A82 RID: 105090 RVA: 0x0025EB2D File Offset: 0x0025CD2D
		// (set) Token: 0x06019A83 RID: 105091 RVA: 0x0025EB3D File Offset: 0x0025CD3D
		public unsafe float DamageRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_DamageRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_DamageRadius) = value;
			}
		}

		// Token: 0x17006677 RID: 26231
		// (get) Token: 0x06019A84 RID: 105092 RVA: 0x0025EB4E File Offset: 0x0025CD4E
		// (set) Token: 0x06019A85 RID: 105093 RVA: 0x0025EB5E File Offset: 0x0025CD5E
		public unsafe bool bAddImpulseAtLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bAddImpulseAtLocation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bAddImpulseAtLocation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006678 RID: 26232
		// (get) Token: 0x06019A86 RID: 105094 RVA: 0x0025EB6F File Offset: 0x0025CD6F
		// (set) Token: 0x06019A87 RID: 105095 RVA: 0x0025EB7F File Offset: 0x0025CD7F
		public unsafe bool bVelChange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bVelChange) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bVelChange) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006679 RID: 26233
		// (get) Token: 0x06019A88 RID: 105096 RVA: 0x0025EB90 File Offset: 0x0025CD90
		// (set) Token: 0x06019A89 RID: 105097 RVA: 0x0025EBA0 File Offset: 0x0025CDA0
		public unsafe bool bAddAngularImpulse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bAddAngularImpulse) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bAddAngularImpulse) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700667A RID: 26234
		// (get) Token: 0x06019A8A RID: 105098 RVA: 0x0025EBB1 File Offset: 0x0025CDB1
		// (set) Token: 0x06019A8B RID: 105099 RVA: 0x0025EBC1 File Offset: 0x0025CDC1
		public unsafe float AngularImpulseFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_AngularImpulseFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_AngularImpulseFactor) = value;
			}
		}

		// Token: 0x1700667B RID: 26235
		// (get) Token: 0x06019A8C RID: 105100 RVA: 0x0025EBD2 File Offset: 0x0025CDD2
		// (set) Token: 0x06019A8D RID: 105101 RVA: 0x0025EBE2 File Offset: 0x0025CDE2
		public unsafe bool bUseEasing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bUseEasing) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bUseEasing) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700667C RID: 26236
		// (get) Token: 0x06019A8E RID: 105102 RVA: 0x0025EBF3 File Offset: 0x0025CDF3
		// (set) Token: 0x06019A8F RID: 105103 RVA: 0x0025EC03 File Offset: 0x0025CE03
		public unsafe float MaxEaseMass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_MaxEaseMass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_MaxEaseMass) = value;
			}
		}

		// Token: 0x1700667D RID: 26237
		// (get) Token: 0x06019A90 RID: 105104 RVA: 0x0025EC14 File Offset: 0x0025CE14
		// (set) Token: 0x06019A91 RID: 105105 RVA: 0x0025EC24 File Offset: 0x0025CE24
		public unsafe ECurveSourceType SourceType
		{
			get
			{
				return (ECurveSourceType)(*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_SourceType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_SourceType) = (byte)value;
			}
		}

		// Token: 0x1700667E RID: 26238
		// (get) Token: 0x06019A92 RID: 105106 RVA: 0x0025EC35 File Offset: 0x0025CE35
		// (set) Token: 0x06019A93 RID: 105107 RVA: 0x0025EC49 File Offset: 0x0025CE49
		[Nullable(2)]
		public unsafe UCurveFloat CurveAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroDestructibleDestructionAsset.__PropertyOffset_CurveAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroDestructibleDestructionAsset.__PropertyOffset_CurveAsset, value);
			}
		}

		// Token: 0x1700667F RID: 26239
		// (get) Token: 0x06019A94 RID: 105108 RVA: 0x0025EC5E File Offset: 0x0025CE5E
		// (set) Token: 0x06019A95 RID: 105109 RVA: 0x0025EC6E File Offset: 0x0025CE6E
		public unsafe EEasingType EasingType
		{
			get
			{
				return (EEasingType)(*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_EasingType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_EasingType) = (byte)value;
			}
		}

		// Token: 0x17006680 RID: 26240
		// (get) Token: 0x06019A96 RID: 105110 RVA: 0x0025EC7F File Offset: 0x0025CE7F
		// (set) Token: 0x06019A97 RID: 105111 RVA: 0x0025EC8F File Offset: 0x0025CE8F
		public unsafe bool bUseLinearDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bUseLinearDamping) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bUseLinearDamping) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006681 RID: 26241
		// (get) Token: 0x06019A98 RID: 105112 RVA: 0x0025ECA0 File Offset: 0x0025CEA0
		// (set) Token: 0x06019A99 RID: 105113 RVA: 0x0025ECB0 File Offset: 0x0025CEB0
		public unsafe float LinearDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_LinearDamping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_LinearDamping) = value;
			}
		}

		// Token: 0x17006682 RID: 26242
		// (get) Token: 0x06019A9A RID: 105114 RVA: 0x0025ECC1 File Offset: 0x0025CEC1
		// (set) Token: 0x06019A9B RID: 105115 RVA: 0x0025ECD1 File Offset: 0x0025CED1
		public unsafe bool bIgnoreUpdateOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bIgnoreUpdateOverlap) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bIgnoreUpdateOverlap) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006683 RID: 26243
		// (get) Token: 0x06019A9C RID: 105116 RVA: 0x0025ECE2 File Offset: 0x0025CEE2
		// (set) Token: 0x06019A9D RID: 105117 RVA: 0x0025ECF2 File Offset: 0x0025CEF2
		public unsafe float StaticMeshSimulatePhysicsTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_StaticMeshSimulatePhysicsTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_StaticMeshSimulatePhysicsTime) = value;
			}
		}

		// Token: 0x17006684 RID: 26244
		// (get) Token: 0x06019A9E RID: 105118 RVA: 0x0025ED03 File Offset: 0x0025CF03
		// (set) Token: 0x06019A9F RID: 105119 RVA: 0x0025ED13 File Offset: 0x0025CF13
		public unsafe bool bCreateTrunksWhileApplyDamage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bCreateTrunksWhileApplyDamage) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bCreateTrunksWhileApplyDamage) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006685 RID: 26245
		// (get) Token: 0x06019AA0 RID: 105120 RVA: 0x0025ED24 File Offset: 0x0025CF24
		// (set) Token: 0x06019AA1 RID: 105121 RVA: 0x0025ED34 File Offset: 0x0025CF34
		public unsafe byte TrunksCreateCountPerFrameMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_TrunksCreateCountPerFrameMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_TrunksCreateCountPerFrameMax) = value;
			}
		}

		// Token: 0x17006686 RID: 26246
		// (get) Token: 0x06019AA2 RID: 105122 RVA: 0x0025ED45 File Offset: 0x0025CF45
		// (set) Token: 0x06019AA3 RID: 105123 RVA: 0x0025ED55 File Offset: 0x0025CF55
		public unsafe byte TrunksCreateCountPerFrameWindowsRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_TrunksCreateCountPerFrameWindowsRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_TrunksCreateCountPerFrameWindowsRatio) = value;
			}
		}

		// Token: 0x17006687 RID: 26247
		// (get) Token: 0x06019AA4 RID: 105124 RVA: 0x0025ED66 File Offset: 0x0025CF66
		// (set) Token: 0x06019AA5 RID: 105125 RVA: 0x0025ED76 File Offset: 0x0025CF76
		public unsafe byte TrunksCreateCountPerFrameIOSRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_TrunksCreateCountPerFrameIOSRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_TrunksCreateCountPerFrameIOSRatio) = value;
			}
		}

		// Token: 0x17006688 RID: 26248
		// (get) Token: 0x06019AA6 RID: 105126 RVA: 0x0025ED87 File Offset: 0x0025CF87
		// (set) Token: 0x06019AA7 RID: 105127 RVA: 0x0025ED97 File Offset: 0x0025CF97
		public unsafe byte TrunksCreateCountPerFrameAndroidRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_TrunksCreateCountPerFrameAndroidRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_TrunksCreateCountPerFrameAndroidRatio) = value;
			}
		}

		// Token: 0x17006689 RID: 26249
		// (get) Token: 0x06019AA8 RID: 105128 RVA: 0x0025EDA8 File Offset: 0x0025CFA8
		// (set) Token: 0x06019AA9 RID: 105129 RVA: 0x0025EDB8 File Offset: 0x0025CFB8
		public unsafe byte TrunksCreateCountPerFrameMacRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_TrunksCreateCountPerFrameMacRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_TrunksCreateCountPerFrameMacRatio) = value;
			}
		}

		// Token: 0x1700668A RID: 26250
		// (get) Token: 0x06019AAA RID: 105130 RVA: 0x0025EDC9 File Offset: 0x0025CFC9
		// (set) Token: 0x06019AAB RID: 105131 RVA: 0x0025EDD9 File Offset: 0x0025CFD9
		public unsafe byte TrunksCreateCountPerFramePS5Ratio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_TrunksCreateCountPerFramePS5Ratio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_TrunksCreateCountPerFramePS5Ratio) = value;
			}
		}

		// Token: 0x1700668B RID: 26251
		// (get) Token: 0x06019AAC RID: 105132 RVA: 0x0025EDEA File Offset: 0x0025CFEA
		// (set) Token: 0x06019AAD RID: 105133 RVA: 0x0025EDFA File Offset: 0x0025CFFA
		public unsafe bool bAutoDestroyAfterStopSimulatePhysics
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bAutoDestroyAfterStopSimulatePhysics) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bAutoDestroyAfterStopSimulatePhysics) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700668C RID: 26252
		// (get) Token: 0x06019AAE RID: 105134 RVA: 0x0025EE0B File Offset: 0x0025D00B
		// (set) Token: 0x06019AAF RID: 105135 RVA: 0x0025EE1B File Offset: 0x0025D01B
		public unsafe bool bAddToGamePartition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bAddToGamePartition) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bAddToGamePartition) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700668D RID: 26253
		// (get) Token: 0x06019AB0 RID: 105136 RVA: 0x0025EE2C File Offset: 0x0025D02C
		// (set) Token: 0x06019AB1 RID: 105137 RVA: 0x0025EE3C File Offset: 0x0025D03C
		public unsafe EGamePartitionCellSizeType GamePartitionCellSize
		{
			get
			{
				return (EGamePartitionCellSizeType)(*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_GamePartitionCellSize));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_GamePartitionCellSize) = (byte)value;
			}
		}

		// Token: 0x1700668E RID: 26254
		// (get) Token: 0x06019AB2 RID: 105138 RVA: 0x0025EE4D File Offset: 0x0025D04D
		// (set) Token: 0x06019AB3 RID: 105139 RVA: 0x0025EE5D File Offset: 0x0025D05D
		public unsafe bool bTrunksKeepLinearVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bTrunksKeepLinearVelocity) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bTrunksKeepLinearVelocity) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700668F RID: 26255
		// (get) Token: 0x06019AB4 RID: 105140 RVA: 0x0025EE6E File Offset: 0x0025D06E
		// (set) Token: 0x06019AB5 RID: 105141 RVA: 0x0025EE7E File Offset: 0x0025D07E
		public unsafe bool bTrunksKeepAngularVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bTrunksKeepAngularVelocity) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bTrunksKeepAngularVelocity) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006690 RID: 26256
		// (get) Token: 0x06019AB6 RID: 105142 RVA: 0x0025EE8F File Offset: 0x0025D08F
		// (set) Token: 0x06019AB7 RID: 105143 RVA: 0x0025EE9F File Offset: 0x0025D09F
		public unsafe bool bTrunksOverrideLinearVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bTrunksOverrideLinearVelocity) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bTrunksOverrideLinearVelocity) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006691 RID: 26257
		// (get) Token: 0x06019AB8 RID: 105144 RVA: 0x0025EEB0 File Offset: 0x0025D0B0
		// (set) Token: 0x06019AB9 RID: 105145 RVA: 0x0025EEC0 File Offset: 0x0025D0C0
		public unsafe bool bTrunksOverrideAngularVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bTrunksOverrideAngularVelocity) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bTrunksOverrideAngularVelocity) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006692 RID: 26258
		// (get) Token: 0x06019ABA RID: 105146 RVA: 0x0025EED1 File Offset: 0x0025D0D1
		// (set) Token: 0x06019ABB RID: 105147 RVA: 0x0025EEE5 File Offset: 0x0025D0E5
		public unsafe FVector TrunksLinearVelocityOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_TrunksLinearVelocityOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_TrunksLinearVelocityOverride) = value;
			}
		}

		// Token: 0x17006693 RID: 26259
		// (get) Token: 0x06019ABC RID: 105148 RVA: 0x0025EEFA File Offset: 0x0025D0FA
		// (set) Token: 0x06019ABD RID: 105149 RVA: 0x0025EF0E File Offset: 0x0025D10E
		public unsafe FVector TrunksAngularVelocityInDegreesOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_TrunksAngularVelocityInDegreesOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_TrunksAngularVelocityInDegreesOverride) = value;
			}
		}

		// Token: 0x17006694 RID: 26260
		// (get) Token: 0x06019ABE RID: 105150 RVA: 0x0025EF23 File Offset: 0x0025D123
		// (set) Token: 0x06019ABF RID: 105151 RVA: 0x0025EF37 File Offset: 0x0025D137
		[Nullable(2)]
		public unsafe UPhysicalMaterial PhysMaterialOverride
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicalMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroDestructibleDestructionAsset.__PropertyOffset_PhysMaterialOverride);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroDestructibleDestructionAsset.__PropertyOffset_PhysMaterialOverride, value);
			}
		}

		// Token: 0x17006695 RID: 26261
		// (get) Token: 0x06019AC0 RID: 105152 RVA: 0x0025EF4C File Offset: 0x0025D14C
		// (set) Token: 0x06019AC1 RID: 105153 RVA: 0x0025EF85 File Offset: 0x0025D185
		public FKuroDestructibleEffect Effect
		{
			get
			{
				base.FastCheckIsValid();
				FKuroDestructibleEffect result;
				if ((result = this._Effect) == null)
				{
					result = (this._Effect = new FKuroDestructibleEffect(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_Effect, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroDestructibleEffect.StaticStruct(), base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_Effect, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006696 RID: 26262
		// (get) Token: 0x06019AC2 RID: 105154 RVA: 0x0025EFA8 File Offset: 0x0025D1A8
		// (set) Token: 0x06019AC3 RID: 105155 RVA: 0x0025EFE1 File Offset: 0x0025D1E1
		public FKuroDestructibleEffect DestructionEffect
		{
			get
			{
				base.FastCheckIsValid();
				FKuroDestructibleEffect result;
				if ((result = this._DestructionEffect) == null)
				{
					result = (this._DestructionEffect = new FKuroDestructibleEffect(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_DestructionEffect, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroDestructibleEffect.StaticStruct(), base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_DestructionEffect, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06019AC4 RID: 105156 RVA: 0x0025F002 File Offset: 0x0025D202
		static UKuroDestructibleDestructionAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroDestructibleDestructionAsset");
		}

		// Token: 0x06019AC5 RID: 105157 RVA: 0x0025F010 File Offset: 0x0025D210
		protected UKuroDestructibleDestructionAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DF46 RID: 57158
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroDestructibleDestructionAsset";

		// Token: 0x0400DF47 RID: 57159
		private static IntPtr _ClassPtr;

		// Token: 0x0400DF48 RID: 57160
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400DF49 RID: 57161
		internal static int __PropertyOffset_CollisionProfileName;

		// Token: 0x0400DF4A RID: 57162
		[Nullable(2)]
		private FCollisionProfileName _CollisionProfileName;

		// Token: 0x0400DF4B RID: 57163
		internal static int __PropertyOffset_TriggerCollisionProfileName;

		// Token: 0x0400DF4C RID: 57164
		[Nullable(2)]
		private FCollisionProfileName _TriggerCollisionProfileName;

		// Token: 0x0400DF4D RID: 57165
		internal static int __PropertyOffset_bProxyMeshComponentCanHit;

		// Token: 0x0400DF4E RID: 57166
		internal static int __PropertyOffset_bProxyMeshComponentCanOverlap;

		// Token: 0x0400DF4F RID: 57167
		internal static int __PropertyOffset_bIgnoreBullet;

		// Token: 0x0400DF50 RID: 57168
		internal static int __PropertyOffset_BaseForce;

		// Token: 0x0400DF51 RID: 57169
		internal static int __PropertyOffset_ImpulseFactor;

		// Token: 0x0400DF52 RID: 57170
		internal static int __PropertyOffset_ImpulseFactor2;

		// Token: 0x0400DF53 RID: 57171
		internal static int __PropertyOffset_DamageThreshold;

		// Token: 0x0400DF54 RID: 57172
		internal static int __PropertyOffset_bUseDamage;

		// Token: 0x0400DF55 RID: 57173
		internal static int __PropertyOffset_TotalDamageAmount;

		// Token: 0x0400DF56 RID: 57174
		internal static int __PropertyOffset_bUseAttenuation;

		// Token: 0x0400DF57 RID: 57175
		internal static int __PropertyOffset_bUseAutoDamageRadius;

		// Token: 0x0400DF58 RID: 57176
		internal static int __PropertyOffset_DamageRadius;

		// Token: 0x0400DF59 RID: 57177
		internal static int __PropertyOffset_bAddImpulseAtLocation;

		// Token: 0x0400DF5A RID: 57178
		internal static int __PropertyOffset_bVelChange;

		// Token: 0x0400DF5B RID: 57179
		internal static int __PropertyOffset_bAddAngularImpulse;

		// Token: 0x0400DF5C RID: 57180
		internal static int __PropertyOffset_AngularImpulseFactor;

		// Token: 0x0400DF5D RID: 57181
		internal static int __PropertyOffset_bUseEasing;

		// Token: 0x0400DF5E RID: 57182
		internal static int __PropertyOffset_MaxEaseMass;

		// Token: 0x0400DF5F RID: 57183
		internal static int __PropertyOffset_SourceType;

		// Token: 0x0400DF60 RID: 57184
		internal static int __PropertyOffset_CurveAsset;

		// Token: 0x0400DF61 RID: 57185
		internal static int __PropertyOffset_EasingType;

		// Token: 0x0400DF62 RID: 57186
		internal static int __PropertyOffset_bUseLinearDamping;

		// Token: 0x0400DF63 RID: 57187
		internal static int __PropertyOffset_LinearDamping;

		// Token: 0x0400DF64 RID: 57188
		internal static int __PropertyOffset_bIgnoreUpdateOverlap;

		// Token: 0x0400DF65 RID: 57189
		internal static int __PropertyOffset_StaticMeshSimulatePhysicsTime;

		// Token: 0x0400DF66 RID: 57190
		internal static int __PropertyOffset_bCreateTrunksWhileApplyDamage;

		// Token: 0x0400DF67 RID: 57191
		internal static int __PropertyOffset_TrunksCreateCountPerFrameMax;

		// Token: 0x0400DF68 RID: 57192
		internal static int __PropertyOffset_TrunksCreateCountPerFrameWindowsRatio;

		// Token: 0x0400DF69 RID: 57193
		internal static int __PropertyOffset_TrunksCreateCountPerFrameIOSRatio;

		// Token: 0x0400DF6A RID: 57194
		internal static int __PropertyOffset_TrunksCreateCountPerFrameAndroidRatio;

		// Token: 0x0400DF6B RID: 57195
		internal static int __PropertyOffset_TrunksCreateCountPerFrameMacRatio;

		// Token: 0x0400DF6C RID: 57196
		internal static int __PropertyOffset_TrunksCreateCountPerFramePS5Ratio;

		// Token: 0x0400DF6D RID: 57197
		internal static int __PropertyOffset_bAutoDestroyAfterStopSimulatePhysics;

		// Token: 0x0400DF6E RID: 57198
		internal static int __PropertyOffset_bAddToGamePartition;

		// Token: 0x0400DF6F RID: 57199
		internal static int __PropertyOffset_GamePartitionCellSize;

		// Token: 0x0400DF70 RID: 57200
		internal static int __PropertyOffset_bTrunksKeepLinearVelocity;

		// Token: 0x0400DF71 RID: 57201
		internal static int __PropertyOffset_bTrunksKeepAngularVelocity;

		// Token: 0x0400DF72 RID: 57202
		internal static int __PropertyOffset_bTrunksOverrideLinearVelocity;

		// Token: 0x0400DF73 RID: 57203
		internal static int __PropertyOffset_bTrunksOverrideAngularVelocity;

		// Token: 0x0400DF74 RID: 57204
		internal static int __PropertyOffset_TrunksLinearVelocityOverride;

		// Token: 0x0400DF75 RID: 57205
		internal static int __PropertyOffset_TrunksAngularVelocityInDegreesOverride;

		// Token: 0x0400DF76 RID: 57206
		internal static int __PropertyOffset_PhysMaterialOverride;

		// Token: 0x0400DF77 RID: 57207
		internal static int __PropertyOffset_Effect;

		// Token: 0x0400DF78 RID: 57208
		[Nullable(2)]
		private FKuroDestructibleEffect _Effect;

		// Token: 0x0400DF79 RID: 57209
		internal static int __PropertyOffset_DestructionEffect;

		// Token: 0x0400DF7A RID: 57210
		[Nullable(2)]
		private FKuroDestructibleEffect _DestructionEffect;
	}
}
