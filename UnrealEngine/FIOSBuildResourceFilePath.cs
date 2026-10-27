using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020015AB RID: 5547
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/IOSRuntimeSettings.IOSBuildResourceFilePath")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FIOSBuildResourceFilePath : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06013F77 RID: 81783 RVA: 0x001D509E File Offset: 0x001D329E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FIOSBuildResourceFilePath._ScriptStructPtr != 0) ? FIOSBuildResourceFilePath._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/IOSRuntimeSettings.IOSBuildResourceFilePath", ref FIOSBuildResourceFilePath._ScriptStructPtr);
		}

		// Token: 0x17004E30 RID: 20016
		// (get) Token: 0x06013F78 RID: 81784 RVA: 0x001D50C2 File Offset: 0x001D32C2
		// (set) Token: 0x06013F79 RID: 81785 RVA: 0x001D50D6 File Offset: 0x001D32D6
		public unsafe string FilePath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FIOSBuildResourceFilePath.__PropertyOffset_FilePath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FIOSBuildResourceFilePath.__PropertyOffset_FilePath)), value);
			}
		}

		// Token: 0x06013F7A RID: 81786 RVA: 0x001D50EB File Offset: 0x001D32EB
		public FIOSBuildResourceFilePath()
		{
		}

		// Token: 0x06013F7B RID: 81787 RVA: 0x001D50F3 File Offset: 0x001D32F3
		public FIOSBuildResourceFilePath(string FilePath)
		{
			this.FilePath = FilePath;
		}

		// Token: 0x06013F7C RID: 81788 RVA: 0x001D5102 File Offset: 0x001D3302
		protected override IntPtr GetUStructPtr()
		{
			return FIOSBuildResourceFilePath.StaticStruct();
		}

		// Token: 0x06013F7D RID: 81789 RVA: 0x001D510E File Offset: 0x001D330E
		[NullableContext(2)]
		public FIOSBuildResourceFilePath(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06013F7E RID: 81790 RVA: 0x001D5118 File Offset: 0x001D3318
		public FIOSBuildResourceFilePath(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06013F7F RID: 81791 RVA: 0x001D5123 File Offset: 0x001D3323
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FIOSBuildResourceFilePath(Pointer, false, true);
		}

		// Token: 0x06013F80 RID: 81792 RVA: 0x001D512D File Offset: 0x001D332D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FIOSBuildResourceFilePath(Pointer, MemoryOwner);
		}

		// Token: 0x0400AD73 RID: 44403
		public const string __ObjectPath = "/Script/IOSRuntimeSettings.IOSBuildResourceFilePath";

		// Token: 0x0400AD74 RID: 44404
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400AD75 RID: 44405
		internal static int __PropertyOffset_FilePath;
	}
}
