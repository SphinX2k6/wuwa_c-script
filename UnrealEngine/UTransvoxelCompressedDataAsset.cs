using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200269F RID: 9887
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Renderer.TransvoxelCompressedDataAsset")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UTransvoxelCompressedDataAsset : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024B7B RID: 150395 RVA: 0x00365AF9 File Offset: 0x00363CF9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTransvoxelCompressedDataAsset._ClassPtr;
		}

		// Token: 0x06024B7C RID: 150396 RVA: 0x00365B08 File Offset: 0x00363D08
		public UTransvoxelCompressedDataAsset() : this(BuiltinUtils.AllocNativeUObject(UTransvoxelCompressedDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024B7D RID: 150397 RVA: 0x00365B30 File Offset: 0x00363D30
		public UTransvoxelCompressedDataAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTransvoxelCompressedDataAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008DAC RID: 36268
		// (get) Token: 0x06024B7E RID: 150398 RVA: 0x00365B63 File Offset: 0x00363D63
		// (set) Token: 0x06024B7F RID: 150399 RVA: 0x00365B77 File Offset: 0x00363D77
		public unsafe FVector BaseVoxelSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransvoxelCompressedDataAsset.__PropertyOffset_BaseVoxelSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransvoxelCompressedDataAsset.__PropertyOffset_BaseVoxelSize) = value;
			}
		}

		// Token: 0x17008DAD RID: 36269
		// (get) Token: 0x06024B80 RID: 150400 RVA: 0x00365B8C File Offset: 0x00363D8C
		// (set) Token: 0x06024B81 RID: 150401 RVA: 0x00365B9C File Offset: 0x00363D9C
		public unsafe int VoxelRes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransvoxelCompressedDataAsset.__PropertyOffset_VoxelRes);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransvoxelCompressedDataAsset.__PropertyOffset_VoxelRes) = value;
			}
		}

		// Token: 0x17008DAE RID: 36270
		// (get) Token: 0x06024B82 RID: 150402 RVA: 0x00365BAD File Offset: 0x00363DAD
		// (set) Token: 0x06024B83 RID: 150403 RVA: 0x00365BC1 File Offset: 0x00363DC1
		public unsafe FIntVector GridSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransvoxelCompressedDataAsset.__PropertyOffset_GridSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransvoxelCompressedDataAsset.__PropertyOffset_GridSize) = value;
			}
		}

		// Token: 0x17008DAF RID: 36271
		// (get) Token: 0x06024B84 RID: 150404 RVA: 0x00365BD8 File Offset: 0x00363DD8
		// (set) Token: 0x06024B85 RID: 150405 RVA: 0x00365C11 File Offset: 0x00363E11
		public TArray<FTransvoxelCompressedChunkData> Chunks
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransvoxelCompressedChunkData> result;
				if ((result = this._Chunks) == null)
				{
					result = (this._Chunks = new TArray<FTransvoxelCompressedChunkData>(base.NativePtr + (IntPtr)UTransvoxelCompressedDataAsset.__PropertyOffset_Chunks, this));
				}
				return result;
			}
			set
			{
				this.Chunks.CopyAssign(value);
			}
		}

		// Token: 0x17008DB0 RID: 36272
		// (get) Token: 0x06024B86 RID: 150406 RVA: 0x00365C1F File Offset: 0x00363E1F
		// (set) Token: 0x06024B87 RID: 150407 RVA: 0x00365C2F File Offset: 0x00363E2F
		public unsafe long PayloadBytes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransvoxelCompressedDataAsset.__PropertyOffset_PayloadBytes);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransvoxelCompressedDataAsset.__PropertyOffset_PayloadBytes) = value;
			}
		}

		// Token: 0x06024B88 RID: 150408 RVA: 0x00365C40 File Offset: 0x00363E40
		static UTransvoxelCompressedDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Renderer.TransvoxelCompressedDataAsset");
		}

		// Token: 0x06024B89 RID: 150409 RVA: 0x00365C4E File Offset: 0x00363E4E
		protected UTransvoxelCompressedDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013BD4 RID: 80852
		public new const string __ObjectPath = "/Script/Renderer.TransvoxelCompressedDataAsset";

		// Token: 0x04013BD5 RID: 80853
		private static IntPtr _ClassPtr;

		// Token: 0x04013BD6 RID: 80854
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013BD7 RID: 80855
		internal static int __PropertyOffset_BaseVoxelSize;

		// Token: 0x04013BD8 RID: 80856
		internal static int __PropertyOffset_VoxelRes;

		// Token: 0x04013BD9 RID: 80857
		internal static int __PropertyOffset_GridSize;

		// Token: 0x04013BDA RID: 80858
		internal static int __PropertyOffset_Chunks;

		// Token: 0x04013BDB RID: 80859
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FTransvoxelCompressedChunkData> _Chunks;

		// Token: 0x04013BDC RID: 80860
		internal static int __PropertyOffset_PayloadBytes;
	}
}
