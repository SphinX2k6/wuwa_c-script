using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200036F RID: 879
	[UnrealObjectPath("/Script/KuroData.TraceLineElement")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class UTraceLineElement : UTraceBaseElement, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060059A9 RID: 22953 RVA: 0x0007E5B3 File Offset: 0x0007C7B3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTraceLineElement._ClassPtr;
		}

		// Token: 0x060059AA RID: 22954 RVA: 0x0007E5C0 File Offset: 0x0007C7C0
		public UTraceLineElement() : this(BuiltinUtils.AllocNativeUObject(UTraceLineElement.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060059AB RID: 22955 RVA: 0x0007E5E8 File Offset: 0x0007C7E8
		[NullableContext(1)]
		public UTraceLineElement(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTraceLineElement.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060059AC RID: 22956 RVA: 0x0007E61B File Offset: 0x0007C81B
		static UTraceLineElement()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroData.TraceLineElement");
		}

		// Token: 0x060059AD RID: 22957 RVA: 0x0007E629 File Offset: 0x0007C829
		protected UTraceLineElement(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002511 RID: 9489
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroData.TraceLineElement";

		// Token: 0x04002512 RID: 9490
		private static IntPtr _ClassPtr;

		// Token: 0x04002513 RID: 9491
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
