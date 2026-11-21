using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000117 RID: 279
	[UnrealObjectPath("/Script/CoreUObject.Int64Property")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UInt64Property : UNumericProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001181 RID: 4481 RVA: 0x0001BB64 File Offset: 0x00019D64
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInt64Property._ClassPtr;
		}

		// Token: 0x06001182 RID: 4482 RVA: 0x0001BB70 File Offset: 0x00019D70
		public UInt64Property() : this(BuiltinUtils.AllocNativeUObject(UInt64Property.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x0001BB98 File Offset: 0x00019D98
		[NullableContext(1)]
		public UInt64Property(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInt64Property.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x0001BBCB File Offset: 0x00019DCB
		static UInt64Property()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.Int64Property");
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x0001BBD9 File Offset: 0x00019DD9
		protected UInt64Property(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000510 RID: 1296
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.Int64Property";

		// Token: 0x04000511 RID: 1297
		private static IntPtr _ClassPtr;

		// Token: 0x04000512 RID: 1298
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
