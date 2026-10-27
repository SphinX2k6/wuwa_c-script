using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200292F RID: 10543
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(4, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 4)]
	[UnrealObjectPath("/Script/TriggerEffect.SlopeFeedbackMode")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 4)]
	public struct FSlopeFeedbackMode : IEqualityOperators<FSlopeFeedbackMode, FSlopeFeedbackMode, bool>, IEquatable<FSlopeFeedbackMode>, IUnrealScriptStruct
	{
		// Token: 0x0602701A RID: 159770 RVA: 0x003B7AD7 File Offset: 0x003B5CD7
		public FSlopeFeedbackMode(byte StartPosition, byte EndPosition, byte StartStrength, byte EndStrength)
		{
			this.StartPosition = StartPosition;
			this.EndPosition = EndPosition;
			this.StartStrength = StartStrength;
			this.EndStrength = EndStrength;
		}

		// Token: 0x0602701B RID: 159771 RVA: 0x003B7AF6 File Offset: 0x003B5CF6
		public static bool operator ==(FSlopeFeedbackMode left, FSlopeFeedbackMode right)
		{
			return left.StartPosition == right.StartPosition && left.EndPosition == right.EndPosition && left.StartStrength == right.StartStrength && left.EndStrength == right.EndStrength;
		}

		// Token: 0x0602701C RID: 159772 RVA: 0x003B7B32 File Offset: 0x003B5D32
		public static bool operator !=(FSlopeFeedbackMode left, FSlopeFeedbackMode right)
		{
			return !(left == right);
		}

		// Token: 0x0602701D RID: 159773 RVA: 0x003B7B3E File Offset: 0x003B5D3E
		public bool Equals(FSlopeFeedbackMode other)
		{
			return this == other;
		}

		// Token: 0x0602701E RID: 159774 RVA: 0x003B7B4C File Offset: 0x003B5D4C
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FSlopeFeedbackMode)
			{
				FSlopeFeedbackMode other = (FSlopeFeedbackMode)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0602701F RID: 159775 RVA: 0x003B7B71 File Offset: 0x003B5D71
		public override int GetHashCode()
		{
			return HashCode.Combine<byte, byte, byte, byte>(this.StartPosition, this.EndPosition, this.StartStrength, this.EndStrength);
		}

		// Token: 0x06027020 RID: 159776 RVA: 0x003B7B90 File Offset: 0x003B5D90
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSlopeFeedbackMode._ScriptStructPtr != 0) ? FSlopeFeedbackMode._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/TriggerEffect.SlopeFeedbackMode", ref FSlopeFeedbackMode._ScriptStructPtr);
		}

		// Token: 0x040156EA RID: 87786
		[FieldOffset(0)]
		public byte StartPosition;

		// Token: 0x040156EB RID: 87787
		[FieldOffset(1)]
		public byte EndPosition;

		// Token: 0x040156EC RID: 87788
		[FieldOffset(2)]
		public byte StartStrength;

		// Token: 0x040156ED RID: 87789
		[FieldOffset(3)]
		public byte EndStrength;

		// Token: 0x040156EE RID: 87790
		public const string __ObjectPath = "/Script/TriggerEffect.SlopeFeedbackMode";

		// Token: 0x040156EF RID: 87791
		private static IntPtr _ScriptStructPtr;
	}
}
