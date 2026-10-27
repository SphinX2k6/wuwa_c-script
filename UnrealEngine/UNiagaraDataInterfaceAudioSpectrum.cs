using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002569 RID: 9577
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceAudioSpectrum")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UNiagaraDataInterfaceAudioSpectrum : UNiagaraDataInterfaceAudioSubmix, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023909 RID: 145673 RVA: 0x0034923D File Offset: 0x0034743D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceAudioSpectrum._ClassPtr;
		}

		// Token: 0x0602390A RID: 145674 RVA: 0x0034924C File Offset: 0x0034744C
		public UNiagaraDataInterfaceAudioSpectrum() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceAudioSpectrum.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602390B RID: 145675 RVA: 0x00349274 File Offset: 0x00347474
		[NullableContext(1)]
		public UNiagaraDataInterfaceAudioSpectrum(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceAudioSpectrum.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008876 RID: 34934
		// (get) Token: 0x0602390C RID: 145676 RVA: 0x003492A7 File Offset: 0x003474A7
		// (set) Token: 0x0602390D RID: 145677 RVA: 0x003492B7 File Offset: 0x003474B7
		public unsafe int Resolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceAudioSpectrum.__PropertyOffset_Resolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceAudioSpectrum.__PropertyOffset_Resolution) = value;
			}
		}

		// Token: 0x17008877 RID: 34935
		// (get) Token: 0x0602390E RID: 145678 RVA: 0x003492C8 File Offset: 0x003474C8
		// (set) Token: 0x0602390F RID: 145679 RVA: 0x003492D8 File Offset: 0x003474D8
		public unsafe float MinimumFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceAudioSpectrum.__PropertyOffset_MinimumFrequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceAudioSpectrum.__PropertyOffset_MinimumFrequency) = value;
			}
		}

		// Token: 0x17008878 RID: 34936
		// (get) Token: 0x06023910 RID: 145680 RVA: 0x003492E9 File Offset: 0x003474E9
		// (set) Token: 0x06023911 RID: 145681 RVA: 0x003492F9 File Offset: 0x003474F9
		public unsafe float MaximumFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceAudioSpectrum.__PropertyOffset_MaximumFrequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceAudioSpectrum.__PropertyOffset_MaximumFrequency) = value;
			}
		}

		// Token: 0x17008879 RID: 34937
		// (get) Token: 0x06023912 RID: 145682 RVA: 0x0034930A File Offset: 0x0034750A
		// (set) Token: 0x06023913 RID: 145683 RVA: 0x0034931A File Offset: 0x0034751A
		public unsafe float NoiseFloorDb
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceAudioSpectrum.__PropertyOffset_NoiseFloorDb);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceAudioSpectrum.__PropertyOffset_NoiseFloorDb) = value;
			}
		}

		// Token: 0x06023914 RID: 145684 RVA: 0x0034932B File Offset: 0x0034752B
		static UNiagaraDataInterfaceAudioSpectrum()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceAudioSpectrum");
		}

		// Token: 0x06023915 RID: 145685 RVA: 0x00349339 File Offset: 0x00347539
		protected UNiagaraDataInterfaceAudioSpectrum(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013101 RID: 78081
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceAudioSpectrum";

		// Token: 0x04013102 RID: 78082
		private static IntPtr _ClassPtr;

		// Token: 0x04013103 RID: 78083
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013104 RID: 78084
		internal static int __PropertyOffset_Resolution;

		// Token: 0x04013105 RID: 78085
		internal static int __PropertyOffset_MinimumFrequency;

		// Token: 0x04013106 RID: 78086
		internal static int __PropertyOffset_MaximumFrequency;

		// Token: 0x04013107 RID: 78087
		internal static int __PropertyOffset_NoiseFloorDb;
	}
}
