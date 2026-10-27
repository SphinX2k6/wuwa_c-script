using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002646 RID: 9798
	[UnrealObjectPath("/Script/PhysicsCore.PhysicalMaterialPropertyBase")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UDEPRECATED_PhysicalMaterialPropertyBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602469A RID: 149146 RVA: 0x0035E839 File Offset: 0x0035CA39
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDEPRECATED_PhysicalMaterialPropertyBase._ClassPtr;
		}

		// Token: 0x0602469B RID: 149147 RVA: 0x0035E845 File Offset: 0x0035CA45
		static UDEPRECATED_PhysicalMaterialPropertyBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/PhysicsCore.PhysicalMaterialPropertyBase");
		}

		// Token: 0x0602469C RID: 149148 RVA: 0x0035E854 File Offset: 0x0035CA54
		protected UDEPRECATED_PhysicalMaterialPropertyBase() : this(BuiltinUtils.AllocNativeUObject(UDEPRECATED_PhysicalMaterialPropertyBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602469D RID: 149149 RVA: 0x0035E87C File Offset: 0x0035CA7C
		protected UDEPRECATED_PhysicalMaterialPropertyBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040138F0 RID: 80112
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/PhysicsCore.PhysicalMaterialPropertyBase";

		// Token: 0x040138F1 RID: 80113
		private static IntPtr _ClassPtr;

		// Token: 0x040138F2 RID: 80114
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
