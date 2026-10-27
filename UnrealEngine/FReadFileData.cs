using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001824 RID: 6180
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroEditorRuntime.ReadFileData")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FReadFileData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016D2A RID: 93482 RVA: 0x002152C6 File Offset: 0x002134C6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FReadFileData._ScriptStructPtr != 0) ? FReadFileData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroEditorRuntime.ReadFileData", ref FReadFileData._ScriptStructPtr);
		}

		// Token: 0x17005C1A RID: 23578
		// (get) Token: 0x06016D2B RID: 93483 RVA: 0x002152EA File Offset: 0x002134EA
		// (set) Token: 0x06016D2C RID: 93484 RVA: 0x002152FE File Offset: 0x002134FE
		public unsafe string FilePath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FReadFileData.__PropertyOffset_FilePath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FReadFileData.__PropertyOffset_FilePath)), value);
			}
		}

		// Token: 0x17005C1B RID: 23579
		// (get) Token: 0x06016D2D RID: 93485 RVA: 0x00215313 File Offset: 0x00213513
		// (set) Token: 0x06016D2E RID: 93486 RVA: 0x00215327 File Offset: 0x00213527
		public unsafe string FileContent
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FReadFileData.__PropertyOffset_FileContent)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FReadFileData.__PropertyOffset_FileContent)), value);
			}
		}

		// Token: 0x06016D2F RID: 93487 RVA: 0x0021533C File Offset: 0x0021353C
		public FReadFileData()
		{
		}

		// Token: 0x06016D30 RID: 93488 RVA: 0x00215344 File Offset: 0x00213544
		public FReadFileData(string FilePath, string FileContent)
		{
			this.FilePath = FilePath;
			this.FileContent = FileContent;
		}

		// Token: 0x06016D31 RID: 93489 RVA: 0x0021535A File Offset: 0x0021355A
		protected override IntPtr GetUStructPtr()
		{
			return FReadFileData.StaticStruct();
		}

		// Token: 0x06016D32 RID: 93490 RVA: 0x00215366 File Offset: 0x00213566
		[NullableContext(2)]
		public FReadFileData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016D33 RID: 93491 RVA: 0x00215370 File Offset: 0x00213570
		public FReadFileData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016D34 RID: 93492 RVA: 0x0021537B File Offset: 0x0021357B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FReadFileData(Pointer, false, true);
		}

		// Token: 0x06016D35 RID: 93493 RVA: 0x00215385 File Offset: 0x00213585
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FReadFileData(Pointer, MemoryOwner);
		}

		// Token: 0x0400C656 RID: 50774
		public const string __ObjectPath = "/Script/KuroEditorRuntime.ReadFileData";

		// Token: 0x0400C657 RID: 50775
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C658 RID: 50776
		internal static int __PropertyOffset_FilePath;

		// Token: 0x0400C659 RID: 50777
		internal static int __PropertyOffset_FileContent;
	}
}
