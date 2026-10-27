using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025BC RID: 9660
	[UnrealObjectPath("/Script/Niagara.NiagaraMessageDataBase")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UNiagaraMessageDataBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023EA0 RID: 147104 RVA: 0x00351D86 File Offset: 0x0034FF86
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraMessageDataBase._ClassPtr;
		}

		// Token: 0x06023EA1 RID: 147105 RVA: 0x00351D94 File Offset: 0x0034FF94
		public UNiagaraMessageDataBase() : this(BuiltinUtils.AllocNativeUObject(UNiagaraMessageDataBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023EA2 RID: 147106 RVA: 0x00351DBC File Offset: 0x0034FFBC
		[NullableContext(1)]
		public UNiagaraMessageDataBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraMessageDataBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06023EA3 RID: 147107 RVA: 0x00351DEF File Offset: 0x0034FFEF
		static UNiagaraMessageDataBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraMessageDataBase");
		}

		// Token: 0x06023EA4 RID: 147108 RVA: 0x00351DFD File Offset: 0x0034FFFD
		protected UNiagaraMessageDataBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013429 RID: 78889
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraMessageDataBase";

		// Token: 0x0401342A RID: 78890
		private static IntPtr _ClassPtr;

		// Token: 0x0401342B RID: 78891
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
