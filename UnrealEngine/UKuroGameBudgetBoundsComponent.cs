using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200186A RID: 6250
	[UnrealObjectPath("/Script/KuroGameBudget.KuroGameBudgetBoundsComponent")]
	[UnrealStructLayout(1600, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1600)]
	public class UKuroGameBudgetBoundsComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017045 RID: 94277 RVA: 0x00218CF7 File Offset: 0x00216EF7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroGameBudgetBoundsComponent._ClassPtr;
		}

		// Token: 0x06017046 RID: 94278 RVA: 0x00218D04 File Offset: 0x00216F04
		public UKuroGameBudgetBoundsComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroGameBudgetBoundsComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017047 RID: 94279 RVA: 0x00218D2C File Offset: 0x00216F2C
		[NullableContext(1)]
		public UKuroGameBudgetBoundsComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroGameBudgetBoundsComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06017048 RID: 94280 RVA: 0x00218D5F File Offset: 0x00216F5F
		static UKuroGameBudgetBoundsComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameBudget.KuroGameBudgetBoundsComponent");
		}

		// Token: 0x06017049 RID: 94281 RVA: 0x00218D6D File Offset: 0x00216F6D
		protected UKuroGameBudgetBoundsComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C7E8 RID: 51176
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameBudget.KuroGameBudgetBoundsComponent";

		// Token: 0x0400C7E9 RID: 51177
		private static IntPtr _ClassPtr;

		// Token: 0x0400C7EA RID: 51178
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
