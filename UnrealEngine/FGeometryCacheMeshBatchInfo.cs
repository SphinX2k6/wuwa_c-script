using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001412 RID: 5138
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Script/GeometryCache.GeometryCacheMeshBatchInfo")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct FGeometryCacheMeshBatchInfo : IEqualityOperators<FGeometryCacheMeshBatchInfo, FGeometryCacheMeshBatchInfo, bool>, IEquatable<FGeometryCacheMeshBatchInfo>, IUnrealScriptStruct
	{
		// Token: 0x06012C25 RID: 76837 RVA: 0x001B9AA8 File Offset: 0x001B7CA8
		public unsafe static bool operator ==(FGeometryCacheMeshBatchInfo left, FGeometryCacheMeshBatchInfo right)
		{
			Span<byte> span = new Span<byte>((void*)(&left), 1);
			Span<byte> span2 = new Span<byte>((void*)(&right), 1);
			return span.SequenceEqual(span2);
		}

		// Token: 0x06012C26 RID: 76838 RVA: 0x001B9AD4 File Offset: 0x001B7CD4
		public static bool operator !=(FGeometryCacheMeshBatchInfo left, FGeometryCacheMeshBatchInfo right)
		{
			return !(left == right);
		}

		// Token: 0x06012C27 RID: 76839 RVA: 0x001B9AE0 File Offset: 0x001B7CE0
		public bool Equals(FGeometryCacheMeshBatchInfo other)
		{
			return this == other;
		}

		// Token: 0x06012C28 RID: 76840 RVA: 0x001B9AF0 File Offset: 0x001B7CF0
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FGeometryCacheMeshBatchInfo)
			{
				FGeometryCacheMeshBatchInfo other = (FGeometryCacheMeshBatchInfo)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06012C29 RID: 76841 RVA: 0x001B9B15 File Offset: 0x001B7D15
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGeometryCacheMeshBatchInfo._ScriptStructPtr != 0) ? FGeometryCacheMeshBatchInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GeometryCache.GeometryCacheMeshBatchInfo", ref FGeometryCacheMeshBatchInfo._ScriptStructPtr);
		}

		// Token: 0x0400A066 RID: 41062
		public const string __ObjectPath = "/Script/GeometryCache.GeometryCacheMeshBatchInfo";

		// Token: 0x0400A067 RID: 41063
		private static IntPtr _ScriptStructPtr;
	}
}
