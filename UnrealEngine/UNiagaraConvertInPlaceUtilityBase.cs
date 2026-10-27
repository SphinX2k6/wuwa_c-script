using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002548 RID: 9544
	[UnrealObjectPath("/Script/Niagara.NiagaraConvertInPlaceUtilityBase")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UNiagaraConvertInPlaceUtilityBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023780 RID: 145280 RVA: 0x00346E82 File Offset: 0x00345082
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraConvertInPlaceUtilityBase._ClassPtr;
		}

		// Token: 0x06023781 RID: 145281 RVA: 0x00346E8E File Offset: 0x0034508E
		static UNiagaraConvertInPlaceUtilityBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraConvertInPlaceUtilityBase");
		}

		// Token: 0x06023782 RID: 145282 RVA: 0x00346E9C File Offset: 0x0034509C
		protected UNiagaraConvertInPlaceUtilityBase() : this(BuiltinUtils.AllocNativeUObject(UNiagaraConvertInPlaceUtilityBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023783 RID: 145283 RVA: 0x00346EC4 File Offset: 0x003450C4
		protected UNiagaraConvertInPlaceUtilityBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013049 RID: 77897
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraConvertInPlaceUtilityBase";

		// Token: 0x0401304A RID: 77898
		private static IntPtr _ClassPtr;

		// Token: 0x0401304B RID: 77899
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
