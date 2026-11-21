using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000379 RID: 889
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroEditorRuntime.ReadFileData")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FReadFileData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060059F0 RID: 23024 RVA: 0x0007F22E File Offset: 0x0007D42E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FReadFileData._ScriptStructPtr != 0) ? FReadFileData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroEditorRuntime.ReadFileData", ref FReadFileData._ScriptStructPtr);
		}

		// Token: 0x170011C7 RID: 4551
		// (get) Token: 0x060059F1 RID: 23025 RVA: 0x0007F252 File Offset: 0x0007D452
		// (set) Token: 0x060059F2 RID: 23026 RVA: 0x0007F266 File Offset: 0x0007D466
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

		// Token: 0x170011C8 RID: 4552
		// (get) Token: 0x060059F3 RID: 23027 RVA: 0x0007F27B File Offset: 0x0007D47B
		// (set) Token: 0x060059F4 RID: 23028 RVA: 0x0007F28F File Offset: 0x0007D48F
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

		// Token: 0x060059F5 RID: 23029 RVA: 0x0007F2A4 File Offset: 0x0007D4A4
		public FReadFileData()
		{
		}

		// Token: 0x060059F6 RID: 23030 RVA: 0x0007F2AC File Offset: 0x0007D4AC
		protected override IntPtr GetUStructPtr()
		{
			return FReadFileData.StaticStruct();
		}

		// Token: 0x060059F7 RID: 23031 RVA: 0x0007F2B8 File Offset: 0x0007D4B8
		[NullableContext(2)]
		public FReadFileData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060059F8 RID: 23032 RVA: 0x0007F2C2 File Offset: 0x0007D4C2
		public FReadFileData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060059F9 RID: 23033 RVA: 0x0007F2CD File Offset: 0x0007D4CD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FReadFileData(Pointer, false, true);
		}

		// Token: 0x060059FA RID: 23034 RVA: 0x0007F2D7 File Offset: 0x0007D4D7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FReadFileData(Pointer, MemoryOwner);
		}

		// Token: 0x0400254C RID: 9548
		public const string __ObjectPath = "/Script/KuroEditorRuntime.ReadFileData";

		// Token: 0x0400254D RID: 9549
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400254E RID: 9550
		internal static int __PropertyOffset_FilePath;

		// Token: 0x0400254F RID: 9551
		internal static int __PropertyOffset_FileContent;
	}
}
