using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000157 RID: 343
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 1)]
	[UnrealObjectPath("/Script/CoreUObject.UniqueNetIdWrapper")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
	public struct FUniqueNetIdWrapper : IEqualityOperators<FUniqueNetIdWrapper, FUniqueNetIdWrapper, bool>, IEquatable<FUniqueNetIdWrapper>, IUnrealScriptStruct
	{
		// Token: 0x0600133D RID: 4925 RVA: 0x0001E5E4 File Offset: 0x0001C7E4
		public unsafe static bool operator ==(FUniqueNetIdWrapper left, FUniqueNetIdWrapper right)
		{
			Span<byte> span = new Span<byte>((void*)(&left), 1);
			Span<byte> span2 = new Span<byte>((void*)(&right), 1);
			return span.SequenceEqual(span2);
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x0001E610 File Offset: 0x0001C810
		public static bool operator !=(FUniqueNetIdWrapper left, FUniqueNetIdWrapper right)
		{
			return !(left == right);
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x0001E61C File Offset: 0x0001C81C
		public bool Equals(FUniqueNetIdWrapper other)
		{
			return this == other;
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x0001E62C File Offset: 0x0001C82C
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FUniqueNetIdWrapper)
			{
				FUniqueNetIdWrapper other = (FUniqueNetIdWrapper)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x0001E651 File Offset: 0x0001C851
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FUniqueNetIdWrapper._ScriptStructPtr != 0) ? FUniqueNetIdWrapper._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.UniqueNetIdWrapper", ref FUniqueNetIdWrapper._ScriptStructPtr);
		}

		// Token: 0x0400061D RID: 1565
		public const string __ObjectPath = "/Script/CoreUObject.UniqueNetIdWrapper";

		// Token: 0x0400061E RID: 1566
		private static IntPtr _ScriptStructPtr;
	}
}
