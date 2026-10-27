using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B26 RID: 6950
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroInstanceGrassInteraction")]
	[UnrealStructLayout(1544, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1544)]
	public class AKuroInstanceGrassInteraction : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601A31B RID: 107291 RVA: 0x0026AD1D File Offset: 0x00268F1D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroInstanceGrassInteraction._ClassPtr;
		}

		// Token: 0x0601A31C RID: 107292 RVA: 0x0026AD2C File Offset: 0x00268F2C
		public AKuroInstanceGrassInteraction() : this(BuiltinUtils.AllocNativeUObject(AKuroInstanceGrassInteraction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601A31D RID: 107293 RVA: 0x0026AD54 File Offset: 0x00268F54
		[NullableContext(1)]
		public AKuroInstanceGrassInteraction(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroInstanceGrassInteraction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006953 RID: 26963
		// (get) Token: 0x0601A31E RID: 107294 RVA: 0x0026AD87 File Offset: 0x00268F87
		// (set) Token: 0x0601A31F RID: 107295 RVA: 0x0026AD9B File Offset: 0x00268F9B
		public unsafe UTextureRenderTarget2D RT_PosA
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroInstanceGrassInteraction.__PropertyOffset_RT_PosA);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroInstanceGrassInteraction.__PropertyOffset_RT_PosA, value);
			}
		}

		// Token: 0x17006954 RID: 26964
		// (get) Token: 0x0601A320 RID: 107296 RVA: 0x0026ADB0 File Offset: 0x00268FB0
		// (set) Token: 0x0601A321 RID: 107297 RVA: 0x0026ADC4 File Offset: 0x00268FC4
		public unsafe UTextureRenderTarget2D RT_PosB
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroInstanceGrassInteraction.__PropertyOffset_RT_PosB);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroInstanceGrassInteraction.__PropertyOffset_RT_PosB, value);
			}
		}

		// Token: 0x17006955 RID: 26965
		// (get) Token: 0x0601A322 RID: 107298 RVA: 0x0026ADD9 File Offset: 0x00268FD9
		// (set) Token: 0x0601A323 RID: 107299 RVA: 0x0026ADE9 File Offset: 0x00268FE9
		public unsafe float CollisionRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroInstanceGrassInteraction.__PropertyOffset_CollisionRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroInstanceGrassInteraction.__PropertyOffset_CollisionRadius) = value;
			}
		}

		// Token: 0x17006956 RID: 26966
		// (get) Token: 0x0601A324 RID: 107300 RVA: 0x0026ADFA File Offset: 0x00268FFA
		// (set) Token: 0x0601A325 RID: 107301 RVA: 0x0026AE0A File Offset: 0x0026900A
		public unsafe float VolDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroInstanceGrassInteraction.__PropertyOffset_VolDamping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroInstanceGrassInteraction.__PropertyOffset_VolDamping) = value;
			}
		}

		// Token: 0x17006957 RID: 26967
		// (get) Token: 0x0601A326 RID: 107302 RVA: 0x0026AE1B File Offset: 0x0026901B
		// (set) Token: 0x0601A327 RID: 107303 RVA: 0x0026AE2B File Offset: 0x0026902B
		public unsafe float K
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroInstanceGrassInteraction.__PropertyOffset_K);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroInstanceGrassInteraction.__PropertyOffset_K) = value;
			}
		}

		// Token: 0x17006958 RID: 26968
		// (get) Token: 0x0601A328 RID: 107304 RVA: 0x0026AE3C File Offset: 0x0026903C
		// (set) Token: 0x0601A329 RID: 107305 RVA: 0x0026AE4C File Offset: 0x0026904C
		public unsafe float InteractionSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroInstanceGrassInteraction.__PropertyOffset_InteractionSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroInstanceGrassInteraction.__PropertyOffset_InteractionSize) = value;
			}
		}

		// Token: 0x17006959 RID: 26969
		// (get) Token: 0x0601A32A RID: 107306 RVA: 0x0026AE5D File Offset: 0x0026905D
		// (set) Token: 0x0601A32B RID: 107307 RVA: 0x0026AE6D File Offset: 0x0026906D
		public unsafe float CollisionRadius_Character
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroInstanceGrassInteraction.__PropertyOffset_CollisionRadius_Character);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroInstanceGrassInteraction.__PropertyOffset_CollisionRadius_Character) = value;
			}
		}

		// Token: 0x1700695A RID: 26970
		// (get) Token: 0x0601A32C RID: 107308 RVA: 0x0026AE7E File Offset: 0x0026907E
		// (set) Token: 0x0601A32D RID: 107309 RVA: 0x0026AE92 File Offset: 0x00269092
		public unsafe UMaterialParameterCollection Scene_MPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroInstanceGrassInteraction.__PropertyOffset_Scene_MPC);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroInstanceGrassInteraction.__PropertyOffset_Scene_MPC, value);
			}
		}

		// Token: 0x1700695B RID: 26971
		// (get) Token: 0x0601A32E RID: 107310 RVA: 0x0026AEA7 File Offset: 0x002690A7
		// (set) Token: 0x0601A32F RID: 107311 RVA: 0x0026AEBB File Offset: 0x002690BB
		public unsafe FLinearColor ClearColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroInstanceGrassInteraction.__PropertyOffset_ClearColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroInstanceGrassInteraction.__PropertyOffset_ClearColor) = value;
			}
		}

		// Token: 0x1700695C RID: 26972
		// (get) Token: 0x0601A330 RID: 107312 RVA: 0x0026AED0 File Offset: 0x002690D0
		// (set) Token: 0x0601A331 RID: 107313 RVA: 0x0026AEE0 File Offset: 0x002690E0
		public unsafe float CollisionRadius_Moto
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroInstanceGrassInteraction.__PropertyOffset_CollisionRadius_Moto);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroInstanceGrassInteraction.__PropertyOffset_CollisionRadius_Moto) = value;
			}
		}

		// Token: 0x1700695D RID: 26973
		// (get) Token: 0x0601A332 RID: 107314 RVA: 0x0026AEF1 File Offset: 0x002690F1
		// (set) Token: 0x0601A333 RID: 107315 RVA: 0x0026AF01 File Offset: 0x00269101
		public unsafe int Case
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroInstanceGrassInteraction.__PropertyOffset_Case);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroInstanceGrassInteraction.__PropertyOffset_Case) = value;
			}
		}

		// Token: 0x1700695E RID: 26974
		// (get) Token: 0x0601A334 RID: 107316 RVA: 0x0026AF12 File Offset: 0x00269112
		// (set) Token: 0x0601A335 RID: 107317 RVA: 0x0026AF26 File Offset: 0x00269126
		public unsafe UMaterialInterface M_StampPos
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroInstanceGrassInteraction.__PropertyOffset_M_StampPos);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroInstanceGrassInteraction.__PropertyOffset_M_StampPos, value);
			}
		}

		// Token: 0x1700695F RID: 26975
		// (get) Token: 0x0601A336 RID: 107318 RVA: 0x0026AF3B File Offset: 0x0026913B
		// (set) Token: 0x0601A337 RID: 107319 RVA: 0x0026AF4F File Offset: 0x0026914F
		public unsafe UMaterialInterface M_UpdatePos
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroInstanceGrassInteraction.__PropertyOffset_M_UpdatePos);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroInstanceGrassInteraction.__PropertyOffset_M_UpdatePos, value);
			}
		}

		// Token: 0x17006960 RID: 26976
		// (get) Token: 0x0601A338 RID: 107320 RVA: 0x0026AF64 File Offset: 0x00269164
		// (set) Token: 0x0601A339 RID: 107321 RVA: 0x0026AF78 File Offset: 0x00269178
		public unsafe UMaterialInstanceDynamic MID_StampPos
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroInstanceGrassInteraction.__PropertyOffset_MID_StampPos);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroInstanceGrassInteraction.__PropertyOffset_MID_StampPos, value);
			}
		}

		// Token: 0x17006961 RID: 26977
		// (get) Token: 0x0601A33A RID: 107322 RVA: 0x0026AF8D File Offset: 0x0026918D
		// (set) Token: 0x0601A33B RID: 107323 RVA: 0x0026AFA1 File Offset: 0x002691A1
		public unsafe UMaterialInstanceDynamic MID_UpdatePos
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroInstanceGrassInteraction.__PropertyOffset_MID_UpdatePos);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroInstanceGrassInteraction.__PropertyOffset_MID_UpdatePos, value);
			}
		}

		// Token: 0x0601A33C RID: 107324 RVA: 0x0026AFB6 File Offset: 0x002691B6
		public void InstanceGrassInteractionTick(FGameplayTag MotorcycleState, FGameplayTag InAirState, float DeltaTime)
		{
			AKuroInstanceGrassInteraction.__InstanceGrassInteractionTick_Internal(base.NativePtr, MotorcycleState, InAirState, DeltaTime);
		}

		// Token: 0x0601A33D RID: 107325 RVA: 0x0026AFC6 File Offset: 0x002691C6
		public void InitData()
		{
			AKuroInstanceGrassInteraction.__InitData_Internal(base.NativePtr);
		}

		// Token: 0x0601A33E RID: 107326
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InstanceGrassInteractionTick_Internal(IntPtr @this, FGameplayTag MotorcycleState, FGameplayTag InAirState, float DeltaTime);

		// Token: 0x0601A33F RID: 107327
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitData_Internal(IntPtr @this);

		// Token: 0x0601A340 RID: 107328 RVA: 0x0026AFD3 File Offset: 0x002691D3
		static AKuroInstanceGrassInteraction()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroInstanceGrassInteraction");
		}

		// Token: 0x0601A341 RID: 107329 RVA: 0x0026AFE1 File Offset: 0x002691E1
		protected AKuroInstanceGrassInteraction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E3A9 RID: 58281
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroInstanceGrassInteraction";

		// Token: 0x0400E3AA RID: 58282
		private static IntPtr _ClassPtr;

		// Token: 0x0400E3AB RID: 58283
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E3AC RID: 58284
		internal static int __PropertyOffset_RT_PosA;

		// Token: 0x0400E3AD RID: 58285
		internal static int __PropertyOffset_RT_PosB;

		// Token: 0x0400E3AE RID: 58286
		internal static int __PropertyOffset_CollisionRadius;

		// Token: 0x0400E3AF RID: 58287
		internal static int __PropertyOffset_VolDamping;

		// Token: 0x0400E3B0 RID: 58288
		internal static int __PropertyOffset_K;

		// Token: 0x0400E3B1 RID: 58289
		internal static int __PropertyOffset_InteractionSize;

		// Token: 0x0400E3B2 RID: 58290
		internal static int __PropertyOffset_CollisionRadius_Character;

		// Token: 0x0400E3B3 RID: 58291
		internal static int __PropertyOffset_Scene_MPC;

		// Token: 0x0400E3B4 RID: 58292
		internal static int __PropertyOffset_ClearColor;

		// Token: 0x0400E3B5 RID: 58293
		internal static int __PropertyOffset_CollisionRadius_Moto;

		// Token: 0x0400E3B6 RID: 58294
		internal static int __PropertyOffset_Case;

		// Token: 0x0400E3B7 RID: 58295
		internal static int __PropertyOffset_M_StampPos;

		// Token: 0x0400E3B8 RID: 58296
		internal static int __PropertyOffset_M_UpdatePos;

		// Token: 0x0400E3B9 RID: 58297
		internal static int __PropertyOffset_MID_StampPos;

		// Token: 0x0400E3BA RID: 58298
		internal static int __PropertyOffset_MID_UpdatePos;
	}
}
