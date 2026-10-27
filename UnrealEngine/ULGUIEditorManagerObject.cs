using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200206E RID: 8302
	[UnrealObjectPath("/Script/LGUI.LGUIEditorManagerObject")]
	[UnrealStructLayout(752, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 752)]
	public class ULGUIEditorManagerObject : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F507 RID: 128263 RVA: 0x002E829E File Offset: 0x002E649E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIEditorManagerObject._ClassPtr;
		}

		// Token: 0x0601F508 RID: 128264 RVA: 0x002E82AC File Offset: 0x002E64AC
		public ULGUIEditorManagerObject() : this(BuiltinUtils.AllocNativeUObject(ULGUIEditorManagerObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F509 RID: 128265 RVA: 0x002E82D4 File Offset: 0x002E64D4
		[NullableContext(1)]
		public ULGUIEditorManagerObject(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIEditorManagerObject.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601F50A RID: 128266 RVA: 0x002E8307 File Offset: 0x002E6507
		static ULGUIEditorManagerObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIEditorManagerObject");
		}

		// Token: 0x0601F50B RID: 128267 RVA: 0x002E8315 File Offset: 0x002E6515
		protected ULGUIEditorManagerObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010EDA RID: 69338
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIEditorManagerObject";

		// Token: 0x04010EDB RID: 69339
		private static IntPtr _ClassPtr;

		// Token: 0x04010EDC RID: 69340
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
