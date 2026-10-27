using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002598 RID: 9624
	[UnrealObjectPath("/Script/Niagara.NiagaraEditorDataBase")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UNiagaraEditorDataBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023BAE RID: 146350 RVA: 0x0034D3CB File Offset: 0x0034B5CB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraEditorDataBase._ClassPtr;
		}

		// Token: 0x06023BAF RID: 146351 RVA: 0x0034D3D8 File Offset: 0x0034B5D8
		public UNiagaraEditorDataBase() : this(BuiltinUtils.AllocNativeUObject(UNiagaraEditorDataBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023BB0 RID: 146352 RVA: 0x0034D400 File Offset: 0x0034B600
		[NullableContext(1)]
		public UNiagaraEditorDataBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraEditorDataBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06023BB1 RID: 146353 RVA: 0x0034D433 File Offset: 0x0034B633
		static UNiagaraEditorDataBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraEditorDataBase");
		}

		// Token: 0x06023BB2 RID: 146354 RVA: 0x0034D441 File Offset: 0x0034B641
		protected UNiagaraEditorDataBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013289 RID: 78473
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraEditorDataBase";

		// Token: 0x0401328A RID: 78474
		private static IntPtr _ClassPtr;

		// Token: 0x0401328B RID: 78475
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
