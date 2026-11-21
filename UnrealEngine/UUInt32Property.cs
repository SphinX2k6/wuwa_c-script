using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000155 RID: 341
	[UnrealObjectPath("/Script/CoreUObject.UInt32Property")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UUInt32Property : UNumericProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001333 RID: 4915 RVA: 0x0001E4E2 File Offset: 0x0001C6E2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUInt32Property._ClassPtr;
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x0001E4F0 File Offset: 0x0001C6F0
		public UUInt32Property() : this(BuiltinUtils.AllocNativeUObject(UUInt32Property.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x0001E518 File Offset: 0x0001C718
		[NullableContext(1)]
		public UUInt32Property(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUInt32Property.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001336 RID: 4918 RVA: 0x0001E54B File Offset: 0x0001C74B
		static UUInt32Property()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.UInt32Property");
		}

		// Token: 0x06001337 RID: 4919 RVA: 0x0001E559 File Offset: 0x0001C759
		protected UUInt32Property(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000617 RID: 1559
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.UInt32Property";

		// Token: 0x04000618 RID: 1560
		private static IntPtr _ClassPtr;

		// Token: 0x04000619 RID: 1561
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
