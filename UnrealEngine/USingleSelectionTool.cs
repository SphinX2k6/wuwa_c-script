using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001598 RID: 5528
	[UnrealObjectPath("/Script/InteractiveToolsFramework.SingleSelectionTool")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class USingleSelectionTool : UInteractiveTool, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013EE6 RID: 81638 RVA: 0x001D447E File Offset: 0x001D267E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USingleSelectionTool._ClassPtr;
		}

		// Token: 0x06013EE7 RID: 81639 RVA: 0x001D448C File Offset: 0x001D268C
		public USingleSelectionTool() : this(BuiltinUtils.AllocNativeUObject(USingleSelectionTool.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013EE8 RID: 81640 RVA: 0x001D44B4 File Offset: 0x001D26B4
		[NullableContext(1)]
		public USingleSelectionTool(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USingleSelectionTool.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013EE9 RID: 81641 RVA: 0x001D44E7 File Offset: 0x001D26E7
		static USingleSelectionTool()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.SingleSelectionTool");
		}

		// Token: 0x06013EEA RID: 81642 RVA: 0x001D44F5 File Offset: 0x001D26F5
		protected USingleSelectionTool(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AC9B RID: 44187
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.SingleSelectionTool";

		// Token: 0x0400AC9C RID: 44188
		private static IntPtr _ClassPtr;

		// Token: 0x0400AC9D RID: 44189
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
