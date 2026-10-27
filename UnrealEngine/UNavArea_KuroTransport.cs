using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200247C RID: 9340
	[UnrealObjectPath("/Script/NavigationSystem.NavArea_KuroTransport")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UNavArea_KuroTransport : UNavArea, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022F3F RID: 143167 RVA: 0x0033AD7A File Offset: 0x00338F7A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavArea_KuroTransport._ClassPtr;
		}

		// Token: 0x06022F40 RID: 143168 RVA: 0x0033AD88 File Offset: 0x00338F88
		public UNavArea_KuroTransport() : this(BuiltinUtils.AllocNativeUObject(UNavArea_KuroTransport.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022F41 RID: 143169 RVA: 0x0033ADB0 File Offset: 0x00338FB0
		[NullableContext(1)]
		public UNavArea_KuroTransport(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNavArea_KuroTransport.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022F42 RID: 143170 RVA: 0x0033ADE3 File Offset: 0x00338FE3
		static UNavArea_KuroTransport()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavArea_KuroTransport");
		}

		// Token: 0x06022F43 RID: 143171 RVA: 0x0033ADF1 File Offset: 0x00338FF1
		protected UNavArea_KuroTransport(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012AA3 RID: 76451
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.NavArea_KuroTransport";

		// Token: 0x04012AA4 RID: 76452
		private static IntPtr _ClassPtr;

		// Token: 0x04012AA5 RID: 76453
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
