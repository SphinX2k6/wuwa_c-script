using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B25 RID: 6949
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroHourglassActor")]
	[UnrealStructLayout(1760, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1760)]
	public class AKuroHourglassActor : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601A2DE RID: 107230 RVA: 0x0026A8E0 File Offset: 0x00268AE0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroHourglassActor._ClassPtr;
		}

		// Token: 0x0601A2DF RID: 107231 RVA: 0x0026A8EC File Offset: 0x00268AEC
		public AKuroHourglassActor() : this(BuiltinUtils.AllocNativeUObject(AKuroHourglassActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601A2E0 RID: 107232 RVA: 0x0026A914 File Offset: 0x00268B14
		[NullableContext(1)]
		public AKuroHourglassActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroHourglassActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006939 RID: 26937
		// (get) Token: 0x0601A2E1 RID: 107233 RVA: 0x0026A947 File Offset: 0x00268B47
		// (set) Token: 0x0601A2E2 RID: 107234 RVA: 0x0026A957 File Offset: 0x00268B57
		public unsafe bool bShowDebugWireframe
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroHourglassActor.__PropertyOffset_bShowDebugWireframe) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroHourglassActor.__PropertyOffset_bShowDebugWireframe) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700693A RID: 26938
		// (get) Token: 0x0601A2E3 RID: 107235 RVA: 0x0026A968 File Offset: 0x00268B68
		// (set) Token: 0x0601A2E4 RID: 107236 RVA: 0x0026A978 File Offset: 0x00268B78
		public unsafe float InteractionRadiusCm
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroHourglassActor.__PropertyOffset_InteractionRadiusCm);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroHourglassActor.__PropertyOffset_InteractionRadiusCm) = value;
			}
		}

		// Token: 0x1700693B RID: 26939
		// (get) Token: 0x0601A2E5 RID: 107237 RVA: 0x0026A989 File Offset: 0x00268B89
		// (set) Token: 0x0601A2E6 RID: 107238 RVA: 0x0026A999 File Offset: 0x00268B99
		public unsafe float WeaponRadiusMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroHourglassActor.__PropertyOffset_WeaponRadiusMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroHourglassActor.__PropertyOffset_WeaponRadiusMultiplier) = value;
			}
		}

		// Token: 0x1700693C RID: 26940
		// (get) Token: 0x0601A2E7 RID: 107239 RVA: 0x0026A9AA File Offset: 0x00268BAA
		// (set) Token: 0x0601A2E8 RID: 107240 RVA: 0x0026A9BA File Offset: 0x00268BBA
		public unsafe float InteractionCooldownSec
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroHourglassActor.__PropertyOffset_InteractionCooldownSec);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroHourglassActor.__PropertyOffset_InteractionCooldownSec) = value;
			}
		}

		// Token: 0x1700693D RID: 26941
		// (get) Token: 0x0601A2E9 RID: 107241 RVA: 0x0026A9CB File Offset: 0x00268BCB
		// (set) Token: 0x0601A2EA RID: 107242 RVA: 0x0026A9DB File Offset: 0x00268BDB
		public unsafe float InteractionMinSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroHourglassActor.__PropertyOffset_InteractionMinSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroHourglassActor.__PropertyOffset_InteractionMinSpeed) = value;
			}
		}

		// Token: 0x1700693E RID: 26942
		// (get) Token: 0x0601A2EB RID: 107243 RVA: 0x0026A9EC File Offset: 0x00268BEC
		// (set) Token: 0x0601A2EC RID: 107244 RVA: 0x0026AA00 File Offset: 0x00268C00
		public unsafe FVector InteractionRotationAxisLocal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroHourglassActor.__PropertyOffset_InteractionRotationAxisLocal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroHourglassActor.__PropertyOffset_InteractionRotationAxisLocal) = value;
			}
		}

		// Token: 0x1700693F RID: 26943
		// (get) Token: 0x0601A2ED RID: 107245 RVA: 0x0026AA15 File Offset: 0x00268C15
		// (set) Token: 0x0601A2EE RID: 107246 RVA: 0x0026AA25 File Offset: 0x00268C25
		public unsafe float FlipProbability
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroHourglassActor.__PropertyOffset_FlipProbability);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroHourglassActor.__PropertyOffset_FlipProbability) = value;
			}
		}

		// Token: 0x17006940 RID: 26944
		// (get) Token: 0x0601A2EF RID: 107247 RVA: 0x0026AA36 File Offset: 0x00268C36
		// (set) Token: 0x0601A2F0 RID: 107248 RVA: 0x0026AA46 File Offset: 0x00268C46
		public unsafe float FlipDurationSec
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroHourglassActor.__PropertyOffset_FlipDurationSec);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroHourglassActor.__PropertyOffset_FlipDurationSec) = value;
			}
		}

		// Token: 0x17006941 RID: 26945
		// (get) Token: 0x0601A2F1 RID: 107249 RVA: 0x0026AA57 File Offset: 0x00268C57
		// (set) Token: 0x0601A2F2 RID: 107250 RVA: 0x0026AA6B File Offset: 0x00268C6B
		public unsafe FVector2D SwayAngleRangeDeg
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroHourglassActor.__PropertyOffset_SwayAngleRangeDeg);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroHourglassActor.__PropertyOffset_SwayAngleRangeDeg) = value;
			}
		}

		// Token: 0x17006942 RID: 26946
		// (get) Token: 0x0601A2F3 RID: 107251 RVA: 0x0026AA80 File Offset: 0x00268C80
		// (set) Token: 0x0601A2F4 RID: 107252 RVA: 0x0026AA94 File Offset: 0x00268C94
		public unsafe FVector2D SwayDurationRangeSec
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroHourglassActor.__PropertyOffset_SwayDurationRangeSec);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroHourglassActor.__PropertyOffset_SwayDurationRangeSec) = value;
			}
		}

		// Token: 0x17006943 RID: 26947
		// (get) Token: 0x0601A2F5 RID: 107253 RVA: 0x0026AAA9 File Offset: 0x00268CA9
		// (set) Token: 0x0601A2F6 RID: 107254 RVA: 0x0026AAB9 File Offset: 0x00268CB9
		public unsafe float HourglassVolumeEdgeLengthCm
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroHourglassActor.__PropertyOffset_HourglassVolumeEdgeLengthCm);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroHourglassActor.__PropertyOffset_HourglassVolumeEdgeLengthCm) = value;
			}
		}

		// Token: 0x17006944 RID: 26948
		// (get) Token: 0x0601A2F7 RID: 107255 RVA: 0x0026AACA File Offset: 0x00268CCA
		// (set) Token: 0x0601A2F8 RID: 107256 RVA: 0x0026AADA File Offset: 0x00268CDA
		public unsafe float HourglassInitialSandRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroHourglassActor.__PropertyOffset_HourglassInitialSandRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroHourglassActor.__PropertyOffset_HourglassInitialSandRatio) = value;
			}
		}

		// Token: 0x17006945 RID: 26949
		// (get) Token: 0x0601A2F9 RID: 107257 RVA: 0x0026AAEB File Offset: 0x00268CEB
		// (set) Token: 0x0601A2FA RID: 107258 RVA: 0x0026AAFB File Offset: 0x00268CFB
		public unsafe int HourglassSimPassesPerFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroHourglassActor.__PropertyOffset_HourglassSimPassesPerFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroHourglassActor.__PropertyOffset_HourglassSimPassesPerFrame) = value;
			}
		}

		// Token: 0x17006946 RID: 26950
		// (get) Token: 0x0601A2FB RID: 107259 RVA: 0x0026AB0C File Offset: 0x00268D0C
		// (set) Token: 0x0601A2FC RID: 107260 RVA: 0x0026AB1C File Offset: 0x00268D1C
		public unsafe EKuroHourglassVolumeResolution HourglassVolumeResolution
		{
			get
			{
				return (EKuroHourglassVolumeResolution)(*(base.NativePtr + (IntPtr)AKuroHourglassActor.__PropertyOffset_HourglassVolumeResolution));
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroHourglassActor.__PropertyOffset_HourglassVolumeResolution) = (byte)value;
			}
		}

		// Token: 0x17006947 RID: 26951
		// (get) Token: 0x0601A2FD RID: 107261 RVA: 0x0026AB2D File Offset: 0x00268D2D
		// (set) Token: 0x0601A2FE RID: 107262 RVA: 0x0026AB3D File Offset: 0x00268D3D
		public unsafe float RayMarchSandOpacityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroHourglassActor.__PropertyOffset_RayMarchSandOpacityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroHourglassActor.__PropertyOffset_RayMarchSandOpacityScale) = value;
			}
		}

		// Token: 0x17006948 RID: 26952
		// (get) Token: 0x0601A2FF RID: 107263 RVA: 0x0026AB4E File Offset: 0x00268D4E
		// (set) Token: 0x0601A300 RID: 107264 RVA: 0x0026AB5E File Offset: 0x00268D5E
		public unsafe float PresetHourglassHalfHeightLp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroHourglassActor.__PropertyOffset_PresetHourglassHalfHeightLp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroHourglassActor.__PropertyOffset_PresetHourglassHalfHeightLp) = value;
			}
		}

		// Token: 0x17006949 RID: 26953
		// (get) Token: 0x0601A301 RID: 107265 RVA: 0x0026AB6F File Offset: 0x00268D6F
		// (set) Token: 0x0601A302 RID: 107266 RVA: 0x0026AB7F File Offset: 0x00268D7F
		public unsafe float PresetHourglassNeckRadiusLp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroHourglassActor.__PropertyOffset_PresetHourglassNeckRadiusLp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroHourglassActor.__PropertyOffset_PresetHourglassNeckRadiusLp) = value;
			}
		}

		// Token: 0x1700694A RID: 26954
		// (get) Token: 0x0601A303 RID: 107267 RVA: 0x0026AB90 File Offset: 0x00268D90
		// (set) Token: 0x0601A304 RID: 107268 RVA: 0x0026ABA0 File Offset: 0x00268DA0
		public unsafe float PresetHourglassBellyRadiusLp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroHourglassActor.__PropertyOffset_PresetHourglassBellyRadiusLp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroHourglassActor.__PropertyOffset_PresetHourglassBellyRadiusLp) = value;
			}
		}

		// Token: 0x1700694B RID: 26955
		// (get) Token: 0x0601A305 RID: 107269 RVA: 0x0026ABB1 File Offset: 0x00268DB1
		// (set) Token: 0x0601A306 RID: 107270 RVA: 0x0026ABC1 File Offset: 0x00268DC1
		public unsafe float PresetHourglassRimRadiusLp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroHourglassActor.__PropertyOffset_PresetHourglassRimRadiusLp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroHourglassActor.__PropertyOffset_PresetHourglassRimRadiusLp) = value;
			}
		}

		// Token: 0x1700694C RID: 26956
		// (get) Token: 0x0601A307 RID: 107271 RVA: 0x0026ABD2 File Offset: 0x00268DD2
		// (set) Token: 0x0601A308 RID: 107272 RVA: 0x0026ABE2 File Offset: 0x00268DE2
		public unsafe float PresetHourglassBellyPositionU
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroHourglassActor.__PropertyOffset_PresetHourglassBellyPositionU);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroHourglassActor.__PropertyOffset_PresetHourglassBellyPositionU) = value;
			}
		}

		// Token: 0x1700694D RID: 26957
		// (get) Token: 0x0601A309 RID: 107273 RVA: 0x0026ABF3 File Offset: 0x00268DF3
		// (set) Token: 0x0601A30A RID: 107274 RVA: 0x0026AC07 File Offset: 0x00268E07
		public unsafe USceneComponent SceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroHourglassActor.__PropertyOffset_SceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroHourglassActor.__PropertyOffset_SceneRoot, value);
			}
		}

		// Token: 0x1700694E RID: 26958
		// (get) Token: 0x0601A30B RID: 107275 RVA: 0x0026AC1C File Offset: 0x00268E1C
		// (set) Token: 0x0601A30C RID: 107276 RVA: 0x0026AC30 File Offset: 0x00268E30
		public unsafe UStaticMeshComponent HourglassFrameMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroHourglassActor.__PropertyOffset_HourglassFrameMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroHourglassActor.__PropertyOffset_HourglassFrameMesh, value);
			}
		}

		// Token: 0x1700694F RID: 26959
		// (get) Token: 0x0601A30D RID: 107277 RVA: 0x0026AC45 File Offset: 0x00268E45
		// (set) Token: 0x0601A30E RID: 107278 RVA: 0x0026AC59 File Offset: 0x00268E59
		public unsafe UStaticMeshComponent HourglassStaticSandMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroHourglassActor.__PropertyOffset_HourglassStaticSandMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroHourglassActor.__PropertyOffset_HourglassStaticSandMesh, value);
			}
		}

		// Token: 0x17006950 RID: 26960
		// (get) Token: 0x0601A30F RID: 107279 RVA: 0x0026AC6E File Offset: 0x00268E6E
		// (set) Token: 0x0601A310 RID: 107280 RVA: 0x0026AC82 File Offset: 0x00268E82
		public unsafe USceneComponent HourglassPivot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroHourglassActor.__PropertyOffset_HourglassPivot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroHourglassActor.__PropertyOffset_HourglassPivot, value);
			}
		}

		// Token: 0x17006951 RID: 26961
		// (get) Token: 0x0601A311 RID: 107281 RVA: 0x0026AC97 File Offset: 0x00268E97
		// (set) Token: 0x0601A312 RID: 107282 RVA: 0x0026ACAB File Offset: 0x00268EAB
		public unsafe UStaticMeshComponent HourglassVisualMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroHourglassActor.__PropertyOffset_HourglassVisualMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroHourglassActor.__PropertyOffset_HourglassVisualMesh, value);
			}
		}

		// Token: 0x17006952 RID: 26962
		// (get) Token: 0x0601A313 RID: 107283 RVA: 0x0026ACC0 File Offset: 0x00268EC0
		// (set) Token: 0x0601A314 RID: 107284 RVA: 0x0026ACD4 File Offset: 0x00268ED4
		public unsafe UBoxComponent InteractionBounds
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroHourglassActor.__PropertyOffset_InteractionBounds);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroHourglassActor.__PropertyOffset_InteractionBounds, value);
			}
		}

		// Token: 0x0601A315 RID: 107285 RVA: 0x0026ACE9 File Offset: 0x00268EE9
		public EKuroHourglassHitReaction TriggerWeaponInteraction(FVectorDouble OriginPoint, float WeaponRadius, int WeaponChannel = 0)
		{
			return AKuroHourglassActor.__TriggerWeaponInteraction_Internal(base.NativePtr, OriginPoint, WeaponRadius, WeaponChannel);
		}

		// Token: 0x0601A316 RID: 107286 RVA: 0x0026ACF9 File Offset: 0x00268EF9
		public void ClearSand()
		{
			AKuroHourglassActor.__ClearSand_Internal(base.NativePtr);
		}

		// Token: 0x0601A317 RID: 107287
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EKuroHourglassHitReaction __TriggerWeaponInteraction_Internal(IntPtr @this, FVectorDouble OriginPoint, float WeaponRadius, int WeaponChannel);

		// Token: 0x0601A318 RID: 107288
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearSand_Internal(IntPtr @this);

		// Token: 0x0601A319 RID: 107289 RVA: 0x0026AD06 File Offset: 0x00268F06
		static AKuroHourglassActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroHourglassActor");
		}

		// Token: 0x0601A31A RID: 107290 RVA: 0x0026AD14 File Offset: 0x00268F14
		protected AKuroHourglassActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E38C RID: 58252
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroHourglassActor";

		// Token: 0x0400E38D RID: 58253
		private static IntPtr _ClassPtr;

		// Token: 0x0400E38E RID: 58254
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E38F RID: 58255
		internal static int __PropertyOffset_bShowDebugWireframe;

		// Token: 0x0400E390 RID: 58256
		internal static int __PropertyOffset_InteractionRadiusCm;

		// Token: 0x0400E391 RID: 58257
		internal static int __PropertyOffset_WeaponRadiusMultiplier;

		// Token: 0x0400E392 RID: 58258
		internal static int __PropertyOffset_InteractionCooldownSec;

		// Token: 0x0400E393 RID: 58259
		internal static int __PropertyOffset_InteractionMinSpeed;

		// Token: 0x0400E394 RID: 58260
		internal static int __PropertyOffset_InteractionRotationAxisLocal;

		// Token: 0x0400E395 RID: 58261
		internal static int __PropertyOffset_FlipProbability;

		// Token: 0x0400E396 RID: 58262
		internal static int __PropertyOffset_FlipDurationSec;

		// Token: 0x0400E397 RID: 58263
		internal static int __PropertyOffset_SwayAngleRangeDeg;

		// Token: 0x0400E398 RID: 58264
		internal static int __PropertyOffset_SwayDurationRangeSec;

		// Token: 0x0400E399 RID: 58265
		internal static int __PropertyOffset_HourglassVolumeEdgeLengthCm;

		// Token: 0x0400E39A RID: 58266
		internal static int __PropertyOffset_HourglassInitialSandRatio;

		// Token: 0x0400E39B RID: 58267
		internal static int __PropertyOffset_HourglassSimPassesPerFrame;

		// Token: 0x0400E39C RID: 58268
		internal static int __PropertyOffset_HourglassVolumeResolution;

		// Token: 0x0400E39D RID: 58269
		internal static int __PropertyOffset_RayMarchSandOpacityScale;

		// Token: 0x0400E39E RID: 58270
		internal static int __PropertyOffset_PresetHourglassHalfHeightLp;

		// Token: 0x0400E39F RID: 58271
		internal static int __PropertyOffset_PresetHourglassNeckRadiusLp;

		// Token: 0x0400E3A0 RID: 58272
		internal static int __PropertyOffset_PresetHourglassBellyRadiusLp;

		// Token: 0x0400E3A1 RID: 58273
		internal static int __PropertyOffset_PresetHourglassRimRadiusLp;

		// Token: 0x0400E3A2 RID: 58274
		internal static int __PropertyOffset_PresetHourglassBellyPositionU;

		// Token: 0x0400E3A3 RID: 58275
		internal static int __PropertyOffset_SceneRoot;

		// Token: 0x0400E3A4 RID: 58276
		internal static int __PropertyOffset_HourglassFrameMesh;

		// Token: 0x0400E3A5 RID: 58277
		internal static int __PropertyOffset_HourglassStaticSandMesh;

		// Token: 0x0400E3A6 RID: 58278
		internal static int __PropertyOffset_HourglassPivot;

		// Token: 0x0400E3A7 RID: 58279
		internal static int __PropertyOffset_HourglassVisualMesh;

		// Token: 0x0400E3A8 RID: 58280
		internal static int __PropertyOffset_InteractionBounds;
	}
}
