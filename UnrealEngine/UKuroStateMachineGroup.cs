using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001ED0 RID: 7888
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.KuroStateMachineGroup")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UKuroStateMachineGroup : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DEAD RID: 122541 RVA: 0x002C3FEE File Offset: 0x002C21EE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroStateMachineGroup._ClassPtr;
		}

		// Token: 0x0601DEAE RID: 122542 RVA: 0x002C3FFC File Offset: 0x002C21FC
		public UKuroStateMachineGroup() : this(BuiltinUtils.AllocNativeUObject(UKuroStateMachineGroup.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DEAF RID: 122543 RVA: 0x002C4024 File Offset: 0x002C2224
		public UKuroStateMachineGroup(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroStateMachineGroup.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170077BA RID: 30650
		// (get) Token: 0x0601DEB0 RID: 122544 RVA: 0x002C4058 File Offset: 0x002C2258
		// (set) Token: 0x0601DEB1 RID: 122545 RVA: 0x002C4091 File Offset: 0x002C2291
		public TArray<UKuroStateMachineBase> StateMachineList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKuroStateMachineBase> result;
				if ((result = this._StateMachineList) == null)
				{
					result = (this._StateMachineList = new TArray<UKuroStateMachineBase>(base.NativePtr + (IntPtr)UKuroStateMachineGroup.__PropertyOffset_StateMachineList, this));
				}
				return result;
			}
			set
			{
				this.StateMachineList.CopyAssign(value);
			}
		}

		// Token: 0x0601DEB2 RID: 122546 RVA: 0x002C409F File Offset: 0x002C229F
		static UKuroStateMachineGroup()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroStateMachineGroup");
		}

		// Token: 0x0601DEB3 RID: 122547 RVA: 0x002C40AD File Offset: 0x002C22AD
		protected UKuroStateMachineGroup(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401032D RID: 66349
		public new const string __ObjectPath = "/Script/KuroUtility.KuroStateMachineGroup";

		// Token: 0x0401032E RID: 66350
		private static IntPtr _ClassPtr;

		// Token: 0x0401032F RID: 66351
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010330 RID: 66352
		internal static int __PropertyOffset_StateMachineList;

		// Token: 0x04010331 RID: 66353
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKuroStateMachineBase> _StateMachineList;
	}
}
