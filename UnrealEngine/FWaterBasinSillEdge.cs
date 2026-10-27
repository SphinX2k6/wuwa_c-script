using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020024B4 RID: 9396
	[UnrealObjectPath("/Script/NavigationSystem.WaterBasinSillEdge")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FWaterBasinSillEdge : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060232FD RID: 144125 RVA: 0x00340C70 File Offset: 0x0033EE70
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWaterBasinSillEdge._ScriptStructPtr != 0) ? FWaterBasinSillEdge._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/NavigationSystem.WaterBasinSillEdge", ref FWaterBasinSillEdge._ScriptStructPtr);
		}

		// Token: 0x17008753 RID: 34643
		// (get) Token: 0x060232FE RID: 144126 RVA: 0x00340C94 File Offset: 0x0033EE94
		// (set) Token: 0x060232FF RID: 144127 RVA: 0x00340CA4 File Offset: 0x0033EEA4
		public unsafe int A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWaterBasinSillEdge.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWaterBasinSillEdge.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x17008754 RID: 34644
		// (get) Token: 0x06023300 RID: 144128 RVA: 0x00340CB5 File Offset: 0x0033EEB5
		// (set) Token: 0x06023301 RID: 144129 RVA: 0x00340CC5 File Offset: 0x0033EEC5
		public unsafe int B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWaterBasinSillEdge.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWaterBasinSillEdge.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x17008755 RID: 34645
		// (get) Token: 0x06023302 RID: 144130 RVA: 0x00340CD6 File Offset: 0x0033EED6
		// (set) Token: 0x06023303 RID: 144131 RVA: 0x00340CE6 File Offset: 0x0033EEE6
		public unsafe float SillZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWaterBasinSillEdge.__PropertyOffset_SillZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWaterBasinSillEdge.__PropertyOffset_SillZ) = value;
			}
		}

		// Token: 0x06023304 RID: 144132 RVA: 0x00340CF7 File Offset: 0x0033EEF7
		public FWaterBasinSillEdge()
		{
		}

		// Token: 0x06023305 RID: 144133 RVA: 0x00340CFF File Offset: 0x0033EEFF
		public FWaterBasinSillEdge(int A, int B, float SillZ)
		{
			this.A = A;
			this.B = B;
			this.SillZ = SillZ;
		}

		// Token: 0x06023306 RID: 144134 RVA: 0x00340D1C File Offset: 0x0033EF1C
		protected override IntPtr GetUStructPtr()
		{
			return FWaterBasinSillEdge.StaticStruct();
		}

		// Token: 0x06023307 RID: 144135 RVA: 0x00340D28 File Offset: 0x0033EF28
		[NullableContext(2)]
		public FWaterBasinSillEdge(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023308 RID: 144136 RVA: 0x00340D32 File Offset: 0x0033EF32
		public FWaterBasinSillEdge(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023309 RID: 144137 RVA: 0x00340D3D File Offset: 0x0033EF3D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWaterBasinSillEdge(Pointer, false, true);
		}

		// Token: 0x0602330A RID: 144138 RVA: 0x00340D47 File Offset: 0x0033EF47
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWaterBasinSillEdge(Pointer, MemoryOwner);
		}

		// Token: 0x04012CAE RID: 76974
		[Nullable(1)]
		public const string __ObjectPath = "/Script/NavigationSystem.WaterBasinSillEdge";

		// Token: 0x04012CAF RID: 76975
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012CB0 RID: 76976
		internal static int __PropertyOffset_A;

		// Token: 0x04012CB1 RID: 76977
		internal static int __PropertyOffset_B;

		// Token: 0x04012CB2 RID: 76978
		internal static int __PropertyOffset_SillZ;
	}
}
