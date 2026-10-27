using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019B2 RID: 6578
	[UnrealObjectPath("/Script/KuroLevelStateMachine.KuroLevelStateAction")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public abstract class UKuroLevelStateAction : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018793 RID: 100243 RVA: 0x00241032 File Offset: 0x0023F232
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroLevelStateAction._ClassPtr;
		}

		// Token: 0x170061BB RID: 25019
		// (get) Token: 0x06018794 RID: 100244 RVA: 0x0024103E File Offset: 0x0023F23E
		// (set) Token: 0x06018795 RID: 100245 RVA: 0x00241052 File Offset: 0x0023F252
		[Nullable(2)]
		public unsafe UKuroLevelStateMachineComponent Owner
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroLevelStateMachineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroLevelStateAction.__PropertyOffset_Owner);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroLevelStateAction.__PropertyOffset_Owner, value);
			}
		}

		// Token: 0x06018796 RID: 100246 RVA: 0x00241067 File Offset: 0x0023F267
		static UKuroLevelStateAction()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroLevelStateMachine.KuroLevelStateAction");
		}

		// Token: 0x06018797 RID: 100247 RVA: 0x00241078 File Offset: 0x0023F278
		protected UKuroLevelStateAction() : this(BuiltinUtils.AllocNativeUObject(UKuroLevelStateAction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018798 RID: 100248 RVA: 0x002410A0 File Offset: 0x0023F2A0
		protected UKuroLevelStateAction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D388 RID: 54152
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroLevelStateMachine.KuroLevelStateAction";

		// Token: 0x0400D389 RID: 54153
		private static IntPtr _ClassPtr;

		// Token: 0x0400D38A RID: 54154
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D38B RID: 54155
		internal static int __PropertyOffset_Owner;
	}
}
