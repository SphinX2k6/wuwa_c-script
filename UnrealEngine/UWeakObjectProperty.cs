using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000772 RID: 1906
	[UnrealObjectPath("/Script/CoreUObject.WeakObjectProperty")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UWeakObjectProperty : UObjectPropertyBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060063EB RID: 25579 RVA: 0x0008F799 File Offset: 0x0008D999
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWeakObjectProperty._ClassPtr;
		}

		// Token: 0x060063EC RID: 25580 RVA: 0x0008F7A8 File Offset: 0x0008D9A8
		public UWeakObjectProperty() : this(BuiltinUtils.AllocNativeUObject(UWeakObjectProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060063ED RID: 25581 RVA: 0x0008F7D0 File Offset: 0x0008D9D0
		[NullableContext(1)]
		public UWeakObjectProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWeakObjectProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060063EE RID: 25582 RVA: 0x0008F803 File Offset: 0x0008DA03
		static UWeakObjectProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.WeakObjectProperty");
		}

		// Token: 0x060063EF RID: 25583 RVA: 0x0008F811 File Offset: 0x0008DA11
		protected UWeakObjectProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002FE9 RID: 12265
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.WeakObjectProperty";

		// Token: 0x04002FEA RID: 12266
		private static IntPtr _ClassPtr;

		// Token: 0x04002FEB RID: 12267
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
