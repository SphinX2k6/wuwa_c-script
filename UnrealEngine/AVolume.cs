using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002AE RID: 686
	[UnrealObjectPath("/Script/Engine.Volume")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public abstract class AVolume : ABrush, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004A43 RID: 19011 RVA: 0x00067FD2 File Offset: 0x000661D2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AVolume._ClassPtr;
		}

		// Token: 0x06004A44 RID: 19012 RVA: 0x00067FDE File Offset: 0x000661DE
		static AVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Volume");
		}

		// Token: 0x06004A45 RID: 19013 RVA: 0x00067FEC File Offset: 0x000661EC
		protected AVolume() : this(BuiltinUtils.AllocNativeUObject(AVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004A46 RID: 19014 RVA: 0x00068014 File Offset: 0x00066214
		protected AVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001D45 RID: 7493
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Volume";

		// Token: 0x04001D46 RID: 7494
		private static IntPtr _ClassPtr;

		// Token: 0x04001D47 RID: 7495
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
