using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002A68 RID: 10856
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/WindowsDeviceProfileSelector.WindowsDeviceProfileMatchingRules")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UWindowsDeviceProfileMatchingRules : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060280EC RID: 164076 RVA: 0x003CFAE7 File Offset: 0x003CDCE7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWindowsDeviceProfileMatchingRules._ClassPtr;
		}

		// Token: 0x060280ED RID: 164077 RVA: 0x003CFAF4 File Offset: 0x003CDCF4
		public UWindowsDeviceProfileMatchingRules() : this(BuiltinUtils.AllocNativeUObject(UWindowsDeviceProfileMatchingRules.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060280EE RID: 164078 RVA: 0x003CFB1C File Offset: 0x003CDD1C
		public UWindowsDeviceProfileMatchingRules(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWindowsDeviceProfileMatchingRules.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170098F6 RID: 39158
		// (get) Token: 0x060280EF RID: 164079 RVA: 0x003CFB50 File Offset: 0x003CDD50
		// (set) Token: 0x060280F0 RID: 164080 RVA: 0x003CFB89 File Offset: 0x003CDD89
		public TArray<FWindowsDeviceProfileMatch> MatchProfile
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FWindowsDeviceProfileMatch> result;
				if ((result = this._MatchProfile) == null)
				{
					result = (this._MatchProfile = new TArray<FWindowsDeviceProfileMatch>(base.NativePtr + (IntPtr)UWindowsDeviceProfileMatchingRules.__PropertyOffset_MatchProfile, this));
				}
				return result;
			}
			set
			{
				this.MatchProfile.CopyAssign(value);
			}
		}

		// Token: 0x060280F1 RID: 164081 RVA: 0x003CFB97 File Offset: 0x003CDD97
		static UWindowsDeviceProfileMatchingRules()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/WindowsDeviceProfileSelector.WindowsDeviceProfileMatchingRules");
		}

		// Token: 0x060280F2 RID: 164082 RVA: 0x003CFBA5 File Offset: 0x003CDDA5
		protected UWindowsDeviceProfileMatchingRules(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015FA9 RID: 90025
		public new const string __ObjectPath = "/Script/WindowsDeviceProfileSelector.WindowsDeviceProfileMatchingRules";

		// Token: 0x04015FAA RID: 90026
		private static IntPtr _ClassPtr;

		// Token: 0x04015FAB RID: 90027
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015FAC RID: 90028
		internal static int __PropertyOffset_MatchProfile;

		// Token: 0x04015FAD RID: 90029
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FWindowsDeviceProfileMatch> _MatchProfile;
	}
}
