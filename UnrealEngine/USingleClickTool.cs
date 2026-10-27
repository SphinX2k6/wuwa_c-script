using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001596 RID: 5526
	[UnrealObjectPath("/Script/InteractiveToolsFramework.SingleClickTool")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class USingleClickTool : UInteractiveTool, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013EDC RID: 81628 RVA: 0x001D4380 File Offset: 0x001D2580
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USingleClickTool._ClassPtr;
		}

		// Token: 0x06013EDD RID: 81629 RVA: 0x001D438C File Offset: 0x001D258C
		public USingleClickTool() : this(BuiltinUtils.AllocNativeUObject(USingleClickTool.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013EDE RID: 81630 RVA: 0x001D43B4 File Offset: 0x001D25B4
		[NullableContext(1)]
		public USingleClickTool(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USingleClickTool.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013EDF RID: 81631 RVA: 0x001D43E7 File Offset: 0x001D25E7
		static USingleClickTool()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.SingleClickTool");
		}

		// Token: 0x06013EE0 RID: 81632 RVA: 0x001D43F5 File Offset: 0x001D25F5
		protected USingleClickTool(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AC95 RID: 44181
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.SingleClickTool";

		// Token: 0x0400AC96 RID: 44182
		private static IntPtr _ClassPtr;

		// Token: 0x0400AC97 RID: 44183
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
