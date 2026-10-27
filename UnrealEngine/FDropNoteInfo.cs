using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020009DC RID: 2524
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.DropNoteInfo")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FDropNoteInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008E96 RID: 36502 RVA: 0x000CBE4A File Offset: 0x000CA04A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDropNoteInfo._ScriptStructPtr != 0) ? FDropNoteInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.DropNoteInfo", ref FDropNoteInfo._ScriptStructPtr);
		}

		// Token: 0x17002199 RID: 8601
		// (get) Token: 0x06008E97 RID: 36503 RVA: 0x000CBE6E File Offset: 0x000CA06E
		// (set) Token: 0x06008E98 RID: 36504 RVA: 0x000CBE82 File Offset: 0x000CA082
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDropNoteInfo.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDropNoteInfo.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x1700219A RID: 8602
		// (get) Token: 0x06008E99 RID: 36505 RVA: 0x000CBE97 File Offset: 0x000CA097
		// (set) Token: 0x06008E9A RID: 36506 RVA: 0x000CBEAB File Offset: 0x000CA0AB
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDropNoteInfo.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDropNoteInfo.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x1700219B RID: 8603
		// (get) Token: 0x06008E9B RID: 36507 RVA: 0x000CBEC0 File Offset: 0x000CA0C0
		// (set) Token: 0x06008E9C RID: 36508 RVA: 0x000CBED4 File Offset: 0x000CA0D4
		public unsafe string Comment
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FDropNoteInfo.__PropertyOffset_Comment)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FDropNoteInfo.__PropertyOffset_Comment)), value);
			}
		}

		// Token: 0x06008E9D RID: 36509 RVA: 0x000CBEE9 File Offset: 0x000CA0E9
		public FDropNoteInfo()
		{
		}

		// Token: 0x06008E9E RID: 36510 RVA: 0x000CBEF1 File Offset: 0x000CA0F1
		public FDropNoteInfo(FVector Location, FRotator Rotation, string Comment)
		{
			this.Location = Location;
			this.Rotation = Rotation;
			this.Comment = Comment;
		}

		// Token: 0x06008E9F RID: 36511 RVA: 0x000CBF0E File Offset: 0x000CA10E
		protected override IntPtr GetUStructPtr()
		{
			return FDropNoteInfo.StaticStruct();
		}

		// Token: 0x06008EA0 RID: 36512 RVA: 0x000CBF1A File Offset: 0x000CA11A
		[NullableContext(2)]
		public FDropNoteInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008EA1 RID: 36513 RVA: 0x000CBF24 File Offset: 0x000CA124
		public FDropNoteInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008EA2 RID: 36514 RVA: 0x000CBF2F File Offset: 0x000CA12F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDropNoteInfo(Pointer, false, true);
		}

		// Token: 0x06008EA3 RID: 36515 RVA: 0x000CBF39 File Offset: 0x000CA139
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDropNoteInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040043D3 RID: 17363
		public const string __ObjectPath = "/Script/Engine.DropNoteInfo";

		// Token: 0x040043D4 RID: 17364
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040043D5 RID: 17365
		internal static int __PropertyOffset_Location;

		// Token: 0x040043D6 RID: 17366
		internal static int __PropertyOffset_Rotation;

		// Token: 0x040043D7 RID: 17367
		internal static int __PropertyOffset_Comment;
	}
}
