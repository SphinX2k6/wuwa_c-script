using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200037D RID: 893
	[UnrealObjectPath("/Script/AudioMixer.SubmixEffectDynamicProcessorFilterSettings")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FSubmixEffectDynamicProcessorFilterSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003104 RID: 12548 RVA: 0x0004BD54 File Offset: 0x00049F54
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSubmixEffectDynamicProcessorFilterSettings._ScriptStructPtr != 0) ? FSubmixEffectDynamicProcessorFilterSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AudioMixer.SubmixEffectDynamicProcessorFilterSettings", ref FSubmixEffectDynamicProcessorFilterSettings._ScriptStructPtr);
		}

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x06003105 RID: 12549 RVA: 0x0004BD78 File Offset: 0x00049F78
		// (set) Token: 0x06003106 RID: 12550 RVA: 0x0004BD91 File Offset: 0x00049F91
		public unsafe bool bEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSubmixEffectDynamicProcessorFilterSettings.__PropertyOffset_bEnabled) & FSubmixEffectDynamicProcessorFilterSettings.__PropertyMask_bEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSubmixEffectDynamicProcessorFilterSettings.__PropertyOffset_bEnabled) = ((*(base.NativePtr + (IntPtr)FSubmixEffectDynamicProcessorFilterSettings.__PropertyOffset_bEnabled) & ~FSubmixEffectDynamicProcessorFilterSettings.__PropertyMask_bEnabled) | (value ? FSubmixEffectDynamicProcessorFilterSettings.__PropertyMask_bEnabled : 0));
			}
		}

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x06003107 RID: 12551 RVA: 0x0004BDC1 File Offset: 0x00049FC1
		// (set) Token: 0x06003108 RID: 12552 RVA: 0x0004BDD1 File Offset: 0x00049FD1
		public unsafe float Cutoff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubmixEffectDynamicProcessorFilterSettings.__PropertyOffset_Cutoff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubmixEffectDynamicProcessorFilterSettings.__PropertyOffset_Cutoff) = value;
			}
		}

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x06003109 RID: 12553 RVA: 0x0004BDE2 File Offset: 0x00049FE2
		// (set) Token: 0x0600310A RID: 12554 RVA: 0x0004BDF2 File Offset: 0x00049FF2
		public unsafe float GainDb
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubmixEffectDynamicProcessorFilterSettings.__PropertyOffset_GainDb);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubmixEffectDynamicProcessorFilterSettings.__PropertyOffset_GainDb) = value;
			}
		}

		// Token: 0x0600310B RID: 12555 RVA: 0x0004BE03 File Offset: 0x0004A003
		public FSubmixEffectDynamicProcessorFilterSettings()
		{
		}

		// Token: 0x0600310C RID: 12556 RVA: 0x0004BE0B File Offset: 0x0004A00B
		public FSubmixEffectDynamicProcessorFilterSettings(bool bEnabled, float Cutoff, float GainDb)
		{
			this.bEnabled = bEnabled;
			this.Cutoff = Cutoff;
			this.GainDb = GainDb;
		}

		// Token: 0x0600310D RID: 12557 RVA: 0x0004BE28 File Offset: 0x0004A028
		protected override IntPtr GetUStructPtr()
		{
			return FSubmixEffectDynamicProcessorFilterSettings.StaticStruct();
		}

		// Token: 0x0600310E RID: 12558 RVA: 0x0004BE34 File Offset: 0x0004A034
		[NullableContext(2)]
		public FSubmixEffectDynamicProcessorFilterSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600310F RID: 12559 RVA: 0x0004BE3E File Offset: 0x0004A03E
		public FSubmixEffectDynamicProcessorFilterSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003110 RID: 12560 RVA: 0x0004BE49 File Offset: 0x0004A049
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSubmixEffectDynamicProcessorFilterSettings(Pointer, false, true);
		}

		// Token: 0x06003111 RID: 12561 RVA: 0x0004BE53 File Offset: 0x0004A053
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSubmixEffectDynamicProcessorFilterSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0400154E RID: 5454
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AudioMixer.SubmixEffectDynamicProcessorFilterSettings";

		// Token: 0x0400154F RID: 5455
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001550 RID: 5456
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x04001551 RID: 5457
		internal static byte __PropertyMask_bEnabled;

		// Token: 0x04001552 RID: 5458
		internal static int __PropertyOffset_Cutoff;

		// Token: 0x04001553 RID: 5459
		internal static int __PropertyOffset_GainDb;
	}
}
