using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002AA4 RID: 10916
	[UnrealObjectPath("/Script/XSXPlatformEditor.XSXTargetSettings")]
	[UnrealStructLayout(528, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 528)]
	public class UXSXTargetSettings : UXboxCommonGDKTargetSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602839E RID: 164766 RVA: 0x003D2E83 File Offset: 0x003D1083
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UXSXTargetSettings._ClassPtr;
		}

		// Token: 0x0602839F RID: 164767 RVA: 0x003D2E90 File Offset: 0x003D1090
		public UXSXTargetSettings() : this(BuiltinUtils.AllocNativeUObject(UXSXTargetSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060283A0 RID: 164768 RVA: 0x003D2EB8 File Offset: 0x003D10B8
		[NullableContext(1)]
		public UXSXTargetSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UXSXTargetSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009976 RID: 39286
		// (get) Token: 0x060283A1 RID: 164769 RVA: 0x003D2EEB File Offset: 0x003D10EB
		// (set) Token: 0x060283A2 RID: 164770 RVA: 0x003D2EFB File Offset: 0x003D10FB
		public unsafe bool bEnableRayTracing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UXSXTargetSettings.__PropertyOffset_bEnableRayTracing) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UXSXTargetSettings.__PropertyOffset_bEnableRayTracing) = (value ? 1 : 0);
			}
		}

		// Token: 0x060283A3 RID: 164771 RVA: 0x003D2F0C File Offset: 0x003D110C
		static UXSXTargetSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/XSXPlatformEditor.XSXTargetSettings");
		}

		// Token: 0x060283A4 RID: 164772 RVA: 0x003D2F1A File Offset: 0x003D111A
		protected UXSXTargetSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040160F6 RID: 90358
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/XSXPlatformEditor.XSXTargetSettings";

		// Token: 0x040160F7 RID: 90359
		private static IntPtr _ClassPtr;

		// Token: 0x040160F8 RID: 90360
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040160F9 RID: 90361
		internal static int __PropertyOffset_bEnableRayTracing;
	}
}
