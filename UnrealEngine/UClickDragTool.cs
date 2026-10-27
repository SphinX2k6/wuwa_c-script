using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200153F RID: 5439
	[UnrealObjectPath("/Script/InteractiveToolsFramework.ClickDragTool")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class UClickDragTool : UInteractiveTool, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013BF5 RID: 80885 RVA: 0x001CFF07 File Offset: 0x001CE107
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UClickDragTool._ClassPtr;
		}

		// Token: 0x06013BF6 RID: 80886 RVA: 0x001CFF14 File Offset: 0x001CE114
		public UClickDragTool() : this(BuiltinUtils.AllocNativeUObject(UClickDragTool.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013BF7 RID: 80887 RVA: 0x001CFF3C File Offset: 0x001CE13C
		[NullableContext(1)]
		public UClickDragTool(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UClickDragTool.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013BF8 RID: 80888 RVA: 0x001CFF6F File Offset: 0x001CE16F
		static UClickDragTool()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.ClickDragTool");
		}

		// Token: 0x06013BF9 RID: 80889 RVA: 0x001CFF7D File Offset: 0x001CE17D
		protected UClickDragTool(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AAE6 RID: 43750
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.ClickDragTool";

		// Token: 0x0400AAE7 RID: 43751
		private static IntPtr _ClassPtr;

		// Token: 0x0400AAE8 RID: 43752
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
