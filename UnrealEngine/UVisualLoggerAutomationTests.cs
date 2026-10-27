using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001237 RID: 4663
	[UnrealObjectPath("/Script/Engine.VisualLoggerAutomationTests")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UVisualLoggerAutomationTests : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601124B RID: 70219 RVA: 0x00192731 File Offset: 0x00190931
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UVisualLoggerAutomationTests._ClassPtr;
		}

		// Token: 0x0601124C RID: 70220 RVA: 0x00192740 File Offset: 0x00190940
		public UVisualLoggerAutomationTests() : this(BuiltinUtils.AllocNativeUObject(UVisualLoggerAutomationTests.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601124D RID: 70221 RVA: 0x00192768 File Offset: 0x00190968
		[NullableContext(1)]
		public UVisualLoggerAutomationTests(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UVisualLoggerAutomationTests.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601124E RID: 70222 RVA: 0x0019279B File Offset: 0x0019099B
		static UVisualLoggerAutomationTests()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.VisualLoggerAutomationTests");
		}

		// Token: 0x0601124F RID: 70223 RVA: 0x001927A9 File Offset: 0x001909A9
		protected UVisualLoggerAutomationTests(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040092C8 RID: 37576
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.VisualLoggerAutomationTests";

		// Token: 0x040092C9 RID: 37577
		private static IntPtr _ClassPtr;

		// Token: 0x040092CA RID: 37578
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
