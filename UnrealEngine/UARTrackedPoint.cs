using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003D5 RID: 981
	[UnrealObjectPath("/Script/AugmentedReality.ARTrackedPoint")]
	[UnrealStructLayout(256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UARTrackedPoint : UARTrackedGeometry, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600370E RID: 14094 RVA: 0x000538E5 File Offset: 0x00051AE5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UARTrackedPoint._ClassPtr;
		}

		// Token: 0x0600370F RID: 14095 RVA: 0x000538F4 File Offset: 0x00051AF4
		public UARTrackedPoint() : this(BuiltinUtils.AllocNativeUObject(UARTrackedPoint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003710 RID: 14096 RVA: 0x0005391C File Offset: 0x00051B1C
		[NullableContext(1)]
		public UARTrackedPoint(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UARTrackedPoint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06003711 RID: 14097 RVA: 0x0005394F File Offset: 0x00051B4F
		static UARTrackedPoint()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARTrackedPoint");
		}

		// Token: 0x06003712 RID: 14098 RVA: 0x0005395D File Offset: 0x00051B5D
		protected UARTrackedPoint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040017DE RID: 6110
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AugmentedReality.ARTrackedPoint";

		// Token: 0x040017DF RID: 6111
		private static IntPtr _ClassPtr;

		// Token: 0x040017E0 RID: 6112
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
