using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002691 RID: 9873
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Script/Renderer.MyParticle_marchCube")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 16)]
	public struct FMyParticle_marchCube : IEqualityOperators<FMyParticle_marchCube, FMyParticle_marchCube, bool>, IEquatable<FMyParticle_marchCube>, IUnrealScriptStruct
	{
		// Token: 0x06024A76 RID: 150134 RVA: 0x0036446C File Offset: 0x0036266C
		public FMyParticle_marchCube(float x, float y, float z, float w)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}

		// Token: 0x06024A77 RID: 150135 RVA: 0x0036448B File Offset: 0x0036268B
		public static bool operator ==(FMyParticle_marchCube left, FMyParticle_marchCube right)
		{
			return left.x == right.x && left.y == right.y && left.z == right.z && left.w == right.w;
		}

		// Token: 0x06024A78 RID: 150136 RVA: 0x003644C7 File Offset: 0x003626C7
		public static bool operator !=(FMyParticle_marchCube left, FMyParticle_marchCube right)
		{
			return !(left == right);
		}

		// Token: 0x06024A79 RID: 150137 RVA: 0x003644D3 File Offset: 0x003626D3
		public bool Equals(FMyParticle_marchCube other)
		{
			return this == other;
		}

		// Token: 0x06024A7A RID: 150138 RVA: 0x003644E4 File Offset: 0x003626E4
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FMyParticle_marchCube)
			{
				FMyParticle_marchCube other = (FMyParticle_marchCube)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06024A7B RID: 150139 RVA: 0x00364509 File Offset: 0x00362709
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float, float>(this.x, this.y, this.z, this.w);
		}

		// Token: 0x06024A7C RID: 150140 RVA: 0x00364528 File Offset: 0x00362728
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMyParticle_marchCube._ScriptStructPtr != 0) ? FMyParticle_marchCube._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Renderer.MyParticle_marchCube", ref FMyParticle_marchCube._ScriptStructPtr);
		}

		// Token: 0x04013B56 RID: 80726
		[FieldOffset(0)]
		public float x;

		// Token: 0x04013B57 RID: 80727
		[FieldOffset(4)]
		public float y;

		// Token: 0x04013B58 RID: 80728
		[FieldOffset(8)]
		public float z;

		// Token: 0x04013B59 RID: 80729
		[FieldOffset(12)]
		public float w;

		// Token: 0x04013B5A RID: 80730
		public const string __ObjectPath = "/Script/Renderer.MyParticle_marchCube";

		// Token: 0x04013B5B RID: 80731
		private static IntPtr _ScriptStructPtr;
	}
}
