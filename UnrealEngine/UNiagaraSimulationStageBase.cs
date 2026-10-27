using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025EA RID: 9706
	[UnrealObjectPath("/Script/Niagara.NiagaraSimulationStageBase")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UNiagaraSimulationStageBase : UNiagaraMergeable, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024125 RID: 147749 RVA: 0x00355EE2 File Offset: 0x003540E2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraSimulationStageBase._ClassPtr;
		}

		// Token: 0x06024126 RID: 147750 RVA: 0x00355EF0 File Offset: 0x003540F0
		public UNiagaraSimulationStageBase() : this(BuiltinUtils.AllocNativeUObject(UNiagaraSimulationStageBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024127 RID: 147751 RVA: 0x00355F18 File Offset: 0x00354118
		[NullableContext(1)]
		public UNiagaraSimulationStageBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraSimulationStageBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008AC7 RID: 35527
		// (get) Token: 0x06024128 RID: 147752 RVA: 0x00355F4B File Offset: 0x0035414B
		// (set) Token: 0x06024129 RID: 147753 RVA: 0x00355F5F File Offset: 0x0035415F
		[Nullable(2)]
		public unsafe UNiagaraScript Script
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraScript>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraSimulationStageBase.__PropertyOffset_Script);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraSimulationStageBase.__PropertyOffset_Script, value);
			}
		}

		// Token: 0x17008AC8 RID: 35528
		// (get) Token: 0x0602412A RID: 147754 RVA: 0x00355F74 File Offset: 0x00354174
		// (set) Token: 0x0602412B RID: 147755 RVA: 0x00355F88 File Offset: 0x00354188
		public unsafe FName SimulationStageName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSimulationStageBase.__PropertyOffset_SimulationStageName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSimulationStageBase.__PropertyOffset_SimulationStageName) = value;
			}
		}

		// Token: 0x17008AC9 RID: 35529
		// (get) Token: 0x0602412C RID: 147756 RVA: 0x00355F9D File Offset: 0x0035419D
		// (set) Token: 0x0602412D RID: 147757 RVA: 0x00355FB6 File Offset: 0x003541B6
		public unsafe bool bEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraSimulationStageBase.__PropertyOffset_bEnabled) & UNiagaraSimulationStageBase.__PropertyMask_bEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraSimulationStageBase.__PropertyOffset_bEnabled) = ((*(base.NativePtr + (IntPtr)UNiagaraSimulationStageBase.__PropertyOffset_bEnabled) & ~UNiagaraSimulationStageBase.__PropertyMask_bEnabled) | (value ? UNiagaraSimulationStageBase.__PropertyMask_bEnabled : 0));
			}
		}

		// Token: 0x0602412E RID: 147758 RVA: 0x00355FE6 File Offset: 0x003541E6
		static UNiagaraSimulationStageBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraSimulationStageBase");
		}

		// Token: 0x0602412F RID: 147759 RVA: 0x00355FF4 File Offset: 0x003541F4
		protected UNiagaraSimulationStageBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013589 RID: 79241
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraSimulationStageBase";

		// Token: 0x0401358A RID: 79242
		private static IntPtr _ClassPtr;

		// Token: 0x0401358B RID: 79243
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401358C RID: 79244
		internal static int __PropertyOffset_Script;

		// Token: 0x0401358D RID: 79245
		internal static int __PropertyOffset_SimulationStageName;

		// Token: 0x0401358E RID: 79246
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x0401358F RID: 79247
		internal static byte __PropertyMask_bEnabled;
	}
}
