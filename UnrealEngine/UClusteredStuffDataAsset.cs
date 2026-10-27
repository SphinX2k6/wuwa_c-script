using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A5D RID: 6749
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.ClusteredStuffDataAsset")]
	[UnrealStructLayout(496, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 496)]
	public class UClusteredStuffDataAsset : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018FB3 RID: 102323 RVA: 0x0024EC94 File Offset: 0x0024CE94
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UClusteredStuffDataAsset._ClassPtr;
		}

		// Token: 0x06018FB4 RID: 102324 RVA: 0x0024ECA0 File Offset: 0x0024CEA0
		public UClusteredStuffDataAsset() : this(BuiltinUtils.AllocNativeUObject(UClusteredStuffDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018FB5 RID: 102325 RVA: 0x0024ECC8 File Offset: 0x0024CEC8
		public UClusteredStuffDataAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UClusteredStuffDataAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006302 RID: 25346
		// (get) Token: 0x06018FB6 RID: 102326 RVA: 0x0024ECFB File Offset: 0x0024CEFB
		// (set) Token: 0x06018FB7 RID: 102327 RVA: 0x0024ED0F File Offset: 0x0024CF0F
		[Nullable(2)]
		public unsafe UNiagaraSystem NiagaraSystem
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + UClusteredStuffDataAsset.__PropertyOffset_NiagaraSystem);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UClusteredStuffDataAsset.__PropertyOffset_NiagaraSystem, value);
			}
		}

		// Token: 0x17006303 RID: 25347
		// (get) Token: 0x06018FB8 RID: 102328 RVA: 0x0024ED24 File Offset: 0x0024CF24
		// (set) Token: 0x06018FB9 RID: 102329 RVA: 0x0024ED5D File Offset: 0x0024CF5D
		public TMap<FName, float> FloatParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._FloatParameters) == null)
				{
					result = (this._FloatParameters = new TMap<FName, float>(base.NativePtr + (IntPtr)UClusteredStuffDataAsset.__PropertyOffset_FloatParameters, this));
				}
				return result;
			}
			set
			{
				this.FloatParameters.CopyAssign(value);
			}
		}

		// Token: 0x17006304 RID: 25348
		// (get) Token: 0x06018FBA RID: 102330 RVA: 0x0024ED6C File Offset: 0x0024CF6C
		// (set) Token: 0x06018FBB RID: 102331 RVA: 0x0024EDA5 File Offset: 0x0024CFA5
		public TMap<FName, FLinearColor> ColorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._ColorParameters) == null)
				{
					result = (this._ColorParameters = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)UClusteredStuffDataAsset.__PropertyOffset_ColorParameters, this));
				}
				return result;
			}
			set
			{
				this.ColorParameters.CopyAssign(value);
			}
		}

		// Token: 0x17006305 RID: 25349
		// (get) Token: 0x06018FBC RID: 102332 RVA: 0x0024EDB4 File Offset: 0x0024CFB4
		// (set) Token: 0x06018FBD RID: 102333 RVA: 0x0024EDED File Offset: 0x0024CFED
		public TMap<FName, FVector> VectorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FVector> result;
				if ((result = this._VectorParameters) == null)
				{
					result = (this._VectorParameters = new TMap<FName, FVector>(base.NativePtr + (IntPtr)UClusteredStuffDataAsset.__PropertyOffset_VectorParameters, this));
				}
				return result;
			}
			set
			{
				this.VectorParameters.CopyAssign(value);
			}
		}

		// Token: 0x17006306 RID: 25350
		// (get) Token: 0x06018FBE RID: 102334 RVA: 0x0024EDFC File Offset: 0x0024CFFC
		// (set) Token: 0x06018FBF RID: 102335 RVA: 0x0024EE35 File Offset: 0x0024D035
		public TMap<FName, UObject> ObjectParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UObject> result;
				if ((result = this._ObjectParameters) == null)
				{
					result = (this._ObjectParameters = new TMap<FName, UObject>(base.NativePtr + (IntPtr)UClusteredStuffDataAsset.__PropertyOffset_ObjectParameters, this));
				}
				return result;
			}
			set
			{
				this.ObjectParameters.CopyAssign(value);
			}
		}

		// Token: 0x17006307 RID: 25351
		// (get) Token: 0x06018FC0 RID: 102336 RVA: 0x0024EE43 File Offset: 0x0024D043
		// (set) Token: 0x06018FC1 RID: 102337 RVA: 0x0024EE57 File Offset: 0x0024D057
		public unsafe FVector Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UClusteredStuffDataAsset.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UClusteredStuffDataAsset.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x17006308 RID: 25352
		// (get) Token: 0x06018FC2 RID: 102338 RVA: 0x0024EE6C File Offset: 0x0024D06C
		// (set) Token: 0x06018FC3 RID: 102339 RVA: 0x0024EE85 File Offset: 0x0024D085
		public unsafe bool bUseWorldPosition
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UClusteredStuffDataAsset.__PropertyOffset_bUseWorldPosition) & UClusteredStuffDataAsset.__PropertyMask_bUseWorldPosition) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UClusteredStuffDataAsset.__PropertyOffset_bUseWorldPosition) = ((*(base.NativePtr + (IntPtr)UClusteredStuffDataAsset.__PropertyOffset_bUseWorldPosition) & ~UClusteredStuffDataAsset.__PropertyMask_bUseWorldPosition) | (value ? UClusteredStuffDataAsset.__PropertyMask_bUseWorldPosition : 0));
			}
		}

		// Token: 0x17006309 RID: 25353
		// (get) Token: 0x06018FC4 RID: 102340 RVA: 0x0024EEB5 File Offset: 0x0024D0B5
		// (set) Token: 0x06018FC5 RID: 102341 RVA: 0x0024EEC9 File Offset: 0x0024D0C9
		public unsafe FTransform WorldTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UClusteredStuffDataAsset.__PropertyOffset_WorldTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UClusteredStuffDataAsset.__PropertyOffset_WorldTransform) = value;
			}
		}

		// Token: 0x1700630A RID: 25354
		// (get) Token: 0x06018FC6 RID: 102342 RVA: 0x0024EEDE File Offset: 0x0024D0DE
		// (set) Token: 0x06018FC7 RID: 102343 RVA: 0x0024EEF2 File Offset: 0x0024D0F2
		[Nullable(2)]
		public unsafe UClusteredStuffDataAsset MobileClusteredStuff
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UClusteredStuffDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UClusteredStuffDataAsset.__PropertyOffset_MobileClusteredStuff);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UClusteredStuffDataAsset.__PropertyOffset_MobileClusteredStuff, value);
			}
		}

		// Token: 0x1700630B RID: 25355
		// (get) Token: 0x06018FC8 RID: 102344 RVA: 0x0024EF07 File Offset: 0x0024D107
		// (set) Token: 0x06018FC9 RID: 102345 RVA: 0x0024EF20 File Offset: 0x0024D120
		public unsafe bool bAlwaysActive
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UClusteredStuffDataAsset.__PropertyOffset_bAlwaysActive) & UClusteredStuffDataAsset.__PropertyMask_bAlwaysActive) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UClusteredStuffDataAsset.__PropertyOffset_bAlwaysActive) = ((*(base.NativePtr + (IntPtr)UClusteredStuffDataAsset.__PropertyOffset_bAlwaysActive) & ~UClusteredStuffDataAsset.__PropertyMask_bAlwaysActive) | (value ? UClusteredStuffDataAsset.__PropertyMask_bAlwaysActive : 0));
			}
		}

		// Token: 0x06018FCA RID: 102346 RVA: 0x0024EF50 File Offset: 0x0024D150
		static UClusteredStuffDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.ClusteredStuffDataAsset");
		}

		// Token: 0x06018FCB RID: 102347 RVA: 0x0024EF5E File Offset: 0x0024D15E
		protected UClusteredStuffDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D83D RID: 55357
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.ClusteredStuffDataAsset";

		// Token: 0x0400D83E RID: 55358
		private static IntPtr _ClassPtr;

		// Token: 0x0400D83F RID: 55359
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D840 RID: 55360
		internal static int __PropertyOffset_NiagaraSystem;

		// Token: 0x0400D841 RID: 55361
		internal static int __PropertyOffset_FloatParameters;

		// Token: 0x0400D842 RID: 55362
		[Nullable(2)]
		private TMap<FName, float> _FloatParameters;

		// Token: 0x0400D843 RID: 55363
		internal static int __PropertyOffset_ColorParameters;

		// Token: 0x0400D844 RID: 55364
		[Nullable(2)]
		private TMap<FName, FLinearColor> _ColorParameters;

		// Token: 0x0400D845 RID: 55365
		internal static int __PropertyOffset_VectorParameters;

		// Token: 0x0400D846 RID: 55366
		[Nullable(2)]
		private TMap<FName, FVector> _VectorParameters;

		// Token: 0x0400D847 RID: 55367
		internal static int __PropertyOffset_ObjectParameters;

		// Token: 0x0400D848 RID: 55368
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UObject> _ObjectParameters;

		// Token: 0x0400D849 RID: 55369
		internal static int __PropertyOffset_Scale;

		// Token: 0x0400D84A RID: 55370
		internal static int __PropertyOffset_bUseWorldPosition;

		// Token: 0x0400D84B RID: 55371
		internal static byte __PropertyMask_bUseWorldPosition;

		// Token: 0x0400D84C RID: 55372
		internal static int __PropertyOffset_WorldTransform;

		// Token: 0x0400D84D RID: 55373
		internal static int __PropertyOffset_MobileClusteredStuff;

		// Token: 0x0400D84E RID: 55374
		internal static int __PropertyOffset_bAlwaysActive;

		// Token: 0x0400D84F RID: 55375
		internal static byte __PropertyMask_bAlwaysActive;
	}
}
