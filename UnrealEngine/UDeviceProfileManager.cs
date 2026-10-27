using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009BA RID: 2490
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.DeviceProfileManager")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class UDeviceProfileManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008CA7 RID: 36007 RVA: 0x000C94A2 File Offset: 0x000C76A2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDeviceProfileManager._ClassPtr;
		}

		// Token: 0x06008CA8 RID: 36008 RVA: 0x000C94B0 File Offset: 0x000C76B0
		public UDeviceProfileManager() : this(BuiltinUtils.AllocNativeUObject(UDeviceProfileManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008CA9 RID: 36009 RVA: 0x000C94D8 File Offset: 0x000C76D8
		public UDeviceProfileManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDeviceProfileManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002115 RID: 8469
		// (get) Token: 0x06008CAA RID: 36010 RVA: 0x000C950C File Offset: 0x000C770C
		// (set) Token: 0x06008CAB RID: 36011 RVA: 0x000C9545 File Offset: 0x000C7745
		public TArray<UObject> Profiles
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._Profiles) == null)
				{
					result = (this._Profiles = new TArray<UObject>(base.NativePtr + (IntPtr)UDeviceProfileManager.__PropertyOffset_Profiles, this));
				}
				return result;
			}
			set
			{
				this.Profiles.CopyAssign(value);
			}
		}

		// Token: 0x06008CAC RID: 36012 RVA: 0x000C9553 File Offset: 0x000C7753
		static UDeviceProfileManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DeviceProfileManager");
		}

		// Token: 0x06008CAD RID: 36013 RVA: 0x000C9561 File Offset: 0x000C7761
		protected UDeviceProfileManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040042C8 RID: 17096
		public new const string __ObjectPath = "/Script/Engine.DeviceProfileManager";

		// Token: 0x040042C9 RID: 17097
		private static IntPtr _ClassPtr;

		// Token: 0x040042CA RID: 17098
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040042CB RID: 17099
		internal static int __PropertyOffset_Profiles;

		// Token: 0x040042CC RID: 17100
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _Profiles;
	}
}
