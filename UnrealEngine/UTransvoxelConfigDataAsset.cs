using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020026A0 RID: 9888
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Renderer.TransvoxelConfigDataAsset")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class UTransvoxelConfigDataAsset : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024B8A RID: 150410 RVA: 0x00365C57 File Offset: 0x00363E57
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTransvoxelConfigDataAsset._ClassPtr;
		}

		// Token: 0x06024B8B RID: 150411 RVA: 0x00365C64 File Offset: 0x00363E64
		public UTransvoxelConfigDataAsset() : this(BuiltinUtils.AllocNativeUObject(UTransvoxelConfigDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024B8C RID: 150412 RVA: 0x00365C8C File Offset: 0x00363E8C
		public UTransvoxelConfigDataAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTransvoxelConfigDataAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008DB1 RID: 36273
		// (get) Token: 0x06024B8D RID: 150413 RVA: 0x00365CC0 File Offset: 0x00363EC0
		// (set) Token: 0x06024B8E RID: 150414 RVA: 0x00365CF9 File Offset: 0x00363EF9
		public TArray<FTransvoxelChunkConfig> ChunkConfigs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransvoxelChunkConfig> result;
				if ((result = this._ChunkConfigs) == null)
				{
					result = (this._ChunkConfigs = new TArray<FTransvoxelChunkConfig>(base.NativePtr + (IntPtr)UTransvoxelConfigDataAsset.__PropertyOffset_ChunkConfigs, this));
				}
				return result;
			}
			set
			{
				this.ChunkConfigs.CopyAssign(value);
			}
		}

		// Token: 0x17008DB2 RID: 36274
		// (get) Token: 0x06024B8F RID: 150415 RVA: 0x00365D07 File Offset: 0x00363F07
		// (set) Token: 0x06024B90 RID: 150416 RVA: 0x00365D17 File Offset: 0x00363F17
		public unsafe int GridSizeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransvoxelConfigDataAsset.__PropertyOffset_GridSizeX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransvoxelConfigDataAsset.__PropertyOffset_GridSizeX) = value;
			}
		}

		// Token: 0x17008DB3 RID: 36275
		// (get) Token: 0x06024B91 RID: 150417 RVA: 0x00365D28 File Offset: 0x00363F28
		// (set) Token: 0x06024B92 RID: 150418 RVA: 0x00365D38 File Offset: 0x00363F38
		public unsafe int GridSizeY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransvoxelConfigDataAsset.__PropertyOffset_GridSizeY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransvoxelConfigDataAsset.__PropertyOffset_GridSizeY) = value;
			}
		}

		// Token: 0x17008DB4 RID: 36276
		// (get) Token: 0x06024B93 RID: 150419 RVA: 0x00365D49 File Offset: 0x00363F49
		// (set) Token: 0x06024B94 RID: 150420 RVA: 0x00365D59 File Offset: 0x00363F59
		public unsafe int GridSizeZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransvoxelConfigDataAsset.__PropertyOffset_GridSizeZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransvoxelConfigDataAsset.__PropertyOffset_GridSizeZ) = value;
			}
		}

		// Token: 0x17008DB5 RID: 36277
		// (get) Token: 0x06024B95 RID: 150421 RVA: 0x00365D6A File Offset: 0x00363F6A
		// (set) Token: 0x06024B96 RID: 150422 RVA: 0x00365D7A File Offset: 0x00363F7A
		public unsafe int GridOriginX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransvoxelConfigDataAsset.__PropertyOffset_GridOriginX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransvoxelConfigDataAsset.__PropertyOffset_GridOriginX) = value;
			}
		}

		// Token: 0x17008DB6 RID: 36278
		// (get) Token: 0x06024B97 RID: 150423 RVA: 0x00365D8B File Offset: 0x00363F8B
		// (set) Token: 0x06024B98 RID: 150424 RVA: 0x00365D9B File Offset: 0x00363F9B
		public unsafe int GridOriginY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransvoxelConfigDataAsset.__PropertyOffset_GridOriginY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransvoxelConfigDataAsset.__PropertyOffset_GridOriginY) = value;
			}
		}

		// Token: 0x17008DB7 RID: 36279
		// (get) Token: 0x06024B99 RID: 150425 RVA: 0x00365DAC File Offset: 0x00363FAC
		// (set) Token: 0x06024B9A RID: 150426 RVA: 0x00365DBC File Offset: 0x00363FBC
		public unsafe int GridOriginZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransvoxelConfigDataAsset.__PropertyOffset_GridOriginZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransvoxelConfigDataAsset.__PropertyOffset_GridOriginZ) = value;
			}
		}

		// Token: 0x17008DB8 RID: 36280
		// (get) Token: 0x06024B9B RID: 150427 RVA: 0x00365DCD File Offset: 0x00363FCD
		// (set) Token: 0x06024B9C RID: 150428 RVA: 0x00365DE1 File Offset: 0x00363FE1
		public unsafe FVector BaseVoxelSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransvoxelConfigDataAsset.__PropertyOffset_BaseVoxelSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransvoxelConfigDataAsset.__PropertyOffset_BaseVoxelSize) = value;
			}
		}

		// Token: 0x17008DB9 RID: 36281
		// (get) Token: 0x06024B9D RID: 150429 RVA: 0x00365DF6 File Offset: 0x00363FF6
		// (set) Token: 0x06024B9E RID: 150430 RVA: 0x00365E06 File Offset: 0x00364006
		public unsafe int VoxelRes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransvoxelConfigDataAsset.__PropertyOffset_VoxelRes);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransvoxelConfigDataAsset.__PropertyOffset_VoxelRes) = value;
			}
		}

		// Token: 0x17008DBA RID: 36282
		// (get) Token: 0x06024B9F RID: 150431 RVA: 0x00365E17 File Offset: 0x00364017
		// (set) Token: 0x06024BA0 RID: 150432 RVA: 0x00365E27 File Offset: 0x00364027
		public unsafe ETransvoxelTerrainShape TerrainShape
		{
			get
			{
				return (ETransvoxelTerrainShape)(*(base.NativePtr + (IntPtr)UTransvoxelConfigDataAsset.__PropertyOffset_TerrainShape));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransvoxelConfigDataAsset.__PropertyOffset_TerrainShape) = (byte)value;
			}
		}

		// Token: 0x17008DBB RID: 36283
		// (get) Token: 0x06024BA1 RID: 150433 RVA: 0x00365E38 File Offset: 0x00364038
		// (set) Token: 0x06024BA2 RID: 150434 RVA: 0x00365E4C File Offset: 0x0036404C
		public unsafe FVector SphereCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransvoxelConfigDataAsset.__PropertyOffset_SphereCenter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransvoxelConfigDataAsset.__PropertyOffset_SphereCenter) = value;
			}
		}

		// Token: 0x17008DBC RID: 36284
		// (get) Token: 0x06024BA3 RID: 150435 RVA: 0x00365E61 File Offset: 0x00364061
		// (set) Token: 0x06024BA4 RID: 150436 RVA: 0x00365E71 File Offset: 0x00364071
		public unsafe float SphereRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransvoxelConfigDataAsset.__PropertyOffset_SphereRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransvoxelConfigDataAsset.__PropertyOffset_SphereRadius) = value;
			}
		}

		// Token: 0x17008DBD RID: 36285
		// (get) Token: 0x06024BA5 RID: 150437 RVA: 0x00365E82 File Offset: 0x00364082
		// (set) Token: 0x06024BA6 RID: 150438 RVA: 0x00365E96 File Offset: 0x00364096
		public unsafe FVector PlanePoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransvoxelConfigDataAsset.__PropertyOffset_PlanePoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransvoxelConfigDataAsset.__PropertyOffset_PlanePoint) = value;
			}
		}

		// Token: 0x17008DBE RID: 36286
		// (get) Token: 0x06024BA7 RID: 150439 RVA: 0x00365EAB File Offset: 0x003640AB
		// (set) Token: 0x06024BA8 RID: 150440 RVA: 0x00365EBF File Offset: 0x003640BF
		public unsafe FVector PlaneNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransvoxelConfigDataAsset.__PropertyOffset_PlaneNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransvoxelConfigDataAsset.__PropertyOffset_PlaneNormal) = value;
			}
		}

		// Token: 0x17008DBF RID: 36287
		// (get) Token: 0x06024BA9 RID: 150441 RVA: 0x00365ED4 File Offset: 0x003640D4
		// (set) Token: 0x06024BAA RID: 150442 RVA: 0x00365EE4 File Offset: 0x003640E4
		public unsafe int GeneratedChunkCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransvoxelConfigDataAsset.__PropertyOffset_GeneratedChunkCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransvoxelConfigDataAsset.__PropertyOffset_GeneratedChunkCount) = value;
			}
		}

		// Token: 0x17008DC0 RID: 36288
		// (get) Token: 0x06024BAB RID: 150443 RVA: 0x00365EF5 File Offset: 0x003640F5
		// (set) Token: 0x06024BAC RID: 150444 RVA: 0x00365F05 File Offset: 0x00364105
		public unsafe bool bGeneratedDataValid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransvoxelConfigDataAsset.__PropertyOffset_bGeneratedDataValid) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransvoxelConfigDataAsset.__PropertyOffset_bGeneratedDataValid) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008DC1 RID: 36289
		// (get) Token: 0x06024BAD RID: 150445 RVA: 0x00365F16 File Offset: 0x00364116
		// (set) Token: 0x06024BAE RID: 150446 RVA: 0x00365F2A File Offset: 0x0036412A
		public unsafe string ExportOutputRelativeDir
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UTransvoxelConfigDataAsset.__PropertyOffset_ExportOutputRelativeDir)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UTransvoxelConfigDataAsset.__PropertyOffset_ExportOutputRelativeDir)), value);
			}
		}

		// Token: 0x17008DC2 RID: 36290
		// (get) Token: 0x06024BAF RID: 150447 RVA: 0x00365F3F File Offset: 0x0036413F
		// (set) Token: 0x06024BB0 RID: 150448 RVA: 0x00365F4F File Offset: 0x0036414F
		public unsafe int TestDataType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransvoxelConfigDataAsset.__PropertyOffset_TestDataType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransvoxelConfigDataAsset.__PropertyOffset_TestDataType) = value;
			}
		}

		// Token: 0x06024BB1 RID: 150449 RVA: 0x00365F60 File Offset: 0x00364160
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void GenerateTerrainData()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTransvoxelConfigDataAsset.__GenerateTerrainData_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024BB2 RID: 150450 RVA: 0x00365F75 File Offset: 0x00364175
		static UTransvoxelConfigDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Renderer.TransvoxelConfigDataAsset");
		}

		// Token: 0x06024BB3 RID: 150451 RVA: 0x00365F83 File Offset: 0x00364183
		protected UTransvoxelConfigDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013BDD RID: 80861
		public new const string __ObjectPath = "/Script/Renderer.TransvoxelConfigDataAsset";

		// Token: 0x04013BDE RID: 80862
		private static IntPtr _ClassPtr;

		// Token: 0x04013BDF RID: 80863
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013BE0 RID: 80864
		internal static int __PropertyOffset_ChunkConfigs;

		// Token: 0x04013BE1 RID: 80865
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FTransvoxelChunkConfig> _ChunkConfigs;

		// Token: 0x04013BE2 RID: 80866
		internal static int __PropertyOffset_GridSizeX;

		// Token: 0x04013BE3 RID: 80867
		internal static int __PropertyOffset_GridSizeY;

		// Token: 0x04013BE4 RID: 80868
		internal static int __PropertyOffset_GridSizeZ;

		// Token: 0x04013BE5 RID: 80869
		internal static int __PropertyOffset_GridOriginX;

		// Token: 0x04013BE6 RID: 80870
		internal static int __PropertyOffset_GridOriginY;

		// Token: 0x04013BE7 RID: 80871
		internal static int __PropertyOffset_GridOriginZ;

		// Token: 0x04013BE8 RID: 80872
		internal static int __PropertyOffset_BaseVoxelSize;

		// Token: 0x04013BE9 RID: 80873
		internal static int __PropertyOffset_VoxelRes;

		// Token: 0x04013BEA RID: 80874
		internal static int __PropertyOffset_TerrainShape;

		// Token: 0x04013BEB RID: 80875
		internal static int __PropertyOffset_SphereCenter;

		// Token: 0x04013BEC RID: 80876
		internal static int __PropertyOffset_SphereRadius;

		// Token: 0x04013BED RID: 80877
		internal static int __PropertyOffset_PlanePoint;

		// Token: 0x04013BEE RID: 80878
		internal static int __PropertyOffset_PlaneNormal;

		// Token: 0x04013BEF RID: 80879
		internal static int __PropertyOffset_GeneratedChunkCount;

		// Token: 0x04013BF0 RID: 80880
		internal static int __PropertyOffset_bGeneratedDataValid;

		// Token: 0x04013BF1 RID: 80881
		internal static int __PropertyOffset_ExportOutputRelativeDir;

		// Token: 0x04013BF2 RID: 80882
		internal static int __PropertyOffset_TestDataType;

		// Token: 0x04013BF3 RID: 80883
		private static IntPtr __GenerateTerrainData_NativeFunctionPtr;
	}
}
