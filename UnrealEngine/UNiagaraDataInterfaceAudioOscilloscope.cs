using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002567 RID: 9575
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceAudioOscilloscope")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UNiagaraDataInterfaceAudioOscilloscope : UNiagaraDataInterface, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060238EB RID: 145643 RVA: 0x00348FAA File Offset: 0x003471AA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceAudioOscilloscope._ClassPtr;
		}

		// Token: 0x060238EC RID: 145644 RVA: 0x00348FB8 File Offset: 0x003471B8
		public UNiagaraDataInterfaceAudioOscilloscope() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceAudioOscilloscope.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060238ED RID: 145645 RVA: 0x00348FE0 File Offset: 0x003471E0
		[NullableContext(1)]
		public UNiagaraDataInterfaceAudioOscilloscope(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceAudioOscilloscope.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700886C RID: 34924
		// (get) Token: 0x060238EE RID: 145646 RVA: 0x00349013 File Offset: 0x00347213
		// (set) Token: 0x060238EF RID: 145647 RVA: 0x00349027 File Offset: 0x00347227
		[Nullable(2)]
		public unsafe USoundSubmix Submix
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundSubmix>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceAudioOscilloscope.__PropertyOffset_Submix);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceAudioOscilloscope.__PropertyOffset_Submix, value);
			}
		}

		// Token: 0x1700886D RID: 34925
		// (get) Token: 0x060238F0 RID: 145648 RVA: 0x0034903C File Offset: 0x0034723C
		// (set) Token: 0x060238F1 RID: 145649 RVA: 0x0034904C File Offset: 0x0034724C
		public unsafe int Resolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceAudioOscilloscope.__PropertyOffset_Resolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceAudioOscilloscope.__PropertyOffset_Resolution) = value;
			}
		}

		// Token: 0x1700886E RID: 34926
		// (get) Token: 0x060238F2 RID: 145650 RVA: 0x0034905D File Offset: 0x0034725D
		// (set) Token: 0x060238F3 RID: 145651 RVA: 0x0034906D File Offset: 0x0034726D
		public unsafe float ScopeInMilliseconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceAudioOscilloscope.__PropertyOffset_ScopeInMilliseconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceAudioOscilloscope.__PropertyOffset_ScopeInMilliseconds) = value;
			}
		}

		// Token: 0x060238F4 RID: 145652 RVA: 0x0034907E File Offset: 0x0034727E
		static UNiagaraDataInterfaceAudioOscilloscope()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceAudioOscilloscope");
		}

		// Token: 0x060238F5 RID: 145653 RVA: 0x0034908C File Offset: 0x0034728C
		protected UNiagaraDataInterfaceAudioOscilloscope(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040130F0 RID: 78064
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceAudioOscilloscope";

		// Token: 0x040130F1 RID: 78065
		private static IntPtr _ClassPtr;

		// Token: 0x040130F2 RID: 78066
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040130F3 RID: 78067
		internal static int __PropertyOffset_Submix;

		// Token: 0x040130F4 RID: 78068
		internal static int __PropertyOffset_Resolution;

		// Token: 0x040130F5 RID: 78069
		internal static int __PropertyOffset_ScopeInMilliseconds;
	}
}
