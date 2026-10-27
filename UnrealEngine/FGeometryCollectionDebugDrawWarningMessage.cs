using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200142E RID: 5166
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 1)]
	[UnrealObjectPath("/Script/GeometryCollectionEngine.GeometryCollectionDebugDrawWarningMessage")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
	public struct FGeometryCollectionDebugDrawWarningMessage : IEqualityOperators<FGeometryCollectionDebugDrawWarningMessage, FGeometryCollectionDebugDrawWarningMessage, bool>, IEquatable<FGeometryCollectionDebugDrawWarningMessage>, IUnrealScriptStruct
	{
		// Token: 0x06012E76 RID: 77430 RVA: 0x001BC990 File Offset: 0x001BAB90
		public unsafe static bool operator ==(FGeometryCollectionDebugDrawWarningMessage left, FGeometryCollectionDebugDrawWarningMessage right)
		{
			Span<byte> span = new Span<byte>((void*)(&left), 1);
			Span<byte> span2 = new Span<byte>((void*)(&right), 1);
			return span.SequenceEqual(span2);
		}

		// Token: 0x06012E77 RID: 77431 RVA: 0x001BC9BC File Offset: 0x001BABBC
		public static bool operator !=(FGeometryCollectionDebugDrawWarningMessage left, FGeometryCollectionDebugDrawWarningMessage right)
		{
			return !(left == right);
		}

		// Token: 0x06012E78 RID: 77432 RVA: 0x001BC9C8 File Offset: 0x001BABC8
		public bool Equals(FGeometryCollectionDebugDrawWarningMessage other)
		{
			return this == other;
		}

		// Token: 0x06012E79 RID: 77433 RVA: 0x001BC9D8 File Offset: 0x001BABD8
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FGeometryCollectionDebugDrawWarningMessage)
			{
				FGeometryCollectionDebugDrawWarningMessage other = (FGeometryCollectionDebugDrawWarningMessage)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06012E7A RID: 77434 RVA: 0x001BC9FD File Offset: 0x001BABFD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGeometryCollectionDebugDrawWarningMessage._ScriptStructPtr != 0) ? FGeometryCollectionDebugDrawWarningMessage._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GeometryCollectionEngine.GeometryCollectionDebugDrawWarningMessage", ref FGeometryCollectionDebugDrawWarningMessage._ScriptStructPtr);
		}

		// Token: 0x0400A19F RID: 41375
		public const string __ObjectPath = "/Script/GeometryCollectionEngine.GeometryCollectionDebugDrawWarningMessage";

		// Token: 0x0400A1A0 RID: 41376
		private static IntPtr _ScriptStructPtr;
	}
}
