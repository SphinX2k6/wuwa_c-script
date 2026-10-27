using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001ECD RID: 7885
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.KuroStateMachineConditionAnd")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UKuroStateMachineConditionAnd : UKuroStateMachineConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DE9A RID: 122522 RVA: 0x002C3DDE File Offset: 0x002C1FDE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroStateMachineConditionAnd._ClassPtr;
		}

		// Token: 0x0601DE9B RID: 122523 RVA: 0x002C3DEC File Offset: 0x002C1FEC
		public UKuroStateMachineConditionAnd() : this(BuiltinUtils.AllocNativeUObject(UKuroStateMachineConditionAnd.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DE9C RID: 122524 RVA: 0x002C3E14 File Offset: 0x002C2014
		public UKuroStateMachineConditionAnd(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroStateMachineConditionAnd.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170077B8 RID: 30648
		// (get) Token: 0x0601DE9D RID: 122525 RVA: 0x002C3E48 File Offset: 0x002C2048
		// (set) Token: 0x0601DE9E RID: 122526 RVA: 0x002C3E81 File Offset: 0x002C2081
		public TArray<UKuroStateMachineConditionBase> Conditions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKuroStateMachineConditionBase> result;
				if ((result = this._Conditions) == null)
				{
					result = (this._Conditions = new TArray<UKuroStateMachineConditionBase>(base.NativePtr + (IntPtr)UKuroStateMachineConditionAnd.__PropertyOffset_Conditions, this));
				}
				return result;
			}
			set
			{
				this.Conditions.CopyAssign(value);
			}
		}

		// Token: 0x0601DE9F RID: 122527 RVA: 0x002C3E8F File Offset: 0x002C208F
		static UKuroStateMachineConditionAnd()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroStateMachineConditionAnd");
		}

		// Token: 0x0601DEA0 RID: 122528 RVA: 0x002C3E9D File Offset: 0x002C209D
		protected UKuroStateMachineConditionAnd(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010320 RID: 66336
		public new const string __ObjectPath = "/Script/KuroUtility.KuroStateMachineConditionAnd";

		// Token: 0x04010321 RID: 66337
		private static IntPtr _ClassPtr;

		// Token: 0x04010322 RID: 66338
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010323 RID: 66339
		internal static int __PropertyOffset_Conditions;

		// Token: 0x04010324 RID: 66340
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKuroStateMachineConditionBase> _Conditions;
	}
}
