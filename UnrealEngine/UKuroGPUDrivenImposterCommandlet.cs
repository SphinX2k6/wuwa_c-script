using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200197A RID: 6522
	[UnrealObjectPath("/Script/KuroGPUDrivenImposter.KuroGPUDrivenImposterCommandlet")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UKuroGPUDrivenImposterCommandlet : UCommandlet, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018390 RID: 99216 RVA: 0x0023BA0A File Offset: 0x00239C0A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroGPUDrivenImposterCommandlet._ClassPtr;
		}

		// Token: 0x06018391 RID: 99217 RVA: 0x0023BA18 File Offset: 0x00239C18
		public UKuroGPUDrivenImposterCommandlet() : this(BuiltinUtils.AllocNativeUObject(UKuroGPUDrivenImposterCommandlet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018392 RID: 99218 RVA: 0x0023BA40 File Offset: 0x00239C40
		[NullableContext(1)]
		public UKuroGPUDrivenImposterCommandlet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroGPUDrivenImposterCommandlet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06018393 RID: 99219 RVA: 0x0023BA73 File Offset: 0x00239C73
		static UKuroGPUDrivenImposterCommandlet()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGPUDrivenImposter.KuroGPUDrivenImposterCommandlet");
		}

		// Token: 0x06018394 RID: 99220 RVA: 0x0023BA81 File Offset: 0x00239C81
		protected UKuroGPUDrivenImposterCommandlet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D1E5 RID: 53733
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGPUDrivenImposter.KuroGPUDrivenImposterCommandlet";

		// Token: 0x0400D1E6 RID: 53734
		private static IntPtr _ClassPtr;

		// Token: 0x0400D1E7 RID: 53735
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
