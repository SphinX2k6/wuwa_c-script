using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020026DB RID: 9947
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 1)]
	[UnrealObjectPath("/Script/SequenceDialogue.DialogueStateStruct")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
	public struct FDialogueStateStruct : IEqualityOperators<FDialogueStateStruct, FDialogueStateStruct, bool>, IEquatable<FDialogueStateStruct>, IUnrealScriptStruct
	{
		// Token: 0x06024E9B RID: 151195 RVA: 0x003698AA File Offset: 0x00367AAA
		public FDialogueStateStruct(EDialogueStateEnum State)
		{
			this.State = State;
		}

		// Token: 0x06024E9C RID: 151196 RVA: 0x003698B3 File Offset: 0x00367AB3
		public static bool operator ==(FDialogueStateStruct left, FDialogueStateStruct right)
		{
			return left.State == right.State;
		}

		// Token: 0x06024E9D RID: 151197 RVA: 0x003698C3 File Offset: 0x00367AC3
		public static bool operator !=(FDialogueStateStruct left, FDialogueStateStruct right)
		{
			return !(left == right);
		}

		// Token: 0x06024E9E RID: 151198 RVA: 0x003698CF File Offset: 0x00367ACF
		public bool Equals(FDialogueStateStruct other)
		{
			return this == other;
		}

		// Token: 0x06024E9F RID: 151199 RVA: 0x003698E0 File Offset: 0x00367AE0
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

		// Token: 0x06024EA0 RID: 151200 RVA: 0x00369905 File Offset: 0x00367B05
		public override int GetHashCode()
		{
			return HashCode.Combine<EDialogueStateEnum>(this.State);
		}

		// Token: 0x06024EA1 RID: 151201 RVA: 0x00369912 File Offset: 0x00367B12
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDialogueStateStruct._ScriptStructPtr != 0) ? FDialogueStateStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SequenceDialogue.DialogueStateStruct", ref FDialogueStateStruct._ScriptStructPtr);
		}

		// Token: 0x04013E27 RID: 81447
		[FieldOffset(0)]
		public EDialogueStateEnum State;

		// Token: 0x04013E28 RID: 81448
		public const string __ObjectPath = "/Script/SequenceDialogue.DialogueStateStruct";

		// Token: 0x04013E29 RID: 81449
		private static IntPtr _ScriptStructPtr;
	}
}
