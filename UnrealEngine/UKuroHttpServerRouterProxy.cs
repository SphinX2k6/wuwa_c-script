using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200047E RID: 1150
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroNetwork.KuroHttpServerRouterProxy")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class UKuroHttpServerRouterProxy : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006CA9 RID: 27817 RVA: 0x0009ECC6 File Offset: 0x0009CEC6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroHttpServerRouterProxy._ClassPtr;
		}

		// Token: 0x06006CAA RID: 27818 RVA: 0x0009ECD4 File Offset: 0x0009CED4
		public UKuroHttpServerRouterProxy() : this(BuiltinUtils.AllocNativeUObject(UKuroHttpServerRouterProxy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006CAB RID: 27819 RVA: 0x0009ECFC File Offset: 0x0009CEFC
		public UKuroHttpServerRouterProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroHttpServerRouterProxy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700157A RID: 5498
		// (get) Token: 0x06006CAC RID: 27820 RVA: 0x0009ED30 File Offset: 0x0009CF30
		// (set) Token: 0x06006CAD RID: 27821 RVA: 0x0009ED69 File Offset: 0x0009CF69
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

		// Token: 0x06006CAE RID: 27822 RVA: 0x0009ED8A File Offset: 0x0009CF8A
		public void StartServer()
		{
			UKuroHttpServerRouterProxy.__StartServer_Internal(base.NativePtr);
		}

		// Token: 0x06006CAF RID: 27823 RVA: 0x0009ED97 File Offset: 0x0009CF97
		public void CreateRouter(int Port)
		{
			UKuroHttpServerRouterProxy.__CreateRouter_Internal(base.NativePtr, Port);
		}

		// Token: 0x06006CB0 RID: 27824 RVA: 0x0009EDA8 File Offset: 0x0009CFA8
		public unsafe void BindRoute(string ModuleName)
		{
			FString fstring = FString.AllocTemp(ModuleName);
			UKuroHttpServerRouterProxy.__BindRoute_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06006CB1 RID: 27825
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartServer_Internal(IntPtr @this);

		// Token: 0x06006CB2 RID: 27826
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CreateRouter_Internal(IntPtr @this, int Port);

		// Token: 0x06006CB3 RID: 27827
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindRoute_Internal(IntPtr @this, in FString ModuleName);

		// Token: 0x06006CB4 RID: 27828 RVA: 0x0009EDD2 File Offset: 0x0009CFD2
		static UKuroHttpServerRouterProxy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroNetwork.KuroHttpServerRouterProxy");
		}

		// Token: 0x06006CB5 RID: 27829 RVA: 0x0009EDE0 File Offset: 0x0009CFE0
		protected UKuroHttpServerRouterProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002E72 RID: 11890
		public new const string __ObjectPath = "/Script/KuroNetwork.KuroHttpServerRouterProxy";

		// Token: 0x04002E73 RID: 11891
		private static IntPtr _ClassPtr;

		// Token: 0x04002E74 RID: 11892
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002E75 RID: 11893
		internal static int __PropertyOffset_HttpRequestDelegate;

		// Token: 0x04002E76 RID: 11894
		[Nullable(2)]
		private FKuroHttpRequestHandle _HttpRequestDelegate;
	}
}
