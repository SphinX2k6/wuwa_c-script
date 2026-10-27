using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012B0 RID: 4784
	[UnrealObjectPath("/Script/FieldSystemEngine.FieldSystem")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UFieldSystem : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011863 RID: 71779 RVA: 0x0019B726 File Offset: 0x00199926
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFieldSystem._ClassPtr;
		}

		// Token: 0x06011864 RID: 71780 RVA: 0x0019B734 File Offset: 0x00199934
		public UFieldSystem() : this(BuiltinUtils.AllocNativeUObject(UFieldSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011865 RID: 71781 RVA: 0x0019B75C File Offset: 0x0019995C
		[NullableContext(1)]
		public UFieldSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFieldSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06011866 RID: 71782 RVA: 0x0019B78F File Offset: 0x0019998F
		static UFieldSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/FieldSystemEngine.FieldSystem");
		}

		// Token: 0x06011867 RID: 71783 RVA: 0x0019B79D File Offset: 0x0019999D
		protected UFieldSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400963E RID: 38462
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/FieldSystemEngine.FieldSystem";

		// Token: 0x0400963F RID: 38463
		private static IntPtr _ClassPtr;

		// Token: 0x04009640 RID: 38464
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
