using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200197C RID: 6524
	[UnrealObjectPath("/Script/KuroGPUDrivenImposter.KuroGPUDrivenImposterUpdater")]
	[UnrealStructLayout(1168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1168)]
	public class AKuroGPUDrivenImposterUpdater : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060183A6 RID: 99238 RVA: 0x0023BC7E File Offset: 0x00239E7E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroGPUDrivenImposterUpdater._ClassPtr;
		}

		// Token: 0x060183A7 RID: 99239 RVA: 0x0023BC8C File Offset: 0x00239E8C
		public AKuroGPUDrivenImposterUpdater() : this(BuiltinUtils.AllocNativeUObject(AKuroGPUDrivenImposterUpdater.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060183A8 RID: 99240 RVA: 0x0023BCB4 File Offset: 0x00239EB4
		[NullableContext(1)]
		public AKuroGPUDrivenImposterUpdater(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroGPUDrivenImposterUpdater.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170060E7 RID: 24807
		// (get) Token: 0x060183A9 RID: 99241 RVA: 0x0023BCE7 File Offset: 0x00239EE7
		// (set) Token: 0x060183AA RID: 99242 RVA: 0x0023BCF7 File Offset: 0x00239EF7
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGPUDrivenImposterUpdater.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGPUDrivenImposterUpdater.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x170060E8 RID: 24808
		// (get) Token: 0x060183AB RID: 99243 RVA: 0x0023BD08 File Offset: 0x00239F08
		// (set) Token: 0x060183AC RID: 99244 RVA: 0x0023BD18 File Offset: 0x00239F18
		public unsafe bool bSearchMainLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGPUDrivenImposterUpdater.__PropertyOffset_bSearchMainLight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGPUDrivenImposterUpdater.__PropertyOffset_bSearchMainLight) = (value ? 1 : 0);
			}
		}

		// Token: 0x170060E9 RID: 24809
		// (get) Token: 0x060183AD RID: 99245 RVA: 0x0023BD29 File Offset: 0x00239F29
		// (set) Token: 0x060183AE RID: 99246 RVA: 0x0023BD39 File Offset: 0x00239F39
		public unsafe bool bBakeShadowEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGPUDrivenImposterUpdater.__PropertyOffset_bBakeShadowEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGPUDrivenImposterUpdater.__PropertyOffset_bBakeShadowEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x170060EA RID: 24810
		// (get) Token: 0x060183AF RID: 99247 RVA: 0x0023BD4A File Offset: 0x00239F4A
		// (set) Token: 0x060183B0 RID: 99248 RVA: 0x0023BD5A File Offset: 0x00239F5A
		public unsafe float BakeShadowStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGPUDrivenImposterUpdater.__PropertyOffset_BakeShadowStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGPUDrivenImposterUpdater.__PropertyOffset_BakeShadowStrength) = value;
			}
		}

		// Token: 0x170060EB RID: 24811
		// (get) Token: 0x060183B1 RID: 99249 RVA: 0x0023BD6B File Offset: 0x00239F6B
		// (set) Token: 0x060183B2 RID: 99250 RVA: 0x0023BD7B File Offset: 0x00239F7B
		public unsafe bool bDisableBakeShadowInterpolation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGPUDrivenImposterUpdater.__PropertyOffset_bDisableBakeShadowInterpolation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGPUDrivenImposterUpdater.__PropertyOffset_bDisableBakeShadowInterpolation) = (value ? 1 : 0);
			}
		}

		// Token: 0x170060EC RID: 24812
		// (get) Token: 0x060183B3 RID: 99251 RVA: 0x0023BD8C File Offset: 0x00239F8C
		// (set) Token: 0x060183B4 RID: 99252 RVA: 0x0023BD9C File Offset: 0x00239F9C
		public unsafe float GBufferAOStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGPUDrivenImposterUpdater.__PropertyOffset_GBufferAOStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGPUDrivenImposterUpdater.__PropertyOffset_GBufferAOStrength) = value;
			}
		}

		// Token: 0x170060ED RID: 24813
		// (get) Token: 0x060183B5 RID: 99253 RVA: 0x0023BDAD File Offset: 0x00239FAD
		// (set) Token: 0x060183B6 RID: 99254 RVA: 0x0023BDBD File Offset: 0x00239FBD
		public unsafe float Specular
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGPUDrivenImposterUpdater.__PropertyOffset_Specular);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGPUDrivenImposterUpdater.__PropertyOffset_Specular) = value;
			}
		}

		// Token: 0x170060EE RID: 24814
		// (get) Token: 0x060183B7 RID: 99255 RVA: 0x0023BDCE File Offset: 0x00239FCE
		// (set) Token: 0x060183B8 RID: 99256 RVA: 0x0023BDDE File Offset: 0x00239FDE
		public unsafe float ColorRampRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGPUDrivenImposterUpdater.__PropertyOffset_ColorRampRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGPUDrivenImposterUpdater.__PropertyOffset_ColorRampRatio) = value;
			}
		}

		// Token: 0x170060EF RID: 24815
		// (get) Token: 0x060183B9 RID: 99257 RVA: 0x0023BDEF File Offset: 0x00239FEF
		// (set) Token: 0x060183BA RID: 99258 RVA: 0x0023BDFF File Offset: 0x00239FFF
		public unsafe bool bGPUCullEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGPUDrivenImposterUpdater.__PropertyOffset_bGPUCullEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGPUDrivenImposterUpdater.__PropertyOffset_bGPUCullEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x170060F0 RID: 24816
		// (get) Token: 0x060183BB RID: 99259 RVA: 0x0023BE10 File Offset: 0x0023A010
		// (set) Token: 0x060183BC RID: 99260 RVA: 0x0023BE20 File Offset: 0x0023A020
		public unsafe bool bForceImposter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGPUDrivenImposterUpdater.__PropertyOffset_bForceImposter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGPUDrivenImposterUpdater.__PropertyOffset_bForceImposter) = (value ? 1 : 0);
			}
		}

		// Token: 0x170060F1 RID: 24817
		// (get) Token: 0x060183BD RID: 99261 RVA: 0x0023BE31 File Offset: 0x0023A031
		// (set) Token: 0x060183BE RID: 99262 RVA: 0x0023BE41 File Offset: 0x0023A041
		public unsafe bool bRealTreeEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGPUDrivenImposterUpdater.__PropertyOffset_bRealTreeEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGPUDrivenImposterUpdater.__PropertyOffset_bRealTreeEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x170060F2 RID: 24818
		// (get) Token: 0x060183BF RID: 99263 RVA: 0x0023BE52 File Offset: 0x0023A052
		// (set) Token: 0x060183C0 RID: 99264 RVA: 0x0023BE62 File Offset: 0x0023A062
		public unsafe float RealTreeImposterSwitchDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGPUDrivenImposterUpdater.__PropertyOffset_RealTreeImposterSwitchDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGPUDrivenImposterUpdater.__PropertyOffset_RealTreeImposterSwitchDistance) = value;
			}
		}

		// Token: 0x170060F3 RID: 24819
		// (get) Token: 0x060183C1 RID: 99265 RVA: 0x0023BE73 File Offset: 0x0023A073
		// (set) Token: 0x060183C2 RID: 99266 RVA: 0x0023BE83 File Offset: 0x0023A083
		public unsafe float ImposterLodFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGPUDrivenImposterUpdater.__PropertyOffset_ImposterLodFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGPUDrivenImposterUpdater.__PropertyOffset_ImposterLodFactor) = value;
			}
		}

		// Token: 0x170060F4 RID: 24820
		// (get) Token: 0x060183C3 RID: 99267 RVA: 0x0023BE94 File Offset: 0x0023A094
		// (set) Token: 0x060183C4 RID: 99268 RVA: 0x0023BEA4 File Offset: 0x0023A0A4
		public unsafe bool bStableInfoVisualize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGPUDrivenImposterUpdater.__PropertyOffset_bStableInfoVisualize) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGPUDrivenImposterUpdater.__PropertyOffset_bStableInfoVisualize) = (value ? 1 : 0);
			}
		}

		// Token: 0x170060F5 RID: 24821
		// (get) Token: 0x060183C5 RID: 99269 RVA: 0x0023BEB5 File Offset: 0x0023A0B5
		// (set) Token: 0x060183C6 RID: 99270 RVA: 0x0023BEC5 File Offset: 0x0023A0C5
		public unsafe bool bBasePassDebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGPUDrivenImposterUpdater.__PropertyOffset_bBasePassDebug) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGPUDrivenImposterUpdater.__PropertyOffset_bBasePassDebug) = (value ? 1 : 0);
			}
		}

		// Token: 0x170060F6 RID: 24822
		// (get) Token: 0x060183C7 RID: 99271 RVA: 0x0023BED6 File Offset: 0x0023A0D6
		// (set) Token: 0x060183C8 RID: 99272 RVA: 0x0023BEE6 File Offset: 0x0023A0E6
		public unsafe bool bImposterDistanceDebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGPUDrivenImposterUpdater.__PropertyOffset_bImposterDistanceDebug) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGPUDrivenImposterUpdater.__PropertyOffset_bImposterDistanceDebug) = (value ? 1 : 0);
			}
		}

		// Token: 0x060183C9 RID: 99273 RVA: 0x0023BEF7 File Offset: 0x0023A0F7
		[NullableContext(2)]
		public void UpdateImposters(UDirectionalLightComponent DirLight, float DeltaTime)
		{
			AKuroGPUDrivenImposterUpdater.__UpdateImposters_Internal(base.NativePtr, (DirLight != null) ? DirLight.NativePtr : IntPtr.Zero, DeltaTime);
		}

		// Token: 0x060183CA RID: 99274 RVA: 0x0023BF15 File Offset: 0x0023A115
		public void FillAllInstGlobalColor()
		{
			AKuroGPUDrivenImposterUpdater.__FillAllInstGlobalColor_Internal(base.NativePtr);
		}

		// Token: 0x060183CB RID: 99275 RVA: 0x0023BF22 File Offset: 0x0023A122
		public void ApplyGlobalSettings()
		{
			AKuroGPUDrivenImposterUpdater.__ApplyGlobalSettings_Internal(base.NativePtr);
		}

		// Token: 0x060183CC RID: 99276
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateImposters_Internal(IntPtr @this, IntPtr DirLight, float DeltaTime);

		// Token: 0x060183CD RID: 99277
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FillAllInstGlobalColor_Internal(IntPtr @this);

		// Token: 0x060183CE RID: 99278
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyGlobalSettings_Internal(IntPtr @this);

		// Token: 0x060183CF RID: 99279 RVA: 0x0023BF2F File Offset: 0x0023A12F
		static AKuroGPUDrivenImposterUpdater()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGPUDrivenImposter.KuroGPUDrivenImposterUpdater");
		}

		// Token: 0x060183D0 RID: 99280 RVA: 0x0023BF3D File Offset: 0x0023A13D
		protected AKuroGPUDrivenImposterUpdater(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D1F4 RID: 53748
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGPUDrivenImposter.KuroGPUDrivenImposterUpdater";

		// Token: 0x0400D1F5 RID: 53749
		private static IntPtr _ClassPtr;

		// Token: 0x0400D1F6 RID: 53750
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D1F7 RID: 53751
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x0400D1F8 RID: 53752
		internal static int __PropertyOffset_bSearchMainLight;

		// Token: 0x0400D1F9 RID: 53753
		internal static int __PropertyOffset_bBakeShadowEnabled;

		// Token: 0x0400D1FA RID: 53754
		internal static int __PropertyOffset_BakeShadowStrength;

		// Token: 0x0400D1FB RID: 53755
		internal static int __PropertyOffset_bDisableBakeShadowInterpolation;

		// Token: 0x0400D1FC RID: 53756
		internal static int __PropertyOffset_GBufferAOStrength;

		// Token: 0x0400D1FD RID: 53757
		internal static int __PropertyOffset_Specular;

		// Token: 0x0400D1FE RID: 53758
		internal static int __PropertyOffset_ColorRampRatio;

		// Token: 0x0400D1FF RID: 53759
		internal static int __PropertyOffset_bGPUCullEnabled;

		// Token: 0x0400D200 RID: 53760
		internal static int __PropertyOffset_bForceImposter;

		// Token: 0x0400D201 RID: 53761
		internal static int __PropertyOffset_bRealTreeEnabled;

		// Token: 0x0400D202 RID: 53762
		internal static int __PropertyOffset_RealTreeImposterSwitchDistance;

		// Token: 0x0400D203 RID: 53763
		internal static int __PropertyOffset_ImposterLodFactor;

		// Token: 0x0400D204 RID: 53764
		internal static int __PropertyOffset_bStableInfoVisualize;

		// Token: 0x0400D205 RID: 53765
		internal static int __PropertyOffset_bBasePassDebug;

		// Token: 0x0400D206 RID: 53766
		internal static int __PropertyOffset_bImposterDistanceDebug;
	}
}
