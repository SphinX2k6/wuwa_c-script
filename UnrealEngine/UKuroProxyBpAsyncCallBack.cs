using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002CE RID: 718
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/JsEnv.KuroProxyBpAsyncCallBack")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UKuroProxyBpAsyncCallBack : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004DF8 RID: 19960 RVA: 0x0006CED4 File Offset: 0x0006B0D4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroProxyBpAsyncCallBack._ClassPtr;
		}

		// Token: 0x06004DF9 RID: 19961 RVA: 0x0006CEE0 File Offset: 0x0006B0E0
		public UKuroProxyBpAsyncCallBack() : this(BuiltinUtils.AllocNativeUObject(UKuroProxyBpAsyncCallBack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004DFA RID: 19962 RVA: 0x0006CF08 File Offset: 0x0006B108
		public UKuroProxyBpAsyncCallBack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroProxyBpAsyncCallBack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000EF5 RID: 3829
		// (get) Token: 0x06004DFB RID: 19963 RVA: 0x0006CF3C File Offset: 0x0006B13C
		// (set) Token: 0x06004DFC RID: 19964 RVA: 0x0006CF75 File Offset: 0x0006B175
		public FOnProxyBpAsyncResolve OnResolve
		{
			get
			{
				base.FastCheckIsValid();
				FOnProxyBpAsyncResolve result;
				if ((result = this._OnResolve) == null)
				{
					result = (this._OnResolve = new FOnProxyBpAsyncResolve(base.NativePtr + (IntPtr)UKuroProxyBpAsyncCallBack.__PropertyOffset_OnResolve, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroProxyBpAsyncCallBack.__PropertyOffset_OnResolve, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000EF6 RID: 3830
		// (get) Token: 0x06004DFD RID: 19965 RVA: 0x0006CF98 File Offset: 0x0006B198
		// (set) Token: 0x06004DFE RID: 19966 RVA: 0x0006CFD1 File Offset: 0x0006B1D1
		public FOnProxyBpAsyncReject OnReject
		{
			get
			{
				base.FastCheckIsValid();
				FOnProxyBpAsyncReject result;
				if ((result = this._OnReject) == null)
				{
					result = (this._OnReject = new FOnProxyBpAsyncReject(base.NativePtr + (IntPtr)UKuroProxyBpAsyncCallBack.__PropertyOffset_OnReject, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroProxyBpAsyncCallBack.__PropertyOffset_OnReject, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06004DFF RID: 19967 RVA: 0x0006CFF2 File Offset: 0x0006B1F2
		static UKuroProxyBpAsyncCallBack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/JsEnv.KuroProxyBpAsyncCallBack");
		}

		// Token: 0x06004E00 RID: 19968 RVA: 0x0006D000 File Offset: 0x0006B200
		protected UKuroProxyBpAsyncCallBack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001F34 RID: 7988
		public new const string __ObjectPath = "/Script/JsEnv.KuroProxyBpAsyncCallBack";

		// Token: 0x04001F35 RID: 7989
		private static IntPtr _ClassPtr;

		// Token: 0x04001F36 RID: 7990
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001F37 RID: 7991
		internal static int __PropertyOffset_OnResolve;

		// Token: 0x04001F38 RID: 7992
		[Nullable(2)]
		private FOnProxyBpAsyncResolve _OnResolve;

		// Token: 0x04001F39 RID: 7993
		internal static int __PropertyOffset_OnReject;

		// Token: 0x04001F3A RID: 7994
		[Nullable(2)]
		private FOnProxyBpAsyncReject _OnReject;
	}
}
