using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020013A7 RID: 5031
	[UnrealObjectPath("/Script/GameplayAbilities.ModifierSpec")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FModifierSpec : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012778 RID: 75640 RVA: 0x001B25E2 File Offset: 0x001B07E2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FModifierSpec._ScriptStructPtr != 0) ? FModifierSpec._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.ModifierSpec", ref FModifierSpec._ScriptStructPtr);
		}

		// Token: 0x170047F5 RID: 18421
		// (get) Token: 0x06012779 RID: 75641 RVA: 0x001B2606 File Offset: 0x001B0806
		// (set) Token: 0x0601277A RID: 75642 RVA: 0x001B2616 File Offset: 0x001B0816
		public unsafe float EvaluatedMagnitude
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FModifierSpec.__PropertyOffset_EvaluatedMagnitude);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FModifierSpec.__PropertyOffset_EvaluatedMagnitude) = value;
			}
		}

		// Token: 0x0601277B RID: 75643 RVA: 0x001B2627 File Offset: 0x001B0827
		public FModifierSpec()
		{
		}

		// Token: 0x0601277C RID: 75644 RVA: 0x001B262F File Offset: 0x001B082F
		public FModifierSpec(float EvaluatedMagnitude)
		{
			this.EvaluatedMagnitude = EvaluatedMagnitude;
		}

		// Token: 0x0601277D RID: 75645 RVA: 0x001B263E File Offset: 0x001B083E
		protected override IntPtr GetUStructPtr()
		{
			return FModifierSpec.StaticStruct();
		}

		// Token: 0x0601277E RID: 75646 RVA: 0x001B264A File Offset: 0x001B084A
		[NullableContext(2)]
		public FModifierSpec(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601277F RID: 75647 RVA: 0x001B2654 File Offset: 0x001B0854
		public FModifierSpec(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012780 RID: 75648 RVA: 0x001B265F File Offset: 0x001B085F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FModifierSpec(Pointer, false, true);
		}

		// Token: 0x06012781 RID: 75649 RVA: 0x001B2669 File Offset: 0x001B0869
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FModifierSpec(Pointer, MemoryOwner);
		}

		// Token: 0x04009E2A RID: 40490
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.ModifierSpec";

		// Token: 0x04009E2B RID: 40491
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009E2C RID: 40492
		internal static int __PropertyOffset_EvaluatedMagnitude;
	}
}
