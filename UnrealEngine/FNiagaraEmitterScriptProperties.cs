using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025A3 RID: 9635
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraEmitterScriptProperties")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FNiagaraEmitterScriptProperties : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023C9B RID: 146587 RVA: 0x0034ED28 File Offset: 0x0034CF28
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraEmitterScriptProperties._ScriptStructPtr != 0) ? FNiagaraEmitterScriptProperties._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraEmitterScriptProperties", ref FNiagaraEmitterScriptProperties._ScriptStructPtr);
		}

		// Token: 0x1700898E RID: 35214
		// (get) Token: 0x06023C9C RID: 146588 RVA: 0x0034ED4C File Offset: 0x0034CF4C
		// (set) Token: 0x06023C9D RID: 146589 RVA: 0x0034ED60 File Offset: 0x0034CF60
		[Nullable(2)]
		public unsafe UNiagaraScript Script
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraScript>(base.NativePtr / (IntPtr)sizeof(void*) + FNiagaraEmitterScriptProperties.__PropertyOffset_Script);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FNiagaraEmitterScriptProperties.__PropertyOffset_Script, value);
			}
		}

		// Token: 0x1700898F RID: 35215
		// (get) Token: 0x06023C9E RID: 146590 RVA: 0x0034ED78 File Offset: 0x0034CF78
		// (set) Token: 0x06023C9F RID: 146591 RVA: 0x0034EDBB File Offset: 0x0034CFBB
		public TArray<FNiagaraEventReceiverProperties> EventReceivers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraEventReceiverProperties> result;
				if ((result = this._EventReceivers) == null)
				{
					result = (this._EventReceivers = new TArray<FNiagaraEventReceiverProperties>(base.NativePtr + (IntPtr)FNiagaraEmitterScriptProperties.__PropertyOffset_EventReceivers, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EventReceivers.CopyAssign(value);
			}
		}

		// Token: 0x17008990 RID: 35216
		// (get) Token: 0x06023CA0 RID: 146592 RVA: 0x0034EDCC File Offset: 0x0034CFCC
		// (set) Token: 0x06023CA1 RID: 146593 RVA: 0x0034EE0F File Offset: 0x0034D00F
		public TArray<FNiagaraEventGeneratorProperties> EventGenerators
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraEventGeneratorProperties> result;
				if ((result = this._EventGenerators) == null)
				{
					result = (this._EventGenerators = new TArray<FNiagaraEventGeneratorProperties>(base.NativePtr + (IntPtr)FNiagaraEmitterScriptProperties.__PropertyOffset_EventGenerators, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EventGenerators.CopyAssign(value);
			}
		}

		// Token: 0x06023CA2 RID: 146594 RVA: 0x0034EE1D File Offset: 0x0034D01D
		public FNiagaraEmitterScriptProperties()
		{
		}

		// Token: 0x06023CA3 RID: 146595 RVA: 0x0034EE25 File Offset: 0x0034D025
		public FNiagaraEmitterScriptProperties(UNiagaraScript Script, TArray<FNiagaraEventReceiverProperties> EventReceivers, TArray<FNiagaraEventGeneratorProperties> EventGenerators)
		{
			this.Script = Script;
			this.EventReceivers = EventReceivers;
			this.EventGenerators = EventGenerators;
		}

		// Token: 0x06023CA4 RID: 146596 RVA: 0x0034EE42 File Offset: 0x0034D042
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraEmitterScriptProperties.StaticStruct();
		}

		// Token: 0x06023CA5 RID: 146597 RVA: 0x0034EE4E File Offset: 0x0034D04E
		[NullableContext(2)]
		public FNiagaraEmitterScriptProperties(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023CA6 RID: 146598 RVA: 0x0034EE58 File Offset: 0x0034D058
		public FNiagaraEmitterScriptProperties(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023CA7 RID: 146599 RVA: 0x0034EE63 File Offset: 0x0034D063
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraEmitterScriptProperties(Pointer, false, true);
		}

		// Token: 0x06023CA8 RID: 146600 RVA: 0x0034EE6D File Offset: 0x0034D06D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraEmitterScriptProperties(Pointer, MemoryOwner);
		}

		// Token: 0x0401331E RID: 78622
		public const string __ObjectPath = "/Script/Niagara.NiagaraEmitterScriptProperties";

		// Token: 0x0401331F RID: 78623
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013320 RID: 78624
		internal static int __PropertyOffset_Script;

		// Token: 0x04013321 RID: 78625
		internal static int __PropertyOffset_EventReceivers;

		// Token: 0x04013322 RID: 78626
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraEventReceiverProperties> _EventReceivers;

		// Token: 0x04013323 RID: 78627
		internal static int __PropertyOffset_EventGenerators;

		// Token: 0x04013324 RID: 78628
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraEventGeneratorProperties> _EventGenerators;
	}
}
