using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000380 RID: 896
	[UnrealObjectPath("/Script/AudioMixer.SubmixEffectEQBand")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FSubmixEffectEQBand : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003149 RID: 12617 RVA: 0x0004C3C8 File Offset: 0x0004A5C8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSubmixEffectEQBand._ScriptStructPtr != 0) ? FSubmixEffectEQBand._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AudioMixer.SubmixEffectEQBand", ref FSubmixEffectEQBand._ScriptStructPtr);
		}

		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x0600314A RID: 12618 RVA: 0x0004C3EC File Offset: 0x0004A5EC
		// (set) Token: 0x0600314B RID: 12619 RVA: 0x0004C3FC File Offset: 0x0004A5FC
		public unsafe float Frequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubmixEffectEQBand.__PropertyOffset_Frequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubmixEffectEQBand.__PropertyOffset_Frequency) = value;
			}
		}

		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x0600314C RID: 12620 RVA: 0x0004C40D File Offset: 0x0004A60D
		// (set) Token: 0x0600314D RID: 12621 RVA: 0x0004C41D File Offset: 0x0004A61D
		public unsafe float Bandwidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubmixEffectEQBand.__PropertyOffset_Bandwidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubmixEffectEQBand.__PropertyOffset_Bandwidth) = value;
			}
		}

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x0600314E RID: 12622 RVA: 0x0004C42E File Offset: 0x0004A62E
		// (set) Token: 0x0600314F RID: 12623 RVA: 0x0004C43E File Offset: 0x0004A63E
		public unsafe float GainDb
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubmixEffectEQBand.__PropertyOffset_GainDb);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubmixEffectEQBand.__PropertyOffset_GainDb) = value;
			}
		}

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x06003150 RID: 12624 RVA: 0x0004C44F File Offset: 0x0004A64F
		// (set) Token: 0x06003151 RID: 12625 RVA: 0x0004C468 File Offset: 0x0004A668
		public unsafe bool bEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSubmixEffectEQBand.__PropertyOffset_bEnabled) & FSubmixEffectEQBand.__PropertyMask_bEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSubmixEffectEQBand.__PropertyOffset_bEnabled) = ((*(base.NativePtr + (IntPtr)FSubmixEffectEQBand.__PropertyOffset_bEnabled) & ~FSubmixEffectEQBand.__PropertyMask_bEnabled) | (value ? FSubmixEffectEQBand.__PropertyMask_bEnabled : 0));
			}
		}

		// Token: 0x06003152 RID: 12626 RVA: 0x0004C498 File Offset: 0x0004A698
		public FSubmixEffectEQBand()
		{
		}

		// Token: 0x06003153 RID: 12627 RVA: 0x0004C4A0 File Offset: 0x0004A6A0
		public FSubmixEffectEQBand(float Frequency, float Bandwidth, float GainDb, bool bEnabled)
		{
			this.Frequency = Frequency;
			this.Bandwidth = Bandwidth;
			this.GainDb = GainDb;
			this.bEnabled = bEnabled;
		}

		// Token: 0x06003154 RID: 12628 RVA: 0x0004C4C5 File Offset: 0x0004A6C5
		protected override IntPtr GetUStructPtr()
		{
			return FSubmixEffectEQBand.StaticStruct();
		}

		// Token: 0x06003155 RID: 12629 RVA: 0x0004C4D1 File Offset: 0x0004A6D1
		[NullableContext(2)]
		public FSubmixEffectEQBand(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003156 RID: 12630 RVA: 0x0004C4DB File Offset: 0x0004A6DB
		public FSubmixEffectEQBand(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003157 RID: 12631 RVA: 0x0004C4E6 File Offset: 0x0004A6E6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSubmixEffectEQBand(Pointer, false, true);
		}

		// Token: 0x06003158 RID: 12632 RVA: 0x0004C4F0 File Offset: 0x0004A6F0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSubmixEffectEQBand(Pointer, MemoryOwner);
		}

		// Token: 0x04001572 RID: 5490
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AudioMixer.SubmixEffectEQBand";

		// Token: 0x04001573 RID: 5491
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001574 RID: 5492
		internal static int __PropertyOffset_Frequency;

		// Token: 0x04001575 RID: 5493
		internal static int __PropertyOffset_Bandwidth;

		// Token: 0x04001576 RID: 5494
		internal static int __PropertyOffset_GainDb;

		// Token: 0x04001577 RID: 5495
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x04001578 RID: 5496
		internal static byte __PropertyMask_bEnabled;
	}
}
