using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A0C RID: 6668
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroNetwork.SendHttpRequest")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class USendHttpRequest : UBlueprintAsyncActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018B47 RID: 101191 RVA: 0x002472EA File Offset: 0x002454EA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USendHttpRequest._ClassPtr;
		}

		// Token: 0x06018B48 RID: 101192 RVA: 0x002472F8 File Offset: 0x002454F8
		public USendHttpRequest() : this(BuiltinUtils.AllocNativeUObject(USendHttpRequest.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018B49 RID: 101193 RVA: 0x00247320 File Offset: 0x00245520
		public USendHttpRequest(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USendHttpRequest.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006216 RID: 25110
		// (get) Token: 0x06018B4A RID: 101194 RVA: 0x00247354 File Offset: 0x00245554
		// (set) Token: 0x06018B4B RID: 101195 RVA: 0x0024738D File Offset: 0x0024558D
		public FHttpResponseDelegatge OnSuccess
		{
			get
			{
				base.FastCheckIsValid();
				FHttpResponseDelegatge result;
				if ((result = this._OnSuccess) == null)
				{
					result = (this._OnSuccess = new FHttpResponseDelegatge(base.NativePtr + (IntPtr)USendHttpRequest.__PropertyOffset_OnSuccess, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USendHttpRequest.__PropertyOffset_OnSuccess, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17006217 RID: 25111
		// (get) Token: 0x06018B4C RID: 101196 RVA: 0x002473B0 File Offset: 0x002455B0
		// (set) Token: 0x06018B4D RID: 101197 RVA: 0x002473E9 File Offset: 0x002455E9
		public FHttpResponseDelegatge OnFail
		{
			get
			{
				base.FastCheckIsValid();
				FHttpResponseDelegatge result;
				if ((result = this._OnFail) == null)
				{
					result = (this._OnFail = new FHttpResponseDelegatge(base.NativePtr + (IntPtr)USendHttpRequest.__PropertyOffset_OnFail, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USendHttpRequest.__PropertyOffset_OnFail, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06018B4E RID: 101198 RVA: 0x0024740C File Offset: 0x0024560C
		[return: Nullable(2)]
		public unsafe static USendHttpRequest HttpRequestEx(string URL, EHttpMethod Method, string PostBody, string HeaderParam)
		{
			FString fstring = FString.AllocTemp(URL);
			FString fstring2 = FString.AllocTemp(PostBody);
			FString fstring3 = FString.AllocTemp(HeaderParam);
			USendHttpRequest orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USendHttpRequest>(USendHttpRequest.__HttpRequestEx_Internal(fstring, Method, fstring2, fstring3));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			FString.NativeDestruct(&fstring3, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06018B4F RID: 101199 RVA: 0x0024745C File Offset: 0x0024565C
		[return: Nullable(2)]
		public unsafe static USendHttpRequest HttpRequest(string URL, EHttpMethod Method, string PostBody)
		{
			FString fstring = FString.AllocTemp(URL);
			FString fstring2 = FString.AllocTemp(PostBody);
			USendHttpRequest orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USendHttpRequest>(USendHttpRequest.__HttpRequest_Internal(fstring, Method, fstring2));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06018B50 RID: 101200
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __HttpRequestEx_Internal(in FString URL, EHttpMethod Method, in FString PostBody, in FString HeaderParam);

		// Token: 0x06018B51 RID: 101201
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __HttpRequest_Internal(in FString URL, EHttpMethod Method, in FString PostBody);

		// Token: 0x06018B52 RID: 101202 RVA: 0x00247498 File Offset: 0x00245698
		static USendHttpRequest()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroNetwork.SendHttpRequest");
		}

		// Token: 0x06018B53 RID: 101203 RVA: 0x002474A6 File Offset: 0x002456A6
		protected USendHttpRequest(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D574 RID: 54644
		public new const string __ObjectPath = "/Script/KuroNetwork.SendHttpRequest";

		// Token: 0x0400D575 RID: 54645
		private static IntPtr _ClassPtr;

		// Token: 0x0400D576 RID: 54646
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D577 RID: 54647
		internal static int __PropertyOffset_OnSuccess;

		// Token: 0x0400D578 RID: 54648
		[Nullable(2)]
		private FHttpResponseDelegatge _OnSuccess;

		// Token: 0x0400D579 RID: 54649
		internal static int __PropertyOffset_OnFail;

		// Token: 0x0400D57A RID: 54650
		[Nullable(2)]
		private FHttpResponseDelegatge _OnFail;
	}
}
