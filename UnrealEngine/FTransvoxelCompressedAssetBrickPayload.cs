using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200269D RID: 9885
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Renderer.TransvoxelCompressedAssetBrickPayload")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FTransvoxelCompressedAssetBrickPayload : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024B55 RID: 150357 RVA: 0x00365733 File Offset: 0x00363933
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTransvoxelCompressedAssetBrickPayload._ScriptStructPtr != 0) ? FTransvoxelCompressedAssetBrickPayload._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Renderer.TransvoxelCompressedAssetBrickPayload", ref FTransvoxelCompressedAssetBrickPayload._ScriptStructPtr);
		}

		// Token: 0x17008DA1 RID: 36257
		// (get) Token: 0x06024B56 RID: 150358 RVA: 0x00365757 File Offset: 0x00363957
		// (set) Token: 0x06024B57 RID: 150359 RVA: 0x0036576B File Offset: 0x0036396B
		public unsafe FIntVector Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelCompressedAssetBrickPayload.__PropertyOffset_Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelCompressedAssetBrickPayload.__PropertyOffset_Size) = value;
			}
		}

		// Token: 0x17008DA2 RID: 36258
		// (get) Token: 0x06024B58 RID: 150360 RVA: 0x00365780 File Offset: 0x00363980
		// (set) Token: 0x06024B59 RID: 150361 RVA: 0x00365790 File Offset: 0x00363990
		public unsafe int BrickSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelCompressedAssetBrickPayload.__PropertyOffset_BrickSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelCompressedAssetBrickPayload.__PropertyOffset_BrickSize) = value;
			}
		}

		// Token: 0x17008DA3 RID: 36259
		// (get) Token: 0x06024B5A RID: 150362 RVA: 0x003657A4 File Offset: 0x003639A4
		// (set) Token: 0x06024B5B RID: 150363 RVA: 0x003657E7 File Offset: 0x003639E7
		public TArray<FTransvoxelCompressedAssetBrickEntry> BrickTable
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransvoxelCompressedAssetBrickEntry> result;
				if ((result = this._BrickTable) == null)
				{
					result = (this._BrickTable = new TArray<FTransvoxelCompressedAssetBrickEntry>(base.NativePtr + (IntPtr)FTransvoxelCompressedAssetBrickPayload.__PropertyOffset_BrickTable, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BrickTable.CopyAssign(value);
			}
		}

		// Token: 0x17008DA4 RID: 36260
		// (get) Token: 0x06024B5C RID: 150364 RVA: 0x003657F8 File Offset: 0x003639F8
		// (set) Token: 0x06024B5D RID: 150365 RVA: 0x0036583B File Offset: 0x00363A3B
		public TArray<byte> ExpandedValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._ExpandedValues) == null)
				{
					result = (this._ExpandedValues = new TArray<byte>(base.NativePtr + (IntPtr)FTransvoxelCompressedAssetBrickPayload.__PropertyOffset_ExpandedValues, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ExpandedValues.CopyAssign(value);
			}
		}

		// Token: 0x06024B5E RID: 150366 RVA: 0x00365849 File Offset: 0x00363A49
		public FTransvoxelCompressedAssetBrickPayload()
		{
		}

		// Token: 0x06024B5F RID: 150367 RVA: 0x00365851 File Offset: 0x00363A51
		public FTransvoxelCompressedAssetBrickPayload(FIntVector Size, int BrickSize, TArray<FTransvoxelCompressedAssetBrickEntry> BrickTable, TArray<byte> ExpandedValues)
		{
			this.Size = Size;
			this.BrickSize = BrickSize;
			this.BrickTable = BrickTable;
			this.ExpandedValues = ExpandedValues;
		}

		// Token: 0x06024B60 RID: 150368 RVA: 0x00365876 File Offset: 0x00363A76
		protected override IntPtr GetUStructPtr()
		{
			return FTransvoxelCompressedAssetBrickPayload.StaticStruct();
		}

		// Token: 0x06024B61 RID: 150369 RVA: 0x00365882 File Offset: 0x00363A82
		[NullableContext(2)]
		public FTransvoxelCompressedAssetBrickPayload(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024B62 RID: 150370 RVA: 0x0036588C File Offset: 0x00363A8C
		public FTransvoxelCompressedAssetBrickPayload(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024B63 RID: 150371 RVA: 0x00365897 File Offset: 0x00363A97
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTransvoxelCompressedAssetBrickPayload(Pointer, false, true);
		}

		// Token: 0x06024B64 RID: 150372 RVA: 0x003658A1 File Offset: 0x00363AA1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTransvoxelCompressedAssetBrickPayload(Pointer, MemoryOwner);
		}

		// Token: 0x04013BC0 RID: 80832
		public const string __ObjectPath = "/Script/Renderer.TransvoxelCompressedAssetBrickPayload";

		// Token: 0x04013BC1 RID: 80833
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013BC2 RID: 80834
		internal static int __PropertyOffset_Size;

		// Token: 0x04013BC3 RID: 80835
		internal static int __PropertyOffset_BrickSize;

		// Token: 0x04013BC4 RID: 80836
		internal static int __PropertyOffset_BrickTable;

		// Token: 0x04013BC5 RID: 80837
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FTransvoxelCompressedAssetBrickEntry> _BrickTable;

		// Token: 0x04013BC6 RID: 80838
		internal static int __PropertyOffset_ExpandedValues;

		// Token: 0x04013BC7 RID: 80839
		[Nullable(2)]
		private TArray<byte> _ExpandedValues;
	}
}
