using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200256C RID: 9580
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceCollisionQuery")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UNiagaraDataInterfaceCollisionQuery : UNiagaraDataInterface, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023926 RID: 145702 RVA: 0x003494AC File Offset: 0x003476AC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceCollisionQuery._ClassPtr;
		}

		// Token: 0x06023927 RID: 145703 RVA: 0x003494B8 File Offset: 0x003476B8
		public UNiagaraDataInterfaceCollisionQuery() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceCollisionQuery.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023928 RID: 145704 RVA: 0x003494E0 File Offset: 0x003476E0
		[NullableContext(1)]
		public UNiagaraDataInterfaceCollisionQuery(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceCollisionQuery.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06023929 RID: 145705 RVA: 0x00349513 File Offset: 0x00347713
		static UNiagaraDataInterfaceCollisionQuery()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceCollisionQuery");
		}

		// Token: 0x0602392A RID: 145706 RVA: 0x00349521 File Offset: 0x00347721
		protected UNiagaraDataInterfaceCollisionQuery(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013111 RID: 78097
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceCollisionQuery";

		// Token: 0x04013112 RID: 78098
		private static IntPtr _ClassPtr;

		// Token: 0x04013113 RID: 78099
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
