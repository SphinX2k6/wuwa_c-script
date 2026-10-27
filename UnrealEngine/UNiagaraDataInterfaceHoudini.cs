using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001516 RID: 5398
	[UnrealObjectPath("/Script/HoudiniNiagara.NiagaraDataInterfaceHoudini")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UNiagaraDataInterfaceHoudini : UNiagaraDataInterface, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013A9F RID: 80543 RVA: 0x001CE213 File Offset: 0x001CC413
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceHoudini._ClassPtr;
		}

		// Token: 0x06013AA0 RID: 80544 RVA: 0x001CE220 File Offset: 0x001CC420
		public UNiagaraDataInterfaceHoudini() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceHoudini.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013AA1 RID: 80545 RVA: 0x001CE248 File Offset: 0x001CC448
		[NullableContext(1)]
		public UNiagaraDataInterfaceHoudini(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceHoudini.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004D01 RID: 19713
		// (get) Token: 0x06013AA2 RID: 80546 RVA: 0x001CE27B File Offset: 0x001CC47B
		// (set) Token: 0x06013AA3 RID: 80547 RVA: 0x001CE28F File Offset: 0x001CC48F
		[Nullable(2)]
		public unsafe UHoudiniPointCache HoudiniPointCacheAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UHoudiniPointCache>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceHoudini.__PropertyOffset_HoudiniPointCacheAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceHoudini.__PropertyOffset_HoudiniPointCacheAsset, value);
			}
		}

		// Token: 0x06013AA4 RID: 80548 RVA: 0x001CE2A4 File Offset: 0x001CC4A4
		static UNiagaraDataInterfaceHoudini()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniNiagara.NiagaraDataInterfaceHoudini");
		}

		// Token: 0x06013AA5 RID: 80549 RVA: 0x001CE2B2 File Offset: 0x001CC4B2
		protected UNiagaraDataInterfaceHoudini(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A9DA RID: 43482
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniNiagara.NiagaraDataInterfaceHoudini";

		// Token: 0x0400A9DB RID: 43483
		private static IntPtr _ClassPtr;

		// Token: 0x0400A9DC RID: 43484
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A9DD RID: 43485
		internal static int __PropertyOffset_HoudiniPointCacheAsset;
	}
}
