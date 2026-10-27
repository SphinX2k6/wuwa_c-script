using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020013DF RID: 5087
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 1)]
	[UnrealObjectPath("/Script/GameplayTags.GameplayTagCreationWidgetHelper")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
	public struct FGameplayTagCreationWidgetHelper : IEqualityOperators<FGameplayTagCreationWidgetHelper, FGameplayTagCreationWidgetHelper, bool>, IEquatable<FGameplayTagCreationWidgetHelper>, IUnrealScriptStruct
	{
		// Token: 0x060129A4 RID: 76196 RVA: 0x001B6058 File Offset: 0x001B4258
		public unsafe static bool operator ==(FGameplayTagCreationWidgetHelper left, FGameplayTagCreationWidgetHelper right)
		{
			Span<byte> span = new Span<byte>((void*)(&left), 1);
			Span<byte> span2 = new Span<byte>((void*)(&right), 1);
			return span.SequenceEqual(span2);
		}

		// Token: 0x060129A5 RID: 76197 RVA: 0x001B6084 File Offset: 0x001B4284
		public static bool operator !=(FGameplayTagCreationWidgetHelper left, FGameplayTagCreationWidgetHelper right)
		{
			return !(left == right);
		}

		// Token: 0x060129A6 RID: 76198 RVA: 0x001B6090 File Offset: 0x001B4290
		public bool Equals(FGameplayTagCreationWidgetHelper other)
		{
			return this == other;
		}

		// Token: 0x060129A7 RID: 76199 RVA: 0x001B60A0 File Offset: 0x001B42A0
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FGameplayTagCreationWidgetHelper)
			{
				FGameplayTagCreationWidgetHelper other = (FGameplayTagCreationWidgetHelper)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060129A8 RID: 76200 RVA: 0x001B60C5 File Offset: 0x001B42C5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayTagCreationWidgetHelper._ScriptStructPtr != 0) ? FGameplayTagCreationWidgetHelper._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayTags.GameplayTagCreationWidgetHelper", ref FGameplayTagCreationWidgetHelper._ScriptStructPtr);
		}

		// Token: 0x04009F0A RID: 40714
		public const string __ObjectPath = "/Script/GameplayTags.GameplayTagCreationWidgetHelper";

		// Token: 0x04009F0B RID: 40715
		private static IntPtr _ScriptStructPtr;
	}
}
