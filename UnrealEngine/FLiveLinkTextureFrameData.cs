using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002220 RID: 8736
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkTextureFrameData")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 256)]
	public class FLiveLinkTextureFrameData : FLiveLinkBaseFrameData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602144E RID: 136270 RVA: 0x00310ACA File Offset: 0x0030ECCA
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkTextureFrameData._ScriptStructPtr != 0) ? FLiveLinkTextureFrameData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkTextureFrameData", ref FLiveLinkTextureFrameData._ScriptStructPtr);
		}

		// Token: 0x170081DB RID: 33243
		// (get) Token: 0x0602144F RID: 136271 RVA: 0x00310AF0 File Offset: 0x0030ECF0
		// (set) Token: 0x06021450 RID: 136272 RVA: 0x00310B33 File Offset: 0x0030ED33
		public TArray<FLiveLinkTextureSingleFrame> TextureFrames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLiveLinkTextureSingleFrame> result;
				if ((result = this._TextureFrames) == null)
				{
					result = (this._TextureFrames = new TArray<FLiveLinkTextureSingleFrame>(base.NativePtr + (IntPtr)FLiveLinkTextureFrameData.__PropertyOffset_TextureFrames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TextureFrames.CopyAssign(value);
			}
		}

		// Token: 0x170081DC RID: 33244
		// (get) Token: 0x06021451 RID: 136273 RVA: 0x00310B44 File Offset: 0x0030ED44
		// (set) Token: 0x06021452 RID: 136274 RVA: 0x00310B87 File Offset: 0x0030ED87
		public TArray<int> DataIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._DataIndices) == null)
				{
					result = (this._DataIndices = new TArray<int>(base.NativePtr + (IntPtr)FLiveLinkTextureFrameData.__PropertyOffset_DataIndices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DataIndices.CopyAssign(value);
			}
		}

		// Token: 0x170081DD RID: 33245
		// (get) Token: 0x06021453 RID: 136275 RVA: 0x00310B95 File Offset: 0x0030ED95
		// (set) Token: 0x06021454 RID: 136276 RVA: 0x00310BA9 File Offset: 0x0030EDA9
		public unsafe FVector2D DataLimitX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkTextureFrameData.__PropertyOffset_DataLimitX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkTextureFrameData.__PropertyOffset_DataLimitX) = value;
			}
		}

		// Token: 0x170081DE RID: 33246
		// (get) Token: 0x06021455 RID: 136277 RVA: 0x00310BBE File Offset: 0x0030EDBE
		// (set) Token: 0x06021456 RID: 136278 RVA: 0x00310BD2 File Offset: 0x0030EDD2
		public unsafe FVector2D DataLimitY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkTextureFrameData.__PropertyOffset_DataLimitY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkTextureFrameData.__PropertyOffset_DataLimitY) = value;
			}
		}

		// Token: 0x170081DF RID: 33247
		// (get) Token: 0x06021457 RID: 136279 RVA: 0x00310BE7 File Offset: 0x0030EDE7
		// (set) Token: 0x06021458 RID: 136280 RVA: 0x00310BFB File Offset: 0x0030EDFB
		public unsafe FVector2D DataLimitZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkTextureFrameData.__PropertyOffset_DataLimitZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkTextureFrameData.__PropertyOffset_DataLimitZ) = value;
			}
		}

		// Token: 0x170081E0 RID: 33248
		// (get) Token: 0x06021459 RID: 136281 RVA: 0x00310C10 File Offset: 0x0030EE10
		// (set) Token: 0x0602145A RID: 136282 RVA: 0x00310C20 File Offset: 0x0030EE20
		public unsafe bool hasBeenBaked
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkTextureFrameData.__PropertyOffset_hasBeenBaked) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkTextureFrameData.__PropertyOffset_hasBeenBaked) = (value ? 1 : 0);
			}
		}

		// Token: 0x170081E1 RID: 33249
		// (get) Token: 0x0602145B RID: 136283 RVA: 0x00310C31 File Offset: 0x0030EE31
		// (set) Token: 0x0602145C RID: 136284 RVA: 0x00310C41 File Offset: 0x0030EE41
		public unsafe int SizeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkTextureFrameData.__PropertyOffset_SizeX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkTextureFrameData.__PropertyOffset_SizeX) = value;
			}
		}

		// Token: 0x170081E2 RID: 33250
		// (get) Token: 0x0602145D RID: 136285 RVA: 0x00310C52 File Offset: 0x0030EE52
		// (set) Token: 0x0602145E RID: 136286 RVA: 0x00310C62 File Offset: 0x0030EE62
		public unsafe int SizeY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkTextureFrameData.__PropertyOffset_SizeY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkTextureFrameData.__PropertyOffset_SizeY) = value;
			}
		}

		// Token: 0x170081E3 RID: 33251
		// (get) Token: 0x0602145F RID: 136287 RVA: 0x00310C73 File Offset: 0x0030EE73
		// (set) Token: 0x06021460 RID: 136288 RVA: 0x00310C83 File Offset: 0x0030EE83
		public unsafe int StartFrameIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkTextureFrameData.__PropertyOffset_StartFrameIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkTextureFrameData.__PropertyOffset_StartFrameIndex) = value;
			}
		}

		// Token: 0x170081E4 RID: 33252
		// (get) Token: 0x06021461 RID: 136289 RVA: 0x00310C94 File Offset: 0x0030EE94
		// (set) Token: 0x06021462 RID: 136290 RVA: 0x00310CA4 File Offset: 0x0030EEA4
		public unsafe int EndFrameIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkTextureFrameData.__PropertyOffset_EndFrameIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkTextureFrameData.__PropertyOffset_EndFrameIndex) = value;
			}
		}

		// Token: 0x170081E5 RID: 33253
		// (get) Token: 0x06021463 RID: 136291 RVA: 0x00310CB5 File Offset: 0x0030EEB5
		// (set) Token: 0x06021464 RID: 136292 RVA: 0x00310CC5 File Offset: 0x0030EEC5
		public unsafe float FrameRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkTextureFrameData.__PropertyOffset_FrameRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkTextureFrameData.__PropertyOffset_FrameRate) = value;
			}
		}

		// Token: 0x170081E6 RID: 33254
		// (get) Token: 0x06021465 RID: 136293 RVA: 0x00310CD6 File Offset: 0x0030EED6
		// (set) Token: 0x06021466 RID: 136294 RVA: 0x00310CE6 File Offset: 0x0030EEE6
		public unsafe int SectionIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkTextureFrameData.__PropertyOffset_SectionIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkTextureFrameData.__PropertyOffset_SectionIndex) = value;
			}
		}

		// Token: 0x170081E7 RID: 33255
		// (get) Token: 0x06021467 RID: 136295 RVA: 0x00310CF7 File Offset: 0x0030EEF7
		// (set) Token: 0x06021468 RID: 136296 RVA: 0x00310D07 File Offset: 0x0030EF07
		public unsafe int MinLOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkTextureFrameData.__PropertyOffset_MinLOD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkTextureFrameData.__PropertyOffset_MinLOD) = value;
			}
		}

		// Token: 0x170081E8 RID: 33256
		// (get) Token: 0x06021469 RID: 136297 RVA: 0x00310D18 File Offset: 0x0030EF18
		// (set) Token: 0x0602146A RID: 136298 RVA: 0x00310D28 File Offset: 0x0030EF28
		public unsafe int MaxLOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkTextureFrameData.__PropertyOffset_MaxLOD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkTextureFrameData.__PropertyOffset_MaxLOD) = value;
			}
		}

		// Token: 0x170081E9 RID: 33257
		// (get) Token: 0x0602146B RID: 136299 RVA: 0x00310D39 File Offset: 0x0030EF39
		// (set) Token: 0x0602146C RID: 136300 RVA: 0x00310D49 File Offset: 0x0030EF49
		public unsafe int LODIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkTextureFrameData.__PropertyOffset_LODIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkTextureFrameData.__PropertyOffset_LODIndex) = value;
			}
		}

		// Token: 0x0602146D RID: 136301 RVA: 0x00310D5A File Offset: 0x0030EF5A
		public FLiveLinkTextureFrameData()
		{
		}

		// Token: 0x0602146E RID: 136302 RVA: 0x00310D64 File Offset: 0x0030EF64
		public FLiveLinkTextureFrameData(TArray<FLiveLinkTextureSingleFrame> TextureFrames, TArray<int> DataIndices, FVector2D DataLimitX, FVector2D DataLimitY, FVector2D DataLimitZ, bool hasBeenBaked, int SizeX, int SizeY, int StartFrameIndex, int EndFrameIndex, float FrameRate, int SectionIndex, int MinLOD, int MaxLOD, int LODIndex, FLiveLinkWorldTime WorldTime, FLiveLinkMetaData MetaData, TArray<float> PropertyValues)
		{
			this.TextureFrames = TextureFrames;
			this.DataIndices = DataIndices;
			this.DataLimitX = DataLimitX;
			this.DataLimitY = DataLimitY;
			this.DataLimitZ = DataLimitZ;
			this.hasBeenBaked = hasBeenBaked;
			this.SizeX = SizeX;
			this.SizeY = SizeY;
			this.StartFrameIndex = StartFrameIndex;
			this.EndFrameIndex = EndFrameIndex;
			this.FrameRate = FrameRate;
			this.SectionIndex = SectionIndex;
			this.MinLOD = MinLOD;
			this.MaxLOD = MaxLOD;
			this.LODIndex = LODIndex;
			base.WorldTime = WorldTime;
			base.MetaData = MetaData;
			base.PropertyValues = PropertyValues;
		}

		// Token: 0x0602146F RID: 136303 RVA: 0x00310E04 File Offset: 0x0030F004
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkTextureFrameData.StaticStruct();
		}

		// Token: 0x06021470 RID: 136304 RVA: 0x00310E10 File Offset: 0x0030F010
		[NullableContext(2)]
		public FLiveLinkTextureFrameData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021471 RID: 136305 RVA: 0x00310E1A File Offset: 0x0030F01A
		public FLiveLinkTextureFrameData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021472 RID: 136306 RVA: 0x00310E25 File Offset: 0x0030F025
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkTextureFrameData(Pointer, false, true);
		}

		// Token: 0x06021473 RID: 136307 RVA: 0x00310E2F File Offset: 0x0030F02F
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkTextureFrameData(Pointer, MemoryOwner);
		}

		// Token: 0x04011BEA RID: 72682
		public new const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkTextureFrameData";

		// Token: 0x04011BEB RID: 72683
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011BEC RID: 72684
		internal static int __PropertyOffset_TextureFrames;

		// Token: 0x04011BED RID: 72685
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FLiveLinkTextureSingleFrame> _TextureFrames;

		// Token: 0x04011BEE RID: 72686
		internal static int __PropertyOffset_DataIndices;

		// Token: 0x04011BEF RID: 72687
		[Nullable(2)]
		private TArray<int> _DataIndices;

		// Token: 0x04011BF0 RID: 72688
		internal static int __PropertyOffset_DataLimitX;

		// Token: 0x04011BF1 RID: 72689
		internal static int __PropertyOffset_DataLimitY;

		// Token: 0x04011BF2 RID: 72690
		internal static int __PropertyOffset_DataLimitZ;

		// Token: 0x04011BF3 RID: 72691
		internal static int __PropertyOffset_hasBeenBaked;

		// Token: 0x04011BF4 RID: 72692
		internal static int __PropertyOffset_SizeX;

		// Token: 0x04011BF5 RID: 72693
		internal static int __PropertyOffset_SizeY;

		// Token: 0x04011BF6 RID: 72694
		internal static int __PropertyOffset_StartFrameIndex;

		// Token: 0x04011BF7 RID: 72695
		internal static int __PropertyOffset_EndFrameIndex;

		// Token: 0x04011BF8 RID: 72696
		internal static int __PropertyOffset_FrameRate;

		// Token: 0x04011BF9 RID: 72697
		internal static int __PropertyOffset_SectionIndex;

		// Token: 0x04011BFA RID: 72698
		internal static int __PropertyOffset_MinLOD;

		// Token: 0x04011BFB RID: 72699
		internal static int __PropertyOffset_MaxLOD;

		// Token: 0x04011BFC RID: 72700
		internal static int __PropertyOffset_LODIndex;
	}
}
