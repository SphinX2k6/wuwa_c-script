using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019F8 RID: 6648
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroNetwork.KuroHttpServerRouterProxy")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class UKuroHttpServerRouterProxy : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018A2C RID: 100908 RVA: 0x002454CB File Offset: 0x002436CB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroHttpServerRouterProxy._ClassPtr;
		}

		// Token: 0x06018A2D RID: 100909 RVA: 0x002454D8 File Offset: 0x002436D8
		public UKuroHttpServerRouterProxy() : this(BuiltinUtils.AllocNativeUObject(UKuroHttpServerRouterProxy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018A2E RID: 100910 RVA: 0x00245500 File Offset: 0x00243700
		public UKuroHttpServerRouterProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroHttpServerRouterProxy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170061FD RID: 25085
		// (get) Token: 0x06018A2F RID: 100911 RVA: 0x00245534 File Offset: 0x00243734
		// (set) Token: 0x06018A30 RID: 100912 RVA: 0x0024556D File Offset: 0x0024376D
		public FKuroHttpRequestHandle HttpRequestDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FKuroHttpRequestHandle result;
				if ((result = this._HttpRequestDelegate) == null)
				{
					result = (this._HttpRequestDelegate = new FKuroHttpRequestHandle(base.NativePtr + (IntPtr)UKuroHttpServerRouterProxy.__PropertyOffset_HttpRequestDelegate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroHttpServerRouterProxy.__PropertyOffset_HttpRequestDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06018A31 RID: 100913 RVA: 0x0024558E File Offset: 0x0024378E
		public void StartServer()
		{
			UKuroHttpServerRouterProxy.__StartServer_Internal(base.NativePtr);
		}

		// Token: 0x06018A32 RID: 100914 RVA: 0x0024559B File Offset: 0x0024379B
		public void CreateRouter(int Port)
		{
			UKuroHttpServerRouterProxy.__CreateRouter_Internal(base.NativePtr, Port);
		}

		// Token: 0x06018A33 RID: 100915 RVA: 0x002455AC File Offset: 0x002437AC
		public unsafe void BindRoute(string ModuleName)
		{
			FString fstring = FString.AllocTemp(ModuleName);
			UKuroHttpServerRouterProxy.__BindRoute_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06018A34 RID: 100916
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartServer_Internal(IntPtr @this);

		// Token: 0x06018A35 RID: 100917
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CreateRouter_Internal(IntPtr @this, int Port);

		// Token: 0x06018A36 RID: 100918
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindRoute_Internal(IntPtr @this, in FString ModuleName);

		// Token: 0x06018A37 RID: 100919 RVA: 0x002455D6 File Offset: 0x002437D6
		static UKuroHttpServerRouterProxy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroNetwork.KuroHttpServerRouterProxy");
		}

		// Token: 0x06018A38 RID: 100920 RVA: 0x002455E4 File Offset: 0x002437E4
		protected UKuroHttpServerRouterProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D510 RID: 54544
		public new const string __ObjectPath = "/Script/KuroNetwork.KuroHttpServerRouterProxy";

		// Token: 0x0400D511 RID: 54545
		private static IntPtr _ClassPtr;

		// Token: 0x0400D512 RID: 54546
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D513 RID: 54547
		internal static int __PropertyOffset_HttpRequestDelegate;

		// Token: 0x0400D514 RID: 54548
		[Nullable(2)]
		private FKuroHttpRequestHandle _HttpRequestDelegate;
	}
}
