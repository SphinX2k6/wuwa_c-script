using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002481 RID: 9345
	[UnrealObjectPath("/Script/NavigationSystem.NavArea_LowHeight")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UNavArea_LowHeight : UNavArea, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022F58 RID: 143192 RVA: 0x0033AFFA File Offset: 0x003391FA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavArea_LowHeight._ClassPtr;
		}

		// Token: 0x06022F59 RID: 143193 RVA: 0x0033B008 File Offset: 0x00339208
		public UNavArea_LowHeight() : this(BuiltinUtils.AllocNativeUObject(UNavArea_LowHeight.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022F5A RID: 143194 RVA: 0x0033B030 File Offset: 0x00339230
		[NullableContext(1)]
		public UNavArea_LowHeight(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNavArea_LowHeight.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022F5B RID: 143195 RVA: 0x0033B063 File Offset: 0x00339263
		static UNavArea_LowHeight()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavArea_LowHeight");
		}

		// Token: 0x06022F5C RID: 143196 RVA: 0x0033B071 File Offset: 0x00339271
		protected UNavArea_LowHeight(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012AB2 RID: 76466
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.NavArea_LowHeight";

		// Token: 0x04012AB3 RID: 76467
		private static IntPtr _ClassPtr;

		// Token: 0x04012AB4 RID: 76468
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
