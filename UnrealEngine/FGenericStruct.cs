using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C09 RID: 3081
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 4)]
	[UnrealObjectPath("/Script/Engine.GenericStruct")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 4)]
	public struct FGenericStruct : IEqualityOperators<FGenericStruct, FGenericStruct, bool>, IEquatable<FGenericStruct>, IUnrealScriptStruct
	{
		// Token: 0x06009B3B RID: 39739 RVA: 0x000DC972 File Offset: 0x000DAB72
		public FGenericStruct(int Data)
		{
			this.Data = Data;
		}

		// Token: 0x06009B3C RID: 39740 RVA: 0x000DC97B File Offset: 0x000DAB7B
		public static bool operator ==(FGenericStruct left, FGenericStruct right)
		{
			return left.Data == right.Data;
		}

		// Token: 0x06009B3D RID: 39741 RVA: 0x000DC98B File Offset: 0x000DAB8B
		public static bool operator !=(FGenericStruct left, FGenericStruct right)
		{
			return !(left == right);
		}

		// Token: 0x06009B3E RID: 39742 RVA: 0x000DC997 File Offset: 0x000DAB97
		public bool Equals(FGenericStruct other)
		{
			return this == other;
		}

		// Token: 0x06009B3F RID: 39743 RVA: 0x000DC9A8 File Offset: 0x000DABA8
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FGenericStruct)
			{
				FGenericStruct other = (FGenericStruct)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06009B40 RID: 39744 RVA: 0x000DC9CD File Offset: 0x000DABCD
		public override int GetHashCode()
		{
			return HashCode.Combine<int>(this.Data);
		}

		// Token: 0x06009B41 RID: 39745 RVA: 0x000DC9DA File Offset: 0x000DABDA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGenericStruct._ScriptStructPtr != 0) ? FGenericStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.GenericStruct", ref FGenericStruct._ScriptStructPtr);
		}

		// Token: 0x040055B2 RID: 21938
		[FieldOffset(0)]
		public int Data;

		// Token: 0x040055B3 RID: 21939
		public const string __ObjectPath = "/Script/Engine.GenericStruct";

		// Token: 0x040055B4 RID: 21940
		private static IntPtr _ScriptStructPtr;
	}
}
