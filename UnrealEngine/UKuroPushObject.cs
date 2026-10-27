using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A3F RID: 6719
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroPushSdk.KuroPushObject")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UKuroPushObject : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018DE9 RID: 101865 RVA: 0x0024BE56 File Offset: 0x0024A056
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPushObject._ClassPtr;
		}

		// Token: 0x06018DEA RID: 101866 RVA: 0x0024BE64 File Offset: 0x0024A064
		public UKuroPushObject() : this(BuiltinUtils.AllocNativeUObject(UKuroPushObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018DEB RID: 101867 RVA: 0x0024BE8C File Offset: 0x0024A08C
		public UKuroPushObject(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPushObject.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006278 RID: 25208
		// (get) Token: 0x06018DEC RID: 101868 RVA: 0x0024BEC0 File Offset: 0x0024A0C0
		// (set) Token: 0x06018DED RID: 101869 RVA: 0x0024BEF9 File Offset: 0x0024A0F9
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

		// Token: 0x17006279 RID: 25209
		// (get) Token: 0x06018DEE RID: 101870 RVA: 0x0024BF1C File Offset: 0x0024A11C
		// (set) Token: 0x06018DEF RID: 101871 RVA: 0x0024BF55 File Offset: 0x0024A155
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

		// Token: 0x06018DF0 RID: 101872 RVA: 0x0024BF76 File Offset: 0x0024A176
		static UKuroPushObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroPushSdk.KuroPushObject");
		}

		// Token: 0x06018DF1 RID: 101873 RVA: 0x0024BF84 File Offset: 0x0024A184
		protected UKuroPushObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D6F0 RID: 55024
		public new const string __ObjectPath = "/Script/KuroPushSdk.KuroPushObject";

		// Token: 0x0400D6F1 RID: 55025
		private static IntPtr _ClassPtr;

		// Token: 0x0400D6F2 RID: 55026
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D6F3 RID: 55027
		internal static int __PropertyOffset_PushSdkMessageBluePrintDelegate;

		// Token: 0x0400D6F4 RID: 55028
		[Nullable(2)]
		private FPushSdkMessageBluePrintDelegate _PushSdkMessageBluePrintDelegate;

		// Token: 0x0400D6F5 RID: 55029
		internal static int __PropertyOffset_AllowedNotificationsDelegate;

		// Token: 0x0400D6F6 RID: 55030
		[Nullable(2)]
		private FAllowedNotificationsDelegate _AllowedNotificationsDelegate;
	}
}
