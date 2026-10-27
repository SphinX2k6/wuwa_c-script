using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025E9 RID: 9705
	[UnrealObjectPath("/Script/Niagara.NiagaraSignificanceHandlerDistance")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UNiagaraSignificanceHandlerDistance : UNiagaraSignificanceHandler, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024120 RID: 147744 RVA: 0x00355E62 File Offset: 0x00354062
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraSignificanceHandlerDistance._ClassPtr;
		}

		// Token: 0x06024121 RID: 147745 RVA: 0x00355E70 File Offset: 0x00354070
		public UNiagaraSignificanceHandlerDistance() : this(BuiltinUtils.AllocNativeUObject(UNiagaraSignificanceHandlerDistance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024122 RID: 147746 RVA: 0x00355E98 File Offset: 0x00354098
		[NullableContext(1)]
		public UNiagaraSignificanceHandlerDistance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraSignificanceHandlerDistance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06024123 RID: 147747 RVA: 0x00355ECB File Offset: 0x003540CB
		static UNiagaraSignificanceHandlerDistance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraSignificanceHandlerDistance");
		}

		// Token: 0x06024124 RID: 147748 RVA: 0x00355ED9 File Offset: 0x003540D9
		protected UNiagaraSignificanceHandlerDistance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013586 RID: 79238
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraSignificanceHandlerDistance";

		// Token: 0x04013587 RID: 79239
		private static IntPtr _ClassPtr;

		// Token: 0x04013588 RID: 79240
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
