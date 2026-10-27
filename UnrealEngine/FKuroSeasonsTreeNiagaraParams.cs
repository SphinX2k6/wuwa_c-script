using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001BB7 RID: 7095
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSeasonsTreeNiagaraParams")]
	[UnrealStructLayout(400, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 400)]
	public class FKuroSeasonsTreeNiagaraParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601B272 RID: 111218 RVA: 0x0028029D File Offset: 0x0027E49D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroSeasonsTreeNiagaraParams._ScriptStructPtr != 0) ? FKuroSeasonsTreeNiagaraParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroSeasonsTreeNiagaraParams", ref FKuroSeasonsTreeNiagaraParams._ScriptStructPtr);
		}

		// Token: 0x17006CEA RID: 27882
		// (get) Token: 0x0601B273 RID: 111219 RVA: 0x002802C4 File Offset: 0x0027E4C4
		// (set) Token: 0x0601B274 RID: 111220 RVA: 0x00280307 File Offset: 0x0027E507
		public TMap<FName, float> FloatParams
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._FloatParams) == null)
				{
					result = (this._FloatParams = new TMap<FName, float>(base.NativePtr + (IntPtr)FKuroSeasonsTreeNiagaraParams.__PropertyOffset_FloatParams, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FloatParams.CopyAssign(value);
			}
		}

		// Token: 0x17006CEB RID: 27883
		// (get) Token: 0x0601B275 RID: 111221 RVA: 0x00280318 File Offset: 0x0027E518
		// (set) Token: 0x0601B276 RID: 111222 RVA: 0x0028035B File Offset: 0x0027E55B
		public TMap<FName, FLinearColor> ColorParams
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._ColorParams) == null)
				{
					result = (this._ColorParams = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)FKuroSeasonsTreeNiagaraParams.__PropertyOffset_ColorParams, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ColorParams.CopyAssign(value);
			}
		}

		// Token: 0x17006CEC RID: 27884
		// (get) Token: 0x0601B277 RID: 111223 RVA: 0x0028036C File Offset: 0x0027E56C
		// (set) Token: 0x0601B278 RID: 111224 RVA: 0x002803AF File Offset: 0x0027E5AF
		public TMap<FName, FVector> VectorParams
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FVector> result;
				if ((result = this._VectorParams) == null)
				{
					result = (this._VectorParams = new TMap<FName, FVector>(base.NativePtr + (IntPtr)FKuroSeasonsTreeNiagaraParams.__PropertyOffset_VectorParams, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.VectorParams.CopyAssign(value);
			}
		}

		// Token: 0x17006CED RID: 27885
		// (get) Token: 0x0601B279 RID: 111225 RVA: 0x002803C0 File Offset: 0x0027E5C0
		// (set) Token: 0x0601B27A RID: 111226 RVA: 0x00280403 File Offset: 0x0027E603
		public TMap<FName, UTexture> TextureParams
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UTexture> result;
				if ((result = this._TextureParams) == null)
				{
					result = (this._TextureParams = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)FKuroSeasonsTreeNiagaraParams.__PropertyOffset_TextureParams, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TextureParams.CopyAssign(value);
			}
		}

		// Token: 0x17006CEE RID: 27886
		// (get) Token: 0x0601B27B RID: 111227 RVA: 0x00280414 File Offset: 0x0027E614
		// (set) Token: 0x0601B27C RID: 111228 RVA: 0x00280457 File Offset: 0x0027E657
		public TMap<FName, UHoudiniPointCache> HoudiniPointCacheParams
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UHoudiniPointCache> result;
				if ((result = this._HoudiniPointCacheParams) == null)
				{
					result = (this._HoudiniPointCacheParams = new TMap<FName, UHoudiniPointCache>(base.NativePtr + (IntPtr)FKuroSeasonsTreeNiagaraParams.__PropertyOffset_HoudiniPointCacheParams, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.HoudiniPointCacheParams.CopyAssign(value);
			}
		}

		// Token: 0x0601B27D RID: 111229 RVA: 0x00280465 File Offset: 0x0027E665
		public FKuroSeasonsTreeNiagaraParams()
		{
		}

		// Token: 0x0601B27E RID: 111230 RVA: 0x0028046D File Offset: 0x0027E66D
		public FKuroSeasonsTreeNiagaraParams(TMap<FName, float> FloatParams, TMap<FName, FLinearColor> ColorParams, TMap<FName, FVector> VectorParams, TMap<FName, UTexture> TextureParams, TMap<FName, UHoudiniPointCache> HoudiniPointCacheParams)
		{
			this.FloatParams = FloatParams;
			this.ColorParams = ColorParams;
			this.VectorParams = VectorParams;
			this.TextureParams = TextureParams;
			this.HoudiniPointCacheParams = HoudiniPointCacheParams;
		}

		// Token: 0x0601B27F RID: 111231 RVA: 0x0028049A File Offset: 0x0027E69A
		protected override IntPtr GetUStructPtr()
		{
			return FKuroSeasonsTreeNiagaraParams.StaticStruct();
		}

		// Token: 0x0601B280 RID: 111232 RVA: 0x002804A6 File Offset: 0x0027E6A6
		[NullableContext(2)]
		public FKuroSeasonsTreeNiagaraParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601B281 RID: 111233 RVA: 0x002804B0 File Offset: 0x0027E6B0
		public FKuroSeasonsTreeNiagaraParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601B282 RID: 111234 RVA: 0x002804BB File Offset: 0x0027E6BB
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroSeasonsTreeNiagaraParams(Pointer, false, true);
		}

		// Token: 0x0601B283 RID: 111235 RVA: 0x002804C5 File Offset: 0x0027E6C5
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroSeasonsTreeNiagaraParams(Pointer, MemoryOwner);
		}

		// Token: 0x0400E9F6 RID: 59894
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSeasonsTreeNiagaraParams";

		// Token: 0x0400E9F7 RID: 59895
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E9F8 RID: 59896
		internal static int __PropertyOffset_FloatParams;

		// Token: 0x0400E9F9 RID: 59897
		[Nullable(2)]
		private TMap<FName, float> _FloatParams;

		// Token: 0x0400E9FA RID: 59898
		internal static int __PropertyOffset_ColorParams;

		// Token: 0x0400E9FB RID: 59899
		[Nullable(2)]
		private TMap<FName, FLinearColor> _ColorParams;

		// Token: 0x0400E9FC RID: 59900
		internal static int __PropertyOffset_VectorParams;

		// Token: 0x0400E9FD RID: 59901
		[Nullable(2)]
		private TMap<FName, FVector> _VectorParams;

		// Token: 0x0400E9FE RID: 59902
		internal static int __PropertyOffset_TextureParams;

		// Token: 0x0400E9FF RID: 59903
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _TextureParams;

		// Token: 0x0400EA00 RID: 59904
		internal static int __PropertyOffset_HoudiniPointCacheParams;

		// Token: 0x0400EA01 RID: 59905
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UHoudiniPointCache> _HoudiniPointCacheParams;
	}
}
