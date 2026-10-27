using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200247D RID: 9341
	[UnrealObjectPath("/Script/NavigationSystem.NavArea_KuroWaterBottom")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UNavArea_KuroWaterBottom : UNavArea, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022F44 RID: 143172 RVA: 0x0033ADFA File Offset: 0x00338FFA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavArea_KuroWaterBottom._ClassPtr;
		}

		// Token: 0x06022F45 RID: 143173 RVA: 0x0033AE08 File Offset: 0x00339008
		public UNavArea_KuroWaterBottom() : this(BuiltinUtils.AllocNativeUObject(UNavArea_KuroWaterBottom.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022F46 RID: 143174 RVA: 0x0033AE30 File Offset: 0x00339030
		[NullableContext(1)]
		public UNavArea_KuroWaterBottom(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNavArea_KuroWaterBottom.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022F47 RID: 143175 RVA: 0x0033AE63 File Offset: 0x00339063
		static UNavArea_KuroWaterBottom()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavArea_KuroWaterBottom");
		}

		// Token: 0x06022F48 RID: 143176 RVA: 0x0033AE71 File Offset: 0x00339071
		protected UNavArea_KuroWaterBottom(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012AA6 RID: 76454
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.NavArea_KuroWaterBottom";

		// Token: 0x04012AA7 RID: 76455
		private static IntPtr _ClassPtr;

		// Token: 0x04012AA8 RID: 76456
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
