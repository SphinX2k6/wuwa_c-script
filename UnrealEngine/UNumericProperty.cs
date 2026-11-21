using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000135 RID: 309
	[UnrealObjectPath("/Script/CoreUObject.NumericProperty")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public abstract class UNumericProperty : UProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600125D RID: 4701 RVA: 0x0001D116 File Offset: 0x0001B316
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNumericProperty._ClassPtr;
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x0001D122 File Offset: 0x0001B322
		static UNumericProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.NumericProperty");
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x0001D130 File Offset: 0x0001B330
		protected UNumericProperty() : this(BuiltinUtils.AllocNativeUObject(UNumericProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x0001D158 File Offset: 0x0001B358
		protected UNumericProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400059A RID: 1434
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.NumericProperty";

		// Token: 0x0400059B RID: 1435
		private static IntPtr _ClassPtr;

		// Token: 0x0400059C RID: 1436
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
