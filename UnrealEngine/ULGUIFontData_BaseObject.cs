using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200207B RID: 8315
	[UnrealObjectPath("/Script/LGUI.LGUIFontData_BaseObject")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public abstract class ULGUIFontData_BaseObject : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F604 RID: 128516 RVA: 0x002E994F File Offset: 0x002E7B4F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIFontData_BaseObject._ClassPtr;
		}

		// Token: 0x0601F605 RID: 128517 RVA: 0x002E995B File Offset: 0x002E7B5B
		static ULGUIFontData_BaseObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIFontData_BaseObject");
		}

		// Token: 0x0601F606 RID: 128518 RVA: 0x002E996C File Offset: 0x002E7B6C
		protected ULGUIFontData_BaseObject() : this(BuiltinUtils.AllocNativeUObject(ULGUIFontData_BaseObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F607 RID: 128519 RVA: 0x002E9994 File Offset: 0x002E7B94
		protected ULGUIFontData_BaseObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010F34 RID: 69428
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIFontData_BaseObject";

		// Token: 0x04010F35 RID: 69429
		private static IntPtr _ClassPtr;

		// Token: 0x04010F36 RID: 69430
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
