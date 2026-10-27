using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200247E RID: 9342
	[UnrealObjectPath("/Script/NavigationSystem.NavArea_KuroWaterDry")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UNavArea_KuroWaterDry : UNavArea, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022F49 RID: 143177 RVA: 0x0033AE7A File Offset: 0x0033907A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavArea_KuroWaterDry._ClassPtr;
		}

		// Token: 0x06022F4A RID: 143178 RVA: 0x0033AE88 File Offset: 0x00339088
		public UNavArea_KuroWaterDry() : this(BuiltinUtils.AllocNativeUObject(UNavArea_KuroWaterDry.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022F4B RID: 143179 RVA: 0x0033AEB0 File Offset: 0x003390B0
		[NullableContext(1)]
		public UNavArea_KuroWaterDry(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNavArea_KuroWaterDry.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022F4C RID: 143180 RVA: 0x0033AEE3 File Offset: 0x003390E3
		static UNavArea_KuroWaterDry()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavArea_KuroWaterDry");
		}

		// Token: 0x06022F4D RID: 143181 RVA: 0x0033AEF1 File Offset: 0x003390F1
		protected UNavArea_KuroWaterDry(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012AA9 RID: 76457
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.NavArea_KuroWaterDry";

		// Token: 0x04012AAA RID: 76458
		private static IntPtr _ClassPtr;

		// Token: 0x04012AAB RID: 76459
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
