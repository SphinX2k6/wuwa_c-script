using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020016B2 RID: 5810
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Script/KuroBuildingGridSystem.KuroBuildingGridCellVector")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct FKuroBuildingGridCellVector : IEqualityOperators<FKuroBuildingGridCellVector, FKuroBuildingGridCellVector, bool>, IEquatable<FKuroBuildingGridCellVector>, IUnrealScriptStruct
	{
		// Token: 0x06015129 RID: 86313 RVA: 0x001EF7CC File Offset: 0x001ED9CC
		public FKuroBuildingGridCellVector(int X, int Y)
		{
			this.X = X;
			this.Y = Y;
		}

		// Token: 0x0601512A RID: 86314 RVA: 0x001EF7DC File Offset: 0x001ED9DC
		public static bool operator ==(FKuroBuildingGridCellVector left, FKuroBuildingGridCellVector right)
		{
			return left.X == right.X && left.Y == right.Y;
		}

		// Token: 0x0601512B RID: 86315 RVA: 0x001EF7FC File Offset: 0x001ED9FC
		public static bool operator !=(FKuroBuildingGridCellVector left, FKuroBuildingGridCellVector right)
		{
			return !(left == right);
		}

		// Token: 0x0601512C RID: 86316 RVA: 0x001EF808 File Offset: 0x001EDA08
		public bool Equals(FKuroBuildingGridCellVector other)
		{
			return this == other;
		}

		// Token: 0x0601512D RID: 86317 RVA: 0x001EF818 File Offset: 0x001EDA18
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

		// Token: 0x0601512E RID: 86318 RVA: 0x001EF83D File Offset: 0x001EDA3D
		public override int GetHashCode()
		{
			return HashCode.Combine<int, int>(this.X, this.Y);
		}

		// Token: 0x0601512F RID: 86319 RVA: 0x001EF850 File Offset: 0x001EDA50
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroBuildingGridCellVector._ScriptStructPtr != 0) ? FKuroBuildingGridCellVector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroBuildingGridSystem.KuroBuildingGridCellVector", ref FKuroBuildingGridCellVector._ScriptStructPtr);
		}

		// Token: 0x0400B77F RID: 46975
		[FieldOffset(0)]
		public int X;

		// Token: 0x0400B780 RID: 46976
		[FieldOffset(4)]
		public int Y;

		// Token: 0x0400B781 RID: 46977
		public const string __ObjectPath = "/Script/KuroBuildingGridSystem.KuroBuildingGridCellVector";

		// Token: 0x0400B782 RID: 46978
		private static IntPtr _ScriptStructPtr;
	}
}
