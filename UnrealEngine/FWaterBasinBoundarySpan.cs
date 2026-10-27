using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020024B3 RID: 9395
	[UnrealObjectPath("/Script/NavigationSystem.WaterBasinBoundarySpan")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FWaterBasinBoundarySpan : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060232EB RID: 144107 RVA: 0x00340B3E File Offset: 0x0033ED3E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWaterBasinBoundarySpan._ScriptStructPtr != 0) ? FWaterBasinBoundarySpan._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/NavigationSystem.WaterBasinBoundarySpan", ref FWaterBasinBoundarySpan._ScriptStructPtr);
		}

		// Token: 0x1700874E RID: 34638
		// (get) Token: 0x060232EC RID: 144108 RVA: 0x00340B62 File Offset: 0x0033ED62
		// (set) Token: 0x060232ED RID: 144109 RVA: 0x00340B72 File Offset: 0x0033ED72
		public unsafe int Edge
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWaterBasinBoundarySpan.__PropertyOffset_Edge);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWaterBasinBoundarySpan.__PropertyOffset_Edge) = value;
			}
		}

		// Token: 0x1700874F RID: 34639
		// (get) Token: 0x060232EE RID: 144110 RVA: 0x00340B83 File Offset: 0x0033ED83
		// (set) Token: 0x060232EF RID: 144111 RVA: 0x00340B93 File Offset: 0x0033ED93
		public unsafe int Cell
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWaterBasinBoundarySpan.__PropertyOffset_Cell);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWaterBasinBoundarySpan.__PropertyOffset_Cell) = value;
			}
		}

		// Token: 0x17008750 RID: 34640
		// (get) Token: 0x060232F0 RID: 144112 RVA: 0x00340BA4 File Offset: 0x0033EDA4
		// (set) Token: 0x060232F1 RID: 144113 RVA: 0x00340BB4 File Offset: 0x0033EDB4
		public unsafe float FloorZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWaterBasinBoundarySpan.__PropertyOffset_FloorZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWaterBasinBoundarySpan.__PropertyOffset_FloorZ) = value;
			}
		}

		// Token: 0x17008751 RID: 34641
		// (get) Token: 0x060232F2 RID: 144114 RVA: 0x00340BC5 File Offset: 0x0033EDC5
		// (set) Token: 0x060232F3 RID: 144115 RVA: 0x00340BD5 File Offset: 0x0033EDD5
		public unsafe float CeilZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWaterBasinBoundarySpan.__PropertyOffset_CeilZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWaterBasinBoundarySpan.__PropertyOffset_CeilZ) = value;
			}
		}

		// Token: 0x17008752 RID: 34642
		// (get) Token: 0x060232F4 RID: 144116 RVA: 0x00340BE6 File Offset: 0x0033EDE6
		// (set) Token: 0x060232F5 RID: 144117 RVA: 0x00340BF6 File Offset: 0x0033EDF6
		public unsafe int Basin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWaterBasinBoundarySpan.__PropertyOffset_Basin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWaterBasinBoundarySpan.__PropertyOffset_Basin) = value;
			}
		}

		// Token: 0x060232F6 RID: 144118 RVA: 0x00340C07 File Offset: 0x0033EE07
		public FWaterBasinBoundarySpan()
		{
		}

		// Token: 0x060232F7 RID: 144119 RVA: 0x00340C0F File Offset: 0x0033EE0F
		public FWaterBasinBoundarySpan(int Edge, int Cell, float FloorZ, float CeilZ, int Basin)
		{
			this.Edge = Edge;
			this.Cell = Cell;
			this.FloorZ = FloorZ;
			this.CeilZ = CeilZ;
			this.Basin = Basin;
		}

		// Token: 0x060232F8 RID: 144120 RVA: 0x00340C3C File Offset: 0x0033EE3C
		protected override IntPtr GetUStructPtr()
		{
			return FWaterBasinBoundarySpan.StaticStruct();
		}

		// Token: 0x060232F9 RID: 144121 RVA: 0x00340C48 File Offset: 0x0033EE48
		[NullableContext(2)]
		public FWaterBasinBoundarySpan(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060232FA RID: 144122 RVA: 0x00340C52 File Offset: 0x0033EE52
		public FWaterBasinBoundarySpan(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060232FB RID: 144123 RVA: 0x00340C5D File Offset: 0x0033EE5D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWaterBasinBoundarySpan(Pointer, false, true);
		}

		// Token: 0x060232FC RID: 144124 RVA: 0x00340C67 File Offset: 0x0033EE67
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWaterBasinBoundarySpan(Pointer, MemoryOwner);
		}

		// Token: 0x04012CA7 RID: 76967
		[Nullable(1)]
		public const string __ObjectPath = "/Script/NavigationSystem.WaterBasinBoundarySpan";

		// Token: 0x04012CA8 RID: 76968
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012CA9 RID: 76969
		internal static int __PropertyOffset_Edge;

		// Token: 0x04012CAA RID: 76970
		internal static int __PropertyOffset_Cell;

		// Token: 0x04012CAB RID: 76971
		internal static int __PropertyOffset_FloorZ;

		// Token: 0x04012CAC RID: 76972
		internal static int __PropertyOffset_CeilZ;

		// Token: 0x04012CAD RID: 76973
		internal static int __PropertyOffset_Basin;
	}
}
