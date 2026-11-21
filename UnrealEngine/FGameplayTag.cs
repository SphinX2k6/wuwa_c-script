using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002C7 RID: 711
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Script/GameplayTags.GameplayTag")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct FGameplayTag : IEqualityOperators<FGameplayTag, FGameplayTag, bool>, IEquatable<FGameplayTag>, IUnrealScriptStruct
	{
		// Token: 0x06004DBD RID: 19901 RVA: 0x0006C9FE File Offset: 0x0006ABFE
		public FGameplayTag(FName TagName)
		{
			this.TagName = TagName;
		}

		// Token: 0x06004DBE RID: 19902 RVA: 0x0006CA07 File Offset: 0x0006AC07
		public static bool operator ==(FGameplayTag left, FGameplayTag right)
		{
			return left.TagName == right.TagName;
		}

		// Token: 0x06004DBF RID: 19903 RVA: 0x0006CA1A File Offset: 0x0006AC1A
		public static bool operator !=(FGameplayTag left, FGameplayTag right)
		{
			return !(left == right);
		}

		// Token: 0x06004DC0 RID: 19904 RVA: 0x0006CA26 File Offset: 0x0006AC26
		public bool Equals(FGameplayTag other)
		{
			return this == other;
		}

		// Token: 0x06004DC1 RID: 19905 RVA: 0x0006CA34 File Offset: 0x0006AC34
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FGameplayTag)
			{
				FGameplayTag other = (FGameplayTag)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06004DC2 RID: 19906 RVA: 0x0006CA59 File Offset: 0x0006AC59
		public override int GetHashCode()
		{
			return HashCode.Combine<FName>(this.TagName);
		}

		// Token: 0x06004DC3 RID: 19907 RVA: 0x0006CA66 File Offset: 0x0006AC66
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayTag._ScriptStructPtr != 0) ? FGameplayTag._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayTags.GameplayTag", ref FGameplayTag._ScriptStructPtr);
		}

		// Token: 0x04001F04 RID: 7940
		[FieldOffset(0)]
		public readonly FName TagName;

		// Token: 0x04001F05 RID: 7941
		public const string __ObjectPath = "/Script/GameplayTags.GameplayTag";

		// Token: 0x04001F06 RID: 7942
		private static IntPtr _ScriptStructPtr;
	}
}
