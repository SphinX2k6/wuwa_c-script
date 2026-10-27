using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020016AF RID: 5807
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBackgroundDownload.KuroRequestDownloadInfo")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FKuroRequestDownloadInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015100 RID: 86272 RVA: 0x001EF4A5 File Offset: 0x001ED6A5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroRequestDownloadInfo._ScriptStructPtr != 0) ? FKuroRequestDownloadInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroBackgroundDownload.KuroRequestDownloadInfo", ref FKuroRequestDownloadInfo._ScriptStructPtr);
		}

		// Token: 0x1700535B RID: 21339
		// (get) Token: 0x06015101 RID: 86273 RVA: 0x001EF4C9 File Offset: 0x001ED6C9
		// (set) Token: 0x06015102 RID: 86274 RVA: 0x001EF4DD File Offset: 0x001ED6DD
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

		// Token: 0x1700535C RID: 21340
		// (get) Token: 0x06015103 RID: 86275 RVA: 0x001EF4F2 File Offset: 0x001ED6F2
		// (set) Token: 0x06015104 RID: 86276 RVA: 0x001EF506 File Offset: 0x001ED706
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

		// Token: 0x1700535D RID: 21341
		// (get) Token: 0x06015105 RID: 86277 RVA: 0x001EF51B File Offset: 0x001ED71B
		// (set) Token: 0x06015106 RID: 86278 RVA: 0x001EF52F File Offset: 0x001ED72F
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

		// Token: 0x1700535E RID: 21342
		// (get) Token: 0x06015107 RID: 86279 RVA: 0x001EF544 File Offset: 0x001ED744
		// (set) Token: 0x06015108 RID: 86280 RVA: 0x001EF554 File Offset: 0x001ED754
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

		// Token: 0x1700535F RID: 21343
		// (get) Token: 0x06015109 RID: 86281 RVA: 0x001EF565 File Offset: 0x001ED765
		// (set) Token: 0x0601510A RID: 86282 RVA: 0x001EF579 File Offset: 0x001ED779
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

		// Token: 0x0601510B RID: 86283 RVA: 0x001EF58E File Offset: 0x001ED78E
		public FKuroRequestDownloadInfo()
		{
		}

		// Token: 0x0601510C RID: 86284 RVA: 0x001EF596 File Offset: 0x001ED796
		public FKuroRequestDownloadInfo(string FileName, string Url, string SavePath, long Size, string HashString)
		{
			this.FileName = FileName;
			this.Url = Url;
			this.SavePath = SavePath;
			this.Size = Size;
			this.HashString = HashString;
		}

		// Token: 0x0601510D RID: 86285 RVA: 0x001EF5C3 File Offset: 0x001ED7C3
		protected override IntPtr GetUStructPtr()
		{
			return FKuroRequestDownloadInfo.StaticStruct();
		}

		// Token: 0x0601510E RID: 86286 RVA: 0x001EF5CF File Offset: 0x001ED7CF
		[NullableContext(2)]
		public FKuroRequestDownloadInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601510F RID: 86287 RVA: 0x001EF5D9 File Offset: 0x001ED7D9
		public FKuroRequestDownloadInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015110 RID: 86288 RVA: 0x001EF5E4 File Offset: 0x001ED7E4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroRequestDownloadInfo(Pointer, false, true);
		}

		// Token: 0x06015111 RID: 86289 RVA: 0x001EF5EE File Offset: 0x001ED7EE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroRequestDownloadInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400B76C RID: 46956
		public const string __ObjectPath = "/Script/KuroBackgroundDownload.KuroRequestDownloadInfo";

		// Token: 0x0400B76D RID: 46957
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B76E RID: 46958
		internal static int __PropertyOffset_FileName;

		// Token: 0x0400B76F RID: 46959
		internal static int __PropertyOffset_Url;

		// Token: 0x0400B770 RID: 46960
		internal static int __PropertyOffset_SavePath;

		// Token: 0x0400B771 RID: 46961
		internal static int __PropertyOffset_Size;

		// Token: 0x0400B772 RID: 46962
		internal static int __PropertyOffset_HashString;
	}
}
