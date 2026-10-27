using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200115B RID: 4443
	[UnrealObjectPath("/Script/Engine.SoundWaveEnvelopeDataPerSound")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FSoundWaveEnvelopeDataPerSound : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060103E4 RID: 66532 RVA: 0x0017EF30 File Offset: 0x0017D130
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSoundWaveEnvelopeDataPerSound._ScriptStructPtr != 0) ? FSoundWaveEnvelopeDataPerSound._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SoundWaveEnvelopeDataPerSound", ref FSoundWaveEnvelopeDataPerSound._ScriptStructPtr);
		}

		// Token: 0x17003FAB RID: 16299
		// (get) Token: 0x060103E5 RID: 66533 RVA: 0x0017EF54 File Offset: 0x0017D154
		// (set) Token: 0x060103E6 RID: 66534 RVA: 0x0017EF64 File Offset: 0x0017D164
		public unsafe float Envelope
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundWaveEnvelopeDataPerSound.__PropertyOffset_Envelope);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundWaveEnvelopeDataPerSound.__PropertyOffset_Envelope) = value;
			}
		}

		// Token: 0x17003FAC RID: 16300
		// (get) Token: 0x060103E7 RID: 66535 RVA: 0x0017EF75 File Offset: 0x0017D175
		// (set) Token: 0x060103E8 RID: 66536 RVA: 0x0017EF85 File Offset: 0x0017D185
		public unsafe float PlaybackTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundWaveEnvelopeDataPerSound.__PropertyOffset_PlaybackTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundWaveEnvelopeDataPerSound.__PropertyOffset_PlaybackTime) = value;
			}
		}

		// Token: 0x17003FAD RID: 16301
		// (get) Token: 0x060103E9 RID: 66537 RVA: 0x0017EF96 File Offset: 0x0017D196
		// (set) Token: 0x060103EA RID: 66538 RVA: 0x0017EFAA File Offset: 0x0017D1AA
		[Nullable(2)]
		public unsafe USoundWave SoundWave
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundWave>(base.NativePtr / (IntPtr)sizeof(void*) + FSoundWaveEnvelopeDataPerSound.__PropertyOffset_SoundWave);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSoundWaveEnvelopeDataPerSound.__PropertyOffset_SoundWave, value);
			}
		}

		// Token: 0x060103EB RID: 66539 RVA: 0x0017EFBF File Offset: 0x0017D1BF
		public FSoundWaveEnvelopeDataPerSound()
		{
		}

		// Token: 0x060103EC RID: 66540 RVA: 0x0017EFC7 File Offset: 0x0017D1C7
		[NullableContext(1)]
		public FSoundWaveEnvelopeDataPerSound(float Envelope, float PlaybackTime, USoundWave SoundWave)
		{
			this.Envelope = Envelope;
			this.PlaybackTime = PlaybackTime;
			this.SoundWave = SoundWave;
		}

		// Token: 0x060103ED RID: 66541 RVA: 0x0017EFE4 File Offset: 0x0017D1E4
		protected override IntPtr GetUStructPtr()
		{
			return FSoundWaveEnvelopeDataPerSound.StaticStruct();
		}

		// Token: 0x060103EE RID: 66542 RVA: 0x0017EFF0 File Offset: 0x0017D1F0
		[NullableContext(2)]
		public FSoundWaveEnvelopeDataPerSound(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060103EF RID: 66543 RVA: 0x0017EFFA File Offset: 0x0017D1FA
		public FSoundWaveEnvelopeDataPerSound(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060103F0 RID: 66544 RVA: 0x0017F005 File Offset: 0x0017D205
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSoundWaveEnvelopeDataPerSound(Pointer, false, true);
		}

		// Token: 0x060103F1 RID: 66545 RVA: 0x0017F00F File Offset: 0x0017D20F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSoundWaveEnvelopeDataPerSound(Pointer, MemoryOwner);
		}

		// Token: 0x04008BD9 RID: 35801
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SoundWaveEnvelopeDataPerSound";

		// Token: 0x04008BDA RID: 35802
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008BDB RID: 35803
		internal static int __PropertyOffset_Envelope;

		// Token: 0x04008BDC RID: 35804
		internal static int __PropertyOffset_PlaybackTime;

		// Token: 0x04008BDD RID: 35805
		internal static int __PropertyOffset_SoundWave;
	}
}
