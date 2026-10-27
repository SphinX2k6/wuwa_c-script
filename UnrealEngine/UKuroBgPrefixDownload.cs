using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016AE RID: 5806
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBackgroundDownload.KuroBgPrefixDownload")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UKuroBgPrefixDownload : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060150ED RID: 86253 RVA: 0x001EF298 File Offset: 0x001ED498
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBgPrefixDownload._ClassPtr;
		}

		// Token: 0x060150EE RID: 86254 RVA: 0x001EF2A4 File Offset: 0x001ED4A4
		public UKuroBgPrefixDownload() : this(BuiltinUtils.AllocNativeUObject(UKuroBgPrefixDownload.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060150EF RID: 86255 RVA: 0x001EF2CC File Offset: 0x001ED4CC
		public UKuroBgPrefixDownload(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroBgPrefixDownload.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005358 RID: 21336
		// (get) Token: 0x060150F0 RID: 86256 RVA: 0x001EF300 File Offset: 0x001ED500
		// (set) Token: 0x060150F1 RID: 86257 RVA: 0x001EF339 File Offset: 0x001ED539
		public FBackgroundDownloadAllCompleteDelegate AllCompleteDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FBackgroundDownloadAllCompleteDelegate result;
				if ((result = this._AllCompleteDelegate) == null)
				{
					result = (this._AllCompleteDelegate = new FBackgroundDownloadAllCompleteDelegate(base.NativePtr + (IntPtr)UKuroBgPrefixDownload.__PropertyOffset_AllCompleteDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroBgPrefixDownload.__PropertyOffset_AllCompleteDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17005359 RID: 21337
		// (get) Token: 0x060150F2 RID: 86258 RVA: 0x001EF35C File Offset: 0x001ED55C
		// (set) Token: 0x060150F3 RID: 86259 RVA: 0x001EF395 File Offset: 0x001ED595
		public FBackgroundDownloadProgressDelegate ProgressDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FBackgroundDownloadProgressDelegate result;
				if ((result = this._ProgressDelegate) == null)
				{
					result = (this._ProgressDelegate = new FBackgroundDownloadProgressDelegate(base.NativePtr + (IntPtr)UKuroBgPrefixDownload.__PropertyOffset_ProgressDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroBgPrefixDownload.__PropertyOffset_ProgressDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700535A RID: 21338
		// (get) Token: 0x060150F4 RID: 86260 RVA: 0x001EF3B8 File Offset: 0x001ED5B8
		// (set) Token: 0x060150F5 RID: 86261 RVA: 0x001EF3F1 File Offset: 0x001ED5F1
		public FBackgroundDownloadProgressDelegateNew ProgressDelegateNew
		{
			get
			{
				base.FastCheckIsValid();
				FBackgroundDownloadProgressDelegateNew result;
				if ((result = this._ProgressDelegateNew) == null)
				{
					result = (this._ProgressDelegateNew = new FBackgroundDownloadProgressDelegateNew(base.NativePtr + (IntPtr)UKuroBgPrefixDownload.__PropertyOffset_ProgressDelegateNew, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroBgPrefixDownload.__PropertyOffset_ProgressDelegateNew, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x060150F6 RID: 86262 RVA: 0x001EF414 File Offset: 0x001ED614
		public unsafe void Start(string Suffix, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> Prefixes, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FKuroRequestDownloadInfo> Targets, int InRetryCount, float InTimeout, bool bNewIOSApi, bool bAllowCell)
		{
			FString fstring = FString.AllocTemp(Suffix);
			UKuroBgPrefixDownload.__Start_Internal(base.NativePtr, fstring, (Prefixes ?? new TArray<string>()).NativePtr, (Targets ?? new TArray<FKuroRequestDownloadInfo>()).NativePtr, InRetryCount, InTimeout, bNewIOSApi, bAllowCell);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060150F7 RID: 86263 RVA: 0x001EF466 File Offset: 0x001ED666
		public int GetBpsSpeed()
		{
			return UKuroBgPrefixDownload.__GetBpsSpeed_Internal(base.NativePtr);
		}

		// Token: 0x060150F8 RID: 86264 RVA: 0x001EF473 File Offset: 0x001ED673
		public void Continue(bool bAllowCell)
		{
			UKuroBgPrefixDownload.__Continue_Internal(base.NativePtr, bAllowCell);
		}

		// Token: 0x060150F9 RID: 86265 RVA: 0x001EF481 File Offset: 0x001ED681
		public void Cancel()
		{
			UKuroBgPrefixDownload.__Cancel_Internal(base.NativePtr);
		}

		// Token: 0x060150FA RID: 86266
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Start_Internal(IntPtr @this, in FString Suffix, IntPtr Prefixes, IntPtr Targets, int InRetryCount, float InTimeout, bool bNewIOSApi, bool bAllowCell);

		// Token: 0x060150FB RID: 86267
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetBpsSpeed_Internal(IntPtr @this);

		// Token: 0x060150FC RID: 86268
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Continue_Internal(IntPtr @this, bool bAllowCell);

		// Token: 0x060150FD RID: 86269
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Cancel_Internal(IntPtr @this);

		// Token: 0x060150FE RID: 86270 RVA: 0x001EF48E File Offset: 0x001ED68E
		static UKuroBgPrefixDownload()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBackgroundDownload.KuroBgPrefixDownload");
		}

		// Token: 0x060150FF RID: 86271 RVA: 0x001EF49C File Offset: 0x001ED69C
		protected UKuroBgPrefixDownload(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B763 RID: 46947
		public new const string __ObjectPath = "/Script/KuroBackgroundDownload.KuroBgPrefixDownload";

		// Token: 0x0400B764 RID: 46948
		private static IntPtr _ClassPtr;

		// Token: 0x0400B765 RID: 46949
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B766 RID: 46950
		internal static int __PropertyOffset_AllCompleteDelegate;

		// Token: 0x0400B767 RID: 46951
		[Nullable(2)]
		private FBackgroundDownloadAllCompleteDelegate _AllCompleteDelegate;

		// Token: 0x0400B768 RID: 46952
		internal static int __PropertyOffset_ProgressDelegate;

		// Token: 0x0400B769 RID: 46953
		[Nullable(2)]
		private FBackgroundDownloadProgressDelegate _ProgressDelegate;

		// Token: 0x0400B76A RID: 46954
		internal static int __PropertyOffset_ProgressDelegateNew;

		// Token: 0x0400B76B RID: 46955
		[Nullable(2)]
		private FBackgroundDownloadProgressDelegateNew _ProgressDelegateNew;
	}
}
