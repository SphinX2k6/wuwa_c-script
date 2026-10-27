using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002089 RID: 8329
	[UnrealObjectPath("/Script/LGUI.LGUIMeshComponent")]
	[UnrealStructLayout(1712, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1712)]
	public abstract class ULGUIMeshComponent : UMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F6D4 RID: 128724 RVA: 0x002EAD90 File Offset: 0x002E8F90
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIMeshComponent._ClassPtr;
		}

		// Token: 0x0601F6D5 RID: 128725 RVA: 0x002EAD9C File Offset: 0x002E8F9C
		static ULGUIMeshComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIMeshComponent");
		}

		// Token: 0x0601F6D6 RID: 128726 RVA: 0x002EADAC File Offset: 0x002E8FAC
		protected ULGUIMeshComponent() : this(BuiltinUtils.AllocNativeUObject(ULGUIMeshComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F6D7 RID: 128727 RVA: 0x002EADD4 File Offset: 0x002E8FD4
		protected ULGUIMeshComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010F95 RID: 69525
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIMeshComponent";

		// Token: 0x04010F96 RID: 69526
		private static IntPtr _ClassPtr;

		// Token: 0x04010F97 RID: 69527
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
