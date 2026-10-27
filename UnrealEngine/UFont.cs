using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000BE3 RID: 3043
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.Font")]
	[UnrealStructLayout(488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 488)]
	public class UFont : UObject, IUnrealUObject, IUnrealObject, IFontProviderInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060095B2 RID: 38322 RVA: 0x000D570E File Offset: 0x000D390E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFont._ClassPtr;
		}

		// Token: 0x060095B3 RID: 38323 RVA: 0x000D571A File Offset: 0x000D391A
		int IFontProviderInterface.InterfaceOffset()
		{
			return UFont.__InterfaceOffset_IFontProviderInterface;
		}

		// Token: 0x060095B4 RID: 38324 RVA: 0x000D5724 File Offset: 0x000D3924
		public UFont() : this(BuiltinUtils.AllocNativeUObject(UFont.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060095B5 RID: 38325 RVA: 0x000D574C File Offset: 0x000D394C
		public UFont(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFont.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170023D4 RID: 9172
		// (get) Token: 0x060095B6 RID: 38326 RVA: 0x000D577F File Offset: 0x000D397F
		// (set) Token: 0x060095B7 RID: 38327 RVA: 0x000D578F File Offset: 0x000D398F
		public unsafe EFontCacheType FontCacheType
		{
			get
			{
				return (EFontCacheType)(*(base.NativePtr + (IntPtr)UFont.__PropertyOffset_FontCacheType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFont.__PropertyOffset_FontCacheType) = (byte)value;
			}
		}

		// Token: 0x170023D5 RID: 9173
		// (get) Token: 0x060095B8 RID: 38328 RVA: 0x000D57A0 File Offset: 0x000D39A0
		// (set) Token: 0x060095B9 RID: 38329 RVA: 0x000D57D9 File Offset: 0x000D39D9
		public TArray<FFontCharacter> Characters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FFontCharacter> result;
				if ((result = this._Characters) == null)
				{
					result = (this._Characters = new TArray<FFontCharacter>(base.NativePtr + (IntPtr)UFont.__PropertyOffset_Characters, this));
				}
				return result;
			}
			set
			{
				this.Characters.CopyAssign(value);
			}
		}

		// Token: 0x170023D6 RID: 9174
		// (get) Token: 0x060095BA RID: 38330 RVA: 0x000D57E8 File Offset: 0x000D39E8
		// (set) Token: 0x060095BB RID: 38331 RVA: 0x000D5821 File Offset: 0x000D3A21
		public TArray<UTexture2D> Textures
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UTexture2D> result;
				if ((result = this._Textures) == null)
				{
					result = (this._Textures = new TArray<UTexture2D>(base.NativePtr + (IntPtr)UFont.__PropertyOffset_Textures, this));
				}
				return result;
			}
			set
			{
				this.Textures.CopyAssign(value);
			}
		}

		// Token: 0x170023D7 RID: 9175
		// (get) Token: 0x060095BC RID: 38332 RVA: 0x000D582F File Offset: 0x000D3A2F
		// (set) Token: 0x060095BD RID: 38333 RVA: 0x000D583F File Offset: 0x000D3A3F
		public unsafe int IsRemapped
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFont.__PropertyOffset_IsRemapped);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFont.__PropertyOffset_IsRemapped) = value;
			}
		}

		// Token: 0x170023D8 RID: 9176
		// (get) Token: 0x060095BE RID: 38334 RVA: 0x000D5850 File Offset: 0x000D3A50
		// (set) Token: 0x060095BF RID: 38335 RVA: 0x000D5860 File Offset: 0x000D3A60
		public unsafe float EmScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFont.__PropertyOffset_EmScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFont.__PropertyOffset_EmScale) = value;
			}
		}

		// Token: 0x170023D9 RID: 9177
		// (get) Token: 0x060095C0 RID: 38336 RVA: 0x000D5871 File Offset: 0x000D3A71
		// (set) Token: 0x060095C1 RID: 38337 RVA: 0x000D5881 File Offset: 0x000D3A81
		public unsafe float Ascent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFont.__PropertyOffset_Ascent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFont.__PropertyOffset_Ascent) = value;
			}
		}

		// Token: 0x170023DA RID: 9178
		// (get) Token: 0x060095C2 RID: 38338 RVA: 0x000D5892 File Offset: 0x000D3A92
		// (set) Token: 0x060095C3 RID: 38339 RVA: 0x000D58A2 File Offset: 0x000D3AA2
		public unsafe float Descent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFont.__PropertyOffset_Descent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFont.__PropertyOffset_Descent) = value;
			}
		}

		// Token: 0x170023DB RID: 9179
		// (get) Token: 0x060095C4 RID: 38340 RVA: 0x000D58B3 File Offset: 0x000D3AB3
		// (set) Token: 0x060095C5 RID: 38341 RVA: 0x000D58C3 File Offset: 0x000D3AC3
		public unsafe float Leading
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFont.__PropertyOffset_Leading);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFont.__PropertyOffset_Leading) = value;
			}
		}

		// Token: 0x170023DC RID: 9180
		// (get) Token: 0x060095C6 RID: 38342 RVA: 0x000D58D4 File Offset: 0x000D3AD4
		// (set) Token: 0x060095C7 RID: 38343 RVA: 0x000D58E4 File Offset: 0x000D3AE4
		public unsafe int Kerning
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFont.__PropertyOffset_Kerning);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFont.__PropertyOffset_Kerning) = value;
			}
		}

		// Token: 0x170023DD RID: 9181
		// (get) Token: 0x060095C8 RID: 38344 RVA: 0x000D58F8 File Offset: 0x000D3AF8
		// (set) Token: 0x060095C9 RID: 38345 RVA: 0x000D5931 File Offset: 0x000D3B31
		public FFontImportOptionsData ImportOptions
		{
			get
			{
				base.FastCheckIsValid();
				FFontImportOptionsData result;
				if ((result = this._ImportOptions) == null)
				{
					result = (this._ImportOptions = new FFontImportOptionsData(base.NativePtr + (IntPtr)UFont.__PropertyOffset_ImportOptions, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFontImportOptionsData.StaticStruct(), base.NativePtr + (IntPtr)UFont.__PropertyOffset_ImportOptions, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170023DE RID: 9182
		// (get) Token: 0x060095CA RID: 38346 RVA: 0x000D5952 File Offset: 0x000D3B52
		// (set) Token: 0x060095CB RID: 38347 RVA: 0x000D5962 File Offset: 0x000D3B62
		public unsafe int NumCharacters
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFont.__PropertyOffset_NumCharacters);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFont.__PropertyOffset_NumCharacters) = value;
			}
		}

		// Token: 0x170023DF RID: 9183
		// (get) Token: 0x060095CC RID: 38348 RVA: 0x000D5974 File Offset: 0x000D3B74
		// (set) Token: 0x060095CD RID: 38349 RVA: 0x000D59AD File Offset: 0x000D3BAD
		public TArray<int> MaxCharHeight
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._MaxCharHeight) == null)
				{
					result = (this._MaxCharHeight = new TArray<int>(base.NativePtr + (IntPtr)UFont.__PropertyOffset_MaxCharHeight, this));
				}
				return result;
			}
			set
			{
				this.MaxCharHeight.CopyAssign(value);
			}
		}

		// Token: 0x170023E0 RID: 9184
		// (get) Token: 0x060095CE RID: 38350 RVA: 0x000D59BB File Offset: 0x000D3BBB
		// (set) Token: 0x060095CF RID: 38351 RVA: 0x000D59CB File Offset: 0x000D3BCB
		public unsafe float ScalingFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFont.__PropertyOffset_ScalingFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFont.__PropertyOffset_ScalingFactor) = value;
			}
		}

		// Token: 0x170023E1 RID: 9185
		// (get) Token: 0x060095D0 RID: 38352 RVA: 0x000D59DC File Offset: 0x000D3BDC
		// (set) Token: 0x060095D1 RID: 38353 RVA: 0x000D59EC File Offset: 0x000D3BEC
		public unsafe int LegacyFontSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFont.__PropertyOffset_LegacyFontSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFont.__PropertyOffset_LegacyFontSize) = value;
			}
		}

		// Token: 0x170023E2 RID: 9186
		// (get) Token: 0x060095D2 RID: 38354 RVA: 0x000D59FD File Offset: 0x000D3BFD
		// (set) Token: 0x060095D3 RID: 38355 RVA: 0x000D5A11 File Offset: 0x000D3C11
		public unsafe FName LegacyFontName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFont.__PropertyOffset_LegacyFontName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFont.__PropertyOffset_LegacyFontName) = value;
			}
		}

		// Token: 0x170023E3 RID: 9187
		// (get) Token: 0x060095D4 RID: 38356 RVA: 0x000D5A28 File Offset: 0x000D3C28
		// (set) Token: 0x060095D5 RID: 38357 RVA: 0x000D5A61 File Offset: 0x000D3C61
		public FCompositeFont CompositeFont
		{
			get
			{
				base.FastCheckIsValid();
				FCompositeFont result;
				if ((result = this._CompositeFont) == null)
				{
					result = (this._CompositeFont = new FCompositeFont(base.NativePtr + (IntPtr)UFont.__PropertyOffset_CompositeFont, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCompositeFont.StaticStruct(), base.NativePtr + (IntPtr)UFont.__PropertyOffset_CompositeFont, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060095D6 RID: 38358 RVA: 0x000D5A82 File Offset: 0x000D3C82
		static UFont()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Font");
		}

		// Token: 0x060095D7 RID: 38359 RVA: 0x000D5A90 File Offset: 0x000D3C90
		protected UFont(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040053F8 RID: 21496
		internal static int __InterfaceOffset_IFontProviderInterface;

		// Token: 0x040053F9 RID: 21497
		public new const string __ObjectPath = "/Script/Engine.Font";

		// Token: 0x040053FA RID: 21498
		private static IntPtr _ClassPtr;

		// Token: 0x040053FB RID: 21499
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040053FC RID: 21500
		internal static int __PropertyOffset_FontCacheType;

		// Token: 0x040053FD RID: 21501
		internal static int __PropertyOffset_Characters;

		// Token: 0x040053FE RID: 21502
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FFontCharacter> _Characters;

		// Token: 0x040053FF RID: 21503
		internal static int __PropertyOffset_Textures;

		// Token: 0x04005400 RID: 21504
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UTexture2D> _Textures;

		// Token: 0x04005401 RID: 21505
		internal static int __PropertyOffset_IsRemapped;

		// Token: 0x04005402 RID: 21506
		internal static int __PropertyOffset_EmScale;

		// Token: 0x04005403 RID: 21507
		internal static int __PropertyOffset_Ascent;

		// Token: 0x04005404 RID: 21508
		internal static int __PropertyOffset_Descent;

		// Token: 0x04005405 RID: 21509
		internal static int __PropertyOffset_Leading;

		// Token: 0x04005406 RID: 21510
		internal static int __PropertyOffset_Kerning;

		// Token: 0x04005407 RID: 21511
		internal static int __PropertyOffset_ImportOptions;

		// Token: 0x04005408 RID: 21512
		[Nullable(2)]
		private FFontImportOptionsData _ImportOptions;

		// Token: 0x04005409 RID: 21513
		internal static int __PropertyOffset_NumCharacters;

		// Token: 0x0400540A RID: 21514
		internal static int __PropertyOffset_MaxCharHeight;

		// Token: 0x0400540B RID: 21515
		[Nullable(2)]
		private TArray<int> _MaxCharHeight;

		// Token: 0x0400540C RID: 21516
		internal static int __PropertyOffset_ScalingFactor;

		// Token: 0x0400540D RID: 21517
		internal static int __PropertyOffset_LegacyFontSize;

		// Token: 0x0400540E RID: 21518
		internal static int __PropertyOffset_LegacyFontName;

		// Token: 0x0400540F RID: 21519
		internal static int __PropertyOffset_CompositeFont;

		// Token: 0x04005410 RID: 21520
		[Nullable(2)]
		private FCompositeFont _CompositeFont;
	}
}
