using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200255F RID: 9567
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceArrayColor")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class UNiagaraDataInterfaceArrayColor : UNiagaraDataInterfaceArray, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023895 RID: 145557 RVA: 0x00348782 File Offset: 0x00346982
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceArrayColor._ClassPtr;
		}

		// Token: 0x06023896 RID: 145558 RVA: 0x00348790 File Offset: 0x00346990
		public UNiagaraDataInterfaceArrayColor() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceArrayColor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023897 RID: 145559 RVA: 0x003487B8 File Offset: 0x003469B8
		public UNiagaraDataInterfaceArrayColor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceArrayColor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008865 RID: 34917
		// (get) Token: 0x06023898 RID: 145560 RVA: 0x003487EC File Offset: 0x003469EC
		// (set) Token: 0x06023899 RID: 145561 RVA: 0x00348825 File Offset: 0x00346A25
		public TArray<FLinearColor> ColorData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLinearColor> result;
				if ((result = this._ColorData) == null)
				{
					result = (this._ColorData = new TArray<FLinearColor>(base.NativePtr + (IntPtr)UNiagaraDataInterfaceArrayColor.__PropertyOffset_ColorData, this));
				}
				return result;
			}
			set
			{
				this.ColorData.CopyAssign(value);
			}
		}

		// Token: 0x0602389A RID: 145562 RVA: 0x00348833 File Offset: 0x00346A33
		static UNiagaraDataInterfaceArrayColor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceArrayColor");
		}

		// Token: 0x0602389B RID: 145563 RVA: 0x00348841 File Offset: 0x00346A41
		protected UNiagaraDataInterfaceArrayColor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040130CA RID: 78026
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceArrayColor";

		// Token: 0x040130CB RID: 78027
		private static IntPtr _ClassPtr;

		// Token: 0x040130CC RID: 78028
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040130CD RID: 78029
		internal static int __PropertyOffset_ColorData;

		// Token: 0x040130CE RID: 78030
		[Nullable(2)]
		private TArray<FLinearColor> _ColorData;
	}
}
