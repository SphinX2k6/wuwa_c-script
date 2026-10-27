using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200269E RID: 9886
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Renderer.TransvoxelCompressedChunkData")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FTransvoxelCompressedChunkData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024B65 RID: 150373 RVA: 0x003658AA File Offset: 0x00363AAA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTransvoxelCompressedChunkData._ScriptStructPtr != 0) ? FTransvoxelCompressedChunkData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Renderer.TransvoxelCompressedChunkData", ref FTransvoxelCompressedChunkData._ScriptStructPtr);
		}

		// Token: 0x17008DA5 RID: 36261
		// (get) Token: 0x06024B66 RID: 150374 RVA: 0x003658D0 File Offset: 0x00363AD0
		// (set) Token: 0x06024B67 RID: 150375 RVA: 0x00365913 File Offset: 0x00363B13
		public FChunkCoord ChunkCoord
		{
			get
			{
				base.FastCheckIsValid();
				FChunkCoord result;
				if ((result = this._ChunkCoord) == null)
				{
					result = (this._ChunkCoord = new FChunkCoord(base.NativePtr + (IntPtr)FTransvoxelCompressedChunkData.__PropertyOffset_ChunkCoord, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FChunkCoord.StaticStruct(), base.NativePtr + (IntPtr)FTransvoxelCompressedChunkData.__PropertyOffset_ChunkCoord, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008DA6 RID: 36262
		// (get) Token: 0x06024B68 RID: 150376 RVA: 0x00365934 File Offset: 0x00363B34
		// (set) Token: 0x06024B69 RID: 150377 RVA: 0x00365944 File Offset: 0x00363B44
		public unsafe int VoxelRes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelCompressedChunkData.__PropertyOffset_VoxelRes);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelCompressedChunkData.__PropertyOffset_VoxelRes) = value;
			}
		}

		// Token: 0x17008DA7 RID: 36263
		// (get) Token: 0x06024B6A RID: 150378 RVA: 0x00365955 File Offset: 0x00363B55
		// (set) Token: 0x06024B6B RID: 150379 RVA: 0x00365965 File Offset: 0x00363B65
		public unsafe int CornerDensityStep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelCompressedChunkData.__PropertyOffset_CornerDensityStep);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelCompressedChunkData.__PropertyOffset_CornerDensityStep) = value;
			}
		}

		// Token: 0x17008DA8 RID: 36264
		// (get) Token: 0x06024B6C RID: 150380 RVA: 0x00365976 File Offset: 0x00363B76
		// (set) Token: 0x06024B6D RID: 150381 RVA: 0x00365986 File Offset: 0x00363B86
		public unsafe float DensityMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelCompressedChunkData.__PropertyOffset_DensityMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelCompressedChunkData.__PropertyOffset_DensityMin) = value;
			}
		}

		// Token: 0x17008DA9 RID: 36265
		// (get) Token: 0x06024B6E RID: 150382 RVA: 0x00365997 File Offset: 0x00363B97
		// (set) Token: 0x06024B6F RID: 150383 RVA: 0x003659A7 File Offset: 0x00363BA7
		public unsafe float DensityMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelCompressedChunkData.__PropertyOffset_DensityMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelCompressedChunkData.__PropertyOffset_DensityMax) = value;
			}
		}

		// Token: 0x17008DAA RID: 36266
		// (get) Token: 0x06024B70 RID: 150384 RVA: 0x003659B8 File Offset: 0x00363BB8
		// (set) Token: 0x06024B71 RID: 150385 RVA: 0x003659FB File Offset: 0x00363BFB
		public FTransvoxelCompressedAssetBrickPayload CornerDensity
		{
			get
			{
				base.FastCheckIsValid();
				FTransvoxelCompressedAssetBrickPayload result;
				if ((result = this._CornerDensity) == null)
				{
					result = (this._CornerDensity = new FTransvoxelCompressedAssetBrickPayload(base.NativePtr + (IntPtr)FTransvoxelCompressedChunkData.__PropertyOffset_CornerDensity, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTransvoxelCompressedAssetBrickPayload.StaticStruct(), base.NativePtr + (IntPtr)FTransvoxelCompressedChunkData.__PropertyOffset_CornerDensity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008DAB RID: 36267
		// (get) Token: 0x06024B72 RID: 150386 RVA: 0x00365A1C File Offset: 0x00363C1C
		// (set) Token: 0x06024B73 RID: 150387 RVA: 0x00365A5F File Offset: 0x00363C5F
		public FTransvoxelCompressedAssetBrickPayload CornerLockedMask
		{
			get
			{
				base.FastCheckIsValid();
				FTransvoxelCompressedAssetBrickPayload result;
				if ((result = this._CornerLockedMask) == null)
				{
					result = (this._CornerLockedMask = new FTransvoxelCompressedAssetBrickPayload(base.NativePtr + (IntPtr)FTransvoxelCompressedChunkData.__PropertyOffset_CornerLockedMask, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTransvoxelCompressedAssetBrickPayload.StaticStruct(), base.NativePtr + (IntPtr)FTransvoxelCompressedChunkData.__PropertyOffset_CornerLockedMask, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06024B74 RID: 150388 RVA: 0x00365A80 File Offset: 0x00363C80
		public FTransvoxelCompressedChunkData()
		{
		}

		// Token: 0x06024B75 RID: 150389 RVA: 0x00365A88 File Offset: 0x00363C88
		public FTransvoxelCompressedChunkData(FChunkCoord ChunkCoord, int VoxelRes, int CornerDensityStep, float DensityMin, float DensityMax, FTransvoxelCompressedAssetBrickPayload CornerDensity, FTransvoxelCompressedAssetBrickPayload CornerLockedMask)
		{
			this.ChunkCoord = ChunkCoord;
			this.VoxelRes = VoxelRes;
			this.CornerDensityStep = CornerDensityStep;
			this.DensityMin = DensityMin;
			this.DensityMax = DensityMax;
			this.CornerDensity = CornerDensity;
			this.CornerLockedMask = CornerLockedMask;
		}

		// Token: 0x06024B76 RID: 150390 RVA: 0x00365AC5 File Offset: 0x00363CC5
		protected override IntPtr GetUStructPtr()
		{
			return FTransvoxelCompressedChunkData.StaticStruct();
		}

		// Token: 0x06024B77 RID: 150391 RVA: 0x00365AD1 File Offset: 0x00363CD1
		[NullableContext(2)]
		public FTransvoxelCompressedChunkData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024B78 RID: 150392 RVA: 0x00365ADB File Offset: 0x00363CDB
		public FTransvoxelCompressedChunkData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024B79 RID: 150393 RVA: 0x00365AE6 File Offset: 0x00363CE6
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTransvoxelCompressedChunkData(Pointer, false, true);
		}

		// Token: 0x06024B7A RID: 150394 RVA: 0x00365AF0 File Offset: 0x00363CF0
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTransvoxelCompressedChunkData(Pointer, MemoryOwner);
		}

		// Token: 0x04013BC8 RID: 80840
		public const string __ObjectPath = "/Script/Renderer.TransvoxelCompressedChunkData";

		// Token: 0x04013BC9 RID: 80841
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013BCA RID: 80842
		internal static int __PropertyOffset_ChunkCoord;

		// Token: 0x04013BCB RID: 80843
		[Nullable(2)]
		private FChunkCoord _ChunkCoord;

		// Token: 0x04013BCC RID: 80844
		internal static int __PropertyOffset_VoxelRes;

		// Token: 0x04013BCD RID: 80845
		internal static int __PropertyOffset_CornerDensityStep;

		// Token: 0x04013BCE RID: 80846
		internal static int __PropertyOffset_DensityMin;

		// Token: 0x04013BCF RID: 80847
		internal static int __PropertyOffset_DensityMax;

		// Token: 0x04013BD0 RID: 80848
		internal static int __PropertyOffset_CornerDensity;

		// Token: 0x04013BD1 RID: 80849
		[Nullable(2)]
		private FTransvoxelCompressedAssetBrickPayload _CornerDensity;

		// Token: 0x04013BD2 RID: 80850
		internal static int __PropertyOffset_CornerLockedMask;

		// Token: 0x04013BD3 RID: 80851
		[Nullable(2)]
		private FTransvoxelCompressedAssetBrickPayload _CornerLockedMask;
	}
}
