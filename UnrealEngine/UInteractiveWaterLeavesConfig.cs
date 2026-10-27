using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AA3 RID: 6819
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.InteractiveWaterLeavesConfig")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UInteractiveWaterLeavesConfig : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060193E9 RID: 103401 RVA: 0x002556CD File Offset: 0x002538CD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInteractiveWaterLeavesConfig._ClassPtr;
		}

		// Token: 0x060193EA RID: 103402 RVA: 0x002556DC File Offset: 0x002538DC
		public UInteractiveWaterLeavesConfig() : this(BuiltinUtils.AllocNativeUObject(UInteractiveWaterLeavesConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060193EB RID: 103403 RVA: 0x00255704 File Offset: 0x00253904
		[NullableContext(1)]
		public UInteractiveWaterLeavesConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInteractiveWaterLeavesConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170064A5 RID: 25765
		// (get) Token: 0x060193EC RID: 103404 RVA: 0x00255737 File Offset: 0x00253937
		// (set) Token: 0x060193ED RID: 103405 RVA: 0x0025574B File Offset: 0x0025394B
		public unsafe UKuroPointCloudCache PointCache
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPointCloudCache>(base.NativePtr / (IntPtr)sizeof(void*) + UInteractiveWaterLeavesConfig.__PropertyOffset_PointCache);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UInteractiveWaterLeavesConfig.__PropertyOffset_PointCache, value);
			}
		}

		// Token: 0x170064A6 RID: 25766
		// (get) Token: 0x060193EE RID: 103406 RVA: 0x00255760 File Offset: 0x00253960
		// (set) Token: 0x060193EF RID: 103407 RVA: 0x00255774 File Offset: 0x00253974
		public unsafe UMaterialInterface LeaveMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UInteractiveWaterLeavesConfig.__PropertyOffset_LeaveMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UInteractiveWaterLeavesConfig.__PropertyOffset_LeaveMaterial, value);
			}
		}

		// Token: 0x170064A7 RID: 25767
		// (get) Token: 0x060193F0 RID: 103408 RVA: 0x00255789 File Offset: 0x00253989
		// (set) Token: 0x060193F1 RID: 103409 RVA: 0x0025579D File Offset: 0x0025399D
		public unsafe UNiagaraSystem LeavesNS
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + UInteractiveWaterLeavesConfig.__PropertyOffset_LeavesNS);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UInteractiveWaterLeavesConfig.__PropertyOffset_LeavesNS, value);
			}
		}

		// Token: 0x170064A8 RID: 25768
		// (get) Token: 0x060193F2 RID: 103410 RVA: 0x002557B2 File Offset: 0x002539B2
		// (set) Token: 0x060193F3 RID: 103411 RVA: 0x002557C2 File Offset: 0x002539C2
		public unsafe float LeaveScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInteractiveWaterLeavesConfig.__PropertyOffset_LeaveScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInteractiveWaterLeavesConfig.__PropertyOffset_LeaveScale) = value;
			}
		}

		// Token: 0x170064A9 RID: 25769
		// (get) Token: 0x060193F4 RID: 103412 RVA: 0x002557D3 File Offset: 0x002539D3
		// (set) Token: 0x060193F5 RID: 103413 RVA: 0x002557E3 File Offset: 0x002539E3
		public unsafe float WaveForce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInteractiveWaterLeavesConfig.__PropertyOffset_WaveForce);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInteractiveWaterLeavesConfig.__PropertyOffset_WaveForce) = value;
			}
		}

		// Token: 0x170064AA RID: 25770
		// (get) Token: 0x060193F6 RID: 103414 RVA: 0x002557F4 File Offset: 0x002539F4
		// (set) Token: 0x060193F7 RID: 103415 RVA: 0x00255804 File Offset: 0x00253A04
		public unsafe float RoleForce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInteractiveWaterLeavesConfig.__PropertyOffset_RoleForce);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInteractiveWaterLeavesConfig.__PropertyOffset_RoleForce) = value;
			}
		}

		// Token: 0x170064AB RID: 25771
		// (get) Token: 0x060193F8 RID: 103416 RVA: 0x00255815 File Offset: 0x00253A15
		// (set) Token: 0x060193F9 RID: 103417 RVA: 0x00255825 File Offset: 0x00253A25
		public unsafe float DragForce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInteractiveWaterLeavesConfig.__PropertyOffset_DragForce);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInteractiveWaterLeavesConfig.__PropertyOffset_DragForce) = value;
			}
		}

		// Token: 0x170064AC RID: 25772
		// (get) Token: 0x060193FA RID: 103418 RVA: 0x00255836 File Offset: 0x00253A36
		// (set) Token: 0x060193FB RID: 103419 RVA: 0x00255846 File Offset: 0x00253A46
		public unsafe float RoleRadiusMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInteractiveWaterLeavesConfig.__PropertyOffset_RoleRadiusMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInteractiveWaterLeavesConfig.__PropertyOffset_RoleRadiusMin) = value;
			}
		}

		// Token: 0x170064AD RID: 25773
		// (get) Token: 0x060193FC RID: 103420 RVA: 0x00255857 File Offset: 0x00253A57
		// (set) Token: 0x060193FD RID: 103421 RVA: 0x00255867 File Offset: 0x00253A67
		public unsafe float RoleRadiusMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInteractiveWaterLeavesConfig.__PropertyOffset_RoleRadiusMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInteractiveWaterLeavesConfig.__PropertyOffset_RoleRadiusMax) = value;
			}
		}

		// Token: 0x170064AE RID: 25774
		// (get) Token: 0x060193FE RID: 103422 RVA: 0x00255878 File Offset: 0x00253A78
		// (set) Token: 0x060193FF RID: 103423 RVA: 0x00255888 File Offset: 0x00253A88
		public unsafe float RefreshRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInteractiveWaterLeavesConfig.__PropertyOffset_RefreshRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInteractiveWaterLeavesConfig.__PropertyOffset_RefreshRadius) = value;
			}
		}

		// Token: 0x170064AF RID: 25775
		// (get) Token: 0x06019400 RID: 103424 RVA: 0x00255899 File Offset: 0x00253A99
		// (set) Token: 0x06019401 RID: 103425 RVA: 0x002558A9 File Offset: 0x00253AA9
		public unsafe float SankTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInteractiveWaterLeavesConfig.__PropertyOffset_SankTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInteractiveWaterLeavesConfig.__PropertyOffset_SankTime) = value;
			}
		}

		// Token: 0x170064B0 RID: 25776
		// (get) Token: 0x06019402 RID: 103426 RVA: 0x002558BA File Offset: 0x00253ABA
		// (set) Token: 0x06019403 RID: 103427 RVA: 0x002558CA File Offset: 0x00253ACA
		public unsafe float RefreshTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInteractiveWaterLeavesConfig.__PropertyOffset_RefreshTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInteractiveWaterLeavesConfig.__PropertyOffset_RefreshTime) = value;
			}
		}

		// Token: 0x06019404 RID: 103428 RVA: 0x002558DB File Offset: 0x00253ADB
		static UInteractiveWaterLeavesConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.InteractiveWaterLeavesConfig");
		}

		// Token: 0x06019405 RID: 103429 RVA: 0x002558E9 File Offset: 0x00253AE9
		protected UInteractiveWaterLeavesConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DC55 RID: 56405
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.InteractiveWaterLeavesConfig";

		// Token: 0x0400DC56 RID: 56406
		private static IntPtr _ClassPtr;

		// Token: 0x0400DC57 RID: 56407
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400DC58 RID: 56408
		internal static int __PropertyOffset_PointCache;

		// Token: 0x0400DC59 RID: 56409
		internal static int __PropertyOffset_LeaveMaterial;

		// Token: 0x0400DC5A RID: 56410
		internal static int __PropertyOffset_LeavesNS;

		// Token: 0x0400DC5B RID: 56411
		internal static int __PropertyOffset_LeaveScale;

		// Token: 0x0400DC5C RID: 56412
		internal static int __PropertyOffset_WaveForce;

		// Token: 0x0400DC5D RID: 56413
		internal static int __PropertyOffset_RoleForce;

		// Token: 0x0400DC5E RID: 56414
		internal static int __PropertyOffset_DragForce;

		// Token: 0x0400DC5F RID: 56415
		internal static int __PropertyOffset_RoleRadiusMin;

		// Token: 0x0400DC60 RID: 56416
		internal static int __PropertyOffset_RoleRadiusMax;

		// Token: 0x0400DC61 RID: 56417
		internal static int __PropertyOffset_RefreshRadius;

		// Token: 0x0400DC62 RID: 56418
		internal static int __PropertyOffset_SankTime;

		// Token: 0x0400DC63 RID: 56419
		internal static int __PropertyOffset_RefreshTime;
	}
}
