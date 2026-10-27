using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010E4 RID: 4324
	[UnrealObjectPath("/Script/Engine.ServerStatReplicator")]
	[UnrealStructLayout(1248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1248)]
	public class AServerStatReplicator : AInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F7E5 RID: 63461 RVA: 0x0016ED3F File Offset: 0x0016CF3F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AServerStatReplicator._ClassPtr;
		}

		// Token: 0x0600F7E6 RID: 63462 RVA: 0x0016ED4C File Offset: 0x0016CF4C
		public AServerStatReplicator() : this(BuiltinUtils.AllocNativeUObject(AServerStatReplicator.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F7E7 RID: 63463 RVA: 0x0016ED74 File Offset: 0x0016CF74
		[NullableContext(1)]
		public AServerStatReplicator(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AServerStatReplicator.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003C4E RID: 15438
		// (get) Token: 0x0600F7E8 RID: 63464 RVA: 0x0016EDA7 File Offset: 0x0016CFA7
		// (set) Token: 0x0600F7E9 RID: 63465 RVA: 0x0016EDB7 File Offset: 0x0016CFB7
		public unsafe bool bUpdateStatNet
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_bUpdateStatNet) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_bUpdateStatNet) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003C4F RID: 15439
		// (get) Token: 0x0600F7EA RID: 63466 RVA: 0x0016EDC8 File Offset: 0x0016CFC8
		// (set) Token: 0x0600F7EB RID: 63467 RVA: 0x0016EDD8 File Offset: 0x0016CFD8
		public unsafe bool bOverwriteClientStats
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_bOverwriteClientStats) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_bOverwriteClientStats) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003C50 RID: 15440
		// (get) Token: 0x0600F7EC RID: 63468 RVA: 0x0016EDE9 File Offset: 0x0016CFE9
		// (set) Token: 0x0600F7ED RID: 63469 RVA: 0x0016EDF9 File Offset: 0x0016CFF9
		public unsafe uint Channels
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_Channels);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_Channels) = (int)value;
			}
		}

		// Token: 0x17003C51 RID: 15441
		// (get) Token: 0x0600F7EE RID: 63470 RVA: 0x0016EE0A File Offset: 0x0016D00A
		// (set) Token: 0x0600F7EF RID: 63471 RVA: 0x0016EE1A File Offset: 0x0016D01A
		public unsafe uint InRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_InRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_InRate) = (int)value;
			}
		}

		// Token: 0x17003C52 RID: 15442
		// (get) Token: 0x0600F7F0 RID: 63472 RVA: 0x0016EE2B File Offset: 0x0016D02B
		// (set) Token: 0x0600F7F1 RID: 63473 RVA: 0x0016EE3B File Offset: 0x0016D03B
		public unsafe uint OutRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_OutRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_OutRate) = (int)value;
			}
		}

		// Token: 0x17003C53 RID: 15443
		// (get) Token: 0x0600F7F2 RID: 63474 RVA: 0x0016EE4C File Offset: 0x0016D04C
		// (set) Token: 0x0600F7F3 RID: 63475 RVA: 0x0016EE5C File Offset: 0x0016D05C
		public unsafe uint MaxPacketOverhead
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_MaxPacketOverhead);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_MaxPacketOverhead) = (int)value;
			}
		}

		// Token: 0x17003C54 RID: 15444
		// (get) Token: 0x0600F7F4 RID: 63476 RVA: 0x0016EE6D File Offset: 0x0016D06D
		// (set) Token: 0x0600F7F5 RID: 63477 RVA: 0x0016EE7D File Offset: 0x0016D07D
		public unsafe uint InRateClientMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_InRateClientMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_InRateClientMax) = (int)value;
			}
		}

		// Token: 0x17003C55 RID: 15445
		// (get) Token: 0x0600F7F6 RID: 63478 RVA: 0x0016EE8E File Offset: 0x0016D08E
		// (set) Token: 0x0600F7F7 RID: 63479 RVA: 0x0016EE9E File Offset: 0x0016D09E
		public unsafe uint InRateClientMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_InRateClientMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_InRateClientMin) = (int)value;
			}
		}

		// Token: 0x17003C56 RID: 15446
		// (get) Token: 0x0600F7F8 RID: 63480 RVA: 0x0016EEAF File Offset: 0x0016D0AF
		// (set) Token: 0x0600F7F9 RID: 63481 RVA: 0x0016EEBF File Offset: 0x0016D0BF
		public unsafe uint InRateClientAvg
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_InRateClientAvg);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_InRateClientAvg) = (int)value;
			}
		}

		// Token: 0x17003C57 RID: 15447
		// (get) Token: 0x0600F7FA RID: 63482 RVA: 0x0016EED0 File Offset: 0x0016D0D0
		// (set) Token: 0x0600F7FB RID: 63483 RVA: 0x0016EEE0 File Offset: 0x0016D0E0
		public unsafe uint InPacketsClientMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_InPacketsClientMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_InPacketsClientMax) = (int)value;
			}
		}

		// Token: 0x17003C58 RID: 15448
		// (get) Token: 0x0600F7FC RID: 63484 RVA: 0x0016EEF1 File Offset: 0x0016D0F1
		// (set) Token: 0x0600F7FD RID: 63485 RVA: 0x0016EF01 File Offset: 0x0016D101
		public unsafe uint InPacketsClientMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_InPacketsClientMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_InPacketsClientMin) = (int)value;
			}
		}

		// Token: 0x17003C59 RID: 15449
		// (get) Token: 0x0600F7FE RID: 63486 RVA: 0x0016EF12 File Offset: 0x0016D112
		// (set) Token: 0x0600F7FF RID: 63487 RVA: 0x0016EF22 File Offset: 0x0016D122
		public unsafe uint InPacketsClientAvg
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_InPacketsClientAvg);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_InPacketsClientAvg) = (int)value;
			}
		}

		// Token: 0x17003C5A RID: 15450
		// (get) Token: 0x0600F800 RID: 63488 RVA: 0x0016EF33 File Offset: 0x0016D133
		// (set) Token: 0x0600F801 RID: 63489 RVA: 0x0016EF43 File Offset: 0x0016D143
		public unsafe uint OutRateClientMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_OutRateClientMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_OutRateClientMax) = (int)value;
			}
		}

		// Token: 0x17003C5B RID: 15451
		// (get) Token: 0x0600F802 RID: 63490 RVA: 0x0016EF54 File Offset: 0x0016D154
		// (set) Token: 0x0600F803 RID: 63491 RVA: 0x0016EF64 File Offset: 0x0016D164
		public unsafe uint OutRateClientMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_OutRateClientMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_OutRateClientMin) = (int)value;
			}
		}

		// Token: 0x17003C5C RID: 15452
		// (get) Token: 0x0600F804 RID: 63492 RVA: 0x0016EF75 File Offset: 0x0016D175
		// (set) Token: 0x0600F805 RID: 63493 RVA: 0x0016EF85 File Offset: 0x0016D185
		public unsafe uint OutRateClientAvg
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_OutRateClientAvg);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_OutRateClientAvg) = (int)value;
			}
		}

		// Token: 0x17003C5D RID: 15453
		// (get) Token: 0x0600F806 RID: 63494 RVA: 0x0016EF96 File Offset: 0x0016D196
		// (set) Token: 0x0600F807 RID: 63495 RVA: 0x0016EFA6 File Offset: 0x0016D1A6
		public unsafe uint OutPacketsClientMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_OutPacketsClientMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_OutPacketsClientMax) = (int)value;
			}
		}

		// Token: 0x17003C5E RID: 15454
		// (get) Token: 0x0600F808 RID: 63496 RVA: 0x0016EFB7 File Offset: 0x0016D1B7
		// (set) Token: 0x0600F809 RID: 63497 RVA: 0x0016EFC7 File Offset: 0x0016D1C7
		public unsafe uint OutPacketsClientMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_OutPacketsClientMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_OutPacketsClientMin) = (int)value;
			}
		}

		// Token: 0x17003C5F RID: 15455
		// (get) Token: 0x0600F80A RID: 63498 RVA: 0x0016EFD8 File Offset: 0x0016D1D8
		// (set) Token: 0x0600F80B RID: 63499 RVA: 0x0016EFE8 File Offset: 0x0016D1E8
		public unsafe uint OutPacketsClientAvg
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_OutPacketsClientAvg);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_OutPacketsClientAvg) = (int)value;
			}
		}

		// Token: 0x17003C60 RID: 15456
		// (get) Token: 0x0600F80C RID: 63500 RVA: 0x0016EFF9 File Offset: 0x0016D1F9
		// (set) Token: 0x0600F80D RID: 63501 RVA: 0x0016F009 File Offset: 0x0016D209
		public unsafe uint NetNumClients
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_NetNumClients);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_NetNumClients) = (int)value;
			}
		}

		// Token: 0x17003C61 RID: 15457
		// (get) Token: 0x0600F80E RID: 63502 RVA: 0x0016F01A File Offset: 0x0016D21A
		// (set) Token: 0x0600F80F RID: 63503 RVA: 0x0016F02A File Offset: 0x0016D22A
		public unsafe uint InPackets
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_InPackets);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_InPackets) = (int)value;
			}
		}

		// Token: 0x17003C62 RID: 15458
		// (get) Token: 0x0600F810 RID: 63504 RVA: 0x0016F03B File Offset: 0x0016D23B
		// (set) Token: 0x0600F811 RID: 63505 RVA: 0x0016F04B File Offset: 0x0016D24B
		public unsafe uint OutPackets
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_OutPackets);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_OutPackets) = (int)value;
			}
		}

		// Token: 0x17003C63 RID: 15459
		// (get) Token: 0x0600F812 RID: 63506 RVA: 0x0016F05C File Offset: 0x0016D25C
		// (set) Token: 0x0600F813 RID: 63507 RVA: 0x0016F06C File Offset: 0x0016D26C
		public unsafe uint InBunches
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_InBunches);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_InBunches) = (int)value;
			}
		}

		// Token: 0x17003C64 RID: 15460
		// (get) Token: 0x0600F814 RID: 63508 RVA: 0x0016F07D File Offset: 0x0016D27D
		// (set) Token: 0x0600F815 RID: 63509 RVA: 0x0016F08D File Offset: 0x0016D28D
		public unsafe uint OutBunches
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_OutBunches);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_OutBunches) = (int)value;
			}
		}

		// Token: 0x17003C65 RID: 15461
		// (get) Token: 0x0600F816 RID: 63510 RVA: 0x0016F09E File Offset: 0x0016D29E
		// (set) Token: 0x0600F817 RID: 63511 RVA: 0x0016F0AE File Offset: 0x0016D2AE
		public unsafe uint OutLoss
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_OutLoss);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_OutLoss) = (int)value;
			}
		}

		// Token: 0x17003C66 RID: 15462
		// (get) Token: 0x0600F818 RID: 63512 RVA: 0x0016F0BF File Offset: 0x0016D2BF
		// (set) Token: 0x0600F819 RID: 63513 RVA: 0x0016F0CF File Offset: 0x0016D2CF
		public unsafe uint InLoss
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_InLoss);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_InLoss) = (int)value;
			}
		}

		// Token: 0x17003C67 RID: 15463
		// (get) Token: 0x0600F81A RID: 63514 RVA: 0x0016F0E0 File Offset: 0x0016D2E0
		// (set) Token: 0x0600F81B RID: 63515 RVA: 0x0016F0F0 File Offset: 0x0016D2F0
		public unsafe uint VoiceBytesSent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_VoiceBytesSent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_VoiceBytesSent) = (int)value;
			}
		}

		// Token: 0x17003C68 RID: 15464
		// (get) Token: 0x0600F81C RID: 63516 RVA: 0x0016F101 File Offset: 0x0016D301
		// (set) Token: 0x0600F81D RID: 63517 RVA: 0x0016F111 File Offset: 0x0016D311
		public unsafe uint VoiceBytesRecv
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_VoiceBytesRecv);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_VoiceBytesRecv) = (int)value;
			}
		}

		// Token: 0x17003C69 RID: 15465
		// (get) Token: 0x0600F81E RID: 63518 RVA: 0x0016F122 File Offset: 0x0016D322
		// (set) Token: 0x0600F81F RID: 63519 RVA: 0x0016F132 File Offset: 0x0016D332
		public unsafe uint VoicePacketsSent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_VoicePacketsSent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_VoicePacketsSent) = (int)value;
			}
		}

		// Token: 0x17003C6A RID: 15466
		// (get) Token: 0x0600F820 RID: 63520 RVA: 0x0016F143 File Offset: 0x0016D343
		// (set) Token: 0x0600F821 RID: 63521 RVA: 0x0016F153 File Offset: 0x0016D353
		public unsafe uint VoicePacketsRecv
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_VoicePacketsRecv);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_VoicePacketsRecv) = (int)value;
			}
		}

		// Token: 0x17003C6B RID: 15467
		// (get) Token: 0x0600F822 RID: 63522 RVA: 0x0016F164 File Offset: 0x0016D364
		// (set) Token: 0x0600F823 RID: 63523 RVA: 0x0016F174 File Offset: 0x0016D374
		public unsafe uint PercentInVoice
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_PercentInVoice);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_PercentInVoice) = (int)value;
			}
		}

		// Token: 0x17003C6C RID: 15468
		// (get) Token: 0x0600F824 RID: 63524 RVA: 0x0016F185 File Offset: 0x0016D385
		// (set) Token: 0x0600F825 RID: 63525 RVA: 0x0016F195 File Offset: 0x0016D395
		public unsafe uint PercentOutVoice
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_PercentOutVoice);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_PercentOutVoice) = (int)value;
			}
		}

		// Token: 0x17003C6D RID: 15469
		// (get) Token: 0x0600F826 RID: 63526 RVA: 0x0016F1A6 File Offset: 0x0016D3A6
		// (set) Token: 0x0600F827 RID: 63527 RVA: 0x0016F1B6 File Offset: 0x0016D3B6
		public unsafe uint NumActorChannels
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_NumActorChannels);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_NumActorChannels) = (int)value;
			}
		}

		// Token: 0x17003C6E RID: 15470
		// (get) Token: 0x0600F828 RID: 63528 RVA: 0x0016F1C7 File Offset: 0x0016D3C7
		// (set) Token: 0x0600F829 RID: 63529 RVA: 0x0016F1D7 File Offset: 0x0016D3D7
		public unsafe uint NumConsideredActors
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_NumConsideredActors);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_NumConsideredActors) = (int)value;
			}
		}

		// Token: 0x17003C6F RID: 15471
		// (get) Token: 0x0600F82A RID: 63530 RVA: 0x0016F1E8 File Offset: 0x0016D3E8
		// (set) Token: 0x0600F82B RID: 63531 RVA: 0x0016F1F8 File Offset: 0x0016D3F8
		public unsafe uint PrioritizedActors
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_PrioritizedActors);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_PrioritizedActors) = (int)value;
			}
		}

		// Token: 0x17003C70 RID: 15472
		// (get) Token: 0x0600F82C RID: 63532 RVA: 0x0016F209 File Offset: 0x0016D409
		// (set) Token: 0x0600F82D RID: 63533 RVA: 0x0016F219 File Offset: 0x0016D419
		public unsafe uint NumRelevantActors
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_NumRelevantActors);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_NumRelevantActors) = (int)value;
			}
		}

		// Token: 0x17003C71 RID: 15473
		// (get) Token: 0x0600F82E RID: 63534 RVA: 0x0016F22A File Offset: 0x0016D42A
		// (set) Token: 0x0600F82F RID: 63535 RVA: 0x0016F23A File Offset: 0x0016D43A
		public unsafe uint NumRelevantDeletedActors
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_NumRelevantDeletedActors);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_NumRelevantDeletedActors) = (int)value;
			}
		}

		// Token: 0x17003C72 RID: 15474
		// (get) Token: 0x0600F830 RID: 63536 RVA: 0x0016F24B File Offset: 0x0016D44B
		// (set) Token: 0x0600F831 RID: 63537 RVA: 0x0016F25B File Offset: 0x0016D45B
		public unsafe uint NumReplicatedActorAttempts
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_NumReplicatedActorAttempts);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_NumReplicatedActorAttempts) = (int)value;
			}
		}

		// Token: 0x17003C73 RID: 15475
		// (get) Token: 0x0600F832 RID: 63538 RVA: 0x0016F26C File Offset: 0x0016D46C
		// (set) Token: 0x0600F833 RID: 63539 RVA: 0x0016F27C File Offset: 0x0016D47C
		public unsafe uint NumReplicatedActors
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_NumReplicatedActors);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_NumReplicatedActors) = (int)value;
			}
		}

		// Token: 0x17003C74 RID: 15476
		// (get) Token: 0x0600F834 RID: 63540 RVA: 0x0016F28D File Offset: 0x0016D48D
		// (set) Token: 0x0600F835 RID: 63541 RVA: 0x0016F29D File Offset: 0x0016D49D
		public unsafe uint NumActors
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_NumActors);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_NumActors) = (int)value;
			}
		}

		// Token: 0x17003C75 RID: 15477
		// (get) Token: 0x0600F836 RID: 63542 RVA: 0x0016F2AE File Offset: 0x0016D4AE
		// (set) Token: 0x0600F837 RID: 63543 RVA: 0x0016F2BE File Offset: 0x0016D4BE
		public unsafe uint NumNetActors
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_NumNetActors);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_NumNetActors) = (int)value;
			}
		}

		// Token: 0x17003C76 RID: 15478
		// (get) Token: 0x0600F838 RID: 63544 RVA: 0x0016F2CF File Offset: 0x0016D4CF
		// (set) Token: 0x0600F839 RID: 63545 RVA: 0x0016F2DF File Offset: 0x0016D4DF
		public unsafe uint NumDormantActors
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_NumDormantActors);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_NumDormantActors) = (int)value;
			}
		}

		// Token: 0x17003C77 RID: 15479
		// (get) Token: 0x0600F83A RID: 63546 RVA: 0x0016F2F0 File Offset: 0x0016D4F0
		// (set) Token: 0x0600F83B RID: 63547 RVA: 0x0016F300 File Offset: 0x0016D500
		public unsafe uint NumInitiallyDormantActors
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_NumInitiallyDormantActors);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_NumInitiallyDormantActors) = (int)value;
			}
		}

		// Token: 0x17003C78 RID: 15480
		// (get) Token: 0x0600F83C RID: 63548 RVA: 0x0016F311 File Offset: 0x0016D511
		// (set) Token: 0x0600F83D RID: 63549 RVA: 0x0016F321 File Offset: 0x0016D521
		public unsafe uint NumNetGUIDsAckd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_NumNetGUIDsAckd);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_NumNetGUIDsAckd) = (int)value;
			}
		}

		// Token: 0x17003C79 RID: 15481
		// (get) Token: 0x0600F83E RID: 63550 RVA: 0x0016F332 File Offset: 0x0016D532
		// (set) Token: 0x0600F83F RID: 63551 RVA: 0x0016F342 File Offset: 0x0016D542
		public unsafe uint NumNetGUIDsPending
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_NumNetGUIDsPending);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_NumNetGUIDsPending) = (int)value;
			}
		}

		// Token: 0x17003C7A RID: 15482
		// (get) Token: 0x0600F840 RID: 63552 RVA: 0x0016F353 File Offset: 0x0016D553
		// (set) Token: 0x0600F841 RID: 63553 RVA: 0x0016F363 File Offset: 0x0016D563
		public unsafe uint NumNetGUIDsUnAckd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_NumNetGUIDsUnAckd);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_NumNetGUIDsUnAckd) = (int)value;
			}
		}

		// Token: 0x17003C7B RID: 15483
		// (get) Token: 0x0600F842 RID: 63554 RVA: 0x0016F374 File Offset: 0x0016D574
		// (set) Token: 0x0600F843 RID: 63555 RVA: 0x0016F384 File Offset: 0x0016D584
		public unsafe uint ObjPathBytes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_ObjPathBytes);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_ObjPathBytes) = (int)value;
			}
		}

		// Token: 0x17003C7C RID: 15484
		// (get) Token: 0x0600F844 RID: 63556 RVA: 0x0016F395 File Offset: 0x0016D595
		// (set) Token: 0x0600F845 RID: 63557 RVA: 0x0016F3A5 File Offset: 0x0016D5A5
		public unsafe uint NetGUIDOutRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_NetGUIDOutRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_NetGUIDOutRate) = (int)value;
			}
		}

		// Token: 0x17003C7D RID: 15485
		// (get) Token: 0x0600F846 RID: 63558 RVA: 0x0016F3B6 File Offset: 0x0016D5B6
		// (set) Token: 0x0600F847 RID: 63559 RVA: 0x0016F3C6 File Offset: 0x0016D5C6
		public unsafe uint NetGUIDInRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_NetGUIDInRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_NetGUIDInRate) = (int)value;
			}
		}

		// Token: 0x17003C7E RID: 15486
		// (get) Token: 0x0600F848 RID: 63560 RVA: 0x0016F3D7 File Offset: 0x0016D5D7
		// (set) Token: 0x0600F849 RID: 63561 RVA: 0x0016F3E7 File Offset: 0x0016D5E7
		public unsafe uint NetSaturated
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_NetSaturated);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AServerStatReplicator.__PropertyOffset_NetSaturated) = (int)value;
			}
		}

		// Token: 0x0600F84A RID: 63562 RVA: 0x0016F3F8 File Offset: 0x0016D5F8
		static AServerStatReplicator()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ServerStatReplicator");
		}

		// Token: 0x0600F84B RID: 63563 RVA: 0x0016F406 File Offset: 0x0016D606
		protected AServerStatReplicator(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040085F1 RID: 34289
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ServerStatReplicator";

		// Token: 0x040085F2 RID: 34290
		private static IntPtr _ClassPtr;

		// Token: 0x040085F3 RID: 34291
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040085F4 RID: 34292
		internal static int __PropertyOffset_bUpdateStatNet;

		// Token: 0x040085F5 RID: 34293
		internal static int __PropertyOffset_bOverwriteClientStats;

		// Token: 0x040085F6 RID: 34294
		internal static int __PropertyOffset_Channels;

		// Token: 0x040085F7 RID: 34295
		internal static int __PropertyOffset_InRate;

		// Token: 0x040085F8 RID: 34296
		internal static int __PropertyOffset_OutRate;

		// Token: 0x040085F9 RID: 34297
		internal static int __PropertyOffset_MaxPacketOverhead;

		// Token: 0x040085FA RID: 34298
		internal static int __PropertyOffset_InRateClientMax;

		// Token: 0x040085FB RID: 34299
		internal static int __PropertyOffset_InRateClientMin;

		// Token: 0x040085FC RID: 34300
		internal static int __PropertyOffset_InRateClientAvg;

		// Token: 0x040085FD RID: 34301
		internal static int __PropertyOffset_InPacketsClientMax;

		// Token: 0x040085FE RID: 34302
		internal static int __PropertyOffset_InPacketsClientMin;

		// Token: 0x040085FF RID: 34303
		internal static int __PropertyOffset_InPacketsClientAvg;

		// Token: 0x04008600 RID: 34304
		internal static int __PropertyOffset_OutRateClientMax;

		// Token: 0x04008601 RID: 34305
		internal static int __PropertyOffset_OutRateClientMin;

		// Token: 0x04008602 RID: 34306
		internal static int __PropertyOffset_OutRateClientAvg;

		// Token: 0x04008603 RID: 34307
		internal static int __PropertyOffset_OutPacketsClientMax;

		// Token: 0x04008604 RID: 34308
		internal static int __PropertyOffset_OutPacketsClientMin;

		// Token: 0x04008605 RID: 34309
		internal static int __PropertyOffset_OutPacketsClientAvg;

		// Token: 0x04008606 RID: 34310
		internal static int __PropertyOffset_NetNumClients;

		// Token: 0x04008607 RID: 34311
		internal static int __PropertyOffset_InPackets;

		// Token: 0x04008608 RID: 34312
		internal static int __PropertyOffset_OutPackets;

		// Token: 0x04008609 RID: 34313
		internal static int __PropertyOffset_InBunches;

		// Token: 0x0400860A RID: 34314
		internal static int __PropertyOffset_OutBunches;

		// Token: 0x0400860B RID: 34315
		internal static int __PropertyOffset_OutLoss;

		// Token: 0x0400860C RID: 34316
		internal static int __PropertyOffset_InLoss;

		// Token: 0x0400860D RID: 34317
		internal static int __PropertyOffset_VoiceBytesSent;

		// Token: 0x0400860E RID: 34318
		internal static int __PropertyOffset_VoiceBytesRecv;

		// Token: 0x0400860F RID: 34319
		internal static int __PropertyOffset_VoicePacketsSent;

		// Token: 0x04008610 RID: 34320
		internal static int __PropertyOffset_VoicePacketsRecv;

		// Token: 0x04008611 RID: 34321
		internal static int __PropertyOffset_PercentInVoice;

		// Token: 0x04008612 RID: 34322
		internal static int __PropertyOffset_PercentOutVoice;

		// Token: 0x04008613 RID: 34323
		internal static int __PropertyOffset_NumActorChannels;

		// Token: 0x04008614 RID: 34324
		internal static int __PropertyOffset_NumConsideredActors;

		// Token: 0x04008615 RID: 34325
		internal static int __PropertyOffset_PrioritizedActors;

		// Token: 0x04008616 RID: 34326
		internal static int __PropertyOffset_NumRelevantActors;

		// Token: 0x04008617 RID: 34327
		internal static int __PropertyOffset_NumRelevantDeletedActors;

		// Token: 0x04008618 RID: 34328
		internal static int __PropertyOffset_NumReplicatedActorAttempts;

		// Token: 0x04008619 RID: 34329
		internal static int __PropertyOffset_NumReplicatedActors;

		// Token: 0x0400861A RID: 34330
		internal static int __PropertyOffset_NumActors;

		// Token: 0x0400861B RID: 34331
		internal static int __PropertyOffset_NumNetActors;

		// Token: 0x0400861C RID: 34332
		internal static int __PropertyOffset_NumDormantActors;

		// Token: 0x0400861D RID: 34333
		internal static int __PropertyOffset_NumInitiallyDormantActors;

		// Token: 0x0400861E RID: 34334
		internal static int __PropertyOffset_NumNetGUIDsAckd;

		// Token: 0x0400861F RID: 34335
		internal static int __PropertyOffset_NumNetGUIDsPending;

		// Token: 0x04008620 RID: 34336
		internal static int __PropertyOffset_NumNetGUIDsUnAckd;

		// Token: 0x04008621 RID: 34337
		internal static int __PropertyOffset_ObjPathBytes;

		// Token: 0x04008622 RID: 34338
		internal static int __PropertyOffset_NetGUIDOutRate;

		// Token: 0x04008623 RID: 34339
		internal static int __PropertyOffset_NetGUIDInRate;

		// Token: 0x04008624 RID: 34340
		internal static int __PropertyOffset_NetSaturated;
	}
}
