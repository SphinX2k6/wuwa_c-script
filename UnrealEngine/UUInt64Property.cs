using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000156 RID: 342
	[UnrealObjectPath("/Script/CoreUObject.UInt64Property")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UUInt64Property : UNumericProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001338 RID: 4920 RVA: 0x0001E562 File Offset: 0x0001C762
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUInt64Property._ClassPtr;
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x0001E570 File Offset: 0x0001C770
		public UUInt64Property() : this(BuiltinUtils.AllocNativeUObject(UUInt64Property.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x0001E598 File Offset: 0x0001C798
		[NullableContext(1)]
		public UUInt64Property(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUInt64Property.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x0001E5CB File Offset: 0x0001C7CB
		static UUInt64Property()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.UInt64Property");
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x0001E5D9 File Offset: 0x0001C7D9
		protected UUInt64Property(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400061A RID: 1562
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.UInt64Property";

		// Token: 0x0400061B RID: 1563
		private static IntPtr _ClassPtr;

		// Token: 0x0400061C RID: 1564
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
