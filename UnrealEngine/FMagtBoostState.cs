using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200226F RID: 8815
	[UnrealObjectPath("/Script/MagtModule.MagtBoostState")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FMagtBoostState : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021818 RID: 137240 RVA: 0x00317E22 File Offset: 0x00316022
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMagtBoostState._ScriptStructPtr != 0) ? FMagtBoostState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MagtModule.MagtBoostState", ref FMagtBoostState._ScriptStructPtr);
		}

		// Token: 0x1700824B RID: 33355
		// (get) Token: 0x06021819 RID: 137241 RVA: 0x00317E46 File Offset: 0x00316046
		// (set) Token: 0x0602181A RID: 137242 RVA: 0x00317E56 File Offset: 0x00316056
		public unsafe int Mode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtBoostState.__PropertyOffset_Mode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtBoostState.__PropertyOffset_Mode) = value;
			}
		}

		// Token: 0x1700824C RID: 33356
		// (get) Token: 0x0602181B RID: 137243 RVA: 0x00317E67 File Offset: 0x00316067
		// (set) Token: 0x0602181C RID: 137244 RVA: 0x00317E77 File Offset: 0x00316077
		public unsafe int Level
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtBoostState.__PropertyOffset_Level);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtBoostState.__PropertyOffset_Level) = value;
			}
		}

		// Token: 0x1700824D RID: 33357
		// (get) Token: 0x0602181D RID: 137245 RVA: 0x00317E88 File Offset: 0x00316088
		// (set) Token: 0x0602181E RID: 137246 RVA: 0x00317E98 File Offset: 0x00316098
		public unsafe int RemainingDurationMs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtBoostState.__PropertyOffset_RemainingDurationMs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtBoostState.__PropertyOffset_RemainingDurationMs) = value;
			}
		}

		// Token: 0x1700824E RID: 33358
		// (get) Token: 0x0602181F RID: 137247 RVA: 0x00317EA9 File Offset: 0x003160A9
		// (set) Token: 0x06021820 RID: 137248 RVA: 0x00317EB9 File Offset: 0x003160B9
		public unsafe bool bIsDRAMBoosted
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtBoostState.__PropertyOffset_bIsDRAMBoosted) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtBoostState.__PropertyOffset_bIsDRAMBoosted) = (value ? 1 : 0);
			}
		}

		// Token: 0x06021821 RID: 137249 RVA: 0x00317ECA File Offset: 0x003160CA
		public FMagtBoostState()
		{
		}

		// Token: 0x06021822 RID: 137250 RVA: 0x00317ED2 File Offset: 0x003160D2
		public FMagtBoostState(int Mode, int Level, int RemainingDurationMs, bool bIsDRAMBoosted)
		{
			this.Mode = Mode;
			this.Level = Level;
			this.RemainingDurationMs = RemainingDurationMs;
			this.bIsDRAMBoosted = bIsDRAMBoosted;
		}

		// Token: 0x06021823 RID: 137251 RVA: 0x00317EF7 File Offset: 0x003160F7
		protected override IntPtr GetUStructPtr()
		{
			return FMagtBoostState.StaticStruct();
		}

		// Token: 0x06021824 RID: 137252 RVA: 0x00317F03 File Offset: 0x00316103
		[NullableContext(2)]
		public FMagtBoostState(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021825 RID: 137253 RVA: 0x00317F0D File Offset: 0x0031610D
		public FMagtBoostState(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021826 RID: 137254 RVA: 0x00317F18 File Offset: 0x00316118
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMagtBoostState(Pointer, false, true);
		}

		// Token: 0x06021827 RID: 137255 RVA: 0x00317F22 File Offset: 0x00316122
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMagtBoostState(Pointer, MemoryOwner);
		}

		// Token: 0x04011E31 RID: 73265
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MagtModule.MagtBoostState";

		// Token: 0x04011E32 RID: 73266
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011E33 RID: 73267
		internal static int __PropertyOffset_Mode;

		// Token: 0x04011E34 RID: 73268
		internal static int __PropertyOffset_Level;

		// Token: 0x04011E35 RID: 73269
		internal static int __PropertyOffset_RemainingDurationMs;

		// Token: 0x04011E36 RID: 73270
		internal static int __PropertyOffset_bIsDRAMBoosted;
	}
}
