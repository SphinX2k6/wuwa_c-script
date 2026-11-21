using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000759 RID: 1881
	[UnrealObjectPath("/Script/MobilePatchingUtils.MobilePendingContent")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UMobilePendingContent : UMobileInstalledContent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A41B RID: 42011 RVA: 0x000F245C File Offset: 0x000F065C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMobilePendingContent._ClassPtr;
		}

		// Token: 0x0600A41C RID: 42012 RVA: 0x000F2468 File Offset: 0x000F0668
		public UMobilePendingContent() : this(BuiltinUtils.AllocNativeUObject(UMobilePendingContent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A41D RID: 42013 RVA: 0x000F2490 File Offset: 0x000F0690
		[NullableContext(1)]
		public UMobilePendingContent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMobilePendingContent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600A41E RID: 42014 RVA: 0x000F24C3 File Offset: 0x000F06C3
		[NullableContext(2)]
		public void StartInstall(FOnContentInstallSucceeded OnSucceeded, FOnContentInstallFailed OnFailed)
		{
			UMobilePendingContent.__StartInstall_Internal(base.NativePtr, (OnSucceeded != null) ? OnSucceeded.NativePtr : ((IntPtr)0), (OnFailed != null) ? OnFailed.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0600A41F RID: 42015 RVA: 0x000F24EA File Offset: 0x000F06EA
		public float GetTotalDownloadedSize()
		{
			return UMobilePendingContent.__GetTotalDownloadedSize_Internal(base.NativePtr);
		}

		// Token: 0x0600A420 RID: 42016 RVA: 0x000F24F7 File Offset: 0x000F06F7
		public float GetRequiredDiskSpace()
		{
			return UMobilePendingContent.__GetRequiredDiskSpace_Internal(base.NativePtr);
		}

		// Token: 0x0600A421 RID: 42017 RVA: 0x000F2504 File Offset: 0x000F0704
		public float GetInstallProgress()
		{
			return UMobilePendingContent.__GetInstallProgress_Internal(base.NativePtr);
		}

		// Token: 0x0600A422 RID: 42018 RVA: 0x000F2511 File Offset: 0x000F0711
		[NullableContext(1)]
		public FText GetDownloadStatusText()
		{
			return new FText(UMobilePendingContent.__GetDownloadStatusText_Internal(base.NativePtr), null);
		}

		// Token: 0x0600A423 RID: 42019 RVA: 0x000F2524 File Offset: 0x000F0724
		public float GetDownloadSpeed()
		{
			return UMobilePendingContent.__GetDownloadSpeed_Internal(base.NativePtr);
		}

		// Token: 0x0600A424 RID: 42020 RVA: 0x000F2531 File Offset: 0x000F0731
		public float GetDownloadSize()
		{
			return UMobilePendingContent.__GetDownloadSize_Internal(base.NativePtr);
		}

		// Token: 0x0600A425 RID: 42021
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartInstall_Internal(IntPtr @this, IntPtr OnSucceeded, IntPtr OnFailed);

		// Token: 0x0600A426 RID: 42022
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTotalDownloadedSize_Internal(IntPtr @this);

		// Token: 0x0600A427 RID: 42023
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRequiredDiskSpace_Internal(IntPtr @this);

		// Token: 0x0600A428 RID: 42024
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetInstallProgress_Internal(IntPtr @this);

		// Token: 0x0600A429 RID: 42025
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDownloadStatusText_Internal(IntPtr @this);

		// Token: 0x0600A42A RID: 42026
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDownloadSpeed_Internal(IntPtr @this);

		// Token: 0x0600A42B RID: 42027
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDownloadSize_Internal(IntPtr @this);

		// Token: 0x0600A42C RID: 42028 RVA: 0x000F253E File Offset: 0x000F073E
		static UMobilePendingContent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MobilePatchingUtils.MobilePendingContent");
		}

		// Token: 0x0600A42D RID: 42029 RVA: 0x000F254C File Offset: 0x000F074C
		protected UMobilePendingContent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040045FC RID: 17916
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MobilePatchingUtils.MobilePendingContent";

		// Token: 0x040045FD RID: 17917
		private static IntPtr _ClassPtr;

		// Token: 0x040045FE RID: 17918
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
