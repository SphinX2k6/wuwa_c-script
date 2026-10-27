using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001ECF RID: 7887
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.KuroStateMachineConditionOr")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UKuroStateMachineConditionOr : UKuroStateMachineConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DEA6 RID: 122534 RVA: 0x002C3F26 File Offset: 0x002C2126
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroStateMachineConditionOr._ClassPtr;
		}

		// Token: 0x0601DEA7 RID: 122535 RVA: 0x002C3F34 File Offset: 0x002C2134
		public UKuroStateMachineConditionOr() : this(BuiltinUtils.AllocNativeUObject(UKuroStateMachineConditionOr.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DEA8 RID: 122536 RVA: 0x002C3F5C File Offset: 0x002C215C
		public UKuroStateMachineConditionOr(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroStateMachineConditionOr.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170077B9 RID: 30649
		// (get) Token: 0x0601DEA9 RID: 122537 RVA: 0x002C3F90 File Offset: 0x002C2190
		// (set) Token: 0x0601DEAA RID: 122538 RVA: 0x002C3FC9 File Offset: 0x002C21C9
		public TArray<UKuroStateMachineConditionBase> Conditions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKuroStateMachineConditionBase> result;
				if ((result = this._Conditions) == null)
				{
					result = (this._Conditions = new TArray<UKuroStateMachineConditionBase>(base.NativePtr + (IntPtr)UKuroStateMachineConditionOr.__PropertyOffset_Conditions, this));
				}
				return result;
			}
			set
			{
				this.Conditions.CopyAssign(value);
			}
		}

		// Token: 0x0601DEAB RID: 122539 RVA: 0x002C3FD7 File Offset: 0x002C21D7
		static UKuroStateMachineConditionOr()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroStateMachineConditionOr");
		}

		// Token: 0x0601DEAC RID: 122540 RVA: 0x002C3FE5 File Offset: 0x002C21E5
		protected UKuroStateMachineConditionOr(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010328 RID: 66344
		public new const string __ObjectPath = "/Script/KuroUtility.KuroStateMachineConditionOr";

		// Token: 0x04010329 RID: 66345
		private static IntPtr _ClassPtr;

		// Token: 0x0401032A RID: 66346
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401032B RID: 66347
		internal static int __PropertyOffset_Conditions;

		// Token: 0x0401032C RID: 66348
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKuroStateMachineConditionBase> _Conditions;
	}
}
