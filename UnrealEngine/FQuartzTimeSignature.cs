using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200105D RID: 4189
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.QuartzTimeSignature")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FQuartzTimeSignature : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600EE43 RID: 60995 RVA: 0x00161860 File Offset: 0x0015FA60
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FQuartzTimeSignature._ScriptStructPtr != 0) ? FQuartzTimeSignature._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.QuartzTimeSignature", ref FQuartzTimeSignature._ScriptStructPtr);
		}

		// Token: 0x170039A8 RID: 14760
		// (get) Token: 0x0600EE44 RID: 60996 RVA: 0x00161884 File Offset: 0x0015FA84
		// (set) Token: 0x0600EE45 RID: 60997 RVA: 0x00161894 File Offset: 0x0015FA94
		public unsafe int NumBeats
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQuartzTimeSignature.__PropertyOffset_NumBeats);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQuartzTimeSignature.__PropertyOffset_NumBeats) = value;
			}
		}

		// Token: 0x170039A9 RID: 14761
		// (get) Token: 0x0600EE46 RID: 60998 RVA: 0x001618A5 File Offset: 0x0015FAA5
		// (set) Token: 0x0600EE47 RID: 60999 RVA: 0x001618B5 File Offset: 0x0015FAB5
		public unsafe EQuartzTimeSignatureQuantization BeatType
		{
			get
			{
				return (EQuartzTimeSignatureQuantization)(*(base.NativePtr + (IntPtr)FQuartzTimeSignature.__PropertyOffset_BeatType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQuartzTimeSignature.__PropertyOffset_BeatType) = (byte)value;
			}
		}

		// Token: 0x170039AA RID: 14762
		// (get) Token: 0x0600EE48 RID: 61000 RVA: 0x001618C8 File Offset: 0x0015FAC8
		// (set) Token: 0x0600EE49 RID: 61001 RVA: 0x0016190B File Offset: 0x0015FB0B
		public TArray<FQuartzPulseOverrideStep> OptionalPulseOverride
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FQuartzPulseOverrideStep> result;
				if ((result = this._OptionalPulseOverride) == null)
				{
					result = (this._OptionalPulseOverride = new TArray<FQuartzPulseOverrideStep>(base.NativePtr + (IntPtr)FQuartzTimeSignature.__PropertyOffset_OptionalPulseOverride, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.OptionalPulseOverride.CopyAssign(value);
			}
		}

		// Token: 0x0600EE4A RID: 61002 RVA: 0x00161919 File Offset: 0x0015FB19
		public FQuartzTimeSignature()
		{
		}

		// Token: 0x0600EE4B RID: 61003 RVA: 0x00161921 File Offset: 0x0015FB21
		public FQuartzTimeSignature(int NumBeats, EQuartzTimeSignatureQuantization BeatType, TArray<FQuartzPulseOverrideStep> OptionalPulseOverride)
		{
			this.NumBeats = NumBeats;
			this.BeatType = BeatType;
			this.OptionalPulseOverride = OptionalPulseOverride;
		}

		// Token: 0x0600EE4C RID: 61004 RVA: 0x0016193E File Offset: 0x0015FB3E
		protected override IntPtr GetUStructPtr()
		{
			return FQuartzTimeSignature.StaticStruct();
		}

		// Token: 0x0600EE4D RID: 61005 RVA: 0x0016194A File Offset: 0x0015FB4A
		[NullableContext(2)]
		public FQuartzTimeSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600EE4E RID: 61006 RVA: 0x00161954 File Offset: 0x0015FB54
		public FQuartzTimeSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600EE4F RID: 61007 RVA: 0x0016195F File Offset: 0x0015FB5F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FQuartzTimeSignature(Pointer, false, true);
		}

		// Token: 0x0600EE50 RID: 61008 RVA: 0x00161969 File Offset: 0x0015FB69
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FQuartzTimeSignature(Pointer, MemoryOwner);
		}

		// Token: 0x040080FE RID: 33022
		public const string __ObjectPath = "/Script/Engine.QuartzTimeSignature";

		// Token: 0x040080FF RID: 33023
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008100 RID: 33024
		internal static int __PropertyOffset_NumBeats;

		// Token: 0x04008101 RID: 33025
		internal static int __PropertyOffset_BeatType;

		// Token: 0x04008102 RID: 33026
		internal static int __PropertyOffset_OptionalPulseOverride;

		// Token: 0x04008103 RID: 33027
		[Nullable(2)]
		private TArray<FQuartzPulseOverrideStep> _OptionalPulseOverride;
	}
}
