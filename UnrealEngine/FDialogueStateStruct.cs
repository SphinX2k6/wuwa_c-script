using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007C4 RID: 1988
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 1)]
	[UnrealObjectPath("/Script/SequenceDialogue.DialogueStateStruct")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
	public struct FDialogueStateStruct : IEqualityOperators<FDialogueStateStruct, FDialogueStateStruct, bool>, IEquatable<FDialogueStateStruct>, IUnrealScriptStruct
	{
		// Token: 0x0600ABEC RID: 44012 RVA: 0x000FD914 File Offset: 0x000FBB14
		public FDialogueStateStruct(EDialogueStateEnum State)
		{
			this.State = State;
		}

		// Token: 0x0600ABED RID: 44013 RVA: 0x000FD91D File Offset: 0x000FBB1D
		public static bool operator ==(FDialogueStateStruct left, FDialogueStateStruct right)
		{
			return left.State == right.State;
		}

		// Token: 0x0600ABEE RID: 44014 RVA: 0x000FD92D File Offset: 0x000FBB2D
		public static bool operator !=(FDialogueStateStruct left, FDialogueStateStruct right)
		{
			return !(left == right);
		}

		// Token: 0x0600ABEF RID: 44015 RVA: 0x000FD939 File Offset: 0x000FBB39
		public bool Equals(FDialogueStateStruct other)
		{
			return this == other;
		}

		// Token: 0x0600ABF0 RID: 44016 RVA: 0x000FD948 File Offset: 0x000FBB48
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FDialogueStateStruct)
			{
				FDialogueStateStruct other = (FDialogueStateStruct)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0600ABF1 RID: 44017 RVA: 0x000FD96D File Offset: 0x000FBB6D
		public override int GetHashCode()
		{
			return HashCode.Combine<EDialogueStateEnum>(this.State);
		}

		// Token: 0x0600ABF2 RID: 44018 RVA: 0x000FD97A File Offset: 0x000FBB7A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDialogueStateStruct._ScriptStructPtr != 0) ? FDialogueStateStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SequenceDialogue.DialogueStateStruct", ref FDialogueStateStruct._ScriptStructPtr);
		}

		// Token: 0x040049EF RID: 18927
		[FieldOffset(0)]
		public EDialogueStateEnum State;

		// Token: 0x040049F0 RID: 18928
		public const string __ObjectPath = "/Script/SequenceDialogue.DialogueStateStruct";

		// Token: 0x040049F1 RID: 18929
		private static IntPtr _ScriptStructPtr;
	}
}
