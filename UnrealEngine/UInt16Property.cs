using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000114 RID: 276
	[UnrealObjectPath("/Script/CoreUObject.Int16Property")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UInt16Property : UNumericProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600116E RID: 4462 RVA: 0x0001B98A File Offset: 0x00019B8A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInt16Property._ClassPtr;
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x0001B998 File Offset: 0x00019B98
		public UInt16Property() : this(BuiltinUtils.AllocNativeUObject(UInt16Property.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x0001B9C0 File Offset: 0x00019BC0
		[NullableContext(1)]
		public UInt16Property(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInt16Property.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x0001B9F3 File Offset: 0x00019BF3
		static UInt16Property()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.Int16Property");
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x0001BA01 File Offset: 0x00019C01
		protected UInt16Property(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000505 RID: 1285
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.Int16Property";

		// Token: 0x04000506 RID: 1286
		private static IntPtr _ClassPtr;

		// Token: 0x04000507 RID: 1287
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
