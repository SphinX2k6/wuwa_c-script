using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000134 RID: 308
	[UnrealObjectPath("/Script/CoreUObject.NameProperty")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UNameProperty : UProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001258 RID: 4696 RVA: 0x0001D096 File Offset: 0x0001B296
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNameProperty._ClassPtr;
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x0001D0A4 File Offset: 0x0001B2A4
		public UNameProperty() : this(BuiltinUtils.AllocNativeUObject(UNameProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x0001D0CC File Offset: 0x0001B2CC
		[NullableContext(1)]
		public UNameProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNameProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x0001D0FF File Offset: 0x0001B2FF
		static UNameProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.NameProperty");
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x0001D10D File Offset: 0x0001B30D
		protected UNameProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000597 RID: 1431
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.NameProperty";

		// Token: 0x04000598 RID: 1432
		private static IntPtr _ClassPtr;

		// Token: 0x04000599 RID: 1433
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
