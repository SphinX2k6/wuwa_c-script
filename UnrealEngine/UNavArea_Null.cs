using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002482 RID: 9346
	[UnrealObjectPath("/Script/NavigationSystem.NavArea_Null")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UNavArea_Null : UNavArea, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022F5D RID: 143197 RVA: 0x0033B07A File Offset: 0x0033927A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavArea_Null._ClassPtr;
		}

		// Token: 0x06022F5E RID: 143198 RVA: 0x0033B088 File Offset: 0x00339288
		public UNavArea_Null() : this(BuiltinUtils.AllocNativeUObject(UNavArea_Null.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022F5F RID: 143199 RVA: 0x0033B0B0 File Offset: 0x003392B0
		[NullableContext(1)]
		public UNavArea_Null(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNavArea_Null.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022F60 RID: 143200 RVA: 0x0033B0E3 File Offset: 0x003392E3
		static UNavArea_Null()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavArea_Null");
		}

		// Token: 0x06022F61 RID: 143201 RVA: 0x0033B0F1 File Offset: 0x003392F1
		protected UNavArea_Null(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012AB5 RID: 76469
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.NavArea_Null";

		// Token: 0x04012AB6 RID: 76470
		private static IntPtr _ClassPtr;

		// Token: 0x04012AB7 RID: 76471
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
