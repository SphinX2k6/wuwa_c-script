using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019B9 RID: 6585
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroLevelStateMachine.KuroLevelToggleActive")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UKuroLevelToggleActive : UKuroLevelStateAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060187E2 RID: 100322 RVA: 0x00241701 File Offset: 0x0023F901
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroLevelToggleActive._ClassPtr;
		}

		// Token: 0x060187E3 RID: 100323 RVA: 0x00241710 File Offset: 0x0023F910
		public UKuroLevelToggleActive() : this(BuiltinUtils.AllocNativeUObject(UKuroLevelToggleActive.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060187E4 RID: 100324 RVA: 0x00241738 File Offset: 0x0023F938
		public UKuroLevelToggleActive(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroLevelToggleActive.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170061C9 RID: 25033
		// (get) Token: 0x060187E5 RID: 100325 RVA: 0x0024176C File Offset: 0x0023F96C
		// (set) Token: 0x060187E6 RID: 100326 RVA: 0x002417A5 File Offset: 0x0023F9A5
		public TArray<FKuroLevelToggleActiveData> Actives
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroLevelToggleActiveData> result;
				if ((result = this._Actives) == null)
				{
					result = (this._Actives = new TArray<FKuroLevelToggleActiveData>(base.NativePtr + (IntPtr)UKuroLevelToggleActive.__PropertyOffset_Actives, this));
				}
				return result;
			}
			set
			{
				this.Actives.CopyAssign(value);
			}
		}

		// Token: 0x060187E7 RID: 100327 RVA: 0x002417B3 File Offset: 0x0023F9B3
		static UKuroLevelToggleActive()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroLevelStateMachine.KuroLevelToggleActive");
		}

		// Token: 0x060187E8 RID: 100328 RVA: 0x002417C1 File Offset: 0x0023F9C1
		protected UKuroLevelToggleActive(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D3AE RID: 54190
		public new const string __ObjectPath = "/Script/KuroLevelStateMachine.KuroLevelToggleActive";

		// Token: 0x0400D3AF RID: 54191
		private static IntPtr _ClassPtr;

		// Token: 0x0400D3B0 RID: 54192
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D3B1 RID: 54193
		internal static int __PropertyOffset_Actives;

		// Token: 0x0400D3B2 RID: 54194
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroLevelToggleActiveData> _Actives;
	}
}
