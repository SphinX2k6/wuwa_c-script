using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C2F RID: 7215
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.SunLensFlareConfig")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class USunLensFlareConfig : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601BF0C RID: 114444 RVA: 0x00291E90 File Offset: 0x00290090
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USunLensFlareConfig._ClassPtr;
		}

		// Token: 0x0601BF0D RID: 114445 RVA: 0x00291E9C File Offset: 0x0029009C
		public USunLensFlareConfig() : this(BuiltinUtils.AllocNativeUObject(USunLensFlareConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601BF0E RID: 114446 RVA: 0x00291EC4 File Offset: 0x002900C4
		[NullableContext(1)]
		public USunLensFlareConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USunLensFlareConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170070D1 RID: 28881
		// (get) Token: 0x0601BF0F RID: 114447 RVA: 0x00291EF7 File Offset: 0x002900F7
		// (set) Token: 0x0601BF10 RID: 114448 RVA: 0x00291F0B File Offset: 0x0029010B
		public unsafe UStaticMesh StaticMeshGhost
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + USunLensFlareConfig.__PropertyOffset_StaticMeshGhost);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USunLensFlareConfig.__PropertyOffset_StaticMeshGhost, value);
			}
		}

		// Token: 0x170070D2 RID: 28882
		// (get) Token: 0x0601BF11 RID: 114449 RVA: 0x00291F20 File Offset: 0x00290120
		// (set) Token: 0x0601BF12 RID: 114450 RVA: 0x00291F34 File Offset: 0x00290134
		public unsafe UMaterialInterface MaterialGhost
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + USunLensFlareConfig.__PropertyOffset_MaterialGhost);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USunLensFlareConfig.__PropertyOffset_MaterialGhost, value);
			}
		}

		// Token: 0x170070D3 RID: 28883
		// (get) Token: 0x0601BF13 RID: 114451 RVA: 0x00291F49 File Offset: 0x00290149
		// (set) Token: 0x0601BF14 RID: 114452 RVA: 0x00291F5D File Offset: 0x0029015D
		public unsafe UStaticMesh StaticMeshHalo
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + USunLensFlareConfig.__PropertyOffset_StaticMeshHalo);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USunLensFlareConfig.__PropertyOffset_StaticMeshHalo, value);
			}
		}

		// Token: 0x170070D4 RID: 28884
		// (get) Token: 0x0601BF15 RID: 114453 RVA: 0x00291F72 File Offset: 0x00290172
		// (set) Token: 0x0601BF16 RID: 114454 RVA: 0x00291F86 File Offset: 0x00290186
		public unsafe UMaterialInterface MaterialHalo
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + USunLensFlareConfig.__PropertyOffset_MaterialHalo);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USunLensFlareConfig.__PropertyOffset_MaterialHalo, value);
			}
		}

		// Token: 0x170070D5 RID: 28885
		// (get) Token: 0x0601BF17 RID: 114455 RVA: 0x00291F9B File Offset: 0x0029019B
		// (set) Token: 0x0601BF18 RID: 114456 RVA: 0x00291FAF File Offset: 0x002901AF
		public unsafe UStaticMesh StaticMeshGlare
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + USunLensFlareConfig.__PropertyOffset_StaticMeshGlare);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USunLensFlareConfig.__PropertyOffset_StaticMeshGlare, value);
			}
		}

		// Token: 0x170070D6 RID: 28886
		// (get) Token: 0x0601BF19 RID: 114457 RVA: 0x00291FC4 File Offset: 0x002901C4
		// (set) Token: 0x0601BF1A RID: 114458 RVA: 0x00291FD8 File Offset: 0x002901D8
		public unsafe UMaterialInterface MaterialGlare
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + USunLensFlareConfig.__PropertyOffset_MaterialGlare);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USunLensFlareConfig.__PropertyOffset_MaterialGlare, value);
			}
		}

		// Token: 0x0601BF1B RID: 114459 RVA: 0x00291FED File Offset: 0x002901ED
		static USunLensFlareConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.SunLensFlareConfig");
		}

		// Token: 0x0601BF1C RID: 114460 RVA: 0x00291FFB File Offset: 0x002901FB
		protected USunLensFlareConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F01D RID: 61469
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.SunLensFlareConfig";

		// Token: 0x0400F01E RID: 61470
		private static IntPtr _ClassPtr;

		// Token: 0x0400F01F RID: 61471
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F020 RID: 61472
		internal static int __PropertyOffset_StaticMeshGhost;

		// Token: 0x0400F021 RID: 61473
		internal static int __PropertyOffset_MaterialGhost;

		// Token: 0x0400F022 RID: 61474
		internal static int __PropertyOffset_StaticMeshHalo;

		// Token: 0x0400F023 RID: 61475
		internal static int __PropertyOffset_MaterialHalo;

		// Token: 0x0400F024 RID: 61476
		internal static int __PropertyOffset_StaticMeshGlare;

		// Token: 0x0400F025 RID: 61477
		internal static int __PropertyOffset_MaterialGlare;
	}
}
