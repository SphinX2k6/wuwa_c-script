using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020013DB RID: 5083
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Script/GameplayTags.GameplayTag")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct FGameplayTag : IEqualityOperators<FGameplayTag, FGameplayTag, bool>, IEquatable<FGameplayTag>, IUnrealScriptStruct
	{
		// Token: 0x06012980 RID: 76160 RVA: 0x001B5BD9 File Offset: 0x001B3DD9
		public FGameplayTag(FName TagName)
		{
			this.TagName = TagName;
		}

		// Token: 0x06012981 RID: 76161 RVA: 0x001B5BE2 File Offset: 0x001B3DE2
		public static bool operator ==(FGameplayTag left, FGameplayTag right)
		{
			return left.TagName == right.TagName;
		}

		// Token: 0x06012982 RID: 76162 RVA: 0x001B5BF5 File Offset: 0x001B3DF5
		public static bool operator !=(FGameplayTag left, FGameplayTag right)
		{
			return !(left == right);
		}

		// Token: 0x06012983 RID: 76163 RVA: 0x001B5C01 File Offset: 0x001B3E01
		public bool Equals(FGameplayTag other)
		{
			return this == other;
		}

		// Token: 0x06012984 RID: 76164 RVA: 0x001B5C10 File Offset: 0x001B3E10
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

		// Token: 0x06012985 RID: 76165 RVA: 0x001B5C35 File Offset: 0x001B3E35
		public override int GetHashCode()
		{
			return HashCode.Combine<FName>(this.TagName);
		}

		// Token: 0x06012986 RID: 76166 RVA: 0x001B5C42 File Offset: 0x001B3E42
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayTag._ScriptStructPtr != 0) ? FGameplayTag._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayTags.GameplayTag", ref FGameplayTag._ScriptStructPtr);
		}

		// Token: 0x04009EFB RID: 40699
		[FieldOffset(0)]
		public readonly FName TagName;

		// Token: 0x04009EFC RID: 40700
		public const string __ObjectPath = "/Script/GameplayTags.GameplayTag";

		// Token: 0x04009EFD RID: 40701
		private static IntPtr _ScriptStructPtr;
	}
}
