using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025E8 RID: 9704
	[UnrealObjectPath("/Script/Niagara.NiagaraSignificanceHandlerAge")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UNiagaraSignificanceHandlerAge : UNiagaraSignificanceHandler, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602411B RID: 147739 RVA: 0x00355DE1 File Offset: 0x00353FE1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraSignificanceHandlerAge._ClassPtr;
		}

		// Token: 0x0602411C RID: 147740 RVA: 0x00355DF0 File Offset: 0x00353FF0
		public UNiagaraSignificanceHandlerAge() : this(BuiltinUtils.AllocNativeUObject(UNiagaraSignificanceHandlerAge.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602411D RID: 147741 RVA: 0x00355E18 File Offset: 0x00354018
		[NullableContext(1)]
		public UNiagaraSignificanceHandlerAge(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraSignificanceHandlerAge.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602411E RID: 147742 RVA: 0x00355E4B File Offset: 0x0035404B
		static UNiagaraSignificanceHandlerAge()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraSignificanceHandlerAge");
		}

		// Token: 0x0602411F RID: 147743 RVA: 0x00355E59 File Offset: 0x00354059
		protected UNiagaraSignificanceHandlerAge(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013583 RID: 79235
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraSignificanceHandlerAge";

		// Token: 0x04013584 RID: 79236
		private static IntPtr _ClassPtr;

		// Token: 0x04013585 RID: 79237
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
