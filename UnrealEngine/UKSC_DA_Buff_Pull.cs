using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D79 RID: 7545
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_Pull")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class UKSC_DA_Buff_Pull : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CE5F RID: 118367 RVA: 0x002AB75D File Offset: 0x002A995D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_Pull._ClassPtr;
		}

		// Token: 0x0601CE60 RID: 118368 RVA: 0x002AB76C File Offset: 0x002A996C
		public UKSC_DA_Buff_Pull() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_Pull.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CE61 RID: 118369 RVA: 0x002AB794 File Offset: 0x002A9994
		[NullableContext(1)]
		public UKSC_DA_Buff_Pull(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_Pull.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007485 RID: 29829
		// (get) Token: 0x0601CE62 RID: 118370 RVA: 0x002AB7C7 File Offset: 0x002A99C7
		// (set) Token: 0x0601CE63 RID: 118371 RVA: 0x002AB7DB File Offset: 0x002A99DB
		public unsafe FVector PullPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Pull.__PropertyOffset_PullPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Pull.__PropertyOffset_PullPos) = value;
			}
		}

		// Token: 0x17007486 RID: 29830
		// (get) Token: 0x0601CE64 RID: 118372 RVA: 0x002AB7F0 File Offset: 0x002A99F0
		// (set) Token: 0x0601CE65 RID: 118373 RVA: 0x002AB804 File Offset: 0x002A9A04
		public unsafe FVector RandomRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Pull.__PropertyOffset_RandomRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Pull.__PropertyOffset_RandomRange) = value;
			}
		}

		// Token: 0x17007487 RID: 29831
		// (get) Token: 0x0601CE66 RID: 118374 RVA: 0x002AB819 File Offset: 0x002A9A19
		// (set) Token: 0x0601CE67 RID: 118375 RVA: 0x002AB829 File Offset: 0x002A9A29
		public unsafe float PullSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Pull.__PropertyOffset_PullSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Pull.__PropertyOffset_PullSpeed) = value;
			}
		}

		// Token: 0x17007488 RID: 29832
		// (get) Token: 0x0601CE68 RID: 118376 RVA: 0x002AB83A File Offset: 0x002A9A3A
		// (set) Token: 0x0601CE69 RID: 118377 RVA: 0x002AB84A File Offset: 0x002A9A4A
		public unsafe EKSC_GPUNPCAnimState PullAnimState
		{
			get
			{
				return (EKSC_GPUNPCAnimState)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Pull.__PropertyOffset_PullAnimState));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Pull.__PropertyOffset_PullAnimState) = (byte)value;
			}
		}

		// Token: 0x0601CE6A RID: 118378 RVA: 0x002AB85B File Offset: 0x002A9A5B
		static UKSC_DA_Buff_Pull()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_Pull");
		}

		// Token: 0x0601CE6B RID: 118379 RVA: 0x002AB869 File Offset: 0x002A9A69
		protected UKSC_DA_Buff_Pull(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FAE3 RID: 64227
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_Pull";

		// Token: 0x0400FAE4 RID: 64228
		private static IntPtr _ClassPtr;

		// Token: 0x0400FAE5 RID: 64229
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FAE6 RID: 64230
		internal static int __PropertyOffset_PullPos;

		// Token: 0x0400FAE7 RID: 64231
		internal static int __PropertyOffset_RandomRange;

		// Token: 0x0400FAE8 RID: 64232
		internal static int __PropertyOffset_PullSpeed;

		// Token: 0x0400FAE9 RID: 64233
		internal static int __PropertyOffset_PullAnimState;
	}
}
