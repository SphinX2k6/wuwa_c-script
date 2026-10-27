using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020017E2 RID: 6114
	[UnrealObjectPath("/Script/KuroCrowdAi.ChunkedPointCode")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FChunkedPointCode : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601694C RID: 92492 RVA: 0x0020F4F3 File Offset: 0x0020D6F3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FChunkedPointCode._ScriptStructPtr != 0) ? FChunkedPointCode._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroCrowdAi.ChunkedPointCode", ref FChunkedPointCode._ScriptStructPtr);
		}

		// Token: 0x17005B3E RID: 23358
		// (get) Token: 0x0601694D RID: 92493 RVA: 0x0020F517 File Offset: 0x0020D717
		// (set) Token: 0x0601694E RID: 92494 RVA: 0x0020F52B File Offset: 0x0020D72B
		public unsafe FIntVector ChunkCoord
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChunkedPointCode.__PropertyOffset_ChunkCoord);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChunkedPointCode.__PropertyOffset_ChunkCoord) = value;
			}
		}

		// Token: 0x17005B3F RID: 23359
		// (get) Token: 0x0601694F RID: 92495 RVA: 0x0020F540 File Offset: 0x0020D740
		// (set) Token: 0x06016950 RID: 92496 RVA: 0x0020F554 File Offset: 0x0020D754
		public unsafe FIntVector LocalCoord
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChunkedPointCode.__PropertyOffset_LocalCoord);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChunkedPointCode.__PropertyOffset_LocalCoord) = value;
			}
		}

		// Token: 0x06016951 RID: 92497 RVA: 0x0020F569 File Offset: 0x0020D769
		public FChunkedPointCode()
		{
		}

		// Token: 0x06016952 RID: 92498 RVA: 0x0020F571 File Offset: 0x0020D771
		public FChunkedPointCode(FIntVector ChunkCoord, FIntVector LocalCoord)
		{
			this.ChunkCoord = ChunkCoord;
			this.LocalCoord = LocalCoord;
		}

		// Token: 0x06016953 RID: 92499 RVA: 0x0020F587 File Offset: 0x0020D787
		protected override IntPtr GetUStructPtr()
		{
			return FChunkedPointCode.StaticStruct();
		}

		// Token: 0x06016954 RID: 92500 RVA: 0x0020F593 File Offset: 0x0020D793
		[NullableContext(2)]
		public FChunkedPointCode(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016955 RID: 92501 RVA: 0x0020F59D File Offset: 0x0020D79D
		public FChunkedPointCode(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016956 RID: 92502 RVA: 0x0020F5A8 File Offset: 0x0020D7A8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FChunkedPointCode(Pointer, false, true);
		}

		// Token: 0x06016957 RID: 92503 RVA: 0x0020F5B2 File Offset: 0x0020D7B2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FChunkedPointCode(Pointer, MemoryOwner);
		}

		// Token: 0x0400C430 RID: 50224
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroCrowdAi.ChunkedPointCode";

		// Token: 0x0400C431 RID: 50225
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C432 RID: 50226
		internal static int __PropertyOffset_ChunkCoord;

		// Token: 0x0400C433 RID: 50227
		internal static int __PropertyOffset_LocalCoord;
	}
}
