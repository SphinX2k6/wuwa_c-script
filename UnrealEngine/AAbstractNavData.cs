using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200246F RID: 9327
	[UnrealObjectPath("/Script/NavigationSystem.AbstractNavData")]
	[UnrealStructLayout(1632, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1632)]
	public class AAbstractNavData : ANavigationData, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022ECC RID: 143052 RVA: 0x0033A1C2 File Offset: 0x003383C2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AAbstractNavData._ClassPtr;
		}

		// Token: 0x06022ECD RID: 143053 RVA: 0x0033A1D0 File Offset: 0x003383D0
		public AAbstractNavData() : this(BuiltinUtils.AllocNativeUObject(AAbstractNavData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022ECE RID: 143054 RVA: 0x0033A1F8 File Offset: 0x003383F8
		[NullableContext(1)]
		public AAbstractNavData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AAbstractNavData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022ECF RID: 143055 RVA: 0x0033A22B File Offset: 0x0033842B
		static AAbstractNavData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.AbstractNavData");
		}

		// Token: 0x06022ED0 RID: 143056 RVA: 0x0033A239 File Offset: 0x00338439
		protected AAbstractNavData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012A3D RID: 76349
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.AbstractNavData";

		// Token: 0x04012A3E RID: 76350
		private static IntPtr _ClassPtr;

		// Token: 0x04012A3F RID: 76351
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
