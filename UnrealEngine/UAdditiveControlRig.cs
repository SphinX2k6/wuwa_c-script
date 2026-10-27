using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004AB RID: 1195
	[UnrealObjectPath("/Script/ControlRig.AdditiveControlRig")]
	[UnrealStructLayout(2080, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2080)]
	public class UAdditiveControlRig : UControlRig, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003F8F RID: 16271 RVA: 0x0005F7FD File Offset: 0x0005D9FD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAdditiveControlRig._ClassPtr;
		}

		// Token: 0x06003F90 RID: 16272 RVA: 0x0005F80C File Offset: 0x0005DA0C
		public UAdditiveControlRig() : this(BuiltinUtils.AllocNativeUObject(UAdditiveControlRig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003F91 RID: 16273 RVA: 0x0005F834 File Offset: 0x0005DA34
		[NullableContext(1)]
		public UAdditiveControlRig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAdditiveControlRig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06003F92 RID: 16274 RVA: 0x0005F867 File Offset: 0x0005DA67
		static UAdditiveControlRig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ControlRig.AdditiveControlRig");
		}

		// Token: 0x06003F93 RID: 16275 RVA: 0x0005F875 File Offset: 0x0005DA75
		protected UAdditiveControlRig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001E62 RID: 7778
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.AdditiveControlRig";

		// Token: 0x04001E63 RID: 7779
		private static IntPtr _ClassPtr;

		// Token: 0x04001E64 RID: 7780
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
