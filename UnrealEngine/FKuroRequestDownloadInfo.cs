using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200031C RID: 796
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBackgroundDownload.KuroRequestDownloadInfo")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FKuroRequestDownloadInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060053F9 RID: 21497 RVA: 0x000757E1 File Offset: 0x000739E1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroRequestDownloadInfo._ScriptStructPtr != 0) ? FKuroRequestDownloadInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroBackgroundDownload.KuroRequestDownloadInfo", ref FKuroRequestDownloadInfo._ScriptStructPtr);
		}

		// Token: 0x17001095 RID: 4245
		// (get) Token: 0x060053FA RID: 21498 RVA: 0x00075805 File Offset: 0x00073A05
		// (set) Token: 0x060053FB RID: 21499 RVA: 0x00075819 File Offset: 0x00073A19
		public unsafe string FileName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroRequestDownloadInfo.__PropertyOffset_FileName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroRequestDownloadInfo.__PropertyOffset_FileName)), value);
			}
		}

		// Token: 0x17001096 RID: 4246
		// (get) Token: 0x060053FC RID: 21500 RVA: 0x0007582E File Offset: 0x00073A2E
		// (set) Token: 0x060053FD RID: 21501 RVA: 0x00075842 File Offset: 0x00073A42
		public unsafe string Url
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroRequestDownloadInfo.__PropertyOffset_Url)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroRequestDownloadInfo.__PropertyOffset_Url)), value);
			}
		}

		// Token: 0x17001097 RID: 4247
		// (get) Token: 0x060053FE RID: 21502 RVA: 0x00075857 File Offset: 0x00073A57
		// (set) Token: 0x060053FF RID: 21503 RVA: 0x0007586B File Offset: 0x00073A6B
		public unsafe string SavePath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroRequestDownloadInfo.__PropertyOffset_SavePath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroRequestDownloadInfo.__PropertyOffset_SavePath)), value);
			}
		}

		// Token: 0x17001098 RID: 4248
		// (get) Token: 0x06005400 RID: 21504 RVA: 0x00075880 File Offset: 0x00073A80
		// (set) Token: 0x06005401 RID: 21505 RVA: 0x00075890 File Offset: 0x00073A90
		public unsafe long Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRequestDownloadInfo.__PropertyOffset_Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRequestDownloadInfo.__PropertyOffset_Size) = value;
			}
		}

		// Token: 0x17001099 RID: 4249
		// (get) Token: 0x06005402 RID: 21506 RVA: 0x000758A1 File Offset: 0x00073AA1
		// (set) Token: 0x06005403 RID: 21507 RVA: 0x000758B5 File Offset: 0x00073AB5
		public unsafe string HashString
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroRequestDownloadInfo.__PropertyOffset_HashString)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroRequestDownloadInfo.__PropertyOffset_HashString)), value);
			}
		}

		// Token: 0x06005404 RID: 21508 RVA: 0x000758CA File Offset: 0x00073ACA
		public FKuroRequestDownloadInfo()
		{
		}

		// Token: 0x06005405 RID: 21509 RVA: 0x000758D2 File Offset: 0x00073AD2
		protected override IntPtr GetUStructPtr()
		{
			return FKuroRequestDownloadInfo.StaticStruct();
		}

		// Token: 0x06005406 RID: 21510 RVA: 0x000758DE File Offset: 0x00073ADE
		[NullableContext(2)]
		public FKuroRequestDownloadInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005407 RID: 21511 RVA: 0x000758E8 File Offset: 0x00073AE8
		public FKuroRequestDownloadInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005408 RID: 21512 RVA: 0x000758F3 File Offset: 0x00073AF3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroRequestDownloadInfo(Pointer, false, true);
		}

		// Token: 0x06005409 RID: 21513 RVA: 0x000758FD File Offset: 0x00073AFD
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroRequestDownloadInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400224C RID: 8780
		public const string __ObjectPath = "/Script/KuroBackgroundDownload.KuroRequestDownloadInfo";

		// Token: 0x0400224D RID: 8781
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400224E RID: 8782
		internal static int __PropertyOffset_FileName;

		// Token: 0x0400224F RID: 8783
		internal static int __PropertyOffset_Url;

		// Token: 0x04002250 RID: 8784
		internal static int __PropertyOffset_SavePath;

		// Token: 0x04002251 RID: 8785
		internal static int __PropertyOffset_Size;

		// Token: 0x04002252 RID: 8786
		internal static int __PropertyOffset_HashString;
	}
}
