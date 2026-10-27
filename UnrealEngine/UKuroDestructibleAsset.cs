using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AE2 RID: 6882
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroDestructibleAsset")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UKuroDestructibleAsset : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019A56 RID: 105046 RVA: 0x0025E6FC File Offset: 0x0025C8FC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroDestructibleAsset._ClassPtr;
		}

		// Token: 0x06019A57 RID: 105047 RVA: 0x0025E708 File Offset: 0x0025C908
		public UKuroDestructibleAsset() : this(BuiltinUtils.AllocNativeUObject(UKuroDestructibleAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019A58 RID: 105048 RVA: 0x0025E730 File Offset: 0x0025C930
		public UKuroDestructibleAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroDestructibleAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006664 RID: 26212
		// (get) Token: 0x06019A59 RID: 105049 RVA: 0x0025E763 File Offset: 0x0025C963
		// (set) Token: 0x06019A5A RID: 105050 RVA: 0x0025E777 File Offset: 0x0025C977
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

		// Token: 0x17006665 RID: 26213
		// (get) Token: 0x06019A5B RID: 105051 RVA: 0x0025E78C File Offset: 0x0025C98C
		// (set) Token: 0x06019A5C RID: 105052 RVA: 0x0025E7C5 File Offset: 0x0025C9C5
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

		// Token: 0x17006666 RID: 26214
		// (get) Token: 0x06019A5D RID: 105053 RVA: 0x0025E7D3 File Offset: 0x0025C9D3
		// (set) Token: 0x06019A5E RID: 105054 RVA: 0x0025E7E7 File Offset: 0x0025C9E7
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

		// Token: 0x17006667 RID: 26215
		// (get) Token: 0x06019A5F RID: 105055 RVA: 0x0025E7FC File Offset: 0x0025C9FC
		// (set) Token: 0x06019A60 RID: 105056 RVA: 0x0025E835 File Offset: 0x0025CA35
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

		// Token: 0x17006668 RID: 26216
		// (get) Token: 0x06019A61 RID: 105057 RVA: 0x0025E844 File Offset: 0x0025CA44
		// (set) Token: 0x06019A62 RID: 105058 RVA: 0x0025E87D File Offset: 0x0025CA7D
		public TArray<FKuroDestructiblePieceInfo> PieceInfos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroDestructiblePieceInfo> result;
				if ((result = this._PieceInfos) == null)
				{
					result = (this._PieceInfos = new TArray<FKuroDestructiblePieceInfo>(base.NativePtr + (IntPtr)UKuroDestructibleAsset.__PropertyOffset_PieceInfos, this));
				}
				return result;
			}
			set
			{
				this.PieceInfos.CopyAssign(value);
			}
		}

		// Token: 0x06019A63 RID: 105059 RVA: 0x0025E88B File Offset: 0x0025CA8B
		static UKuroDestructibleAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroDestructibleAsset");
		}

		// Token: 0x06019A64 RID: 105060 RVA: 0x0025E899 File Offset: 0x0025CA99
		protected UKuroDestructibleAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DF3B RID: 57147
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroDestructibleAsset";

		// Token: 0x0400DF3C RID: 57148
		private static IntPtr _ClassPtr;

		// Token: 0x0400DF3D RID: 57149
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400DF3E RID: 57150
		internal static int __PropertyOffset_WholeStaticMesh;

		// Token: 0x0400DF3F RID: 57151
		internal static int __PropertyOffset_StaticMeshMaterialOverrides;

		// Token: 0x0400DF40 RID: 57152
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _StaticMeshMaterialOverrides;

		// Token: 0x0400DF41 RID: 57153
		internal static int __PropertyOffset_SkeletalMeshForRender;

		// Token: 0x0400DF42 RID: 57154
		internal static int __PropertyOffset_SkeletalMeshMaterialOverrides;

		// Token: 0x0400DF43 RID: 57155
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _SkeletalMeshMaterialOverrides;

		// Token: 0x0400DF44 RID: 57156
		internal static int __PropertyOffset_PieceInfos;

		// Token: 0x0400DF45 RID: 57157
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroDestructiblePieceInfo> _PieceInfos;
	}
}
