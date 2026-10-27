using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BB8 RID: 7096
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSeasonsTreeNiagaraParamsAsset")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UKuroSeasonsTreeNiagaraParamsAsset : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B284 RID: 111236 RVA: 0x002804CE File Offset: 0x0027E6CE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSeasonsTreeNiagaraParamsAsset._ClassPtr;
		}

		// Token: 0x0601B285 RID: 111237 RVA: 0x002804DC File Offset: 0x0027E6DC
		public UKuroSeasonsTreeNiagaraParamsAsset() : this(BuiltinUtils.AllocNativeUObject(UKuroSeasonsTreeNiagaraParamsAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B286 RID: 111238 RVA: 0x00280504 File Offset: 0x0027E704
		public UKuroSeasonsTreeNiagaraParamsAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSeasonsTreeNiagaraParamsAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CEF RID: 27887
		// (get) Token: 0x0601B287 RID: 111239 RVA: 0x00280538 File Offset: 0x0027E738
		// (set) Token: 0x0601B288 RID: 111240 RVA: 0x00280571 File Offset: 0x0027E771
		public TMap<UStaticMesh, FKuroSeasonsTreeNiagaraParams> MeshToParams
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UStaticMesh, FKuroSeasonsTreeNiagaraParams> result;
				if ((result = this._MeshToParams) == null)
				{
					result = (this._MeshToParams = new TMap<UStaticMesh, FKuroSeasonsTreeNiagaraParams>(base.NativePtr + (IntPtr)UKuroSeasonsTreeNiagaraParamsAsset.__PropertyOffset_MeshToParams, this));
				}
				return result;
			}
			set
			{
				this.MeshToParams.CopyAssign(value);
			}
		}

		// Token: 0x0601B289 RID: 111241 RVA: 0x0028057F File Offset: 0x0027E77F
		static UKuroSeasonsTreeNiagaraParamsAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroSeasonsTreeNiagaraParamsAsset");
		}

		// Token: 0x0601B28A RID: 111242 RVA: 0x0028058D File Offset: 0x0027E78D
		protected UKuroSeasonsTreeNiagaraParamsAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EA02 RID: 59906
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSeasonsTreeNiagaraParamsAsset";

		// Token: 0x0400EA03 RID: 59907
		private static IntPtr _ClassPtr;

		// Token: 0x0400EA04 RID: 59908
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EA05 RID: 59909
		internal static int __PropertyOffset_MeshToParams;

		// Token: 0x0400EA06 RID: 59910
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<UStaticMesh, FKuroSeasonsTreeNiagaraParams> _MeshToParams;
	}
}
