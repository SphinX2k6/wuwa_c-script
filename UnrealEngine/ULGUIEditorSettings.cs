using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200206F RID: 8303
	[UnrealObjectPath("/Script/LGUI.LGUIEditorSettings")]
	[UnrealStructLayout(696, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 696)]
	public class ULGUIEditorSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F50C RID: 128268 RVA: 0x002E831E File Offset: 0x002E651E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIEditorSettings._ClassPtr;
		}

		// Token: 0x0601F50D RID: 128269 RVA: 0x002E832C File Offset: 0x002E652C
		public ULGUIEditorSettings() : this(BuiltinUtils.AllocNativeUObject(ULGUIEditorSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F50E RID: 128270 RVA: 0x002E8354 File Offset: 0x002E6554
		[NullableContext(1)]
		public ULGUIEditorSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIEditorSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601F50F RID: 128271 RVA: 0x002E8387 File Offset: 0x002E6587
		static ULGUIEditorSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIEditorSettings");
		}

		// Token: 0x0601F510 RID: 128272 RVA: 0x002E8395 File Offset: 0x002E6595
		protected ULGUIEditorSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010EDD RID: 69341
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIEditorSettings";

		// Token: 0x04010EDE RID: 69342
		private static IntPtr _ClassPtr;

		// Token: 0x04010EDF RID: 69343
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
