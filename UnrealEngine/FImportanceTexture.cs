using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C41 RID: 3137
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ImportanceTexture")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FImportanceTexture : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009F3C RID: 40764 RVA: 0x000E253C File Offset: 0x000E073C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FImportanceTexture._ScriptStructPtr != 0) ? FImportanceTexture._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ImportanceTexture", ref FImportanceTexture._ScriptStructPtr);
		}

		// Token: 0x170025FC RID: 9724
		// (get) Token: 0x06009F3D RID: 40765 RVA: 0x000E2560 File Offset: 0x000E0760
		// (set) Token: 0x06009F3E RID: 40766 RVA: 0x000E2574 File Offset: 0x000E0774
		public unsafe FIntPoint Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FImportanceTexture.__PropertyOffset_Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FImportanceTexture.__PropertyOffset_Size) = value;
			}
		}

		// Token: 0x170025FD RID: 9725
		// (get) Token: 0x06009F3F RID: 40767 RVA: 0x000E2589 File Offset: 0x000E0789
		// (set) Token: 0x06009F40 RID: 40768 RVA: 0x000E2599 File Offset: 0x000E0799
		public unsafe int NumMips
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FImportanceTexture.__PropertyOffset_NumMips);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FImportanceTexture.__PropertyOffset_NumMips) = value;
			}
		}

		// Token: 0x170025FE RID: 9726
		// (get) Token: 0x06009F41 RID: 40769 RVA: 0x000E25AC File Offset: 0x000E07AC
		// (set) Token: 0x06009F42 RID: 40770 RVA: 0x000E25EF File Offset: 0x000E07EF
		public TArray<float> MarginalCDF
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._MarginalCDF) == null)
				{
					result = (this._MarginalCDF = new TArray<float>(base.NativePtr + (IntPtr)FImportanceTexture.__PropertyOffset_MarginalCDF, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MarginalCDF.CopyAssign(value);
			}
		}

		// Token: 0x170025FF RID: 9727
		// (get) Token: 0x06009F43 RID: 40771 RVA: 0x000E2600 File Offset: 0x000E0800
		// (set) Token: 0x06009F44 RID: 40772 RVA: 0x000E2643 File Offset: 0x000E0843
		public TArray<float> ConditionalCDF
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._ConditionalCDF) == null)
				{
					result = (this._ConditionalCDF = new TArray<float>(base.NativePtr + (IntPtr)FImportanceTexture.__PropertyOffset_ConditionalCDF, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ConditionalCDF.CopyAssign(value);
			}
		}

		// Token: 0x17002600 RID: 9728
		// (get) Token: 0x06009F45 RID: 40773 RVA: 0x000E2654 File Offset: 0x000E0854
		// (set) Token: 0x06009F46 RID: 40774 RVA: 0x000E2697 File Offset: 0x000E0897
		public TArray<FColor> TextureData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FColor> result;
				if ((result = this._TextureData) == null)
				{
					result = (this._TextureData = new TArray<FColor>(base.NativePtr + (IntPtr)FImportanceTexture.__PropertyOffset_TextureData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TextureData.CopyAssign(value);
			}
		}

		// Token: 0x17002601 RID: 9729
		// (get) Token: 0x06009F47 RID: 40775 RVA: 0x000E26A5 File Offset: 0x000E08A5
		// (set) Token: 0x06009F48 RID: 40776 RVA: 0x000E26B9 File Offset: 0x000E08B9
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UTexture2D> Texture
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FImportanceTexture.__PropertyOffset_Texture);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FImportanceTexture.__PropertyOffset_Texture) = value;
			}
		}

		// Token: 0x17002602 RID: 9730
		// (get) Token: 0x06009F49 RID: 40777 RVA: 0x000E26CE File Offset: 0x000E08CE
		// (set) Token: 0x06009F4A RID: 40778 RVA: 0x000E26E2 File Offset: 0x000E08E2
		[Nullable(0)]
		public unsafe TEnumAsByte<EImportanceWeight> Weighting
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FImportanceTexture.__PropertyOffset_Weighting);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FImportanceTexture.__PropertyOffset_Weighting) = value;
			}
		}

		// Token: 0x06009F4B RID: 40779 RVA: 0x000E26F7 File Offset: 0x000E08F7
		public FImportanceTexture()
		{
		}

		// Token: 0x06009F4C RID: 40780 RVA: 0x000E26FF File Offset: 0x000E08FF
		public FImportanceTexture(FIntPoint Size, int NumMips, TArray<float> MarginalCDF, TArray<float> ConditionalCDF, TArray<FColor> TextureData, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UTexture2D> Texture, [Nullable(0)] TEnumAsByte<EImportanceWeight> Weighting)
		{
			this.Size = Size;
			this.NumMips = NumMips;
			this.MarginalCDF = MarginalCDF;
			this.ConditionalCDF = ConditionalCDF;
			this.TextureData = TextureData;
			this.Texture = Texture;
			this.Weighting = Weighting;
		}

		// Token: 0x06009F4D RID: 40781 RVA: 0x000E273C File Offset: 0x000E093C
		protected override IntPtr GetUStructPtr()
		{
			return FImportanceTexture.StaticStruct();
		}

		// Token: 0x06009F4E RID: 40782 RVA: 0x000E2748 File Offset: 0x000E0948
		[NullableContext(2)]
		public FImportanceTexture(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009F4F RID: 40783 RVA: 0x000E2752 File Offset: 0x000E0952
		public FImportanceTexture(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009F50 RID: 40784 RVA: 0x000E275D File Offset: 0x000E095D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FImportanceTexture(Pointer, false, true);
		}

		// Token: 0x06009F51 RID: 40785 RVA: 0x000E2767 File Offset: 0x000E0967
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FImportanceTexture(Pointer, MemoryOwner);
		}

		// Token: 0x040057A8 RID: 22440
		public const string __ObjectPath = "/Script/Engine.ImportanceTexture";

		// Token: 0x040057A9 RID: 22441
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040057AA RID: 22442
		internal static int __PropertyOffset_Size;

		// Token: 0x040057AB RID: 22443
		internal static int __PropertyOffset_NumMips;

		// Token: 0x040057AC RID: 22444
		internal static int __PropertyOffset_MarginalCDF;

		// Token: 0x040057AD RID: 22445
		[Nullable(2)]
		private TArray<float> _MarginalCDF;

		// Token: 0x040057AE RID: 22446
		internal static int __PropertyOffset_ConditionalCDF;

		// Token: 0x040057AF RID: 22447
		[Nullable(2)]
		private TArray<float> _ConditionalCDF;

		// Token: 0x040057B0 RID: 22448
		internal static int __PropertyOffset_TextureData;

		// Token: 0x040057B1 RID: 22449
		[Nullable(2)]
		private TArray<FColor> _TextureData;

		// Token: 0x040057B2 RID: 22450
		internal static int __PropertyOffset_Texture;

		// Token: 0x040057B3 RID: 22451
		internal static int __PropertyOffset_Weighting;
	}
}
