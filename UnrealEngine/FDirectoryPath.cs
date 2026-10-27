using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020009C4 RID: 2500
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.DirectoryPath")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FDirectoryPath : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008DA3 RID: 36259 RVA: 0x000CA7E5 File Offset: 0x000C89E5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDirectoryPath._ScriptStructPtr != 0) ? FDirectoryPath._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.DirectoryPath", ref FDirectoryPath._ScriptStructPtr);
		}

		// Token: 0x1700215C RID: 8540
		// (get) Token: 0x06008DA4 RID: 36260 RVA: 0x000CA809 File Offset: 0x000C8A09
		// (set) Token: 0x06008DA5 RID: 36261 RVA: 0x000CA81D File Offset: 0x000C8A1D
		public unsafe string Path
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FDirectoryPath.__PropertyOffset_Path)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FDirectoryPath.__PropertyOffset_Path)), value);
			}
		}

		// Token: 0x06008DA6 RID: 36262 RVA: 0x000CA832 File Offset: 0x000C8A32
		public FDirectoryPath()
		{
		}

		// Token: 0x06008DA7 RID: 36263 RVA: 0x000CA83A File Offset: 0x000C8A3A
		public FDirectoryPath(string Path)
		{
			this.Path = Path;
		}

		// Token: 0x06008DA8 RID: 36264 RVA: 0x000CA849 File Offset: 0x000C8A49
		protected override IntPtr GetUStructPtr()
		{
			return FDirectoryPath.StaticStruct();
		}

		// Token: 0x06008DA9 RID: 36265 RVA: 0x000CA855 File Offset: 0x000C8A55
		[NullableContext(2)]
		public FDirectoryPath(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008DAA RID: 36266 RVA: 0x000CA85F File Offset: 0x000C8A5F
		public FDirectoryPath(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008DAB RID: 36267 RVA: 0x000CA86A File Offset: 0x000C8A6A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDirectoryPath(Pointer, false, true);
		}

		// Token: 0x06008DAC RID: 36268 RVA: 0x000CA874 File Offset: 0x000C8A74
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDirectoryPath(Pointer, MemoryOwner);
		}

		// Token: 0x0400433B RID: 17211
		public const string __ObjectPath = "/Script/Engine.DirectoryPath";

		// Token: 0x0400433C RID: 17212
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400433D RID: 17213
		internal static int __PropertyOffset_Path;
	}
}
