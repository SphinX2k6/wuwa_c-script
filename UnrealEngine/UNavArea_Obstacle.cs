using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002483 RID: 9347
	[UnrealObjectPath("/Script/NavigationSystem.NavArea_Obstacle")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UNavArea_Obstacle : UNavArea, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022F62 RID: 143202 RVA: 0x0033B0FA File Offset: 0x003392FA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavArea_Obstacle._ClassPtr;
		}

		// Token: 0x06022F63 RID: 143203 RVA: 0x0033B108 File Offset: 0x00339308
		public UNavArea_Obstacle() : this(BuiltinUtils.AllocNativeUObject(UNavArea_Obstacle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022F64 RID: 143204 RVA: 0x0033B130 File Offset: 0x00339330
		[NullableContext(1)]
		public UNavArea_Obstacle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNavArea_Obstacle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022F65 RID: 143205 RVA: 0x0033B163 File Offset: 0x00339363
		static UNavArea_Obstacle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavArea_Obstacle");
		}

		// Token: 0x06022F66 RID: 143206 RVA: 0x0033B171 File Offset: 0x00339371
		protected UNavArea_Obstacle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012AB8 RID: 76472
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.NavArea_Obstacle";

		// Token: 0x04012AB9 RID: 76473
		private static IntPtr _ClassPtr;

		// Token: 0x04012ABA RID: 76474
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
