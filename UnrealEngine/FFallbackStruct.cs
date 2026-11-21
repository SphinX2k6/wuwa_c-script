using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000108 RID: 264
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 1)]
	[UnrealObjectPath("/Script/CoreUObject.FallbackStruct")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
	public struct FFallbackStruct : IEqualityOperators<FFallbackStruct, FFallbackStruct, bool>, IEquatable<FFallbackStruct>, IUnrealScriptStruct
	{
		// Token: 0x06001117 RID: 4375 RVA: 0x0001B1A8 File Offset: 0x000193A8
		public unsafe static bool operator ==(FFallbackStruct left, FFallbackStruct right)
		{
			Span<byte> span = new Span<byte>((void*)(&left), 1);
			Span<byte> span2 = new Span<byte>((void*)(&right), 1);
			return span.SequenceEqual(span2);
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x0001B1D4 File Offset: 0x000193D4
		public static bool operator !=(FFallbackStruct left, FFallbackStruct right)
		{
			return !(left == right);
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x0001B1E0 File Offset: 0x000193E0
		public bool Equals(FFallbackStruct other)
		{
			return this == other;
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x0001B1F0 File Offset: 0x000193F0
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FFallbackStruct)
			{
				FFallbackStruct other = (FFallbackStruct)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x0001B215 File Offset: 0x00019415
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFallbackStruct._ScriptStructPtr != 0) ? FFallbackStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.FallbackStruct", ref FFallbackStruct._ScriptStructPtr);
		}

		// Token: 0x040004D8 RID: 1240
		public const string __ObjectPath = "/Script/CoreUObject.FallbackStruct";

		// Token: 0x040004D9 RID: 1241
		private static IntPtr _ScriptStructPtr;
	}
}
