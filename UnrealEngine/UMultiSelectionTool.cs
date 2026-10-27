using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200158E RID: 5518
	[UnrealObjectPath("/Script/InteractiveToolsFramework.MultiSelectionTool")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UMultiSelectionTool : UInteractiveTool, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013E94 RID: 81556 RVA: 0x001D3D2A File Offset: 0x001D1F2A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMultiSelectionTool._ClassPtr;
		}

		// Token: 0x06013E95 RID: 81557 RVA: 0x001D3D38 File Offset: 0x001D1F38
		public UMultiSelectionTool() : this(BuiltinUtils.AllocNativeUObject(UMultiSelectionTool.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013E96 RID: 81558 RVA: 0x001D3D60 File Offset: 0x001D1F60
		[NullableContext(1)]
		public UMultiSelectionTool(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMultiSelectionTool.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013E97 RID: 81559 RVA: 0x001D3D93 File Offset: 0x001D1F93
		static UMultiSelectionTool()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.MultiSelectionTool");
		}

		// Token: 0x06013E98 RID: 81560 RVA: 0x001D3DA1 File Offset: 0x001D1FA1
		protected UMultiSelectionTool(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AC6D RID: 44141
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.MultiSelectionTool";

		// Token: 0x0400AC6E RID: 44142
		private static IntPtr _ClassPtr;

		// Token: 0x0400AC6F RID: 44143
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
