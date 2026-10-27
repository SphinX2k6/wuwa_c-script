using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002A6E RID: 10862
	[UnrealObjectPath("/Script/WwiseConcurrency.WwiseConcurrencySettings")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UWwiseConcurrencySettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602810C RID: 164108 RVA: 0x003CFD91 File Offset: 0x003CDF91
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWwiseConcurrencySettings._ClassPtr;
		}

		// Token: 0x0602810D RID: 164109 RVA: 0x003CFDA0 File Offset: 0x003CDFA0
		public UWwiseConcurrencySettings() : this(BuiltinUtils.AllocNativeUObject(UWwiseConcurrencySettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602810E RID: 164110 RVA: 0x003CFDC8 File Offset: 0x003CDFC8
		[NullableContext(1)]
		public UWwiseConcurrencySettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWwiseConcurrencySettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170098FD RID: 39165
		// (get) Token: 0x0602810F RID: 164111 RVA: 0x003CFDFB File Offset: 0x003CDFFB
		// (set) Token: 0x06028110 RID: 164112 RVA: 0x003CFE0B File Offset: 0x003CE00B
		public unsafe bool bStopEnqueueWhenClosing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWwiseConcurrencySettings.__PropertyOffset_bStopEnqueueWhenClosing) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWwiseConcurrencySettings.__PropertyOffset_bStopEnqueueWhenClosing) = (value ? 1 : 0);
			}
		}

		// Token: 0x06028111 RID: 164113 RVA: 0x003CFE1C File Offset: 0x003CE01C
		static UWwiseConcurrencySettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/WwiseConcurrency.WwiseConcurrencySettings");
		}

		// Token: 0x06028112 RID: 164114 RVA: 0x003CFE2A File Offset: 0x003CE02A
		protected UWwiseConcurrencySettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015FC9 RID: 90057
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/WwiseConcurrency.WwiseConcurrencySettings";

		// Token: 0x04015FCA RID: 90058
		private static IntPtr _ClassPtr;

		// Token: 0x04015FCB RID: 90059
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015FCC RID: 90060
		internal static int __PropertyOffset_bStopEnqueueWhenClosing;
	}
}
