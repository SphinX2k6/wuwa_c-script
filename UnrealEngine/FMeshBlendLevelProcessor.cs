using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020022C0 RID: 8896
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 1)]
	[UnrealObjectPath("/Script/MeshBlend.MeshBlendLevelProcessor")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
	public struct FMeshBlendLevelProcessor : IEqualityOperators<FMeshBlendLevelProcessor, FMeshBlendLevelProcessor, bool>, IEquatable<FMeshBlendLevelProcessor>, IUnrealScriptStruct
	{
		// Token: 0x06021CB3 RID: 138419 RVA: 0x0031F4AC File Offset: 0x0031D6AC
		public unsafe static bool operator ==(FMeshBlendLevelProcessor left, FMeshBlendLevelProcessor right)
		{
			Span<byte> span = new Span<byte>((void*)(&left), 1);
			Span<byte> span2 = new Span<byte>((void*)(&right), 1);
			return span.SequenceEqual(span2);
		}

		// Token: 0x06021CB4 RID: 138420 RVA: 0x0031F4D8 File Offset: 0x0031D6D8
		public static bool operator !=(FMeshBlendLevelProcessor left, FMeshBlendLevelProcessor right)
		{
			return !(left == right);
		}

		// Token: 0x06021CB5 RID: 138421 RVA: 0x0031F4E4 File Offset: 0x0031D6E4
		public bool Equals(FMeshBlendLevelProcessor other)
		{
			return this == other;
		}

		// Token: 0x06021CB6 RID: 138422 RVA: 0x0031F4F4 File Offset: 0x0031D6F4
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FMeshBlendLevelProcessor)
			{
				FMeshBlendLevelProcessor other = (FMeshBlendLevelProcessor)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06021CB7 RID: 138423 RVA: 0x0031F519 File Offset: 0x0031D719
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMeshBlendLevelProcessor._ScriptStructPtr != 0) ? FMeshBlendLevelProcessor._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MeshBlend.MeshBlendLevelProcessor", ref FMeshBlendLevelProcessor._ScriptStructPtr);
		}

		// Token: 0x0401207D RID: 73853
		public const string __ObjectPath = "/Script/MeshBlend.MeshBlendLevelProcessor";

		// Token: 0x0401207E RID: 73854
		private static IntPtr _ScriptStructPtr;
	}
}
