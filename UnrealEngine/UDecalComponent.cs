using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009AC RID: 2476
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.DecalComponent")]
	[UnrealStructLayout(656, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 656)]
	public class UDecalComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008BD1 RID: 35793 RVA: 0x000C846C File Offset: 0x000C666C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDecalComponent._ClassPtr;
		}

		// Token: 0x06008BD2 RID: 35794 RVA: 0x000C8478 File Offset: 0x000C6678
		public UDecalComponent() : this(BuiltinUtils.AllocNativeUObject(UDecalComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008BD3 RID: 35795 RVA: 0x000C84A0 File Offset: 0x000C66A0
		[NullableContext(1)]
		public UDecalComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDecalComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170020E5 RID: 8421
		// (get) Token: 0x06008BD4 RID: 35796 RVA: 0x000C84D3 File Offset: 0x000C66D3
		// (set) Token: 0x06008BD5 RID: 35797 RVA: 0x000C84E7 File Offset: 0x000C66E7
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

		// Token: 0x170020E6 RID: 8422
		// (get) Token: 0x06008BD6 RID: 35798 RVA: 0x000C84FC File Offset: 0x000C66FC
		// (set) Token: 0x06008BD7 RID: 35799 RVA: 0x000C850C File Offset: 0x000C670C
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

		// Token: 0x170020E7 RID: 8423
		// (get) Token: 0x06008BD8 RID: 35800 RVA: 0x000C851D File Offset: 0x000C671D
		// (set) Token: 0x06008BD9 RID: 35801 RVA: 0x000C852D File Offset: 0x000C672D
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

		// Token: 0x170020E8 RID: 8424
		// (get) Token: 0x06008BDA RID: 35802 RVA: 0x000C853E File Offset: 0x000C673E
		// (set) Token: 0x06008BDB RID: 35803 RVA: 0x000C854E File Offset: 0x000C674E
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

		// Token: 0x170020E9 RID: 8425
		// (get) Token: 0x06008BDC RID: 35804 RVA: 0x000C855F File Offset: 0x000C675F
		// (set) Token: 0x06008BDD RID: 35805 RVA: 0x000C856F File Offset: 0x000C676F
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

		// Token: 0x170020EA RID: 8426
		// (get) Token: 0x06008BDE RID: 35806 RVA: 0x000C8580 File Offset: 0x000C6780
		// (set) Token: 0x06008BDF RID: 35807 RVA: 0x000C8590 File Offset: 0x000C6790
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

		// Token: 0x170020EB RID: 8427
		// (get) Token: 0x06008BE0 RID: 35808 RVA: 0x000C85A1 File Offset: 0x000C67A1
		// (set) Token: 0x06008BE1 RID: 35809 RVA: 0x000C85B1 File Offset: 0x000C67B1
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

		// Token: 0x170020EC RID: 8428
		// (get) Token: 0x06008BE2 RID: 35810 RVA: 0x000C85C2 File Offset: 0x000C67C2
		// (set) Token: 0x06008BE3 RID: 35811 RVA: 0x000C85D2 File Offset: 0x000C67D2
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

		// Token: 0x170020ED RID: 8429
		// (get) Token: 0x06008BE4 RID: 35812 RVA: 0x000C85E3 File Offset: 0x000C67E3
		// (set) Token: 0x06008BE5 RID: 35813 RVA: 0x000C85F3 File Offset: 0x000C67F3
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

		// Token: 0x170020EE RID: 8430
		// (get) Token: 0x06008BE6 RID: 35814 RVA: 0x000C8604 File Offset: 0x000C6804
		// (set) Token: 0x06008BE7 RID: 35815 RVA: 0x000C8614 File Offset: 0x000C6814
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

		// Token: 0x170020EF RID: 8431
		// (get) Token: 0x06008BE8 RID: 35816 RVA: 0x000C8625 File Offset: 0x000C6825
		// (set) Token: 0x06008BE9 RID: 35817 RVA: 0x000C8635 File Offset: 0x000C6835
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

		// Token: 0x170020F0 RID: 8432
		// (get) Token: 0x06008BEA RID: 35818 RVA: 0x000C8646 File Offset: 0x000C6846
		// (set) Token: 0x06008BEB RID: 35819 RVA: 0x000C8656 File Offset: 0x000C6856
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

		// Token: 0x170020F1 RID: 8433
		// (get) Token: 0x06008BEC RID: 35820 RVA: 0x000C8667 File Offset: 0x000C6867
		// (set) Token: 0x06008BED RID: 35821 RVA: 0x000C8677 File Offset: 0x000C6877
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

		// Token: 0x170020F2 RID: 8434
		// (get) Token: 0x06008BEE RID: 35822 RVA: 0x000C8688 File Offset: 0x000C6888
		// (set) Token: 0x06008BEF RID: 35823 RVA: 0x000C8698 File Offset: 0x000C6898
		public unsafe EDecalOutputTarget DecalOutputTarget
		{
			get
			{
				return (EDecalOutputTarget)(*(base.NativePtr + (IntPtr)UDecalComponent.__PropertyOffset_DecalOutputTarget));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDecalComponent.__PropertyOffset_DecalOutputTarget) = (byte)value;
			}
		}

		// Token: 0x170020F3 RID: 8435
		// (get) Token: 0x06008BF0 RID: 35824 RVA: 0x000C86A9 File Offset: 0x000C68A9
		// (set) Token: 0x06008BF1 RID: 35825 RVA: 0x000C86B9 File Offset: 0x000C68B9
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

		// Token: 0x170020F4 RID: 8436
		// (get) Token: 0x06008BF2 RID: 35826 RVA: 0x000C86CA File Offset: 0x000C68CA
		// (set) Token: 0x06008BF3 RID: 35827 RVA: 0x000C86DA File Offset: 0x000C68DA
		public unsafe EToonShadowType ToonShadowMode
		{
			get
			{
				return (EToonShadowType)(*(base.NativePtr + (IntPtr)UDecalComponent.__PropertyOffset_ToonShadowMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDecalComponent.__PropertyOffset_ToonShadowMode) = (byte)value;
			}
		}

		// Token: 0x170020F5 RID: 8437
		// (get) Token: 0x06008BF4 RID: 35828 RVA: 0x000C86EB File Offset: 0x000C68EB
		// (set) Token: 0x06008BF5 RID: 35829 RVA: 0x000C86FB File Offset: 0x000C68FB
		public unsafe EPostSceneColorDecalInsertLocation PostSceneColorInsertLocation
		{
			get
			{
				return (EPostSceneColorDecalInsertLocation)(*(base.NativePtr + (IntPtr)UDecalComponent.__PropertyOffset_PostSceneColorInsertLocation));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDecalComponent.__PropertyOffset_PostSceneColorInsertLocation) = (byte)value;
			}
		}

		// Token: 0x170020F6 RID: 8438
		// (get) Token: 0x06008BF6 RID: 35830 RVA: 0x000C870C File Offset: 0x000C690C
		// (set) Token: 0x06008BF7 RID: 35831 RVA: 0x000C8725 File Offset: 0x000C6925
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

		// Token: 0x170020F7 RID: 8439
		// (get) Token: 0x06008BF8 RID: 35832 RVA: 0x000C8755 File Offset: 0x000C6955
		// (set) Token: 0x06008BF9 RID: 35833 RVA: 0x000C8769 File Offset: 0x000C6969
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

		// Token: 0x06008BFA RID: 35834 RVA: 0x000C877E File Offset: 0x000C697E
		public void SetSortOrder(int Value)
		{
			UDecalComponent.__SetSortOrder_Internal(base.NativePtr, Value);
		}

		// Token: 0x06008BFB RID: 35835 RVA: 0x000C878C File Offset: 0x000C698C
		public void SetIsUIScenePrimitive(bool bValue)
		{
			UDecalComponent.__SetIsUIScenePrimitive_Internal(base.NativePtr, bValue);
		}

		// Token: 0x06008BFC RID: 35836 RVA: 0x000C879A File Offset: 0x000C699A
		public void SetForceRenderScene(bool bForceRender = false)
		{
			UDecalComponent.__SetForceRenderScene_Internal(base.NativePtr, bForceRender);
		}

		// Token: 0x06008BFD RID: 35837 RVA: 0x000C87A8 File Offset: 0x000C69A8
		public void SetForceRenderCharactor(bool bForceRender = false)
		{
			UDecalComponent.__SetForceRenderCharactor_Internal(base.NativePtr, bForceRender);
		}

		// Token: 0x06008BFE RID: 35838 RVA: 0x000C87B6 File Offset: 0x000C69B6
		public void SetFadeScreenSize(float NewFadeScreenSize)
		{
			UDecalComponent.__SetFadeScreenSize_Internal(base.NativePtr, NewFadeScreenSize);
		}

		// Token: 0x06008BFF RID: 35839 RVA: 0x000C87C4 File Offset: 0x000C69C4
		public void SetFadeOut(float StartDelay, float Duration, bool DestroyOwnerAfterFade = true)
		{
			UDecalComponent.__SetFadeOut_Internal(base.NativePtr, StartDelay, Duration, DestroyOwnerAfterFade);
		}

		// Token: 0x06008C00 RID: 35840 RVA: 0x000C87D4 File Offset: 0x000C69D4
		public void SetFadeIn(float StartDelay, float Duaration)
		{
			UDecalComponent.__SetFadeIn_Internal(base.NativePtr, StartDelay, Duaration);
		}

		// Token: 0x06008C01 RID: 35841 RVA: 0x000C87E3 File Offset: 0x000C69E3
		public void SetDecalMaterial(UMaterialInterface NewDecalMaterial)
		{
			UDecalComponent.__SetDecalMaterial_Internal(base.NativePtr, (NewDecalMaterial != null) ? NewDecalMaterial.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06008C02 RID: 35842 RVA: 0x000C8800 File Offset: 0x000C6A00
		public EToonShadowType GetToonShadowMode()
		{
			return UDecalComponent.__GetToonShadowMode_Internal(base.NativePtr);
		}

		// Token: 0x06008C03 RID: 35843 RVA: 0x000C880D File Offset: 0x000C6A0D
		public float GetFadeStartDelay()
		{
			return UDecalComponent.__GetFadeStartDelay_Internal(base.NativePtr);
		}

		// Token: 0x06008C04 RID: 35844 RVA: 0x000C881A File Offset: 0x000C6A1A
		public float GetFadeInStartDelay()
		{
			return UDecalComponent.__GetFadeInStartDelay_Internal(base.NativePtr);
		}

		// Token: 0x06008C05 RID: 35845 RVA: 0x000C8827 File Offset: 0x000C6A27
		public float GetFadeInDuration()
		{
			return UDecalComponent.__GetFadeInDuration_Internal(base.NativePtr);
		}

		// Token: 0x06008C06 RID: 35846 RVA: 0x000C8834 File Offset: 0x000C6A34
		public float GetFadeDuration()
		{
			return UDecalComponent.__GetFadeDuration_Internal(base.NativePtr);
		}

		// Token: 0x06008C07 RID: 35847 RVA: 0x000C8841 File Offset: 0x000C6A41
		public UMaterialInterface GetDecalMaterial()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInterface>(UDecalComponent.__GetDecalMaterial_Internal(base.NativePtr));
		}

		// Token: 0x06008C08 RID: 35848 RVA: 0x000C8853 File Offset: 0x000C6A53
		public UMaterialInstanceDynamic CreateDynamicMaterialInstance()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(UDecalComponent.__CreateDynamicMaterialInstance_Internal(base.NativePtr));
		}

		// Token: 0x06008C09 RID: 35849
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSortOrder_Internal(IntPtr @this, int Value);

		// Token: 0x06008C0A RID: 35850
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsUIScenePrimitive_Internal(IntPtr @this, bool bValue);

		// Token: 0x06008C0B RID: 35851
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetForceRenderScene_Internal(IntPtr @this, bool bForceRender);

		// Token: 0x06008C0C RID: 35852
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetForceRenderCharactor_Internal(IntPtr @this, bool bForceRender);

		// Token: 0x06008C0D RID: 35853
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFadeScreenSize_Internal(IntPtr @this, float NewFadeScreenSize);

		// Token: 0x06008C0E RID: 35854
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFadeOut_Internal(IntPtr @this, float StartDelay, float Duration, bool DestroyOwnerAfterFade);

		// Token: 0x06008C0F RID: 35855
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFadeIn_Internal(IntPtr @this, float StartDelay, float Duaration);

		// Token: 0x06008C10 RID: 35856
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDecalMaterial_Internal(IntPtr @this, IntPtr NewDecalMaterial);

		// Token: 0x06008C11 RID: 35857
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EToonShadowType __GetToonShadowMode_Internal(IntPtr @this);

		// Token: 0x06008C12 RID: 35858
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFadeStartDelay_Internal(IntPtr @this);

		// Token: 0x06008C13 RID: 35859
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFadeInStartDelay_Internal(IntPtr @this);

		// Token: 0x06008C14 RID: 35860
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFadeInDuration_Internal(IntPtr @this);

		// Token: 0x06008C15 RID: 35861
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFadeDuration_Internal(IntPtr @this);

		// Token: 0x06008C16 RID: 35862
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDecalMaterial_Internal(IntPtr @this);

		// Token: 0x06008C17 RID: 35863
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateDynamicMaterialInstance_Internal(IntPtr @this);

		// Token: 0x06008C18 RID: 35864 RVA: 0x000C8865 File Offset: 0x000C6A65
		static UDecalComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DecalComponent");
		}

		// Token: 0x06008C19 RID: 35865 RVA: 0x000C8873 File Offset: 0x000C6A73
		protected UDecalComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004269 RID: 17001
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DecalComponent";

		// Token: 0x0400426A RID: 17002
		private static IntPtr _ClassPtr;

		// Token: 0x0400426B RID: 17003
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400426C RID: 17004
		internal static int __PropertyOffset_DecalMaterial;

		// Token: 0x0400426D RID: 17005
		internal static int __PropertyOffset_SortOrder;

		// Token: 0x0400426E RID: 17006
		internal static int __PropertyOffset_FadeScreenSize;

		// Token: 0x0400426F RID: 17007
		internal static int __PropertyOffset_FadeStartDelay;

		// Token: 0x04004270 RID: 17008
		internal static int __PropertyOffset_FadeDuration;

		// Token: 0x04004271 RID: 17009
		internal static int __PropertyOffset_FadeInDuration;

		// Token: 0x04004272 RID: 17010
		internal static int __PropertyOffset_FadeInStartDelay;

		// Token: 0x04004273 RID: 17011
		internal static int __PropertyOffset_IsUIScenePrimitive;

		// Token: 0x04004274 RID: 17012
		internal static int __PropertyOffset_ZFadingFactor;

		// Token: 0x04004275 RID: 17013
		internal static int __PropertyOffset_ZFadingPower;

		// Token: 0x04004276 RID: 17014
		internal static int __PropertyOffset_ForceRenderScene;

		// Token: 0x04004277 RID: 17015
		internal static int __PropertyOffset_ForceRenderCharactor;

		// Token: 0x04004278 RID: 17016
		internal static int __PropertyOffset_bLocalPostProcessMode;

		// Token: 0x04004279 RID: 17017
		internal static int __PropertyOffset_DecalOutputTarget;

		// Token: 0x0400427A RID: 17018
		internal static int __PropertyOffset_ForceDisablePreStencil;

		// Token: 0x0400427B RID: 17019
		internal static int __PropertyOffset_ToonShadowMode;

		// Token: 0x0400427C RID: 17020
		internal static int __PropertyOffset_PostSceneColorInsertLocation;

		// Token: 0x0400427D RID: 17021
		internal static int __PropertyOffset_bDestroyOwnerAfterFade;

		// Token: 0x0400427E RID: 17022
		internal static byte __PropertyMask_bDestroyOwnerAfterFade;

		// Token: 0x0400427F RID: 17023
		internal static int __PropertyOffset_DecalSize;
	}
}
