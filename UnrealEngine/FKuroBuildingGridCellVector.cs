using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200031E RID: 798
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Script/KuroBuildingGridSystem.KuroBuildingGridCellVector")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct FKuroBuildingGridCellVector : IEqualityOperators<FKuroBuildingGridCellVector, FKuroBuildingGridCellVector, bool>, IEquatable<FKuroBuildingGridCellVector>, IUnrealScriptStruct
	{
		// Token: 0x06005421 RID: 21537 RVA: 0x00075ADC File Offset: 0x00073CDC
		public FKuroBuildingGridCellVector(int X, int Y)
		{
			this.X = X;
			this.Y = Y;
		}

		// Token: 0x06005422 RID: 21538 RVA: 0x00075AEC File Offset: 0x00073CEC
		public static bool operator ==(FKuroBuildingGridCellVector left, FKuroBuildingGridCellVector right)
		{
			return left.X == right.X && left.Y == right.Y;
		}

		// Token: 0x06005423 RID: 21539 RVA: 0x00075B0C File Offset: 0x00073D0C
		public static bool operator !=(FKuroBuildingGridCellVector left, FKuroBuildingGridCellVector right)
		{
			return !(left == right);
		}

		// Token: 0x06005424 RID: 21540 RVA: 0x00075B18 File Offset: 0x00073D18
		public bool Equals(FKuroBuildingGridCellVector other)
		{
			return this == other;
		}

		// Token: 0x06005425 RID: 21541 RVA: 0x00075B28 File Offset: 0x00073D28
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FKuroBuildingGridCellVector)
			{
				FKuroBuildingGridCellVector other = (FKuroBuildingGridCellVector)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06005426 RID: 21542 RVA: 0x00075B4D File Offset: 0x00073D4D
		public override int GetHashCode()
		{
			return HashCode.Combine<int, int>(this.X, this.Y);
		}

		// Token: 0x06005427 RID: 21543 RVA: 0x00075B60 File Offset: 0x00073D60
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroBuildingGridCellVector._ScriptStructPtr != 0) ? FKuroBuildingGridCellVector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroBuildingGridSystem.KuroBuildingGridCellVector", ref FKuroBuildingGridCellVector._ScriptStructPtr);
		}

		// Token: 0x0400225B RID: 8795
		[FieldOffset(0)]
		public int X;

		// Token: 0x0400225C RID: 8796
		[FieldOffset(4)]
		public int Y;

		// Token: 0x0400225D RID: 8797
		public const string __ObjectPath = "/Script/KuroBuildingGridSystem.KuroBuildingGridCellVector";

		// Token: 0x0400225E RID: 8798
		private static IntPtr _ScriptStructPtr;
	}
}
