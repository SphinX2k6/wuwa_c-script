using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002479 RID: 9337
	[UnrealObjectPath("/Script/NavigationSystem.NavArea_Default")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UNavArea_Default : UNavArea, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022F30 RID: 143152 RVA: 0x0033ABF9 File Offset: 0x00338DF9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavArea_Default._ClassPtr;
		}

		// Token: 0x06022F31 RID: 143153 RVA: 0x0033AC08 File Offset: 0x00338E08
		public UNavArea_Default() : this(BuiltinUtils.AllocNativeUObject(UNavArea_Default.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022F32 RID: 143154 RVA: 0x0033AC30 File Offset: 0x00338E30
		[NullableContext(1)]
		public UNavArea_Default(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNavArea_Default.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022F33 RID: 143155 RVA: 0x0033AC63 File Offset: 0x00338E63
		static UNavArea_Default()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavArea_Default");
		}

		// Token: 0x06022F34 RID: 143156 RVA: 0x0033AC71 File Offset: 0x00338E71
		protected UNavArea_Default(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012A9A RID: 76442
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.NavArea_Default";

		// Token: 0x04012A9B RID: 76443
		private static IntPtr _ClassPtr;

		// Token: 0x04012A9C RID: 76444
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
