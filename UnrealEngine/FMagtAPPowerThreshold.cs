using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200226D RID: 8813
	[UnrealObjectPath("/Script/MagtModule.MagtAPPowerThreshold")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FMagtAPPowerThreshold : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060217F6 RID: 137206 RVA: 0x00317B9C File Offset: 0x00315D9C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMagtAPPowerThreshold._ScriptStructPtr != 0) ? FMagtAPPowerThreshold._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MagtModule.MagtAPPowerThreshold", ref FMagtAPPowerThreshold._ScriptStructPtr);
		}

		// Token: 0x17008242 RID: 33346
		// (get) Token: 0x060217F7 RID: 137207 RVA: 0x00317BC0 File Offset: 0x00315DC0
		// (set) Token: 0x060217F8 RID: 137208 RVA: 0x00317BD0 File Offset: 0x00315DD0
		public unsafe float UpperBound
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtAPPowerThreshold.__PropertyOffset_UpperBound);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtAPPowerThreshold.__PropertyOffset_UpperBound) = value;
			}
		}

		// Token: 0x17008243 RID: 33347
		// (get) Token: 0x060217F9 RID: 137209 RVA: 0x00317BE1 File Offset: 0x00315DE1
		// (set) Token: 0x060217FA RID: 137210 RVA: 0x00317BF1 File Offset: 0x00315DF1
		public unsafe float LowerBound
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtAPPowerThreshold.__PropertyOffset_LowerBound);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtAPPowerThreshold.__PropertyOffset_LowerBound) = value;
			}
		}

		// Token: 0x060217FB RID: 137211 RVA: 0x00317C02 File Offset: 0x00315E02
		public FMagtAPPowerThreshold()
		{
		}

		// Token: 0x060217FC RID: 137212 RVA: 0x00317C0A File Offset: 0x00315E0A
		public FMagtAPPowerThreshold(float UpperBound, float LowerBound)
		{
			this.UpperBound = UpperBound;
			this.LowerBound = LowerBound;
		}

		// Token: 0x060217FD RID: 137213 RVA: 0x00317C20 File Offset: 0x00315E20
		protected override IntPtr GetUStructPtr()
		{
			return FMagtAPPowerThreshold.StaticStruct();
		}

		// Token: 0x060217FE RID: 137214 RVA: 0x00317C2C File Offset: 0x00315E2C
		[NullableContext(2)]
		public FMagtAPPowerThreshold(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060217FF RID: 137215 RVA: 0x00317C36 File Offset: 0x00315E36
		public FMagtAPPowerThreshold(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021800 RID: 137216 RVA: 0x00317C41 File Offset: 0x00315E41
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMagtAPPowerThreshold(Pointer, false, true);
		}

		// Token: 0x06021801 RID: 137217 RVA: 0x00317C4B File Offset: 0x00315E4B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMagtAPPowerThreshold(Pointer, MemoryOwner);
		}

		// Token: 0x04011E23 RID: 73251
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MagtModule.MagtAPPowerThreshold";

		// Token: 0x04011E24 RID: 73252
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011E25 RID: 73253
		internal static int __PropertyOffset_UpperBound;

		// Token: 0x04011E26 RID: 73254
		internal static int __PropertyOffset_LowerBound;
	}
}
