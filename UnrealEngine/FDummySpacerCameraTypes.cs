using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020009DD RID: 2525
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 1)]
	[UnrealObjectPath("/Script/Engine.DummySpacerCameraTypes")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
	public struct FDummySpacerCameraTypes : IEqualityOperators<FDummySpacerCameraTypes, FDummySpacerCameraTypes, bool>, IEquatable<FDummySpacerCameraTypes>, IUnrealScriptStruct
	{
		// Token: 0x06008EA4 RID: 36516 RVA: 0x000CBF44 File Offset: 0x000CA144
		public unsafe static bool operator ==(FDummySpacerCameraTypes left, FDummySpacerCameraTypes right)
		{
			Span<byte> span = new Span<byte>((void*)(&left), 1);
			Span<byte> span2 = new Span<byte>((void*)(&right), 1);
			return span.SequenceEqual(span2);
		}

		// Token: 0x06008EA5 RID: 36517 RVA: 0x000CBF70 File Offset: 0x000CA170
		public static bool operator !=(FDummySpacerCameraTypes left, FDummySpacerCameraTypes right)
		{
			return !(left == right);
		}

		// Token: 0x06008EA6 RID: 36518 RVA: 0x000CBF7C File Offset: 0x000CA17C
		public bool Equals(FDummySpacerCameraTypes other)
		{
			return this == other;
		}

		// Token: 0x06008EA7 RID: 36519 RVA: 0x000CBF8C File Offset: 0x000CA18C
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FDummySpacerCameraTypes)
			{
				FDummySpacerCameraTypes other = (FDummySpacerCameraTypes)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06008EA8 RID: 36520 RVA: 0x000CBFB1 File Offset: 0x000CA1B1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDummySpacerCameraTypes._ScriptStructPtr != 0) ? FDummySpacerCameraTypes._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.DummySpacerCameraTypes", ref FDummySpacerCameraTypes._ScriptStructPtr);
		}

		// Token: 0x040043D8 RID: 17368
		public const string __ObjectPath = "/Script/Engine.DummySpacerCameraTypes";

		// Token: 0x040043D9 RID: 17369
		private static IntPtr _ScriptStructPtr;
	}
}
