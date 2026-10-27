using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200247F RID: 9343
	[UnrealObjectPath("/Script/NavigationSystem.NavArea_KuroWaterShallow")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UNavArea_KuroWaterShallow : UNavArea, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022F4E RID: 143182 RVA: 0x0033AEFA File Offset: 0x003390FA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavArea_KuroWaterShallow._ClassPtr;
		}

		// Token: 0x06022F4F RID: 143183 RVA: 0x0033AF08 File Offset: 0x00339108
		public UNavArea_KuroWaterShallow() : this(BuiltinUtils.AllocNativeUObject(UNavArea_KuroWaterShallow.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022F50 RID: 143184 RVA: 0x0033AF30 File Offset: 0x00339130
		[NullableContext(1)]
		public UNavArea_KuroWaterShallow(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNavArea_KuroWaterShallow.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022F51 RID: 143185 RVA: 0x0033AF63 File Offset: 0x00339163
		static UNavArea_KuroWaterShallow()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavArea_KuroWaterShallow");
		}

		// Token: 0x06022F52 RID: 143186 RVA: 0x0033AF71 File Offset: 0x00339171
		protected UNavArea_KuroWaterShallow(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012AAC RID: 76460
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.NavArea_KuroWaterShallow";

		// Token: 0x04012AAD RID: 76461
		private static IntPtr _ClassPtr;

		// Token: 0x04012AAE RID: 76462
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
