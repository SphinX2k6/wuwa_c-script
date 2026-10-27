using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025A7 RID: 9639
	[UnrealObjectPath("/Script/Niagara.NiagaraEventReceiverProperties")]
	[UnrealStructLayout(36, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class FNiagaraEventReceiverProperties : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023CC2 RID: 146626 RVA: 0x0034F08F File Offset: 0x0034D28F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraEventReceiverProperties._ScriptStructPtr != 0) ? FNiagaraEventReceiverProperties._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraEventReceiverProperties", ref FNiagaraEventReceiverProperties._ScriptStructPtr);
		}

		// Token: 0x17008995 RID: 35221
		// (get) Token: 0x06023CC3 RID: 146627 RVA: 0x0034F0B3 File Offset: 0x0034D2B3
		// (set) Token: 0x06023CC4 RID: 146628 RVA: 0x0034F0C7 File Offset: 0x0034D2C7
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraEventReceiverProperties.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraEventReceiverProperties.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17008996 RID: 35222
		// (get) Token: 0x06023CC5 RID: 146629 RVA: 0x0034F0DC File Offset: 0x0034D2DC
		// (set) Token: 0x06023CC6 RID: 146630 RVA: 0x0034F0F0 File Offset: 0x0034D2F0
		public unsafe FName SourceEventGenerator
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraEventReceiverProperties.__PropertyOffset_SourceEventGenerator);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraEventReceiverProperties.__PropertyOffset_SourceEventGenerator) = value;
			}
		}

		// Token: 0x17008997 RID: 35223
		// (get) Token: 0x06023CC7 RID: 146631 RVA: 0x0034F105 File Offset: 0x0034D305
		// (set) Token: 0x06023CC8 RID: 146632 RVA: 0x0034F119 File Offset: 0x0034D319
		public unsafe FName SourceEmitter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraEventReceiverProperties.__PropertyOffset_SourceEmitter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraEventReceiverProperties.__PropertyOffset_SourceEmitter) = value;
			}
		}

		// Token: 0x06023CC9 RID: 146633 RVA: 0x0034F12E File Offset: 0x0034D32E
		public FNiagaraEventReceiverProperties()
		{
		}

		// Token: 0x06023CCA RID: 146634 RVA: 0x0034F136 File Offset: 0x0034D336
		public FNiagaraEventReceiverProperties(FName Name, FName SourceEventGenerator, FName SourceEmitter)
		{
			this.Name = Name;
			this.SourceEventGenerator = SourceEventGenerator;
			this.SourceEmitter = SourceEmitter;
		}

		// Token: 0x06023CCB RID: 146635 RVA: 0x0034F153 File Offset: 0x0034D353
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraEventReceiverProperties.StaticStruct();
		}

		// Token: 0x06023CCC RID: 146636 RVA: 0x0034F15F File Offset: 0x0034D35F
		[NullableContext(2)]
		public FNiagaraEventReceiverProperties(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023CCD RID: 146637 RVA: 0x0034F169 File Offset: 0x0034D369
		public FNiagaraEventReceiverProperties(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023CCE RID: 146638 RVA: 0x0034F174 File Offset: 0x0034D374
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraEventReceiverProperties(Pointer, false, true);
		}

		// Token: 0x06023CCF RID: 146639 RVA: 0x0034F17E File Offset: 0x0034D37E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraEventReceiverProperties(Pointer, MemoryOwner);
		}

		// Token: 0x04013332 RID: 78642
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NiagaraEventReceiverProperties";

		// Token: 0x04013333 RID: 78643
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013334 RID: 78644
		internal static int __PropertyOffset_Name;

		// Token: 0x04013335 RID: 78645
		internal static int __PropertyOffset_SourceEventGenerator;

		// Token: 0x04013336 RID: 78646
		internal static int __PropertyOffset_SourceEmitter;
	}
}
