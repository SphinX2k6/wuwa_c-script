using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200255E RID: 9566
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceArrayBool")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class UNiagaraDataInterfaceArrayBool : UNiagaraDataInterfaceArray, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602388E RID: 145550 RVA: 0x003486B9 File Offset: 0x003468B9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceArrayBool._ClassPtr;
		}

		// Token: 0x0602388F RID: 145551 RVA: 0x003486C8 File Offset: 0x003468C8
		public UNiagaraDataInterfaceArrayBool() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceArrayBool.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023890 RID: 145552 RVA: 0x003486F0 File Offset: 0x003468F0
		public UNiagaraDataInterfaceArrayBool(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceArrayBool.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008864 RID: 34916
		// (get) Token: 0x06023891 RID: 145553 RVA: 0x00348724 File Offset: 0x00346924
		// (set) Token: 0x06023892 RID: 145554 RVA: 0x0034875D File Offset: 0x0034695D
		public TArray<bool> BoolData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<bool> result;
				if ((result = this._BoolData) == null)
				{
					result = (this._BoolData = new TArray<bool>(base.NativePtr + (IntPtr)UNiagaraDataInterfaceArrayBool.__PropertyOffset_BoolData, this));
				}
				return result;
			}
			set
			{
				this.BoolData.CopyAssign(value);
			}
		}

		// Token: 0x06023893 RID: 145555 RVA: 0x0034876B File Offset: 0x0034696B
		static UNiagaraDataInterfaceArrayBool()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceArrayBool");
		}

		// Token: 0x06023894 RID: 145556 RVA: 0x00348779 File Offset: 0x00346979
		protected UNiagaraDataInterfaceArrayBool(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040130C5 RID: 78021
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceArrayBool";

		// Token: 0x040130C6 RID: 78022
		private static IntPtr _ClassPtr;

		// Token: 0x040130C7 RID: 78023
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040130C8 RID: 78024
		internal static int __PropertyOffset_BoolData;

		// Token: 0x040130C9 RID: 78025
		[Nullable(2)]
		private TArray<bool> _BoolData;
	}
}
