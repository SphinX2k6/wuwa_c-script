using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000F3A RID: 3898
	[UnrealObjectPath("/Script/Engine.PacketSimulationSettings")]
	[UnrealStructLayout(52, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 52)]
	public class FPacketSimulationSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600D228 RID: 53800 RVA: 0x0013401A File Offset: 0x0013221A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPacketSimulationSettings._ScriptStructPtr != 0) ? FPacketSimulationSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PacketSimulationSettings", ref FPacketSimulationSettings._ScriptStructPtr);
		}

		// Token: 0x17003114 RID: 12564
		// (get) Token: 0x0600D229 RID: 53801 RVA: 0x0013403E File Offset: 0x0013223E
		// (set) Token: 0x0600D22A RID: 53802 RVA: 0x0013404E File Offset: 0x0013224E
		public unsafe int PktLoss
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPacketSimulationSettings.__PropertyOffset_PktLoss);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPacketSimulationSettings.__PropertyOffset_PktLoss) = value;
			}
		}

		// Token: 0x17003115 RID: 12565
		// (get) Token: 0x0600D22B RID: 53803 RVA: 0x0013405F File Offset: 0x0013225F
		// (set) Token: 0x0600D22C RID: 53804 RVA: 0x0013406F File Offset: 0x0013226F
		public unsafe int PktLossMaxSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPacketSimulationSettings.__PropertyOffset_PktLossMaxSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPacketSimulationSettings.__PropertyOffset_PktLossMaxSize) = value;
			}
		}

		// Token: 0x17003116 RID: 12566
		// (get) Token: 0x0600D22D RID: 53805 RVA: 0x00134080 File Offset: 0x00132280
		// (set) Token: 0x0600D22E RID: 53806 RVA: 0x00134090 File Offset: 0x00132290
		public unsafe int PktLossMinSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPacketSimulationSettings.__PropertyOffset_PktLossMinSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPacketSimulationSettings.__PropertyOffset_PktLossMinSize) = value;
			}
		}

		// Token: 0x17003117 RID: 12567
		// (get) Token: 0x0600D22F RID: 53807 RVA: 0x001340A1 File Offset: 0x001322A1
		// (set) Token: 0x0600D230 RID: 53808 RVA: 0x001340B1 File Offset: 0x001322B1
		public unsafe int PktOrder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPacketSimulationSettings.__PropertyOffset_PktOrder);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPacketSimulationSettings.__PropertyOffset_PktOrder) = value;
			}
		}

		// Token: 0x17003118 RID: 12568
		// (get) Token: 0x0600D231 RID: 53809 RVA: 0x001340C2 File Offset: 0x001322C2
		// (set) Token: 0x0600D232 RID: 53810 RVA: 0x001340D2 File Offset: 0x001322D2
		public unsafe int PktDup
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPacketSimulationSettings.__PropertyOffset_PktDup);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPacketSimulationSettings.__PropertyOffset_PktDup) = value;
			}
		}

		// Token: 0x17003119 RID: 12569
		// (get) Token: 0x0600D233 RID: 53811 RVA: 0x001340E3 File Offset: 0x001322E3
		// (set) Token: 0x0600D234 RID: 53812 RVA: 0x001340F3 File Offset: 0x001322F3
		public unsafe int PktLag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPacketSimulationSettings.__PropertyOffset_PktLag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPacketSimulationSettings.__PropertyOffset_PktLag) = value;
			}
		}

		// Token: 0x1700311A RID: 12570
		// (get) Token: 0x0600D235 RID: 53813 RVA: 0x00134104 File Offset: 0x00132304
		// (set) Token: 0x0600D236 RID: 53814 RVA: 0x00134114 File Offset: 0x00132314
		public unsafe int PktLagVariance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPacketSimulationSettings.__PropertyOffset_PktLagVariance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPacketSimulationSettings.__PropertyOffset_PktLagVariance) = value;
			}
		}

		// Token: 0x1700311B RID: 12571
		// (get) Token: 0x0600D237 RID: 53815 RVA: 0x00134125 File Offset: 0x00132325
		// (set) Token: 0x0600D238 RID: 53816 RVA: 0x00134135 File Offset: 0x00132335
		public unsafe int PktLagMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPacketSimulationSettings.__PropertyOffset_PktLagMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPacketSimulationSettings.__PropertyOffset_PktLagMin) = value;
			}
		}

		// Token: 0x1700311C RID: 12572
		// (get) Token: 0x0600D239 RID: 53817 RVA: 0x00134146 File Offset: 0x00132346
		// (set) Token: 0x0600D23A RID: 53818 RVA: 0x00134156 File Offset: 0x00132356
		public unsafe int PktLagMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPacketSimulationSettings.__PropertyOffset_PktLagMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPacketSimulationSettings.__PropertyOffset_PktLagMax) = value;
			}
		}

		// Token: 0x1700311D RID: 12573
		// (get) Token: 0x0600D23B RID: 53819 RVA: 0x00134167 File Offset: 0x00132367
		// (set) Token: 0x0600D23C RID: 53820 RVA: 0x00134177 File Offset: 0x00132377
		public unsafe int PktIncomingLagMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPacketSimulationSettings.__PropertyOffset_PktIncomingLagMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPacketSimulationSettings.__PropertyOffset_PktIncomingLagMin) = value;
			}
		}

		// Token: 0x1700311E RID: 12574
		// (get) Token: 0x0600D23D RID: 53821 RVA: 0x00134188 File Offset: 0x00132388
		// (set) Token: 0x0600D23E RID: 53822 RVA: 0x00134198 File Offset: 0x00132398
		public unsafe int PktIncomingLagMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPacketSimulationSettings.__PropertyOffset_PktIncomingLagMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPacketSimulationSettings.__PropertyOffset_PktIncomingLagMax) = value;
			}
		}

		// Token: 0x1700311F RID: 12575
		// (get) Token: 0x0600D23F RID: 53823 RVA: 0x001341A9 File Offset: 0x001323A9
		// (set) Token: 0x0600D240 RID: 53824 RVA: 0x001341B9 File Offset: 0x001323B9
		public unsafe int PktIncomingLoss
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPacketSimulationSettings.__PropertyOffset_PktIncomingLoss);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPacketSimulationSettings.__PropertyOffset_PktIncomingLoss) = value;
			}
		}

		// Token: 0x17003120 RID: 12576
		// (get) Token: 0x0600D241 RID: 53825 RVA: 0x001341CA File Offset: 0x001323CA
		// (set) Token: 0x0600D242 RID: 53826 RVA: 0x001341DA File Offset: 0x001323DA
		public unsafe int PktJitter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPacketSimulationSettings.__PropertyOffset_PktJitter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPacketSimulationSettings.__PropertyOffset_PktJitter) = value;
			}
		}

		// Token: 0x0600D243 RID: 53827 RVA: 0x001341EB File Offset: 0x001323EB
		public FPacketSimulationSettings()
		{
		}

		// Token: 0x0600D244 RID: 53828 RVA: 0x001341F4 File Offset: 0x001323F4
		public FPacketSimulationSettings(int PktLoss, int PktLossMaxSize, int PktLossMinSize, int PktOrder, int PktDup, int PktLag, int PktLagVariance, int PktLagMin, int PktLagMax, int PktIncomingLagMin, int PktIncomingLagMax, int PktIncomingLoss, int PktJitter)
		{
			this.PktLoss = PktLoss;
			this.PktLossMaxSize = PktLossMaxSize;
			this.PktLossMinSize = PktLossMinSize;
			this.PktOrder = PktOrder;
			this.PktDup = PktDup;
			this.PktLag = PktLag;
			this.PktLagVariance = PktLagVariance;
			this.PktLagMin = PktLagMin;
			this.PktLagMax = PktLagMax;
			this.PktIncomingLagMin = PktIncomingLagMin;
			this.PktIncomingLagMax = PktIncomingLagMax;
			this.PktIncomingLoss = PktIncomingLoss;
			this.PktJitter = PktJitter;
		}

		// Token: 0x0600D245 RID: 53829 RVA: 0x0013426C File Offset: 0x0013246C
		protected override IntPtr GetUStructPtr()
		{
			return FPacketSimulationSettings.StaticStruct();
		}

		// Token: 0x0600D246 RID: 53830 RVA: 0x00134278 File Offset: 0x00132478
		[NullableContext(2)]
		public FPacketSimulationSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D247 RID: 53831 RVA: 0x00134282 File Offset: 0x00132482
		public FPacketSimulationSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D248 RID: 53832 RVA: 0x0013428D File Offset: 0x0013248D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPacketSimulationSettings(Pointer, false, true);
		}

		// Token: 0x0600D249 RID: 53833 RVA: 0x00134297 File Offset: 0x00132497
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPacketSimulationSettings(Pointer, MemoryOwner);
		}

		// Token: 0x040070C9 RID: 28873
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PacketSimulationSettings";

		// Token: 0x040070CA RID: 28874
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040070CB RID: 28875
		internal static int __PropertyOffset_PktLoss;

		// Token: 0x040070CC RID: 28876
		internal static int __PropertyOffset_PktLossMaxSize;

		// Token: 0x040070CD RID: 28877
		internal static int __PropertyOffset_PktLossMinSize;

		// Token: 0x040070CE RID: 28878
		internal static int __PropertyOffset_PktOrder;

		// Token: 0x040070CF RID: 28879
		internal static int __PropertyOffset_PktDup;

		// Token: 0x040070D0 RID: 28880
		internal static int __PropertyOffset_PktLag;

		// Token: 0x040070D1 RID: 28881
		internal static int __PropertyOffset_PktLagVariance;

		// Token: 0x040070D2 RID: 28882
		internal static int __PropertyOffset_PktLagMin;

		// Token: 0x040070D3 RID: 28883
		internal static int __PropertyOffset_PktLagMax;

		// Token: 0x040070D4 RID: 28884
		internal static int __PropertyOffset_PktIncomingLagMin;

		// Token: 0x040070D5 RID: 28885
		internal static int __PropertyOffset_PktIncomingLagMax;

		// Token: 0x040070D6 RID: 28886
		internal static int __PropertyOffset_PktIncomingLoss;

		// Token: 0x040070D7 RID: 28887
		internal static int __PropertyOffset_PktJitter;
	}
}
