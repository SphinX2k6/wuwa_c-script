using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002699 RID: 9881
	[UnrealObjectPath("/Script/Renderer.TransvoxelCell")]
	[UnrealStructLayout(124, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 124)]
	public class FTransvoxelCell : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024AFD RID: 150269 RVA: 0x00365000 File Offset: 0x00363200
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTransvoxelCell._ScriptStructPtr != 0) ? FTransvoxelCell._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Renderer.TransvoxelCell", ref FTransvoxelCell._ScriptStructPtr);
		}

		// Token: 0x17008D84 RID: 36228
		// (get) Token: 0x06024AFE RID: 150270 RVA: 0x00365024 File Offset: 0x00363224
		// (set) Token: 0x06024AFF RID: 150271 RVA: 0x00365034 File Offset: 0x00363234
		public unsafe int VoxelX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_VoxelX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_VoxelX) = value;
			}
		}

		// Token: 0x17008D85 RID: 36229
		// (get) Token: 0x06024B00 RID: 150272 RVA: 0x00365045 File Offset: 0x00363245
		// (set) Token: 0x06024B01 RID: 150273 RVA: 0x00365055 File Offset: 0x00363255
		public unsafe int VoxelY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_VoxelY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_VoxelY) = value;
			}
		}

		// Token: 0x17008D86 RID: 36230
		// (get) Token: 0x06024B02 RID: 150274 RVA: 0x00365066 File Offset: 0x00363266
		// (set) Token: 0x06024B03 RID: 150275 RVA: 0x00365076 File Offset: 0x00363276
		public unsafe int VoxelZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_VoxelZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_VoxelZ) = value;
			}
		}

		// Token: 0x17008D87 RID: 36231
		// (get) Token: 0x06024B04 RID: 150276 RVA: 0x00365087 File Offset: 0x00363287
		// (set) Token: 0x06024B05 RID: 150277 RVA: 0x00365097 File Offset: 0x00363297
		public unsafe int BoundaryAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_BoundaryAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_BoundaryAxis) = value;
			}
		}

		// Token: 0x17008D88 RID: 36232
		// (get) Token: 0x06024B06 RID: 150278 RVA: 0x003650A8 File Offset: 0x003632A8
		// (set) Token: 0x06024B07 RID: 150279 RVA: 0x003650B8 File Offset: 0x003632B8
		public unsafe int BoundarySign
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_BoundarySign);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_BoundarySign) = value;
			}
		}

		// Token: 0x17008D89 RID: 36233
		// (get) Token: 0x06024B08 RID: 150280 RVA: 0x003650C9 File Offset: 0x003632C9
		// (set) Token: 0x06024B09 RID: 150281 RVA: 0x003650D9 File Offset: 0x003632D9
		public unsafe int WindingCase
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_WindingCase);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_WindingCase) = value;
			}
		}

		// Token: 0x17008D8A RID: 36234
		// (get) Token: 0x06024B0A RID: 150282 RVA: 0x003650EA File Offset: 0x003632EA
		// (set) Token: 0x06024B0B RID: 150283 RVA: 0x003650FA File Offset: 0x003632FA
		public unsafe int LodLevel0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_LodLevel0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_LodLevel0) = value;
			}
		}

		// Token: 0x17008D8B RID: 36235
		// (get) Token: 0x06024B0C RID: 150284 RVA: 0x0036510B File Offset: 0x0036330B
		// (set) Token: 0x06024B0D RID: 150285 RVA: 0x0036511B File Offset: 0x0036331B
		public unsafe int LodLevel1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_LodLevel1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_LodLevel1) = value;
			}
		}

		// Token: 0x17008D8C RID: 36236
		// (get) Token: 0x06024B0E RID: 150286 RVA: 0x0036512C File Offset: 0x0036332C
		// (set) Token: 0x06024B0F RID: 150287 RVA: 0x0036513C File Offset: 0x0036333C
		public unsafe bool IsBoundaryEdgeCell
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_IsBoundaryEdgeCell) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_IsBoundaryEdgeCell) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008D8D RID: 36237
		// (get) Token: 0x06024B10 RID: 150288 RVA: 0x0036514D File Offset: 0x0036334D
		// (set) Token: 0x06024B11 RID: 150289 RVA: 0x00365161 File Offset: 0x00363361
		public unsafe FVector Chunk0Origin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_Chunk0Origin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_Chunk0Origin) = value;
			}
		}

		// Token: 0x17008D8E RID: 36238
		// (get) Token: 0x06024B12 RID: 150290 RVA: 0x00365176 File Offset: 0x00363376
		// (set) Token: 0x06024B13 RID: 150291 RVA: 0x0036518A File Offset: 0x0036338A
		public unsafe FVector Chunk1Origin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_Chunk1Origin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_Chunk1Origin) = value;
			}
		}

		// Token: 0x17008D8F RID: 36239
		// (get) Token: 0x06024B14 RID: 150292 RVA: 0x0036519F File Offset: 0x0036339F
		// (set) Token: 0x06024B15 RID: 150293 RVA: 0x003651B3 File Offset: 0x003633B3
		public unsafe FVector ChunkLowResOrigin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_ChunkLowResOrigin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_ChunkLowResOrigin) = value;
			}
		}

		// Token: 0x17008D90 RID: 36240
		// (get) Token: 0x06024B16 RID: 150294 RVA: 0x003651C8 File Offset: 0x003633C8
		// (set) Token: 0x06024B17 RID: 150295 RVA: 0x003651D8 File Offset: 0x003633D8
		public unsafe float ChunkSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_ChunkSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_ChunkSize) = value;
			}
		}

		// Token: 0x17008D91 RID: 36241
		// (get) Token: 0x06024B18 RID: 150296 RVA: 0x003651E9 File Offset: 0x003633E9
		// (set) Token: 0x06024B19 RID: 150297 RVA: 0x003651FD File Offset: 0x003633FD
		public unsafe FVector BaseVoxelSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_BaseVoxelSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_BaseVoxelSize) = value;
			}
		}

		// Token: 0x17008D92 RID: 36242
		// (get) Token: 0x06024B1A RID: 150298 RVA: 0x00365212 File Offset: 0x00363412
		// (set) Token: 0x06024B1B RID: 150299 RVA: 0x00365222 File Offset: 0x00363422
		public unsafe int VoxelScaleLowRes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_VoxelScaleLowRes);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_VoxelScaleLowRes) = value;
			}
		}

		// Token: 0x17008D93 RID: 36243
		// (get) Token: 0x06024B1C RID: 150300 RVA: 0x00365233 File Offset: 0x00363433
		// (set) Token: 0x06024B1D RID: 150301 RVA: 0x00365243 File Offset: 0x00363443
		public unsafe int VoxelScale0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_VoxelScale0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_VoxelScale0) = value;
			}
		}

		// Token: 0x17008D94 RID: 36244
		// (get) Token: 0x06024B1E RID: 150302 RVA: 0x00365254 File Offset: 0x00363454
		// (set) Token: 0x06024B1F RID: 150303 RVA: 0x00365264 File Offset: 0x00363464
		public unsafe int VoxelScale1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_VoxelScale1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_VoxelScale1) = value;
			}
		}

		// Token: 0x17008D95 RID: 36245
		// (get) Token: 0x06024B20 RID: 150304 RVA: 0x00365275 File Offset: 0x00363475
		// (set) Token: 0x06024B21 RID: 150305 RVA: 0x00365285 File Offset: 0x00363485
		public unsafe int VoxelResChunk0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_VoxelResChunk0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_VoxelResChunk0) = value;
			}
		}

		// Token: 0x17008D96 RID: 36246
		// (get) Token: 0x06024B22 RID: 150306 RVA: 0x00365296 File Offset: 0x00363496
		// (set) Token: 0x06024B23 RID: 150307 RVA: 0x003652A6 File Offset: 0x003634A6
		public unsafe int VoxelResChunk1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_VoxelResChunk1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_VoxelResChunk1) = value;
			}
		}

		// Token: 0x17008D97 RID: 36247
		// (get) Token: 0x06024B24 RID: 150308 RVA: 0x003652B7 File Offset: 0x003634B7
		// (set) Token: 0x06024B25 RID: 150309 RVA: 0x003652C7 File Offset: 0x003634C7
		public unsafe int LodLevelChunk0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_LodLevelChunk0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_LodLevelChunk0) = value;
			}
		}

		// Token: 0x17008D98 RID: 36248
		// (get) Token: 0x06024B26 RID: 150310 RVA: 0x003652D8 File Offset: 0x003634D8
		// (set) Token: 0x06024B27 RID: 150311 RVA: 0x003652E8 File Offset: 0x003634E8
		public unsafe int LodLevelChunk1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_LodLevelChunk1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_LodLevelChunk1) = value;
			}
		}

		// Token: 0x17008D99 RID: 36249
		// (get) Token: 0x06024B28 RID: 150312 RVA: 0x003652F9 File Offset: 0x003634F9
		// (set) Token: 0x06024B29 RID: 150313 RVA: 0x00365309 File Offset: 0x00363509
		public unsafe int CornerDensityStepChunk0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_CornerDensityStepChunk0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_CornerDensityStepChunk0) = value;
			}
		}

		// Token: 0x17008D9A RID: 36250
		// (get) Token: 0x06024B2A RID: 150314 RVA: 0x0036531A File Offset: 0x0036351A
		// (set) Token: 0x06024B2B RID: 150315 RVA: 0x0036532A File Offset: 0x0036352A
		public unsafe int CornerDensityStepChunk1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_CornerDensityStepChunk1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelCell.__PropertyOffset_CornerDensityStepChunk1) = value;
			}
		}

		// Token: 0x06024B2C RID: 150316 RVA: 0x0036533B File Offset: 0x0036353B
		public FTransvoxelCell()
		{
		}

		// Token: 0x06024B2D RID: 150317 RVA: 0x00365344 File Offset: 0x00363544
		public FTransvoxelCell(int VoxelX, int VoxelY, int VoxelZ, int BoundaryAxis, int BoundarySign, int WindingCase, int LodLevel0, int LodLevel1, bool IsBoundaryEdgeCell, FVector Chunk0Origin, FVector Chunk1Origin, FVector ChunkLowResOrigin, float ChunkSize, FVector BaseVoxelSize, int VoxelScaleLowRes, int VoxelScale0, int VoxelScale1, int VoxelResChunk0, int VoxelResChunk1, int LodLevelChunk0, int LodLevelChunk1, int CornerDensityStepChunk0, int CornerDensityStepChunk1)
		{
			this.VoxelX = VoxelX;
			this.VoxelY = VoxelY;
			this.VoxelZ = VoxelZ;
			this.BoundaryAxis = BoundaryAxis;
			this.BoundarySign = BoundarySign;
			this.WindingCase = WindingCase;
			this.LodLevel0 = LodLevel0;
			this.LodLevel1 = LodLevel1;
			this.IsBoundaryEdgeCell = IsBoundaryEdgeCell;
			this.Chunk0Origin = Chunk0Origin;
			this.Chunk1Origin = Chunk1Origin;
			this.ChunkLowResOrigin = ChunkLowResOrigin;
			this.ChunkSize = ChunkSize;
			this.BaseVoxelSize = BaseVoxelSize;
			this.VoxelScaleLowRes = VoxelScaleLowRes;
			this.VoxelScale0 = VoxelScale0;
			this.VoxelScale1 = VoxelScale1;
			this.VoxelResChunk0 = VoxelResChunk0;
			this.VoxelResChunk1 = VoxelResChunk1;
			this.LodLevelChunk0 = LodLevelChunk0;
			this.LodLevelChunk1 = LodLevelChunk1;
			this.CornerDensityStepChunk0 = CornerDensityStepChunk0;
			this.CornerDensityStepChunk1 = CornerDensityStepChunk1;
		}

		// Token: 0x06024B2E RID: 150318 RVA: 0x0036540C File Offset: 0x0036360C
		protected override IntPtr GetUStructPtr()
		{
			return FTransvoxelCell.StaticStruct();
		}

		// Token: 0x06024B2F RID: 150319 RVA: 0x00365418 File Offset: 0x00363618
		[NullableContext(2)]
		public FTransvoxelCell(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024B30 RID: 150320 RVA: 0x00365422 File Offset: 0x00363622
		public FTransvoxelCell(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024B31 RID: 150321 RVA: 0x0036542D File Offset: 0x0036362D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTransvoxelCell(Pointer, false, true);
		}

		// Token: 0x06024B32 RID: 150322 RVA: 0x00365437 File Offset: 0x00363637
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTransvoxelCell(Pointer, MemoryOwner);
		}

		// Token: 0x04013B96 RID: 80790
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Renderer.TransvoxelCell";

		// Token: 0x04013B97 RID: 80791
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013B98 RID: 80792
		internal static int __PropertyOffset_VoxelX;

		// Token: 0x04013B99 RID: 80793
		internal static int __PropertyOffset_VoxelY;

		// Token: 0x04013B9A RID: 80794
		internal static int __PropertyOffset_VoxelZ;

		// Token: 0x04013B9B RID: 80795
		internal static int __PropertyOffset_BoundaryAxis;

		// Token: 0x04013B9C RID: 80796
		internal static int __PropertyOffset_BoundarySign;

		// Token: 0x04013B9D RID: 80797
		internal static int __PropertyOffset_WindingCase;

		// Token: 0x04013B9E RID: 80798
		internal static int __PropertyOffset_LodLevel0;

		// Token: 0x04013B9F RID: 80799
		internal static int __PropertyOffset_LodLevel1;

		// Token: 0x04013BA0 RID: 80800
		internal static int __PropertyOffset_IsBoundaryEdgeCell;

		// Token: 0x04013BA1 RID: 80801
		internal static int __PropertyOffset_Chunk0Origin;

		// Token: 0x04013BA2 RID: 80802
		internal static int __PropertyOffset_Chunk1Origin;

		// Token: 0x04013BA3 RID: 80803
		internal static int __PropertyOffset_ChunkLowResOrigin;

		// Token: 0x04013BA4 RID: 80804
		internal static int __PropertyOffset_ChunkSize;

		// Token: 0x04013BA5 RID: 80805
		internal static int __PropertyOffset_BaseVoxelSize;

		// Token: 0x04013BA6 RID: 80806
		internal static int __PropertyOffset_VoxelScaleLowRes;

		// Token: 0x04013BA7 RID: 80807
		internal static int __PropertyOffset_VoxelScale0;

		// Token: 0x04013BA8 RID: 80808
		internal static int __PropertyOffset_VoxelScale1;

		// Token: 0x04013BA9 RID: 80809
		internal static int __PropertyOffset_VoxelResChunk0;

		// Token: 0x04013BAA RID: 80810
		internal static int __PropertyOffset_VoxelResChunk1;

		// Token: 0x04013BAB RID: 80811
		internal static int __PropertyOffset_LodLevelChunk0;

		// Token: 0x04013BAC RID: 80812
		internal static int __PropertyOffset_LodLevelChunk1;

		// Token: 0x04013BAD RID: 80813
		internal static int __PropertyOffset_CornerDensityStepChunk0;

		// Token: 0x04013BAE RID: 80814
		internal static int __PropertyOffset_CornerDensityStepChunk1;
	}
}
