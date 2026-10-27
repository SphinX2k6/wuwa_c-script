using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001739 RID: 5945
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroCloudGame.ClipBoardCopyStruct")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FClipBoardCopyStruct : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015659 RID: 87641 RVA: 0x001F6FB9 File Offset: 0x001F51B9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FClipBoardCopyStruct._ScriptStructPtr != 0) ? FClipBoardCopyStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroCloudGame.ClipBoardCopyStruct", ref FClipBoardCopyStruct._ScriptStructPtr);
		}

		// Token: 0x17005488 RID: 21640
		// (get) Token: 0x0601565A RID: 87642 RVA: 0x001F6FDD File Offset: 0x001F51DD
		// (set) Token: 0x0601565B RID: 87643 RVA: 0x001F6FF1 File Offset: 0x001F51F1
		public unsafe string CopyText
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FClipBoardCopyStruct.__PropertyOffset_CopyText)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FClipBoardCopyStruct.__PropertyOffset_CopyText)), value);
			}
		}

		// Token: 0x0601565C RID: 87644 RVA: 0x001F7006 File Offset: 0x001F5206
		public FClipBoardCopyStruct()
		{
		}

		// Token: 0x0601565D RID: 87645 RVA: 0x001F700E File Offset: 0x001F520E
		public FClipBoardCopyStruct(string CopyText)
		{
			this.CopyText = CopyText;
		}

		// Token: 0x0601565E RID: 87646 RVA: 0x001F701D File Offset: 0x001F521D
		protected override IntPtr GetUStructPtr()
		{
			return FClipBoardCopyStruct.StaticStruct();
		}

		// Token: 0x0601565F RID: 87647 RVA: 0x001F7029 File Offset: 0x001F5229
		[NullableContext(2)]
		public FClipBoardCopyStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015660 RID: 87648 RVA: 0x001F7033 File Offset: 0x001F5233
		public FClipBoardCopyStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015661 RID: 87649 RVA: 0x001F703E File Offset: 0x001F523E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FClipBoardCopyStruct(Pointer, false, true);
		}

		// Token: 0x06015662 RID: 87650 RVA: 0x001F7048 File Offset: 0x001F5248
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FClipBoardCopyStruct(Pointer, MemoryOwner);
		}

		// Token: 0x0400BAAF RID: 47791
		public const string __ObjectPath = "/Script/KuroCloudGame.ClipBoardCopyStruct";

		// Token: 0x0400BAB0 RID: 47792
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BAB1 RID: 47793
		internal static int __PropertyOffset_CopyText;
	}
}
