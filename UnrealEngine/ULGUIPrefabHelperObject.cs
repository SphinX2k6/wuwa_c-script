using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020B3 RID: 8371
	[UnrealObjectPath("/Script/LGUI.LGUIPrefabHelperObject")]
	[UnrealStructLayout(408, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 408)]
	public class ULGUIPrefabHelperObject : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F8AF RID: 129199 RVA: 0x002EE496 File Offset: 0x002EC696
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIPrefabHelperObject._ClassPtr;
		}

		// Token: 0x0601F8B0 RID: 129200 RVA: 0x002EE4A4 File Offset: 0x002EC6A4
		public ULGUIPrefabHelperObject() : this(BuiltinUtils.AllocNativeUObject(ULGUIPrefabHelperObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F8B1 RID: 129201 RVA: 0x002EE4CC File Offset: 0x002EC6CC
		[NullableContext(1)]
		public ULGUIPrefabHelperObject(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIPrefabHelperObject.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601F8B2 RID: 129202 RVA: 0x002EE4FF File Offset: 0x002EC6FF
		static ULGUIPrefabHelperObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIPrefabHelperObject");
		}

		// Token: 0x0601F8B3 RID: 129203 RVA: 0x002EE50D File Offset: 0x002EC70D
		protected ULGUIPrefabHelperObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011075 RID: 69749
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIPrefabHelperObject";

		// Token: 0x04011076 RID: 69750
		private static IntPtr _ClassPtr;

		// Token: 0x04011077 RID: 69751
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
