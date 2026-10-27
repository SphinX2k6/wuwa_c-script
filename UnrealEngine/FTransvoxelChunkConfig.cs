using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200269A RID: 9882
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Renderer.TransvoxelChunkConfig")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FTransvoxelChunkConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024B33 RID: 150323 RVA: 0x00365440 File Offset: 0x00363640
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTransvoxelChunkConfig._ScriptStructPtr != 0) ? FTransvoxelChunkConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Renderer.TransvoxelChunkConfig", ref FTransvoxelChunkConfig._ScriptStructPtr);
		}

		// Token: 0x17008D9B RID: 36251
		// (get) Token: 0x06024B34 RID: 150324 RVA: 0x00365464 File Offset: 0x00363664
		// (set) Token: 0x06024B35 RID: 150325 RVA: 0x003654A7 File Offset: 0x003636A7
		public FChunkCoord ChunkCoord
		{
			get
			{
				base.FastCheckIsValid();
				FChunkCoord result;
				if ((result = this._ChunkCoord) == null)
				{
					result = (this._ChunkCoord = new FChunkCoord(base.NativePtr + (IntPtr)FTransvoxelChunkConfig.__PropertyOffset_ChunkCoord, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FChunkCoord.StaticStruct(), base.NativePtr + (IntPtr)FTransvoxelChunkConfig.__PropertyOffset_ChunkCoord, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008D9C RID: 36252
		// (get) Token: 0x06024B36 RID: 150326 RVA: 0x003654C8 File Offset: 0x003636C8
		// (set) Token: 0x06024B37 RID: 150327 RVA: 0x003654D8 File Offset: 0x003636D8
		public unsafe int LodLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelChunkConfig.__PropertyOffset_LodLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelChunkConfig.__PropertyOffset_LodLevel) = value;
			}
		}

		// Token: 0x17008D9D RID: 36253
		// (get) Token: 0x06024B38 RID: 150328 RVA: 0x003654EC File Offset: 0x003636EC
		// (set) Token: 0x06024B39 RID: 150329 RVA: 0x0036552F File Offset: 0x0036372F
		public TArray<byte> CornerDensities
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._CornerDensities) == null)
				{
					result = (this._CornerDensities = new TArray<byte>(base.NativePtr + (IntPtr)FTransvoxelChunkConfig.__PropertyOffset_CornerDensities, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CornerDensities.CopyAssign(value);
			}
		}

		// Token: 0x17008D9E RID: 36254
		// (get) Token: 0x06024B3A RID: 150330 RVA: 0x00365540 File Offset: 0x00363740
		// (set) Token: 0x06024B3B RID: 150331 RVA: 0x00365583 File Offset: 0x00363783
		public TArray<byte> VoxelDigFlags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._VoxelDigFlags) == null)
				{
					result = (this._VoxelDigFlags = new TArray<byte>(base.NativePtr + (IntPtr)FTransvoxelChunkConfig.__PropertyOffset_VoxelDigFlags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.VoxelDigFlags.CopyAssign(value);
			}
		}

		// Token: 0x06024B3C RID: 150332 RVA: 0x00365591 File Offset: 0x00363791
		public FTransvoxelChunkConfig()
		{
		}

		// Token: 0x06024B3D RID: 150333 RVA: 0x00365599 File Offset: 0x00363799
		public FTransvoxelChunkConfig(FChunkCoord ChunkCoord, int LodLevel, TArray<byte> CornerDensities, TArray<byte> VoxelDigFlags)
		{
			this.ChunkCoord = ChunkCoord;
			this.LodLevel = LodLevel;
			this.CornerDensities = CornerDensities;
			this.VoxelDigFlags = VoxelDigFlags;
		}

		// Token: 0x06024B3E RID: 150334 RVA: 0x003655BE File Offset: 0x003637BE
		protected override IntPtr GetUStructPtr()
		{
			return FTransvoxelChunkConfig.StaticStruct();
		}

		// Token: 0x06024B3F RID: 150335 RVA: 0x003655CA File Offset: 0x003637CA
		[NullableContext(2)]
		public FTransvoxelChunkConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024B40 RID: 150336 RVA: 0x003655D4 File Offset: 0x003637D4
		public FTransvoxelChunkConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024B41 RID: 150337 RVA: 0x003655DF File Offset: 0x003637DF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTransvoxelChunkConfig(Pointer, false, true);
		}

		// Token: 0x06024B42 RID: 150338 RVA: 0x003655E9 File Offset: 0x003637E9
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTransvoxelChunkConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04013BAF RID: 80815
		public const string __ObjectPath = "/Script/Renderer.TransvoxelChunkConfig";

		// Token: 0x04013BB0 RID: 80816
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013BB1 RID: 80817
		internal static int __PropertyOffset_ChunkCoord;

		// Token: 0x04013BB2 RID: 80818
		[Nullable(2)]
		private FChunkCoord _ChunkCoord;

		// Token: 0x04013BB3 RID: 80819
		internal static int __PropertyOffset_LodLevel;

		// Token: 0x04013BB4 RID: 80820
		internal static int __PropertyOffset_CornerDensities;

		// Token: 0x04013BB5 RID: 80821
		[Nullable(2)]
		private TArray<byte> _CornerDensities;

		// Token: 0x04013BB6 RID: 80822
		internal static int __PropertyOffset_VoxelDigFlags;

		// Token: 0x04013BB7 RID: 80823
		[Nullable(2)]
		private TArray<byte> _VoxelDigFlags;
	}
}
