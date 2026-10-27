using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014CF RID: 5327
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniInputGeometryCollection")]
	[UnrealStructLayout(256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UHoudiniInputGeometryCollection : UHoudiniInputObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060134F1 RID: 79089 RVA: 0x001C6432 File Offset: 0x001C4632
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniInputGeometryCollection._ClassPtr;
		}

		// Token: 0x060134F2 RID: 79090 RVA: 0x001C6440 File Offset: 0x001C4640
		public UHoudiniInputGeometryCollection() : this(BuiltinUtils.AllocNativeUObject(UHoudiniInputGeometryCollection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060134F3 RID: 79091 RVA: 0x001C6468 File Offset: 0x001C4668
		[NullableContext(1)]
		public UHoudiniInputGeometryCollection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniInputGeometryCollection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060134F4 RID: 79092 RVA: 0x001C649B File Offset: 0x001C469B
		static UHoudiniInputGeometryCollection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniInputGeometryCollection");
		}

		// Token: 0x060134F5 RID: 79093 RVA: 0x001C64A9 File Offset: 0x001C46A9
		protected UHoudiniInputGeometryCollection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A6DF RID: 42719
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniInputGeometryCollection";

		// Token: 0x0400A6E0 RID: 42720
		private static IntPtr _ClassPtr;

		// Token: 0x0400A6E1 RID: 42721
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
