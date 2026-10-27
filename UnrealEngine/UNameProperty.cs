using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200074E RID: 1870
	[UnrealObjectPath("/Script/CoreUObject.NameProperty")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UNameProperty : UProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060062FC RID: 25340 RVA: 0x0008E116 File Offset: 0x0008C316
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNameProperty._ClassPtr;
		}

		// Token: 0x060062FD RID: 25341 RVA: 0x0008E124 File Offset: 0x0008C324
		public UNameProperty() : this(BuiltinUtils.AllocNativeUObject(UNameProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060062FE RID: 25342 RVA: 0x0008E14C File Offset: 0x0008C34C
		[NullableContext(1)]
		public UNameProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNameProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060062FF RID: 25343 RVA: 0x0008E17F File Offset: 0x0008C37F
		static UNameProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.NameProperty");
		}

		// Token: 0x06006300 RID: 25344 RVA: 0x0008E18D File Offset: 0x0008C38D
		protected UNameProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002F61 RID: 12129
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.NameProperty";

		// Token: 0x04002F62 RID: 12130
		private static IntPtr _ClassPtr;

		// Token: 0x04002F63 RID: 12131
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
