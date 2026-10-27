using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004D4 RID: 1236
	[UnrealObjectPath("/Script/ControlRig.ControlRigSettings")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class UControlRigSettings : UDeveloperSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004260 RID: 16992 RVA: 0x00063346 File Offset: 0x00061546
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UControlRigSettings._ClassPtr;
		}

		// Token: 0x06004261 RID: 16993 RVA: 0x00063354 File Offset: 0x00061554
		public UControlRigSettings() : this(BuiltinUtils.AllocNativeUObject(UControlRigSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004262 RID: 16994 RVA: 0x0006337C File Offset: 0x0006157C
		[NullableContext(1)]
		public UControlRigSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UControlRigSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06004263 RID: 16995 RVA: 0x000633AF File Offset: 0x000615AF
		static UControlRigSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ControlRig.ControlRigSettings");
		}

		// Token: 0x06004264 RID: 16996 RVA: 0x000633BD File Offset: 0x000615BD
		protected UControlRigSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001F8B RID: 8075
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.ControlRigSettings";

		// Token: 0x04001F8C RID: 8076
		private static IntPtr _ClassPtr;

		// Token: 0x04001F8D RID: 8077
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
