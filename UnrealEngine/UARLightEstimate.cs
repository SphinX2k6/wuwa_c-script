using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003AD RID: 941
	[UnrealObjectPath("/Script/AugmentedReality.ARLightEstimate")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UARLightEstimate : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003432 RID: 13362 RVA: 0x0004FCF6 File Offset: 0x0004DEF6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UARLightEstimate._ClassPtr;
		}

		// Token: 0x06003433 RID: 13363 RVA: 0x0004FD04 File Offset: 0x0004DF04
		public UARLightEstimate() : this(BuiltinUtils.AllocNativeUObject(UARLightEstimate.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003434 RID: 13364 RVA: 0x0004FD2C File Offset: 0x0004DF2C
		[NullableContext(1)]
		public UARLightEstimate(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UARLightEstimate.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06003435 RID: 13365 RVA: 0x0004FD5F File Offset: 0x0004DF5F
		static UARLightEstimate()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARLightEstimate");
		}

		// Token: 0x06003436 RID: 13366 RVA: 0x0004FD6D File Offset: 0x0004DF6D
		protected UARLightEstimate(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040016A8 RID: 5800
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AugmentedReality.ARLightEstimate";

		// Token: 0x040016A9 RID: 5801
		private static IntPtr _ClassPtr;

		// Token: 0x040016AA RID: 5802
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
