using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002937 RID: 10551
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.AsyncTaskDownloadImage")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UAsyncTaskDownloadImage : UBlueprintAsyncActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602705E RID: 159838 RVA: 0x003B85FF File Offset: 0x003B67FF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAsyncTaskDownloadImage._ClassPtr;
		}

		// Token: 0x0602705F RID: 159839 RVA: 0x003B860C File Offset: 0x003B680C
		public UAsyncTaskDownloadImage() : this(BuiltinUtils.AllocNativeUObject(UAsyncTaskDownloadImage.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027060 RID: 159840 RVA: 0x003B8634 File Offset: 0x003B6834
		public UAsyncTaskDownloadImage(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAsyncTaskDownloadImage.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009629 RID: 38441
		// (get) Token: 0x06027061 RID: 159841 RVA: 0x003B8668 File Offset: 0x003B6868
		// (set) Token: 0x06027062 RID: 159842 RVA: 0x003B86A1 File Offset: 0x003B68A1
		public FDownloadImageDelegate OnSuccess
		{
			get
			{
				base.FastCheckIsValid();
				FDownloadImageDelegate result;
				if ((result = this._OnSuccess) == null)
				{
					result = (this._OnSuccess = new FDownloadImageDelegate(base.NativePtr + (IntPtr)UAsyncTaskDownloadImage.__PropertyOffset_OnSuccess, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAsyncTaskDownloadImage.__PropertyOffset_OnSuccess, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700962A RID: 38442
		// (get) Token: 0x06027063 RID: 159843 RVA: 0x003B86C4 File Offset: 0x003B68C4
		// (set) Token: 0x06027064 RID: 159844 RVA: 0x003B86FD File Offset: 0x003B68FD
		public FDownloadImageDelegate OnFail
		{
			get
			{
				base.FastCheckIsValid();
				FDownloadImageDelegate result;
				if ((result = this._OnFail) == null)
				{
					result = (this._OnFail = new FDownloadImageDelegate(base.NativePtr + (IntPtr)UAsyncTaskDownloadImage.__PropertyOffset_OnFail, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAsyncTaskDownloadImage.__PropertyOffset_OnFail, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06027065 RID: 159845 RVA: 0x003B8720 File Offset: 0x003B6920
		[return: Nullable(2)]
		public unsafe static UAsyncTaskDownloadImage DownloadImage(string URL)
		{
			FString fstring = FString.AllocTemp(URL);
			UAsyncTaskDownloadImage orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAsyncTaskDownloadImage>(UAsyncTaskDownloadImage.__DownloadImage_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06027066 RID: 159846
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __DownloadImage_Internal(in FString URL);

		// Token: 0x06027067 RID: 159847 RVA: 0x003B8749 File Offset: 0x003B6949
		static UAsyncTaskDownloadImage()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.AsyncTaskDownloadImage");
		}

		// Token: 0x06027068 RID: 159848 RVA: 0x003B8757 File Offset: 0x003B6957
		protected UAsyncTaskDownloadImage(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015721 RID: 87841
		public new const string __ObjectPath = "/Script/UMG.AsyncTaskDownloadImage";

		// Token: 0x04015722 RID: 87842
		private static IntPtr _ClassPtr;

		// Token: 0x04015723 RID: 87843
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015724 RID: 87844
		internal static int __PropertyOffset_OnSuccess;

		// Token: 0x04015725 RID: 87845
		[Nullable(2)]
		private FDownloadImageDelegate _OnSuccess;

		// Token: 0x04015726 RID: 87846
		internal static int __PropertyOffset_OnFail;

		// Token: 0x04015727 RID: 87847
		[Nullable(2)]
		private FDownloadImageDelegate _OnFail;
	}
}
