using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000148 RID: 328
	[UnrealObjectPath("/Script/CoreUObject.SetProperty")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class USetProperty : UProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060012E8 RID: 4840 RVA: 0x0001DDCA File Offset: 0x0001BFCA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USetProperty._ClassPtr;
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x0001DDD8 File Offset: 0x0001BFD8
		public USetProperty() : this(BuiltinUtils.AllocNativeUObject(USetProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x0001DE00 File Offset: 0x0001C000
		[NullableContext(1)]
		public USetProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USetProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x0001DE33 File Offset: 0x0001C033
		static USetProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.SetProperty");
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x0001DE41 File Offset: 0x0001C041
		protected USetProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040005EC RID: 1516
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.SetProperty";

		// Token: 0x040005ED RID: 1517
		private static IntPtr _ClassPtr;

		// Token: 0x040005EE RID: 1518
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
