using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018C1 RID: 6337
	[UnrealObjectPath("/Script/KuroGameplay.KuroAxisFilteredAttachComponent")]
	[UnrealStructLayout(448, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 448)]
	public class UKuroAxisFilteredAttachComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060176AC RID: 95916 RVA: 0x00223D33 File Offset: 0x00221F33
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAxisFilteredAttachComponent._ClassPtr;
		}

		// Token: 0x060176AD RID: 95917 RVA: 0x00223D40 File Offset: 0x00221F40
		public UKuroAxisFilteredAttachComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroAxisFilteredAttachComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060176AE RID: 95918 RVA: 0x00223D68 File Offset: 0x00221F68
		[NullableContext(1)]
		public UKuroAxisFilteredAttachComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAxisFilteredAttachComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060176AF RID: 95919 RVA: 0x00223D9B File Offset: 0x00221F9B
		static UKuroAxisFilteredAttachComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroAxisFilteredAttachComponent");
		}

		// Token: 0x060176B0 RID: 95920 RVA: 0x00223DA9 File Offset: 0x00221FA9
		protected UKuroAxisFilteredAttachComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CBC2 RID: 52162
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroAxisFilteredAttachComponent";

		// Token: 0x0400CBC3 RID: 52163
		private static IntPtr _ClassPtr;

		// Token: 0x0400CBC4 RID: 52164
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
