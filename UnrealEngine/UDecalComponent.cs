using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001C7 RID: 455
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.DecalComponent")]
	[UnrealStructLayout(656, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 656)]
	public class UDecalComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600212B RID: 8491 RVA: 0x00030C0C File Offset: 0x0002EE0C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDecalComponent._ClassPtr;
		}

		// Token: 0x0600212C RID: 8492 RVA: 0x00030C18 File Offset: 0x0002EE18
		public UDecalComponent() : this(BuiltinUtils.AllocNativeUObject(UDecalComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600212D RID: 8493 RVA: 0x00030C40 File Offset: 0x0002EE40
		[NullableContext(1)]
		public UDecalComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDecalComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x0600212E RID: 8494 RVA: 0x00030C73 File Offset: 0x0002EE73
		// (set) Token: 0x0600212F RID: 8495 RVA: 0x00030C87 File Offset: 0x0002EE87
		public unsafe UMaterialInterface DecalMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UDecalComponent.__PropertyOffset_DecalMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UDecalComponent.__PropertyOffset_DecalMaterial, value);
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06002130 RID: 8496 RVA: 0x00030C9C File Offset: 0x0002EE9C
		// (set) Token: 0x06002131 RID: 8497 RVA: 0x00030CAC File Offset: 0x0002EEAC
		public unsafe int SortOrder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDecalComponent.__PropertyOffset_SortOrder);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDecalComponent.__PropertyOffset_SortOrder) = value;
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06002132 RID: 8498 RVA: 0x00030CBD File Offset: 0x0002EEBD
		// (set) Token: 0x06002133 RID: 8499 RVA: 0x00030CCD File Offset: 0x0002EECD
		public unsafe float FadeScreenSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDecalComponent.__PropertyOffset_FadeScreenSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDecalComponent.__PropertyOffset_FadeScreenSize) = value;
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06002134 RID: 8500 RVA: 0x00030CDE File Offset: 0x0002EEDE
		// (set) Token: 0x06002135 RID: 8501 RVA: 0x00030CEE File Offset: 0x0002EEEE
		public unsafe float FadeStartDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDecalComponent.__PropertyOffset_FadeStartDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDecalComponent.__PropertyOffset_FadeStartDelay) = value;
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06002136 RID: 8502 RVA: 0x00030CFF File Offset: 0x0002EEFF
		// (set) Token: 0x06002137 RID: 8503 RVA: 0x00030D0F File Offset: 0x0002EF0F
		public unsafe float FadeDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDecalComponent.__PropertyOffset_FadeDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDecalComponent.__PropertyOffset_FadeDuration) = value;
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06002138 RID: 8504 RVA: 0x00030D20 File Offset: 0x0002EF20
		// (set) Token: 0x06002139 RID: 8505 RVA: 0x00030D30 File Offset: 0x0002EF30
		public unsafe float FadeInDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDecalComponent.__PropertyOffset_FadeInDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDecalComponent.__PropertyOffset_FadeInDuration) = value;
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x0600213A RID: 8506 RVA: 0x00030D41 File Offset: 0x0002EF41
		// (set) Token: 0x0600213B RID: 8507 RVA: 0x00030D51 File Offset: 0x0002EF51
		public unsafe float FadeInStartDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDecalComponent.__PropertyOffset_FadeInStartDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDecalComponent.__PropertyOffset_FadeInStartDelay) = value;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x0600213C RID: 8508 RVA: 0x00030D62 File Offset: 0x0002EF62
		// (set) Token: 0x0600213D RID: 8509 RVA: 0x00030D72 File Offset: 0x0002EF72
		public unsafe bool IsUIScenePrimitive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDecalComponent.__PropertyOffset_IsUIScenePrimitive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDecalComponent.__PropertyOffset_IsUIScenePrimitive) = (value ? 1 : 0);
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x0600213E RID: 8510 RVA: 0x00030D83 File Offset: 0x0002EF83
		// (set) Token: 0x0600213F RID: 8511 RVA: 0x00030D93 File Offset: 0x0002EF93
		public unsafe float ZFadingFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDecalComponent.__PropertyOffset_ZFadingFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDecalComponent.__PropertyOffset_ZFadingFactor) = value;
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06002140 RID: 8512 RVA: 0x00030DA4 File Offset: 0x0002EFA4
		// (set) Token: 0x06002141 RID: 8513 RVA: 0x00030DB4 File Offset: 0x0002EFB4
		public unsafe float ZFadingPower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDecalComponent.__PropertyOffset_ZFadingPower);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDecalComponent.__PropertyOffset_ZFadingPower) = value;
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06002142 RID: 8514 RVA: 0x00030DC5 File Offset: 0x0002EFC5
		// (set) Token: 0x06002143 RID: 8515 RVA: 0x00030DD5 File Offset: 0x0002EFD5
		public unsafe bool ForceRenderScene
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDecalComponent.__PropertyOffset_ForceRenderScene) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDecalComponent.__PropertyOffset_ForceRenderScene) = (value ? 1 : 0);
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06002144 RID: 8516 RVA: 0x00030DE6 File Offset: 0x0002EFE6
		// (set) Token: 0x06002145 RID: 8517 RVA: 0x00030DF6 File Offset: 0x0002EFF6
		public unsafe bool ForceRenderCharactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDecalComponent.__PropertyOffset_ForceRenderCharactor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDecalComponent.__PropertyOffset_ForceRenderCharactor) = (value ? 1 : 0);
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06002146 RID: 8518 RVA: 0x00030E07 File Offset: 0x0002F007
		// (set) Token: 0x06002147 RID: 8519 RVA: 0x00030E17 File Offset: 0x0002F017
		public unsafe bool bLocalPostProcessMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDecalComponent.__PropertyOffset_bLocalPostProcessMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDecalComponent.__PropertyOffset_bLocalPostProcessMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06002148 RID: 8520 RVA: 0x00030E28 File Offset: 0x0002F028
		// (set) Token: 0x06002149 RID: 8521 RVA: 0x00030E38 File Offset: 0x0002F038
		public unsafe bool ForceDisablePreStencil
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDecalComponent.__PropertyOffset_ForceDisablePreStencil) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDecalComponent.__PropertyOffset_ForceDisablePreStencil) = (value ? 1 : 0);
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x0600214A RID: 8522 RVA: 0x00030E49 File Offset: 0x0002F049
		// (set) Token: 0x0600214B RID: 8523 RVA: 0x00030E62 File Offset: 0x0002F062
		public unsafe bool bDestroyOwnerAfterFade
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UDecalComponent.__PropertyOffset_bDestroyOwnerAfterFade) & UDecalComponent.__PropertyMask_bDestroyOwnerAfterFade) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UDecalComponent.__PropertyOffset_bDestroyOwnerAfterFade) = ((*(base.NativePtr + (IntPtr)UDecalComponent.__PropertyOffset_bDestroyOwnerAfterFade) & ~UDecalComponent.__PropertyMask_bDestroyOwnerAfterFade) | (value ? UDecalComponent.__PropertyMask_bDestroyOwnerAfterFade : 0));
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x0600214C RID: 8524 RVA: 0x00030E92 File Offset: 0x0002F092
		// (set) Token: 0x0600214D RID: 8525 RVA: 0x00030EA6 File Offset: 0x0002F0A6
		public unsafe FVector DecalSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDecalComponent.__PropertyOffset_DecalSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDecalComponent.__PropertyOffset_DecalSize) = value;
			}
		}

		// Token: 0x0600214E RID: 8526 RVA: 0x00030EBB File Offset: 0x0002F0BB
		public void SetSortOrder(int Value)
		{
			UDecalComponent.__SetSortOrder_Internal(base.NativePtr, Value);
		}

		// Token: 0x0600214F RID: 8527 RVA: 0x00030EC9 File Offset: 0x0002F0C9
		public void SetIsUIScenePrimitive(bool bValue)
		{
			UDecalComponent.__SetIsUIScenePrimitive_Internal(base.NativePtr, bValue);
		}

		// Token: 0x06002150 RID: 8528 RVA: 0x00030ED7 File Offset: 0x0002F0D7
		public void SetForceRenderScene(bool bForceRender = false)
		{
			UDecalComponent.__SetForceRenderScene_Internal(base.NativePtr, bForceRender);
		}

		// Token: 0x06002151 RID: 8529 RVA: 0x00030EE5 File Offset: 0x0002F0E5
		public void SetForceRenderCharactor(bool bForceRender = false)
		{
			UDecalComponent.__SetForceRenderCharactor_Internal(base.NativePtr, bForceRender);
		}

		// Token: 0x06002152 RID: 8530 RVA: 0x00030EF3 File Offset: 0x0002F0F3
		public void SetFadeScreenSize(float NewFadeScreenSize)
		{
			UDecalComponent.__SetFadeScreenSize_Internal(base.NativePtr, NewFadeScreenSize);
		}

		// Token: 0x06002153 RID: 8531 RVA: 0x00030F01 File Offset: 0x0002F101
		public void SetFadeOut(float StartDelay, float Duration, bool DestroyOwnerAfterFade = true)
		{
			UDecalComponent.__SetFadeOut_Internal(base.NativePtr, StartDelay, Duration, DestroyOwnerAfterFade);
		}

		// Token: 0x06002154 RID: 8532 RVA: 0x00030F11 File Offset: 0x0002F111
		public void SetFadeIn(float StartDelay, float Duaration)
		{
			UDecalComponent.__SetFadeIn_Internal(base.NativePtr, StartDelay, Duaration);
		}

		// Token: 0x06002155 RID: 8533 RVA: 0x00030F20 File Offset: 0x0002F120
		public void SetDecalMaterial(UMaterialInterface NewDecalMaterial)
		{
			UDecalComponent.__SetDecalMaterial_Internal(base.NativePtr, (NewDecalMaterial != null) ? NewDecalMaterial.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06002156 RID: 8534 RVA: 0x00030F3D File Offset: 0x0002F13D
		public float GetFadeStartDelay()
		{
			return UDecalComponent.__GetFadeStartDelay_Internal(base.NativePtr);
		}

		// Token: 0x06002157 RID: 8535 RVA: 0x00030F4A File Offset: 0x0002F14A
		public float GetFadeInStartDelay()
		{
			return UDecalComponent.__GetFadeInStartDelay_Internal(base.NativePtr);
		}

		// Token: 0x06002158 RID: 8536 RVA: 0x00030F57 File Offset: 0x0002F157
		public float GetFadeInDuration()
		{
			return UDecalComponent.__GetFadeInDuration_Internal(base.NativePtr);
		}

		// Token: 0x06002159 RID: 8537 RVA: 0x00030F64 File Offset: 0x0002F164
		public float GetFadeDuration()
		{
			return UDecalComponent.__GetFadeDuration_Internal(base.NativePtr);
		}

		// Token: 0x0600215A RID: 8538 RVA: 0x00030F71 File Offset: 0x0002F171
		public UMaterialInterface GetDecalMaterial()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInterface>(UDecalComponent.__GetDecalMaterial_Internal(base.NativePtr));
		}

		// Token: 0x0600215B RID: 8539 RVA: 0x00030F83 File Offset: 0x0002F183
		public UMaterialInstanceDynamic CreateDynamicMaterialInstance()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(UDecalComponent.__CreateDynamicMaterialInstance_Internal(base.NativePtr));
		}

		// Token: 0x0600215C RID: 8540
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSortOrder_Internal(IntPtr @this, int Value);

		// Token: 0x0600215D RID: 8541
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsUIScenePrimitive_Internal(IntPtr @this, bool bValue);

		// Token: 0x0600215E RID: 8542
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetForceRenderScene_Internal(IntPtr @this, bool bForceRender);

		// Token: 0x0600215F RID: 8543
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetForceRenderCharactor_Internal(IntPtr @this, bool bForceRender);

		// Token: 0x06002160 RID: 8544
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFadeScreenSize_Internal(IntPtr @this, float NewFadeScreenSize);

		// Token: 0x06002161 RID: 8545
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFadeOut_Internal(IntPtr @this, float StartDelay, float Duration, bool DestroyOwnerAfterFade);

		// Token: 0x06002162 RID: 8546
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFadeIn_Internal(IntPtr @this, float StartDelay, float Duaration);

		// Token: 0x06002163 RID: 8547
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDecalMaterial_Internal(IntPtr @this, IntPtr NewDecalMaterial);

		// Token: 0x06002164 RID: 8548
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFadeStartDelay_Internal(IntPtr @this);

		// Token: 0x06002165 RID: 8549
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFadeInStartDelay_Internal(IntPtr @this);

		// Token: 0x06002166 RID: 8550
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFadeInDuration_Internal(IntPtr @this);

		// Token: 0x06002167 RID: 8551
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFadeDuration_Internal(IntPtr @this);

		// Token: 0x06002168 RID: 8552
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDecalMaterial_Internal(IntPtr @this);

		// Token: 0x06002169 RID: 8553
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateDynamicMaterialInstance_Internal(IntPtr @this);

		// Token: 0x0600216A RID: 8554 RVA: 0x00030F95 File Offset: 0x0002F195
		static UDecalComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DecalComponent");
		}

		// Token: 0x0600216B RID: 8555 RVA: 0x00030FA3 File Offset: 0x0002F1A3
		protected UDecalComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000B11 RID: 2833
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DecalComponent";

		// Token: 0x04000B12 RID: 2834
		private static IntPtr _ClassPtr;

		// Token: 0x04000B13 RID: 2835
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000B14 RID: 2836
		internal static int __PropertyOffset_DecalMaterial;

		// Token: 0x04000B15 RID: 2837
		internal static int __PropertyOffset_SortOrder;

		// Token: 0x04000B16 RID: 2838
		internal static int __PropertyOffset_FadeScreenSize;

		// Token: 0x04000B17 RID: 2839
		internal static int __PropertyOffset_FadeStartDelay;

		// Token: 0x04000B18 RID: 2840
		internal static int __PropertyOffset_FadeDuration;

		// Token: 0x04000B19 RID: 2841
		internal static int __PropertyOffset_FadeInDuration;

		// Token: 0x04000B1A RID: 2842
		internal static int __PropertyOffset_FadeInStartDelay;

		// Token: 0x04000B1B RID: 2843
		internal static int __PropertyOffset_IsUIScenePrimitive;

		// Token: 0x04000B1C RID: 2844
		internal static int __PropertyOffset_ZFadingFactor;

		// Token: 0x04000B1D RID: 2845
		internal static int __PropertyOffset_ZFadingPower;

		// Token: 0x04000B1E RID: 2846
		internal static int __PropertyOffset_ForceRenderScene;

		// Token: 0x04000B1F RID: 2847
		internal static int __PropertyOffset_ForceRenderCharactor;

		// Token: 0x04000B20 RID: 2848
		internal static int __PropertyOffset_bLocalPostProcessMode;

		// Token: 0x04000B21 RID: 2849
		internal static int __PropertyOffset_ForceDisablePreStencil;

		// Token: 0x04000B22 RID: 2850
		internal static int __PropertyOffset_bDestroyOwnerAfterFade;

		// Token: 0x04000B23 RID: 2851
		internal static byte __PropertyMask_bDestroyOwnerAfterFade;

		// Token: 0x04000B24 RID: 2852
		internal static int __PropertyOffset_DecalSize;
	}
}
