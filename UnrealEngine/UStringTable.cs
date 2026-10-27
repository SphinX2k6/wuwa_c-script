using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011B3 RID: 4531
	[UnrealObjectPath("/Script/Engine.StringTable")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UStringTable : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010B55 RID: 68437 RVA: 0x00188832 File Offset: 0x00186A32
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStringTable._ClassPtr;
		}

		// Token: 0x06010B56 RID: 68438 RVA: 0x00188840 File Offset: 0x00186A40
		public UStringTable() : this(BuiltinUtils.AllocNativeUObject(UStringTable.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010B57 RID: 68439 RVA: 0x00188868 File Offset: 0x00186A68
		[NullableContext(1)]
		public UStringTable(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UStringTable.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06010B58 RID: 68440 RVA: 0x0018889B File Offset: 0x00186A9B
		static UStringTable()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.StringTable");
		}

		// Token: 0x06010B59 RID: 68441 RVA: 0x001888A9 File Offset: 0x00186AA9
		protected UStringTable(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008EF1 RID: 36593
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.StringTable";

		// Token: 0x04008EF2 RID: 36594
		private static IntPtr _ClassPtr;

		// Token: 0x04008EF3 RID: 36595
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
