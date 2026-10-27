using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000763 RID: 1891
	[UnrealObjectPath("/Script/CoreUObject.SoftClassProperty")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class USoftClassProperty : USoftObjectProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006395 RID: 25493 RVA: 0x0008EF56 File Offset: 0x0008D156
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoftClassProperty._ClassPtr;
		}

		// Token: 0x06006396 RID: 25494 RVA: 0x0008EF64 File Offset: 0x0008D164
		public USoftClassProperty() : this(BuiltinUtils.AllocNativeUObject(USoftClassProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006397 RID: 25495 RVA: 0x0008EF8C File Offset: 0x0008D18C
		[NullableContext(1)]
		public USoftClassProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USoftClassProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006398 RID: 25496 RVA: 0x0008EFBF File Offset: 0x0008D1BF
		static USoftClassProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.SoftClassProperty");
		}

		// Token: 0x06006399 RID: 25497 RVA: 0x0008EFCD File Offset: 0x0008D1CD
		protected USoftClassProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002FB9 RID: 12217
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.SoftClassProperty";

		// Token: 0x04002FBA RID: 12218
		private static IntPtr _ClassPtr;

		// Token: 0x04002FBB RID: 12219
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
