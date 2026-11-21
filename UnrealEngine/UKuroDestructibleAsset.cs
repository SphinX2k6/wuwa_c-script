using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004C0 RID: 1216
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroDestructibleAsset")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UKuroDestructibleAsset : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006FF6 RID: 28662 RVA: 0x000A581C File Offset: 0x000A3A1C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroDestructibleAsset._ClassPtr;
		}

		// Token: 0x06006FF7 RID: 28663 RVA: 0x000A5828 File Offset: 0x000A3A28
		public UKuroDestructibleAsset() : this(BuiltinUtils.AllocNativeUObject(UKuroDestructibleAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006FF8 RID: 28664 RVA: 0x000A5850 File Offset: 0x000A3A50
		public UKuroDestructibleAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroDestructibleAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170015CB RID: 5579
		// (get) Token: 0x06006FF9 RID: 28665 RVA: 0x000A5883 File Offset: 0x000A3A83
		// (set) Token: 0x06006FFA RID: 28666 RVA: 0x000A5897 File Offset: 0x000A3A97
		[Nullable(2)]
		public unsafe UStaticMesh WholeStaticMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroDestructibleAsset.__PropertyOffset_WholeStaticMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroDestructibleAsset.__PropertyOffset_WholeStaticMesh, value);
			}
		}

		// Token: 0x170015CC RID: 5580
		// (get) Token: 0x06006FFB RID: 28667 RVA: 0x000A58AC File Offset: 0x000A3AAC
		// (set) Token: 0x06006FFC RID: 28668 RVA: 0x000A58E5 File Offset: 0x000A3AE5
		public TArray<UMaterialInterface> StaticMeshMaterialOverrides
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._StaticMeshMaterialOverrides) == null)
				{
					result = (this._StaticMeshMaterialOverrides = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)UKuroDestructibleAsset.__PropertyOffset_StaticMeshMaterialOverrides, this));
				}
				return result;
			}
			set
			{
				this.StaticMeshMaterialOverrides.CopyAssign(value);
			}
		}

		// Token: 0x170015CD RID: 5581
		// (get) Token: 0x06006FFD RID: 28669 RVA: 0x000A58F3 File Offset: 0x000A3AF3
		// (set) Token: 0x06006FFE RID: 28670 RVA: 0x000A5907 File Offset: 0x000A3B07
		[Nullable(2)]
		public unsafe USkeletalMesh SkeletalMeshForRender
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroDestructibleAsset.__PropertyOffset_SkeletalMeshForRender);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroDestructibleAsset.__PropertyOffset_SkeletalMeshForRender, value);
			}
		}

		// Token: 0x170015CE RID: 5582
		// (get) Token: 0x06006FFF RID: 28671 RVA: 0x000A591C File Offset: 0x000A3B1C
		// (set) Token: 0x06007000 RID: 28672 RVA: 0x000A5955 File Offset: 0x000A3B55
		public TArray<UMaterialInterface> SkeletalMeshMaterialOverrides
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._SkeletalMeshMaterialOverrides) == null)
				{
					result = (this._SkeletalMeshMaterialOverrides = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)UKuroDestructibleAsset.__PropertyOffset_SkeletalMeshMaterialOverrides, this));
				}
				return result;
			}
			set
			{
				this.SkeletalMeshMaterialOverrides.CopyAssign(value);
			}
		}

		// Token: 0x06007001 RID: 28673 RVA: 0x000A5963 File Offset: 0x000A3B63
		static UKuroDestructibleAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroDestructibleAsset");
		}

		// Token: 0x06007002 RID: 28674 RVA: 0x000A5971 File Offset: 0x000A3B71
		protected UKuroDestructibleAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003055 RID: 12373
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroDestructibleAsset";

		// Token: 0x04003056 RID: 12374
		private static IntPtr _ClassPtr;

		// Token: 0x04003057 RID: 12375
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003058 RID: 12376
		internal static int __PropertyOffset_WholeStaticMesh;

		// Token: 0x04003059 RID: 12377
		internal static int __PropertyOffset_StaticMeshMaterialOverrides;

		// Token: 0x0400305A RID: 12378
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _StaticMeshMaterialOverrides;

		// Token: 0x0400305B RID: 12379
		internal static int __PropertyOffset_SkeletalMeshForRender;

		// Token: 0x0400305C RID: 12380
		internal static int __PropertyOffset_SkeletalMeshMaterialOverrides;

		// Token: 0x0400305D RID: 12381
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _SkeletalMeshMaterialOverrides;
	}
}
