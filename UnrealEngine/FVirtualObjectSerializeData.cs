using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002659 RID: 9817
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Script/PrefabSystem.VirtualObjectSerializeData")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct FVirtualObjectSerializeData : IEqualityOperators<FVirtualObjectSerializeData, FVirtualObjectSerializeData, bool>, IEquatable<FVirtualObjectSerializeData>, IUnrealScriptStruct
	{
		// Token: 0x060247BE RID: 149438 RVA: 0x003601E2 File Offset: 0x0035E3E2
		public FVirtualObjectSerializeData(int FileID, int PrefabInstanceChainFileID, int SourcePrefabObjectFileID)
		{
			this.FileID = FileID;
			this.PrefabInstanceChainFileID = PrefabInstanceChainFileID;
			this.SourcePrefabObjectFileID = SourcePrefabObjectFileID;
		}

		// Token: 0x060247BF RID: 149439 RVA: 0x003601F9 File Offset: 0x0035E3F9
		public static bool operator ==(FVirtualObjectSerializeData left, FVirtualObjectSerializeData right)
		{
			return left.FileID == right.FileID && left.PrefabInstanceChainFileID == right.PrefabInstanceChainFileID && left.SourcePrefabObjectFileID == right.SourcePrefabObjectFileID;
		}

		// Token: 0x060247C0 RID: 149440 RVA: 0x00360227 File Offset: 0x0035E427
		public static bool operator !=(FVirtualObjectSerializeData left, FVirtualObjectSerializeData right)
		{
			return !(left == right);
		}

		// Token: 0x060247C1 RID: 149441 RVA: 0x00360233 File Offset: 0x0035E433
		public bool Equals(FVirtualObjectSerializeData other)
		{
			return this == other;
		}

		// Token: 0x060247C2 RID: 149442 RVA: 0x00360244 File Offset: 0x0035E444
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FVirtualObjectSerializeData)
			{
				FVirtualObjectSerializeData other = (FVirtualObjectSerializeData)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060247C3 RID: 149443 RVA: 0x00360269 File Offset: 0x0035E469
		public override int GetHashCode()
		{
			return HashCode.Combine<int, int, int>(this.FileID, this.PrefabInstanceChainFileID, this.SourcePrefabObjectFileID);
		}

		// Token: 0x060247C4 RID: 149444 RVA: 0x00360282 File Offset: 0x0035E482
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVirtualObjectSerializeData._ScriptStructPtr != 0) ? FVirtualObjectSerializeData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/PrefabSystem.VirtualObjectSerializeData", ref FVirtualObjectSerializeData._ScriptStructPtr);
		}

		// Token: 0x0401399E RID: 80286
		[FieldOffset(0)]
		public int FileID;

		// Token: 0x0401399F RID: 80287
		[FieldOffset(4)]
		public int PrefabInstanceChainFileID;

		// Token: 0x040139A0 RID: 80288
		[FieldOffset(8)]
		public int SourcePrefabObjectFileID;

		// Token: 0x040139A1 RID: 80289
		public const string __ObjectPath = "/Script/PrefabSystem.VirtualObjectSerializeData";

		// Token: 0x040139A2 RID: 80290
		private static IntPtr _ScriptStructPtr;
	}
}
