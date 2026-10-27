using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200197E RID: 6526
	[UnrealObjectPath("/Script/KuroHotPatch.DownloaderProxy")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UDownloaderProxy : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060183DA RID: 99290 RVA: 0x0023C15E File Offset: 0x0023A35E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDownloaderProxy._ClassPtr;
		}

		// Token: 0x060183DB RID: 99291 RVA: 0x0023C16C File Offset: 0x0023A36C
		public UDownloaderProxy() : this(BuiltinUtils.AllocNativeUObject(UDownloaderProxy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060183DC RID: 99292 RVA: 0x0023C194 File Offset: 0x0023A394
		[NullableContext(1)]
		public UDownloaderProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDownloaderProxy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060183DD RID: 99293 RVA: 0x0023C1C7 File Offset: 0x0023A3C7
		public void UnbindCallback()
		{
			UDownloaderProxy.__UnbindCallback_Internal(base.NativePtr);
		}

		// Token: 0x060183DE RID: 99294 RVA: 0x0023C1D4 File Offset: 0x0023A3D4
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

		// Token: 0x060183DF RID: 99295 RVA: 0x0023C241 File Offset: 0x0023A441
		[NullableContext(2)]
		public void SetProgressCallback(FKuroDownloadProgress InCb)
		{
			UDownloaderProxy.__SetProgressCallback_Internal(base.NativePtr, (InCb != null) ? InCb.NativePtr : ((IntPtr)0));
		}

		// Token: 0x060183E0 RID: 99296 RVA: 0x0023C25B File Offset: 0x0023A45B
		[NullableContext(2)]
		public void SetCompleteCallback(FKuroDownloadComplete InCb)
		{
			UDownloaderProxy.__SetCompleteCallback_Internal(base.NativePtr, (InCb != null) ? InCb.NativePtr : ((IntPtr)0));
		}

		// Token: 0x060183E1 RID: 99297 RVA: 0x0023C275 File Offset: 0x0023A475
		public bool HasComplete()
		{
			return UDownloaderProxy.__HasComplete_Internal(base.NativePtr);
		}

		// Token: 0x060183E2 RID: 99298 RVA: 0x0023C282 File Offset: 0x0023A482
		public float GetTotalDownloadTime()
		{
			return UDownloaderProxy.__GetTotalDownloadTime_Internal(base.NativePtr);
		}

		// Token: 0x060183E3 RID: 99299 RVA: 0x0023C28F File Offset: 0x0023A48F
		public long GetSavedSize()
		{
			return UDownloaderProxy.__GetSavedSize_Internal(base.NativePtr);
		}

		// Token: 0x060183E4 RID: 99300 RVA: 0x0023C29C File Offset: 0x0023A49C
		public long GetReceivedSize()
		{
			return UDownloaderProxy.__GetReceivedSize_Internal(base.NativePtr);
		}

		// Token: 0x060183E5 RID: 99301 RVA: 0x0023C2A9 File Offset: 0x0023A4A9
		public long GetContentLength()
		{
			return UDownloaderProxy.__GetContentLength_Internal(base.NativePtr);
		}

		// Token: 0x060183E6 RID: 99302 RVA: 0x0023C2B6 File Offset: 0x0023A4B6
		public void Cancel()
		{
			UDownloaderProxy.__Cancel_Internal(base.NativePtr);
		}

		// Token: 0x060183E7 RID: 99303
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnbindCallback_Internal(IntPtr @this);

		// Token: 0x060183E8 RID: 99304
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Start_Internal(IntPtr @this, in FString Url, in FString SavePath, in FString Suffix, long InFileSize, float InLimitTime, bool bForceNew, bool InCache, in FString Sha1, float InTimeout, bool bNewTick);

		// Token: 0x060183E9 RID: 99305
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetProgressCallback_Internal(IntPtr @this, IntPtr InCb);

		// Token: 0x060183EA RID: 99306
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCompleteCallback_Internal(IntPtr @this, IntPtr InCb);

		// Token: 0x060183EB RID: 99307
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasComplete_Internal(IntPtr @this);

		// Token: 0x060183EC RID: 99308
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTotalDownloadTime_Internal(IntPtr @this);

		// Token: 0x060183ED RID: 99309
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern long __GetSavedSize_Internal(IntPtr @this);

		// Token: 0x060183EE RID: 99310
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern long __GetReceivedSize_Internal(IntPtr @this);

		// Token: 0x060183EF RID: 99311
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern long __GetContentLength_Internal(IntPtr @this);

		// Token: 0x060183F0 RID: 99312
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Cancel_Internal(IntPtr @this);

		// Token: 0x060183F1 RID: 99313 RVA: 0x0023C2C3 File Offset: 0x0023A4C3
		static UDownloaderProxy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroHotPatch.DownloaderProxy");
		}

		// Token: 0x060183F2 RID: 99314 RVA: 0x0023C2D1 File Offset: 0x0023A4D1
		protected UDownloaderProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D20E RID: 53774
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroHotPatch.DownloaderProxy";

		// Token: 0x0400D20F RID: 53775
		private static IntPtr _ClassPtr;

		// Token: 0x0400D210 RID: 53776
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
