using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020B2 RID: 8370
	[UnrealObjectPath("/Script/LGUI.LGUIPrefabHelperComponent")]
	[UnrealStructLayout(640, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 640)]
	public class ULGUIPrefabHelperComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F8AA RID: 129194 RVA: 0x002EE416 File Offset: 0x002EC616
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIPrefabHelperComponent._ClassPtr;
		}

		// Token: 0x0601F8AB RID: 129195 RVA: 0x002EE424 File Offset: 0x002EC624
		public ULGUIPrefabHelperComponent() : this(BuiltinUtils.AllocNativeUObject(ULGUIPrefabHelperComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F8AC RID: 129196 RVA: 0x002EE44C File Offset: 0x002EC64C
		[NullableContext(1)]
		public ULGUIPrefabHelperComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIPrefabHelperComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601F8AD RID: 129197 RVA: 0x002EE47F File Offset: 0x002EC67F
		static ULGUIPrefabHelperComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIPrefabHelperComponent");
		}

		// Token: 0x0601F8AE RID: 129198 RVA: 0x002EE48D File Offset: 0x002EC68D
		protected ULGUIPrefabHelperComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011072 RID: 69746
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIPrefabHelperComponent";

		// Token: 0x04011073 RID: 69747
		private static IntPtr _ClassPtr;

		// Token: 0x04011074 RID: 69748
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
