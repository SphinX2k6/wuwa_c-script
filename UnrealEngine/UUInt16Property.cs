using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000154 RID: 340
	[UnrealObjectPath("/Script/CoreUObject.UInt16Property")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UUInt16Property : UNumericProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600132E RID: 4910 RVA: 0x0001E464 File Offset: 0x0001C664
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUInt16Property._ClassPtr;
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x0001E470 File Offset: 0x0001C670
		public UUInt16Property() : this(BuiltinUtils.AllocNativeUObject(UUInt16Property.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001330 RID: 4912 RVA: 0x0001E498 File Offset: 0x0001C698
		[NullableContext(1)]
		public UUInt16Property(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUInt16Property.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x0001E4CB File Offset: 0x0001C6CB
		static UUInt16Property()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.UInt16Property");
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x0001E4D9 File Offset: 0x0001C6D9
		protected UUInt16Property(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000614 RID: 1556
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.UInt16Property";

		// Token: 0x04000615 RID: 1557
		private static IntPtr _ClassPtr;

		// Token: 0x04000616 RID: 1558
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
