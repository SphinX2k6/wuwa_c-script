using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002480 RID: 9344
	[UnrealObjectPath("/Script/NavigationSystem.NavArea_KuroWaterSurface")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UNavArea_KuroWaterSurface : UNavArea, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022F53 RID: 143187 RVA: 0x0033AF7A File Offset: 0x0033917A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavArea_KuroWaterSurface._ClassPtr;
		}

		// Token: 0x06022F54 RID: 143188 RVA: 0x0033AF88 File Offset: 0x00339188
		public UNavArea_KuroWaterSurface() : this(BuiltinUtils.AllocNativeUObject(UNavArea_KuroWaterSurface.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022F55 RID: 143189 RVA: 0x0033AFB0 File Offset: 0x003391B0
		[NullableContext(1)]
		public UNavArea_KuroWaterSurface(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNavArea_KuroWaterSurface.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022F56 RID: 143190 RVA: 0x0033AFE3 File Offset: 0x003391E3
		static UNavArea_KuroWaterSurface()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavArea_KuroWaterSurface");
		}

		// Token: 0x06022F57 RID: 143191 RVA: 0x0033AFF1 File Offset: 0x003391F1
		protected UNavArea_KuroWaterSurface(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012AAF RID: 76463
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.NavArea_KuroWaterSurface";

		// Token: 0x04012AB0 RID: 76464
		private static IntPtr _ClassPtr;

		// Token: 0x04012AB1 RID: 76465
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
