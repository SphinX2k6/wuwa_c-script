using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015B8 RID: 5560
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/JsEnv.KuroProxyBpAsyncCallBack")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UKuroProxyBpAsyncCallBack : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601411A RID: 82202 RVA: 0x001D7336 File Offset: 0x001D5536
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroProxyBpAsyncCallBack._ClassPtr;
		}

		// Token: 0x0601411B RID: 82203 RVA: 0x001D7344 File Offset: 0x001D5544
		public UKuroProxyBpAsyncCallBack() : this(BuiltinUtils.AllocNativeUObject(UKuroProxyBpAsyncCallBack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601411C RID: 82204 RVA: 0x001D736C File Offset: 0x001D556C
		public UKuroProxyBpAsyncCallBack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroProxyBpAsyncCallBack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004EAD RID: 20141
		// (get) Token: 0x0601411D RID: 82205 RVA: 0x001D73A0 File Offset: 0x001D55A0
		// (set) Token: 0x0601411E RID: 82206 RVA: 0x001D73D9 File Offset: 0x001D55D9
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

		// Token: 0x17004EAE RID: 20142
		// (get) Token: 0x0601411F RID: 82207 RVA: 0x001D73FC File Offset: 0x001D55FC
		// (set) Token: 0x06014120 RID: 82208 RVA: 0x001D7435 File Offset: 0x001D5635
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

		// Token: 0x06014121 RID: 82209 RVA: 0x001D7456 File Offset: 0x001D5656
		static UKuroProxyBpAsyncCallBack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/JsEnv.KuroProxyBpAsyncCallBack");
		}

		// Token: 0x06014122 RID: 82210 RVA: 0x001D7464 File Offset: 0x001D5664
		protected UKuroProxyBpAsyncCallBack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AE91 RID: 44689
		public new const string __ObjectPath = "/Script/JsEnv.KuroProxyBpAsyncCallBack";

		// Token: 0x0400AE92 RID: 44690
		private static IntPtr _ClassPtr;

		// Token: 0x0400AE93 RID: 44691
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AE94 RID: 44692
		internal static int __PropertyOffset_OnResolve;

		// Token: 0x0400AE95 RID: 44693
		[Nullable(2)]
		private FOnProxyBpAsyncResolve _OnResolve;

		// Token: 0x0400AE96 RID: 44694
		internal static int __PropertyOffset_OnReject;

		// Token: 0x0400AE97 RID: 44695
		[Nullable(2)]
		private FOnProxyBpAsyncReject _OnReject;
	}
}
