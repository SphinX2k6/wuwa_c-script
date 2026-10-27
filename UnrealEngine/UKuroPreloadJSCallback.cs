using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015B6 RID: 5558
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/JsEnv.KuroPreloadJSCallback")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UKuroPreloadJSCallback : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601410A RID: 82186 RVA: 0x001D7156 File Offset: 0x001D5356
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPreloadJSCallback._ClassPtr;
		}

		// Token: 0x0601410B RID: 82187 RVA: 0x001D7164 File Offset: 0x001D5364
		public UKuroPreloadJSCallback() : this(BuiltinUtils.AllocNativeUObject(UKuroPreloadJSCallback.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601410C RID: 82188 RVA: 0x001D718C File Offset: 0x001D538C
		public UKuroPreloadJSCallback(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPreloadJSCallback.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004EAC RID: 20140
		// (get) Token: 0x0601410D RID: 82189 RVA: 0x001D71C0 File Offset: 0x001D53C0
		// (set) Token: 0x0601410E RID: 82190 RVA: 0x001D71F9 File Offset: 0x001D53F9
		public FKuroPreloadJSCompletedDelegate CompletedDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FKuroPreloadJSCompletedDelegate result;
				if ((result = this._CompletedDelegate) == null)
				{
					result = (this._CompletedDelegate = new FKuroPreloadJSCompletedDelegate(base.NativePtr + (IntPtr)UKuroPreloadJSCallback.__PropertyOffset_CompletedDelegate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroPreloadJSCallback.__PropertyOffset_CompletedDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0601410F RID: 82191 RVA: 0x001D721A File Offset: 0x001D541A
		static UKuroPreloadJSCallback()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/JsEnv.KuroPreloadJSCallback");
		}

		// Token: 0x06014110 RID: 82192 RVA: 0x001D7228 File Offset: 0x001D5428
		protected UKuroPreloadJSCallback(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AE89 RID: 44681
		public new const string __ObjectPath = "/Script/JsEnv.KuroPreloadJSCallback";

		// Token: 0x0400AE8A RID: 44682
		private static IntPtr _ClassPtr;

		// Token: 0x0400AE8B RID: 44683
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AE8C RID: 44684
		internal static int __PropertyOffset_CompletedDelegate;

		// Token: 0x0400AE8D RID: 44685
		[Nullable(2)]
		private FKuroPreloadJSCompletedDelegate _CompletedDelegate;
	}
}
