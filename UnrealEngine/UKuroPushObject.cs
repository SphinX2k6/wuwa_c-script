using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200049F RID: 1183
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroPushSdk.KuroPushObject")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UKuroPushObject : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006E2E RID: 28206 RVA: 0x000A22EE File Offset: 0x000A04EE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPushObject._ClassPtr;
		}

		// Token: 0x06006E2F RID: 28207 RVA: 0x000A22FC File Offset: 0x000A04FC
		public UKuroPushObject() : this(BuiltinUtils.AllocNativeUObject(UKuroPushObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006E30 RID: 28208 RVA: 0x000A2324 File Offset: 0x000A0524
		public UKuroPushObject(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPushObject.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001589 RID: 5513
		// (get) Token: 0x06006E31 RID: 28209 RVA: 0x000A2358 File Offset: 0x000A0558
		// (set) Token: 0x06006E32 RID: 28210 RVA: 0x000A2391 File Offset: 0x000A0591
		public FPushSdkMessageBluePrintDelegate PushSdkMessageBluePrintDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FPushSdkMessageBluePrintDelegate result;
				if ((result = this._PushSdkMessageBluePrintDelegate) == null)
				{
					result = (this._PushSdkMessageBluePrintDelegate = new FPushSdkMessageBluePrintDelegate(base.NativePtr + (IntPtr)UKuroPushObject.__PropertyOffset_PushSdkMessageBluePrintDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroPushObject.__PropertyOffset_PushSdkMessageBluePrintDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700158A RID: 5514
		// (get) Token: 0x06006E33 RID: 28211 RVA: 0x000A23B4 File Offset: 0x000A05B4
		// (set) Token: 0x06006E34 RID: 28212 RVA: 0x000A23ED File Offset: 0x000A05ED
		public FAllowedNotificationsDelegate AllowedNotificationsDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FAllowedNotificationsDelegate result;
				if ((result = this._AllowedNotificationsDelegate) == null)
				{
					result = (this._AllowedNotificationsDelegate = new FAllowedNotificationsDelegate(base.NativePtr + (IntPtr)UKuroPushObject.__PropertyOffset_AllowedNotificationsDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroPushObject.__PropertyOffset_AllowedNotificationsDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06006E35 RID: 28213 RVA: 0x000A240E File Offset: 0x000A060E
		static UKuroPushObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroPushSdk.KuroPushObject");
		}

		// Token: 0x06006E36 RID: 28214 RVA: 0x000A241C File Offset: 0x000A061C
		protected UKuroPushObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002F30 RID: 12080
		public new const string __ObjectPath = "/Script/KuroPushSdk.KuroPushObject";

		// Token: 0x04002F31 RID: 12081
		private static IntPtr _ClassPtr;

		// Token: 0x04002F32 RID: 12082
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002F33 RID: 12083
		internal static int __PropertyOffset_PushSdkMessageBluePrintDelegate;

		// Token: 0x04002F34 RID: 12084
		[Nullable(2)]
		private FPushSdkMessageBluePrintDelegate _PushSdkMessageBluePrintDelegate;

		// Token: 0x04002F35 RID: 12085
		internal static int __PropertyOffset_AllowedNotificationsDelegate;

		// Token: 0x04002F36 RID: 12086
		[Nullable(2)]
		private FAllowedNotificationsDelegate _AllowedNotificationsDelegate;
	}
}
