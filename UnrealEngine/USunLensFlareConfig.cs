using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004F5 RID: 1269
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.SunLensFlareConfig")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class USunLensFlareConfig : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007749 RID: 30537 RVA: 0x000AE636 File Offset: 0x000AC836
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USunLensFlareConfig._ClassPtr;
		}

		// Token: 0x0600774A RID: 30538 RVA: 0x000AE644 File Offset: 0x000AC844
		public USunLensFlareConfig() : this(BuiltinUtils.AllocNativeUObject(USunLensFlareConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600774B RID: 30539 RVA: 0x000AE66C File Offset: 0x000AC86C
		[NullableContext(1)]
		public USunLensFlareConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USunLensFlareConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170016FB RID: 5883
		// (get) Token: 0x0600774C RID: 30540 RVA: 0x000AE69F File Offset: 0x000AC89F
		// (set) Token: 0x0600774D RID: 30541 RVA: 0x000AE6B3 File Offset: 0x000AC8B3
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

		// Token: 0x170016FC RID: 5884
		// (get) Token: 0x0600774E RID: 30542 RVA: 0x000AE6C8 File Offset: 0x000AC8C8
		// (set) Token: 0x0600774F RID: 30543 RVA: 0x000AE6DC File Offset: 0x000AC8DC
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

		// Token: 0x170016FD RID: 5885
		// (get) Token: 0x06007750 RID: 30544 RVA: 0x000AE6F1 File Offset: 0x000AC8F1
		// (set) Token: 0x06007751 RID: 30545 RVA: 0x000AE705 File Offset: 0x000AC905
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

		// Token: 0x170016FE RID: 5886
		// (get) Token: 0x06007752 RID: 30546 RVA: 0x000AE71A File Offset: 0x000AC91A
		// (set) Token: 0x06007753 RID: 30547 RVA: 0x000AE72E File Offset: 0x000AC92E
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

		// Token: 0x170016FF RID: 5887
		// (get) Token: 0x06007754 RID: 30548 RVA: 0x000AE743 File Offset: 0x000AC943
		// (set) Token: 0x06007755 RID: 30549 RVA: 0x000AE757 File Offset: 0x000AC957
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

		// Token: 0x17001700 RID: 5888
		// (get) Token: 0x06007756 RID: 30550 RVA: 0x000AE76C File Offset: 0x000AC96C
		// (set) Token: 0x06007757 RID: 30551 RVA: 0x000AE780 File Offset: 0x000AC980
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

		// Token: 0x06007758 RID: 30552 RVA: 0x000AE795 File Offset: 0x000AC995
		static USunLensFlareConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.SunLensFlareConfig");
		}

		// Token: 0x06007759 RID: 30553 RVA: 0x000AE7A3 File Offset: 0x000AC9A3
		protected USunLensFlareConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003245 RID: 12869
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.SunLensFlareConfig";

		// Token: 0x04003246 RID: 12870
		private static IntPtr _ClassPtr;

		// Token: 0x04003247 RID: 12871
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003248 RID: 12872
		internal static int __PropertyOffset_StaticMeshGhost;

		// Token: 0x04003249 RID: 12873
		internal static int __PropertyOffset_MaterialGhost;

		// Token: 0x0400324A RID: 12874
		internal static int __PropertyOffset_StaticMeshHalo;

		// Token: 0x0400324B RID: 12875
		internal static int __PropertyOffset_MaterialHalo;

		// Token: 0x0400324C RID: 12876
		internal static int __PropertyOffset_StaticMeshGlare;

		// Token: 0x0400324D RID: 12877
		internal static int __PropertyOffset_MaterialGlare;
	}
}
