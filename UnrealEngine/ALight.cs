using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D43 RID: 3395
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.Light")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public abstract class ALight : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B5EC RID: 46572 RVA: 0x001038EE File Offset: 0x00101AEE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ALight._ClassPtr;
		}

		// Token: 0x17002998 RID: 10648
		// (get) Token: 0x0600B5ED RID: 46573 RVA: 0x001038FA File Offset: 0x00101AFA
		// (set) Token: 0x0600B5EE RID: 46574 RVA: 0x0010390E File Offset: 0x00101B0E
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

		// Token: 0x17002999 RID: 10649
		// (get) Token: 0x0600B5EF RID: 46575 RVA: 0x00103923 File Offset: 0x00101B23
		// (set) Token: 0x0600B5F0 RID: 46576 RVA: 0x0010393C File Offset: 0x00101B3C
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

		// Token: 0x0600B5F1 RID: 46577 RVA: 0x0010396C File Offset: 0x00101B6C
		public void ToggleEnabled()
		{
			ALight.__ToggleEnabled_Internal(base.NativePtr);
		}

		// Token: 0x0600B5F2 RID: 46578 RVA: 0x00103979 File Offset: 0x00101B79
		public void SetLightFunctionScale(FVector NewLightFunctionScale)
		{
			ALight.__SetLightFunctionScale_Internal(base.NativePtr, NewLightFunctionScale);
		}

		// Token: 0x0600B5F3 RID: 46579 RVA: 0x00103987 File Offset: 0x00101B87
		public void SetLightFunctionMaterial(UMaterialInterface NewLightFunctionMaterial)
		{
			ALight.__SetLightFunctionMaterial_Internal(base.NativePtr, (NewLightFunctionMaterial != null) ? NewLightFunctionMaterial.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600B5F4 RID: 46580 RVA: 0x001039A4 File Offset: 0x00101BA4
		public void SetLightFunctionFadeDistance(float NewLightFunctionFadeDistance)
		{
			ALight.__SetLightFunctionFadeDistance_Internal(base.NativePtr, NewLightFunctionFadeDistance);
		}

		// Token: 0x0600B5F5 RID: 46581 RVA: 0x001039B2 File Offset: 0x00101BB2
		public void SetLightColor(FLinearColor NewLightColor)
		{
			ALight.__SetLightColor_Internal(base.NativePtr, NewLightColor);
		}

		// Token: 0x0600B5F6 RID: 46582 RVA: 0x001039C0 File Offset: 0x00101BC0
		public void SetEnabled(bool bSetEnabled)
		{
			ALight.__SetEnabled_Internal(base.NativePtr, bSetEnabled);
		}

		// Token: 0x0600B5F7 RID: 46583 RVA: 0x001039CE File Offset: 0x00101BCE
		public void SetCastShadows(bool bNewValue)
		{
			ALight.__SetCastShadows_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x0600B5F8 RID: 46584 RVA: 0x001039DC File Offset: 0x00101BDC
		public void SetBrightness(float NewBrightness)
		{
			ALight.__SetBrightness_Internal(base.NativePtr, NewBrightness);
		}

		// Token: 0x0600B5F9 RID: 46585 RVA: 0x001039EA File Offset: 0x00101BEA
		public void SetAffectTranslucentLighting(bool bNewValue)
		{
			ALight.__SetAffectTranslucentLighting_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x0600B5FA RID: 46586 RVA: 0x001039F8 File Offset: 0x00101BF8
		public void OnRep_bEnabled()
		{
			ALight.__OnRep_bEnabled_Internal(base.NativePtr);
		}

		// Token: 0x0600B5FB RID: 46587 RVA: 0x00103A05 File Offset: 0x00101C05
		public bool IsEnabled()
		{
			return ALight.__IsEnabled_Internal(base.NativePtr);
		}

		// Token: 0x0600B5FC RID: 46588 RVA: 0x00103A12 File Offset: 0x00101C12
		public FLinearColor GetLightColor()
		{
			return ALight.__GetLightColor_Internal(base.NativePtr);
		}

		// Token: 0x0600B5FD RID: 46589 RVA: 0x00103A1F File Offset: 0x00101C1F
		public float GetBrightness()
		{
			return ALight.__GetBrightness_Internal(base.NativePtr);
		}

		// Token: 0x0600B5FE RID: 46590
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ToggleEnabled_Internal(IntPtr @this);

		// Token: 0x0600B5FF RID: 46591
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightFunctionScale_Internal(IntPtr @this, FVector NewLightFunctionScale);

		// Token: 0x0600B600 RID: 46592
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightFunctionMaterial_Internal(IntPtr @this, IntPtr NewLightFunctionMaterial);

		// Token: 0x0600B601 RID: 46593
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightFunctionFadeDistance_Internal(IntPtr @this, float NewLightFunctionFadeDistance);

		// Token: 0x0600B602 RID: 46594
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightColor_Internal(IntPtr @this, FLinearColor NewLightColor);

		// Token: 0x0600B603 RID: 46595
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnabled_Internal(IntPtr @this, bool bSetEnabled);

		// Token: 0x0600B604 RID: 46596
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCastShadows_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x0600B605 RID: 46597
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBrightness_Internal(IntPtr @this, float NewBrightness);

		// Token: 0x0600B606 RID: 46598
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAffectTranslucentLighting_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x0600B607 RID: 46599
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_bEnabled_Internal(IntPtr @this);

		// Token: 0x0600B608 RID: 46600
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsEnabled_Internal(IntPtr @this);

		// Token: 0x0600B609 RID: 46601
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __GetLightColor_Internal(IntPtr @this);

		// Token: 0x0600B60A RID: 46602
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetBrightness_Internal(IntPtr @this);

		// Token: 0x0600B60B RID: 46603 RVA: 0x00103A2C File Offset: 0x00101C2C
		static ALight()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Light");
		}

		// Token: 0x0600B60C RID: 46604 RVA: 0x00103A3C File Offset: 0x00101C3C
		protected ALight() : this(BuiltinUtils.AllocNativeUObject(ALight.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B60D RID: 46605 RVA: 0x00103A64 File Offset: 0x00101C64
		protected ALight(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005F9A RID: 24474
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Light";

		// Token: 0x04005F9B RID: 24475
		private static IntPtr _ClassPtr;

		// Token: 0x04005F9C RID: 24476
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005F9D RID: 24477
		internal static int __PropertyOffset_LightComponent;

		// Token: 0x04005F9E RID: 24478
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x04005F9F RID: 24479
		internal static byte __PropertyMask_bEnabled;
	}
}
