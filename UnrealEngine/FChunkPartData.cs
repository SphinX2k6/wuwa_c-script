using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000432 RID: 1074
	[UnrealObjectPath("/Script/BuildPatchServices.ChunkPartData")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FChunkPartData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060039BD RID: 14781 RVA: 0x000578EB File Offset: 0x00055AEB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FChunkPartData._ScriptStructPtr != 0) ? FChunkPartData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/BuildPatchServices.ChunkPartData", ref FChunkPartData._ScriptStructPtr);
		}

		// Token: 0x17000DBD RID: 3517
		// (get) Token: 0x060039BE RID: 14782 RVA: 0x0005790F File Offset: 0x00055B0F
		// (set) Token: 0x060039BF RID: 14783 RVA: 0x00057923 File Offset: 0x00055B23
		public unsafe FGuid Guid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChunkPartData.__PropertyOffset_Guid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChunkPartData.__PropertyOffset_Guid) = value;
			}
		}

		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x060039C0 RID: 14784 RVA: 0x00057938 File Offset: 0x00055B38
		// (set) Token: 0x060039C1 RID: 14785 RVA: 0x00057948 File Offset: 0x00055B48
		public unsafe uint Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChunkPartData.__PropertyOffset_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChunkPartData.__PropertyOffset_Offset) = (int)value;
			}
		}

		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x060039C2 RID: 14786 RVA: 0x00057959 File Offset: 0x00055B59
		// (set) Token: 0x060039C3 RID: 14787 RVA: 0x00057969 File Offset: 0x00055B69
		public unsafe uint Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChunkPartData.__PropertyOffset_Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChunkPartData.__PropertyOffset_Size) = (int)value;
			}
		}

		// Token: 0x060039C4 RID: 14788 RVA: 0x0005797A File Offset: 0x00055B7A
		public FChunkPartData()
		{
		}

		// Token: 0x060039C5 RID: 14789 RVA: 0x00057982 File Offset: 0x00055B82
		public FChunkPartData(FGuid Guid, uint Offset, uint Size)
		{
			this.Guid = Guid;
			this.Offset = Offset;
			this.Size = Size;
		}

		// Token: 0x060039C6 RID: 14790 RVA: 0x0005799F File Offset: 0x00055B9F
		protected override IntPtr GetUStructPtr()
		{
			return FChunkPartData.StaticStruct();
		}

		// Token: 0x060039C7 RID: 14791 RVA: 0x000579AB File Offset: 0x00055BAB
		[NullableContext(2)]
		public FChunkPartData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060039C8 RID: 14792 RVA: 0x000579B5 File Offset: 0x00055BB5
		public FChunkPartData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060039C9 RID: 14793 RVA: 0x000579C0 File Offset: 0x00055BC0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FChunkPartData(Pointer, false, true);
		}

		// Token: 0x060039CA RID: 14794 RVA: 0x000579CA File Offset: 0x00055BCA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FChunkPartData(Pointer, MemoryOwner);
		}

		// Token: 0x04001A52 RID: 6738
		[Nullable(1)]
		public const string __ObjectPath = "/Script/BuildPatchServices.ChunkPartData";

		// Token: 0x04001A53 RID: 6739
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001A54 RID: 6740
		internal static int __PropertyOffset_Guid;

		// Token: 0x04001A55 RID: 6741
		internal static int __PropertyOffset_Offset;

		// Token: 0x04001A56 RID: 6742
		internal static int __PropertyOffset_Size;
	}
}
