using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020026A3 RID: 9891
	[UnrealObjectPath("/Script/Renderer.TransvoxelHeightMapCompressedGenerationSettings")]
	[UnrealStructLayout(44, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 44)]
	public class FTransvoxelHeightMapCompressedGenerationSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024C93 RID: 150675 RVA: 0x00366F1C File Offset: 0x0036511C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTransvoxelHeightMapCompressedGenerationSettings._ScriptStructPtr != 0) ? FTransvoxelHeightMapCompressedGenerationSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Renderer.TransvoxelHeightMapCompressedGenerationSettings", ref FTransvoxelHeightMapCompressedGenerationSettings._ScriptStructPtr);
		}

		// Token: 0x17008E22 RID: 36386
		// (get) Token: 0x06024C94 RID: 150676 RVA: 0x00366F40 File Offset: 0x00365140
		// (set) Token: 0x06024C95 RID: 150677 RVA: 0x00366F54 File Offset: 0x00365154
		public unsafe FIntVector WorldVoxelSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelHeightMapCompressedGenerationSettings.__PropertyOffset_WorldVoxelSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelHeightMapCompressedGenerationSettings.__PropertyOffset_WorldVoxelSize) = value;
			}
		}

		// Token: 0x17008E23 RID: 36387
		// (get) Token: 0x06024C96 RID: 150678 RVA: 0x00366F69 File Offset: 0x00365169
		// (set) Token: 0x06024C97 RID: 150679 RVA: 0x00366F79 File Offset: 0x00365179
		public unsafe int ChunkVoxelRes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelHeightMapCompressedGenerationSettings.__PropertyOffset_ChunkVoxelRes);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelHeightMapCompressedGenerationSettings.__PropertyOffset_ChunkVoxelRes) = value;
			}
		}

		// Token: 0x17008E24 RID: 36388
		// (get) Token: 0x06024C98 RID: 150680 RVA: 0x00366F8A File Offset: 0x0036518A
		// (set) Token: 0x06024C99 RID: 150681 RVA: 0x00366F9E File Offset: 0x0036519E
		public unsafe FVector BaseVoxelSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelHeightMapCompressedGenerationSettings.__PropertyOffset_BaseVoxelSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelHeightMapCompressedGenerationSettings.__PropertyOffset_BaseVoxelSize) = value;
			}
		}

		// Token: 0x17008E25 RID: 36389
		// (get) Token: 0x06024C9A RID: 150682 RVA: 0x00366FB3 File Offset: 0x003651B3
		// (set) Token: 0x06024C9B RID: 150683 RVA: 0x00366FC7 File Offset: 0x003651C7
		public unsafe FVector2D HeightRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelHeightMapCompressedGenerationSettings.__PropertyOffset_HeightRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelHeightMapCompressedGenerationSettings.__PropertyOffset_HeightRange) = value;
			}
		}

		// Token: 0x17008E26 RID: 36390
		// (get) Token: 0x06024C9C RID: 150684 RVA: 0x00366FDC File Offset: 0x003651DC
		// (set) Token: 0x06024C9D RID: 150685 RVA: 0x00366FEC File Offset: 0x003651EC
		public unsafe float DensityGain
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelHeightMapCompressedGenerationSettings.__PropertyOffset_DensityGain);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelHeightMapCompressedGenerationSettings.__PropertyOffset_DensityGain) = value;
			}
		}

		// Token: 0x17008E27 RID: 36391
		// (get) Token: 0x06024C9E RID: 150686 RVA: 0x00366FFD File Offset: 0x003651FD
		// (set) Token: 0x06024C9F RID: 150687 RVA: 0x0036700D File Offset: 0x0036520D
		public unsafe int BrickSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelHeightMapCompressedGenerationSettings.__PropertyOffset_BrickSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelHeightMapCompressedGenerationSettings.__PropertyOffset_BrickSize) = value;
			}
		}

		// Token: 0x06024CA0 RID: 150688 RVA: 0x0036701E File Offset: 0x0036521E
		public FTransvoxelHeightMapCompressedGenerationSettings()
		{
		}

		// Token: 0x06024CA1 RID: 150689 RVA: 0x00367026 File Offset: 0x00365226
		public FTransvoxelHeightMapCompressedGenerationSettings(FIntVector WorldVoxelSize, int ChunkVoxelRes, FVector BaseVoxelSize, FVector2D HeightRange, float DensityGain, int BrickSize)
		{
			this.WorldVoxelSize = WorldVoxelSize;
			this.ChunkVoxelRes = ChunkVoxelRes;
			this.BaseVoxelSize = BaseVoxelSize;
			this.HeightRange = HeightRange;
			this.DensityGain = DensityGain;
			this.BrickSize = BrickSize;
		}

		// Token: 0x06024CA2 RID: 150690 RVA: 0x0036705B File Offset: 0x0036525B
		protected override IntPtr GetUStructPtr()
		{
			return FTransvoxelHeightMapCompressedGenerationSettings.StaticStruct();
		}

		// Token: 0x06024CA3 RID: 150691 RVA: 0x00367067 File Offset: 0x00365267
		[NullableContext(2)]
		public FTransvoxelHeightMapCompressedGenerationSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024CA4 RID: 150692 RVA: 0x00367071 File Offset: 0x00365271
		public FTransvoxelHeightMapCompressedGenerationSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024CA5 RID: 150693 RVA: 0x0036707C File Offset: 0x0036527C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTransvoxelHeightMapCompressedGenerationSettings(Pointer, false, true);
		}

		// Token: 0x06024CA6 RID: 150694 RVA: 0x00367086 File Offset: 0x00365286
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTransvoxelHeightMapCompressedGenerationSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04013C5F RID: 80991
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Renderer.TransvoxelHeightMapCompressedGenerationSettings";

		// Token: 0x04013C60 RID: 80992
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013C61 RID: 80993
		internal static int __PropertyOffset_WorldVoxelSize;

		// Token: 0x04013C62 RID: 80994
		internal static int __PropertyOffset_ChunkVoxelRes;

		// Token: 0x04013C63 RID: 80995
		internal static int __PropertyOffset_BaseVoxelSize;

		// Token: 0x04013C64 RID: 80996
		internal static int __PropertyOffset_HeightRange;

		// Token: 0x04013C65 RID: 80997
		internal static int __PropertyOffset_DensityGain;

		// Token: 0x04013C66 RID: 80998
		internal static int __PropertyOffset_BrickSize;
	}
}
