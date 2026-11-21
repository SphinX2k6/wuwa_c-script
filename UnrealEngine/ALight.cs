using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000235 RID: 565
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.Light")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public abstract class ALight : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002DC8 RID: 11720 RVA: 0x00040C42 File Offset: 0x0003EE42
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ALight._ClassPtr;
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06002DC9 RID: 11721 RVA: 0x00040C4E File Offset: 0x0003EE4E
		// (set) Token: 0x06002DCA RID: 11722 RVA: 0x00040C62 File Offset: 0x0003EE62
		public unsafe ULightComponent LightComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ALight.__PropertyOffset_LightComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALight.__PropertyOffset_LightComponent, value);
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06002DCB RID: 11723 RVA: 0x00040C77 File Offset: 0x0003EE77
		// (set) Token: 0x06002DCC RID: 11724 RVA: 0x00040C87 File Offset: 0x0003EE87
		public unsafe float KuroGroupFadeInitialIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALight.__PropertyOffset_KuroGroupFadeInitialIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALight.__PropertyOffset_KuroGroupFadeInitialIntensity) = value;
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06002DCD RID: 11725 RVA: 0x00040C98 File Offset: 0x0003EE98
		// (set) Token: 0x06002DCE RID: 11726 RVA: 0x00040CB1 File Offset: 0x0003EEB1
		public unsafe bool bEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ALight.__PropertyOffset_bEnabled) & ALight.__PropertyMask_bEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ALight.__PropertyOffset_bEnabled) = ((*(base.NativePtr + (IntPtr)ALight.__PropertyOffset_bEnabled) & ~ALight.__PropertyMask_bEnabled) | (value ? ALight.__PropertyMask_bEnabled : 0));
			}
		}

		// Token: 0x06002DCF RID: 11727 RVA: 0x00040CE1 File Offset: 0x0003EEE1
		public void ToggleEnabled()
		{
			ALight.__ToggleEnabled_Internal(base.NativePtr);
		}

		// Token: 0x06002DD0 RID: 11728 RVA: 0x00040CEE File Offset: 0x0003EEEE
		public void SetLightFunctionScale(FVector NewLightFunctionScale)
		{
			ALight.__SetLightFunctionScale_Internal(base.NativePtr, NewLightFunctionScale);
		}

		// Token: 0x06002DD1 RID: 11729 RVA: 0x00040CFC File Offset: 0x0003EEFC
		public void SetLightFunctionMaterial(UMaterialInterface NewLightFunctionMaterial)
		{
			ALight.__SetLightFunctionMaterial_Internal(base.NativePtr, (NewLightFunctionMaterial != null) ? NewLightFunctionMaterial.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06002DD2 RID: 11730 RVA: 0x00040D19 File Offset: 0x0003EF19
		public void SetLightFunctionFadeDistance(float NewLightFunctionFadeDistance)
		{
			ALight.__SetLightFunctionFadeDistance_Internal(base.NativePtr, NewLightFunctionFadeDistance);
		}

		// Token: 0x06002DD3 RID: 11731 RVA: 0x00040D27 File Offset: 0x0003EF27
		public void SetLightColor(FLinearColor NewLightColor)
		{
			ALight.__SetLightColor_Internal(base.NativePtr, NewLightColor);
		}

		// Token: 0x06002DD4 RID: 11732 RVA: 0x00040D35 File Offset: 0x0003EF35
		public void SetEnabled(bool bSetEnabled)
		{
			ALight.__SetEnabled_Internal(base.NativePtr, bSetEnabled);
		}

		// Token: 0x06002DD5 RID: 11733 RVA: 0x00040D43 File Offset: 0x0003EF43
		public void SetCastShadows(bool bNewValue)
		{
			ALight.__SetCastShadows_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x06002DD6 RID: 11734 RVA: 0x00040D51 File Offset: 0x0003EF51
		public void SetBrightness(float NewBrightness)
		{
			ALight.__SetBrightness_Internal(base.NativePtr, NewBrightness);
		}

		// Token: 0x06002DD7 RID: 11735 RVA: 0x00040D5F File Offset: 0x0003EF5F
		public void SetAffectTranslucentLighting(bool bNewValue)
		{
			ALight.__SetAffectTranslucentLighting_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x06002DD8 RID: 11736 RVA: 0x00040D6D File Offset: 0x0003EF6D
		public void OnRep_bEnabled()
		{
			ALight.__OnRep_bEnabled_Internal(base.NativePtr);
		}

		// Token: 0x06002DD9 RID: 11737 RVA: 0x00040D7A File Offset: 0x0003EF7A
		public bool IsEnabled()
		{
			return ALight.__IsEnabled_Internal(base.NativePtr);
		}

		// Token: 0x06002DDA RID: 11738 RVA: 0x00040D87 File Offset: 0x0003EF87
		public FLinearColor GetLightColor()
		{
			return ALight.__GetLightColor_Internal(base.NativePtr);
		}

		// Token: 0x06002DDB RID: 11739 RVA: 0x00040D94 File Offset: 0x0003EF94
		public float GetBrightness()
		{
			return ALight.__GetBrightness_Internal(base.NativePtr);
		}

		// Token: 0x06002DDC RID: 11740
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ToggleEnabled_Internal(IntPtr @this);

		// Token: 0x06002DDD RID: 11741
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightFunctionScale_Internal(IntPtr @this, FVector NewLightFunctionScale);

		// Token: 0x06002DDE RID: 11742
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightFunctionMaterial_Internal(IntPtr @this, IntPtr NewLightFunctionMaterial);

		// Token: 0x06002DDF RID: 11743
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightFunctionFadeDistance_Internal(IntPtr @this, float NewLightFunctionFadeDistance);

		// Token: 0x06002DE0 RID: 11744
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightColor_Internal(IntPtr @this, FLinearColor NewLightColor);

		// Token: 0x06002DE1 RID: 11745
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnabled_Internal(IntPtr @this, bool bSetEnabled);

		// Token: 0x06002DE2 RID: 11746
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCastShadows_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x06002DE3 RID: 11747
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBrightness_Internal(IntPtr @this, float NewBrightness);

		// Token: 0x06002DE4 RID: 11748
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAffectTranslucentLighting_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x06002DE5 RID: 11749
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_bEnabled_Internal(IntPtr @this);

		// Token: 0x06002DE6 RID: 11750
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsEnabled_Internal(IntPtr @this);

		// Token: 0x06002DE7 RID: 11751
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __GetLightColor_Internal(IntPtr @this);

		// Token: 0x06002DE8 RID: 11752
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetBrightness_Internal(IntPtr @this);

		// Token: 0x06002DE9 RID: 11753 RVA: 0x00040DA1 File Offset: 0x0003EFA1
		static ALight()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Light");
		}

		// Token: 0x06002DEA RID: 11754 RVA: 0x00040DB0 File Offset: 0x0003EFB0
		protected ALight() : this(BuiltinUtils.AllocNativeUObject(ALight.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002DEB RID: 11755 RVA: 0x00040DD8 File Offset: 0x0003EFD8
		protected ALight(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000EAA RID: 3754
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Light";

		// Token: 0x04000EAB RID: 3755
		private static IntPtr _ClassPtr;

		// Token: 0x04000EAC RID: 3756
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000EAD RID: 3757
		internal static int __PropertyOffset_LightComponent;

		// Token: 0x04000EAE RID: 3758
		internal static int __PropertyOffset_KuroGroupFadeInitialIntensity;

		// Token: 0x04000EAF RID: 3759
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x04000EB0 RID: 3760
		internal static byte __PropertyMask_bEnabled;
	}
}
