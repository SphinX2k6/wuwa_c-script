using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BCA RID: 7114
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSunLensflareInfo")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FKuroSunLensflareInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601B4C2 RID: 111810 RVA: 0x002838A0 File Offset: 0x00281AA0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroSunLensflareInfo._ScriptStructPtr != 0) ? FKuroSunLensflareInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroSunLensflareInfo", ref FKuroSunLensflareInfo._ScriptStructPtr);
		}

		// Token: 0x17006DA9 RID: 28073
		// (get) Token: 0x0601B4C3 RID: 111811 RVA: 0x002838C4 File Offset: 0x00281AC4
		// (set) Token: 0x0601B4C4 RID: 111812 RVA: 0x002838D8 File Offset: 0x00281AD8
		public unsafe USunLensFlareConfig LensFlareConfig
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USunLensFlareConfig>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroSunLensflareInfo.__PropertyOffset_LensFlareConfig);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroSunLensflareInfo.__PropertyOffset_LensFlareConfig, value);
			}
		}

		// Token: 0x17006DAA RID: 28074
		// (get) Token: 0x0601B4C5 RID: 111813 RVA: 0x002838ED File Offset: 0x00281AED
		// (set) Token: 0x0601B4C6 RID: 111814 RVA: 0x00283901 File Offset: 0x00281B01
		public unsafe AActor LensFlareActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroSunLensflareInfo.__PropertyOffset_LensFlareActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroSunLensflareInfo.__PropertyOffset_LensFlareActor, value);
			}
		}

		// Token: 0x17006DAB RID: 28075
		// (get) Token: 0x0601B4C7 RID: 111815 RVA: 0x00283916 File Offset: 0x00281B16
		// (set) Token: 0x0601B4C8 RID: 111816 RVA: 0x0028392A File Offset: 0x00281B2A
		public unsafe UStaticMeshComponent HaloComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroSunLensflareInfo.__PropertyOffset_HaloComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroSunLensflareInfo.__PropertyOffset_HaloComponent, value);
			}
		}

		// Token: 0x17006DAC RID: 28076
		// (get) Token: 0x0601B4C9 RID: 111817 RVA: 0x0028393F File Offset: 0x00281B3F
		// (set) Token: 0x0601B4CA RID: 111818 RVA: 0x00283953 File Offset: 0x00281B53
		public unsafe UStaticMeshComponent GhostComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroSunLensflareInfo.__PropertyOffset_GhostComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroSunLensflareInfo.__PropertyOffset_GhostComponent, value);
			}
		}

		// Token: 0x17006DAD RID: 28077
		// (get) Token: 0x0601B4CB RID: 111819 RVA: 0x00283968 File Offset: 0x00281B68
		// (set) Token: 0x0601B4CC RID: 111820 RVA: 0x0028397C File Offset: 0x00281B7C
		public unsafe UStaticMeshComponent GlareComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroSunLensflareInfo.__PropertyOffset_GlareComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroSunLensflareInfo.__PropertyOffset_GlareComponent, value);
			}
		}

		// Token: 0x17006DAE RID: 28078
		// (get) Token: 0x0601B4CD RID: 111821 RVA: 0x00283991 File Offset: 0x00281B91
		// (set) Token: 0x0601B4CE RID: 111822 RVA: 0x002839A5 File Offset: 0x00281BA5
		public unsafe UMaterialInstanceDynamic HaloMaterialDynamic
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroSunLensflareInfo.__PropertyOffset_HaloMaterialDynamic);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroSunLensflareInfo.__PropertyOffset_HaloMaterialDynamic, value);
			}
		}

		// Token: 0x17006DAF RID: 28079
		// (get) Token: 0x0601B4CF RID: 111823 RVA: 0x002839BA File Offset: 0x00281BBA
		// (set) Token: 0x0601B4D0 RID: 111824 RVA: 0x002839CE File Offset: 0x00281BCE
		public unsafe UMaterialInstanceDynamic GhostMaterialDynamic
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroSunLensflareInfo.__PropertyOffset_GhostMaterialDynamic);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroSunLensflareInfo.__PropertyOffset_GhostMaterialDynamic, value);
			}
		}

		// Token: 0x17006DB0 RID: 28080
		// (get) Token: 0x0601B4D1 RID: 111825 RVA: 0x002839E3 File Offset: 0x00281BE3
		// (set) Token: 0x0601B4D2 RID: 111826 RVA: 0x002839F7 File Offset: 0x00281BF7
		public unsafe UMaterialInstanceDynamic GlareMaterialDynamic
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroSunLensflareInfo.__PropertyOffset_GlareMaterialDynamic);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroSunLensflareInfo.__PropertyOffset_GlareMaterialDynamic, value);
			}
		}

		// Token: 0x0601B4D3 RID: 111827 RVA: 0x00283A0C File Offset: 0x00281C0C
		public FKuroSunLensflareInfo()
		{
		}

		// Token: 0x0601B4D4 RID: 111828 RVA: 0x00283A14 File Offset: 0x00281C14
		[NullableContext(1)]
		public FKuroSunLensflareInfo(USunLensFlareConfig LensFlareConfig, AActor LensFlareActor, UStaticMeshComponent HaloComponent, UStaticMeshComponent GhostComponent, UStaticMeshComponent GlareComponent, UMaterialInstanceDynamic HaloMaterialDynamic, UMaterialInstanceDynamic GhostMaterialDynamic, UMaterialInstanceDynamic GlareMaterialDynamic)
		{
			this.LensFlareConfig = LensFlareConfig;
			this.LensFlareActor = LensFlareActor;
			this.HaloComponent = HaloComponent;
			this.GhostComponent = GhostComponent;
			this.GlareComponent = GlareComponent;
			this.HaloMaterialDynamic = HaloMaterialDynamic;
			this.GhostMaterialDynamic = GhostMaterialDynamic;
			this.GlareMaterialDynamic = GlareMaterialDynamic;
		}

		// Token: 0x0601B4D5 RID: 111829 RVA: 0x00283A64 File Offset: 0x00281C64
		protected override IntPtr GetUStructPtr()
		{
			return FKuroSunLensflareInfo.StaticStruct();
		}

		// Token: 0x0601B4D6 RID: 111830 RVA: 0x00283A70 File Offset: 0x00281C70
		public FKuroSunLensflareInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601B4D7 RID: 111831 RVA: 0x00283A7A File Offset: 0x00281C7A
		public FKuroSunLensflareInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601B4D8 RID: 111832 RVA: 0x00283A85 File Offset: 0x00281C85
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroSunLensflareInfo(Pointer, false, true);
		}

		// Token: 0x0601B4D9 RID: 111833 RVA: 0x00283A8F File Offset: 0x00281C8F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroSunLensflareInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400EB32 RID: 60210
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSunLensflareInfo";

		// Token: 0x0400EB33 RID: 60211
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EB34 RID: 60212
		internal static int __PropertyOffset_LensFlareConfig;

		// Token: 0x0400EB35 RID: 60213
		internal static int __PropertyOffset_LensFlareActor;

		// Token: 0x0400EB36 RID: 60214
		internal static int __PropertyOffset_HaloComponent;

		// Token: 0x0400EB37 RID: 60215
		internal static int __PropertyOffset_GhostComponent;

		// Token: 0x0400EB38 RID: 60216
		internal static int __PropertyOffset_GlareComponent;

		// Token: 0x0400EB39 RID: 60217
		internal static int __PropertyOffset_HaloMaterialDynamic;

		// Token: 0x0400EB3A RID: 60218
		internal static int __PropertyOffset_GhostMaterialDynamic;

		// Token: 0x0400EB3B RID: 60219
		internal static int __PropertyOffset_GlareMaterialDynamic;
	}
}
