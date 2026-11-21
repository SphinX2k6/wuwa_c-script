using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200043B RID: 1083
	[UnrealObjectPath("/Script/KuroHotPatch.DownloaderProxy")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UDownloaderProxy : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060068E3 RID: 26851 RVA: 0x000992E6 File Offset: 0x000974E6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDownloaderProxy._ClassPtr;
		}

		// Token: 0x060068E4 RID: 26852 RVA: 0x000992F4 File Offset: 0x000974F4
		public UDownloaderProxy() : this(BuiltinUtils.AllocNativeUObject(UDownloaderProxy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060068E5 RID: 26853 RVA: 0x0009931C File Offset: 0x0009751C
		[NullableContext(1)]
		public UDownloaderProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDownloaderProxy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060068E6 RID: 26854 RVA: 0x0009934F File Offset: 0x0009754F
		public void UnbindCallback()
		{
			UDownloaderProxy.__UnbindCallback_Internal(base.NativePtr);
		}

		// Token: 0x060068E7 RID: 26855 RVA: 0x0009935C File Offset: 0x0009755C
		[NullableContext(1)]
		public unsafe void Start(string Url, string SavePath, string Suffix, long InFileSize, float InLimitTime, bool bForceNew, bool InCache, string Sha1, float InTimeout, bool bNewTick)
		{
			FString fstring = FString.AllocTemp(Url);
			FString fstring2 = FString.AllocTemp(SavePath);
			FString fstring3 = FString.AllocTemp(Suffix);
			FString fstring4 = FString.AllocTemp(Sha1);
			UDownloaderProxy.__Start_Internal(base.NativePtr, fstring, fstring2, fstring3, InFileSize, InLimitTime, bForceNew, InCache, fstring4, InTimeout, bNewTick);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			FString.NativeDestruct(&fstring3, 1);
			FString.NativeDestruct(&fstring4, 1);
		}

		// Token: 0x060068E8 RID: 26856 RVA: 0x000993C9 File Offset: 0x000975C9
		[NullableContext(2)]
		public void SetProgressCallback(FKuroDownloadProgress InCb)
		{
			UDownloaderProxy.__SetProgressCallback_Internal(base.NativePtr, (InCb != null) ? InCb.NativePtr : ((IntPtr)0));
		}

		// Token: 0x060068E9 RID: 26857 RVA: 0x000993E3 File Offset: 0x000975E3
		[NullableContext(2)]
		public void SetCompleteCallback(FKuroDownloadComplete InCb)
		{
			UDownloaderProxy.__SetCompleteCallback_Internal(base.NativePtr, (InCb != null) ? InCb.NativePtr : ((IntPtr)0));
		}

		// Token: 0x060068EA RID: 26858 RVA: 0x000993FD File Offset: 0x000975FD
		public bool HasComplete()
		{
			return UDownloaderProxy.__HasComplete_Internal(base.NativePtr);
		}

		// Token: 0x060068EB RID: 26859 RVA: 0x0009940A File Offset: 0x0009760A
		public float GetTotalDownloadTime()
		{
			return UDownloaderProxy.__GetTotalDownloadTime_Internal(base.NativePtr);
		}

		// Token: 0x060068EC RID: 26860 RVA: 0x00099417 File Offset: 0x00097617
		public long GetSavedSize()
		{
			return UDownloaderProxy.__GetSavedSize_Internal(base.NativePtr);
		}

		// Token: 0x060068ED RID: 26861 RVA: 0x00099424 File Offset: 0x00097624
		public long GetReceivedSize()
		{
			return UDownloaderProxy.__GetReceivedSize_Internal(base.NativePtr);
		}

		// Token: 0x060068EE RID: 26862 RVA: 0x00099431 File Offset: 0x00097631
		public long GetContentLength()
		{
			return UDownloaderProxy.__GetContentLength_Internal(base.NativePtr);
		}

		// Token: 0x060068EF RID: 26863 RVA: 0x0009943E File Offset: 0x0009763E
		public void Cancel()
		{
			UDownloaderProxy.__Cancel_Internal(base.NativePtr);
		}

		// Token: 0x060068F0 RID: 26864
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnbindCallback_Internal(IntPtr @this);

		// Token: 0x060068F1 RID: 26865
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Start_Internal(IntPtr @this, in FString Url, in FString SavePath, in FString Suffix, long InFileSize, float InLimitTime, bool bForceNew, bool InCache, in FString Sha1, float InTimeout, bool bNewTick);

		// Token: 0x060068F2 RID: 26866
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetProgressCallback_Internal(IntPtr @this, IntPtr InCb);

		// Token: 0x060068F3 RID: 26867
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCompleteCallback_Internal(IntPtr @this, IntPtr InCb);

		// Token: 0x060068F4 RID: 26868
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasComplete_Internal(IntPtr @this);

		// Token: 0x060068F5 RID: 26869
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTotalDownloadTime_Internal(IntPtr @this);

		// Token: 0x060068F6 RID: 26870
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern long __GetSavedSize_Internal(IntPtr @this);

		// Token: 0x060068F7 RID: 26871
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern long __GetReceivedSize_Internal(IntPtr @this);

		// Token: 0x060068F8 RID: 26872
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern long __GetContentLength_Internal(IntPtr @this);

		// Token: 0x060068F9 RID: 26873
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Cancel_Internal(IntPtr @this);

		// Token: 0x060068FA RID: 26874 RVA: 0x0009944B File Offset: 0x0009764B
		static UDownloaderProxy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroHotPatch.DownloaderProxy");
		}

		// Token: 0x060068FB RID: 26875 RVA: 0x00099459 File Offset: 0x00097659
		protected UDownloaderProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002CB0 RID: 11440
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroHotPatch.DownloaderProxy";

		// Token: 0x04002CB1 RID: 11441
		private static IntPtr _ClassPtr;

		// Token: 0x04002CB2 RID: 11442
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
