using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002866 RID: 10342
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SMSystem.ASMConditionAnd")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UASMConditionAnd : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026553 RID: 157011 RVA: 0x003A3AB5 File Offset: 0x003A1CB5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UASMConditionAnd._ClassPtr;
		}

		// Token: 0x06026554 RID: 157012 RVA: 0x003A3AC4 File Offset: 0x003A1CC4
		public UASMConditionAnd() : this(BuiltinUtils.AllocNativeUObject(UASMConditionAnd.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026555 RID: 157013 RVA: 0x003A3AEC File Offset: 0x003A1CEC
		public UASMConditionAnd(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UASMConditionAnd.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170093F6 RID: 37878
		// (get) Token: 0x06026556 RID: 157014 RVA: 0x003A3B20 File Offset: 0x003A1D20
		// (set) Token: 0x06026557 RID: 157015 RVA: 0x003A3B59 File Offset: 0x003A1D59
		public TArray<UASMConditionBase> Conditions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UASMConditionBase> result;
				if ((result = this._Conditions) == null)
				{
					result = (this._Conditions = new TArray<UASMConditionBase>(base.NativePtr + (IntPtr)UASMConditionAnd.__PropertyOffset_Conditions, this));
				}
				return result;
			}
			set
			{
				this.Conditions.CopyAssign(value);
			}
		}

		// Token: 0x06026558 RID: 157016 RVA: 0x003A3B67 File Offset: 0x003A1D67
		static UASMConditionAnd()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SMSystem.ASMConditionAnd");
		}

		// Token: 0x06026559 RID: 157017 RVA: 0x003A3B75 File Offset: 0x003A1D75
		protected UASMConditionAnd(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401504E RID: 86094
		public new const string __ObjectPath = "/Script/SMSystem.ASMConditionAnd";

		// Token: 0x0401504F RID: 86095
		private static IntPtr _ClassPtr;

		// Token: 0x04015050 RID: 86096
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015051 RID: 86097
		internal static int __PropertyOffset_Conditions;

		// Token: 0x04015052 RID: 86098
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UASMConditionBase> _Conditions;
	}
}
