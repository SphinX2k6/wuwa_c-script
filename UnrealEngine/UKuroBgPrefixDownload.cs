using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200031B RID: 795
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBackgroundDownload.KuroBgPrefixDownload")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UKuroBgPrefixDownload : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060053E6 RID: 21478 RVA: 0x000755D4 File Offset: 0x000737D4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBgPrefixDownload._ClassPtr;
		}

		// Token: 0x060053E7 RID: 21479 RVA: 0x000755E0 File Offset: 0x000737E0
		public UKuroBgPrefixDownload() : this(BuiltinUtils.AllocNativeUObject(UKuroBgPrefixDownload.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060053E8 RID: 21480 RVA: 0x00075608 File Offset: 0x00073808
		public UKuroBgPrefixDownload(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroBgPrefixDownload.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001092 RID: 4242
		// (get) Token: 0x060053E9 RID: 21481 RVA: 0x0007563C File Offset: 0x0007383C
		// (set) Token: 0x060053EA RID: 21482 RVA: 0x00075675 File Offset: 0x00073875
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

		// Token: 0x17001093 RID: 4243
		// (get) Token: 0x060053EB RID: 21483 RVA: 0x00075698 File Offset: 0x00073898
		// (set) Token: 0x060053EC RID: 21484 RVA: 0x000756D1 File Offset: 0x000738D1
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

		// Token: 0x17001094 RID: 4244
		// (get) Token: 0x060053ED RID: 21485 RVA: 0x000756F4 File Offset: 0x000738F4
		// (set) Token: 0x060053EE RID: 21486 RVA: 0x0007572D File Offset: 0x0007392D
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

		// Token: 0x060053EF RID: 21487 RVA: 0x00075750 File Offset: 0x00073950
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

		// Token: 0x060053F0 RID: 21488 RVA: 0x000757A2 File Offset: 0x000739A2
		public int GetBpsSpeed()
		{
			return UKuroBgPrefixDownload.__GetBpsSpeed_Internal(base.NativePtr);
		}

		// Token: 0x060053F1 RID: 21489 RVA: 0x000757AF File Offset: 0x000739AF
		public void Continue(bool bAllowCell)
		{
			UKuroBgPrefixDownload.__Continue_Internal(base.NativePtr, bAllowCell);
		}

		// Token: 0x060053F2 RID: 21490 RVA: 0x000757BD File Offset: 0x000739BD
		public void Cancel()
		{
			UKuroBgPrefixDownload.__Cancel_Internal(base.NativePtr);
		}

		// Token: 0x060053F3 RID: 21491
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Start_Internal(IntPtr @this, in FString Suffix, IntPtr Prefixes, IntPtr Targets, int InRetryCount, float InTimeout, bool bNewIOSApi, bool bAllowCell);

		// Token: 0x060053F4 RID: 21492
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetBpsSpeed_Internal(IntPtr @this);

		// Token: 0x060053F5 RID: 21493
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Continue_Internal(IntPtr @this, bool bAllowCell);

		// Token: 0x060053F6 RID: 21494
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Cancel_Internal(IntPtr @this);

		// Token: 0x060053F7 RID: 21495 RVA: 0x000757CA File Offset: 0x000739CA
		static UKuroBgPrefixDownload()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBackgroundDownload.KuroBgPrefixDownload");
		}

		// Token: 0x060053F8 RID: 21496 RVA: 0x000757D8 File Offset: 0x000739D8
		protected UKuroBgPrefixDownload(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002243 RID: 8771
		public new const string __ObjectPath = "/Script/KuroBackgroundDownload.KuroBgPrefixDownload";

		// Token: 0x04002244 RID: 8772
		private static IntPtr _ClassPtr;

		// Token: 0x04002245 RID: 8773
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002246 RID: 8774
		internal static int __PropertyOffset_AllCompleteDelegate;

		// Token: 0x04002247 RID: 8775
		[Nullable(2)]
		private FBackgroundDownloadAllCompleteDelegate _AllCompleteDelegate;

		// Token: 0x04002248 RID: 8776
		internal static int __PropertyOffset_ProgressDelegate;

		// Token: 0x04002249 RID: 8777
		[Nullable(2)]
		private FBackgroundDownloadProgressDelegate _ProgressDelegate;

		// Token: 0x0400224A RID: 8778
		internal static int __PropertyOffset_ProgressDelegateNew;

		// Token: 0x0400224B RID: 8779
		[Nullable(2)]
		private FBackgroundDownloadProgressDelegateNew _ProgressDelegateNew;
	}
}
