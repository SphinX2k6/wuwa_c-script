using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200069C RID: 1692
	[UnrealObjectPath("/Script/LGUI.LGUIFontData_BaseObject")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public abstract class ULGUIFontData_BaseObject : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060091E7 RID: 37351 RVA: 0x000DB877 File Offset: 0x000D9A77
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIFontData_BaseObject._ClassPtr;
		}

		// Token: 0x060091E8 RID: 37352 RVA: 0x000DB883 File Offset: 0x000D9A83
		static ULGUIFontData_BaseObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIFontData_BaseObject");
		}

		// Token: 0x060091E9 RID: 37353 RVA: 0x000DB894 File Offset: 0x000D9A94
		protected ULGUIFontData_BaseObject() : this(BuiltinUtils.AllocNativeUObject(ULGUIFontData_BaseObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060091EA RID: 37354 RVA: 0x000DB8BC File Offset: 0x000D9ABC
		protected ULGUIFontData_BaseObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003F95 RID: 16277
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIFontData_BaseObject";

		// Token: 0x04003F96 RID: 16278
		private static IntPtr _ClassPtr;

		// Token: 0x04003F97 RID: 16279
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
