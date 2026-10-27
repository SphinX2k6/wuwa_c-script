using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022F8 RID: 8952
	[UnrealObjectPath("/Script/MobilePatchingUtils.MobilePendingContent")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UMobilePendingContent : UMobileInstalledContent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021EE7 RID: 138983 RVA: 0x00322D3C File Offset: 0x00320F3C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMobilePendingContent._ClassPtr;
		}

		// Token: 0x06021EE8 RID: 138984 RVA: 0x00322D48 File Offset: 0x00320F48
		public UMobilePendingContent() : this(BuiltinUtils.AllocNativeUObject(UMobilePendingContent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021EE9 RID: 138985 RVA: 0x00322D70 File Offset: 0x00320F70
		[NullableContext(1)]
		public UMobilePendingContent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMobilePendingContent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021EEA RID: 138986 RVA: 0x00322DA3 File Offset: 0x00320FA3
		[NullableContext(2)]
		public void StartInstall(FOnContentInstallSucceeded OnSucceeded, FOnContentInstallFailed OnFailed)
		{
			UMobilePendingContent.__StartInstall_Internal(base.NativePtr, (OnSucceeded != null) ? OnSucceeded.NativePtr : ((IntPtr)0), (OnFailed != null) ? OnFailed.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06021EEB RID: 138987 RVA: 0x00322DCA File Offset: 0x00320FCA
		public float GetTotalDownloadedSize()
		{
			return UMobilePendingContent.__GetTotalDownloadedSize_Internal(base.NativePtr);
		}

		// Token: 0x06021EEC RID: 138988 RVA: 0x00322DD7 File Offset: 0x00320FD7
		public float GetRequiredDiskSpace()
		{
			return UMobilePendingContent.__GetRequiredDiskSpace_Internal(base.NativePtr);
		}

		// Token: 0x06021EED RID: 138989 RVA: 0x00322DE4 File Offset: 0x00320FE4
		public float GetInstallProgress()
		{
			return UMobilePendingContent.__GetInstallProgress_Internal(base.NativePtr);
		}

		// Token: 0x06021EEE RID: 138990 RVA: 0x00322DF1 File Offset: 0x00320FF1
		[NullableContext(1)]
		public FText GetDownloadStatusText()
		{
			return new FText(UMobilePendingContent.__GetDownloadStatusText_Internal(base.NativePtr), null);
		}

		// Token: 0x06021EEF RID: 138991 RVA: 0x00322E04 File Offset: 0x00321004
		public float GetDownloadSpeed()
		{
			return UMobilePendingContent.__GetDownloadSpeed_Internal(base.NativePtr);
		}

		// Token: 0x06021EF0 RID: 138992 RVA: 0x00322E11 File Offset: 0x00321011
		public float GetDownloadSize()
		{
			return UMobilePendingContent.__GetDownloadSize_Internal(base.NativePtr);
		}

		// Token: 0x06021EF1 RID: 138993
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartInstall_Internal(IntPtr @this, IntPtr OnSucceeded, IntPtr OnFailed);

		// Token: 0x06021EF2 RID: 138994
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTotalDownloadedSize_Internal(IntPtr @this);

		// Token: 0x06021EF3 RID: 138995
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRequiredDiskSpace_Internal(IntPtr @this);

		// Token: 0x06021EF4 RID: 138996
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetInstallProgress_Internal(IntPtr @this);

		// Token: 0x06021EF5 RID: 138997
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDownloadStatusText_Internal(IntPtr @this);

		// Token: 0x06021EF6 RID: 138998
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDownloadSpeed_Internal(IntPtr @this);

		// Token: 0x06021EF7 RID: 138999
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDownloadSize_Internal(IntPtr @this);

		// Token: 0x06021EF8 RID: 139000 RVA: 0x00322E1E File Offset: 0x0032101E
		static UMobilePendingContent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MobilePatchingUtils.MobilePendingContent");
		}

		// Token: 0x06021EF9 RID: 139001 RVA: 0x00322E2C File Offset: 0x0032102C
		protected UMobilePendingContent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040121A1 RID: 74145
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MobilePatchingUtils.MobilePendingContent";

		// Token: 0x040121A2 RID: 74146
		private static IntPtr _ClassPtr;

		// Token: 0x040121A3 RID: 74147
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
