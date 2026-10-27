using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200292B RID: 10539
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(2, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 2)]
	[UnrealObjectPath("/Script/TriggerEffect.FeedbackMode")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 2)]
	public struct FFeedbackMode : IEqualityOperators<FFeedbackMode, FFeedbackMode, bool>, IEquatable<FFeedbackMode>, IUnrealScriptStruct
	{
		// Token: 0x06026FE6 RID: 159718 RVA: 0x003B7643 File Offset: 0x003B5843
		public FFeedbackMode(byte Position, byte Strength)
		{
			this.Position = Position;
			this.Strength = Strength;
		}

		// Token: 0x06026FE7 RID: 159719 RVA: 0x003B7653 File Offset: 0x003B5853
		public static bool operator ==(FFeedbackMode left, FFeedbackMode right)
		{
			return left.Position == right.Position && left.Strength == right.Strength;
		}

		// Token: 0x06026FE8 RID: 159720 RVA: 0x003B7673 File Offset: 0x003B5873
		public static bool operator !=(FFeedbackMode left, FFeedbackMode right)
		{
			return !(left == right);
		}

		// Token: 0x06026FE9 RID: 159721 RVA: 0x003B767F File Offset: 0x003B587F
		public bool Equals(FFeedbackMode other)
		{
			return this == other;
		}

		// Token: 0x06026FEA RID: 159722 RVA: 0x003B7690 File Offset: 0x003B5890
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FFeedbackMode)
			{
				FFeedbackMode other = (FFeedbackMode)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06026FEB RID: 159723 RVA: 0x003B76B5 File Offset: 0x003B58B5
		public override int GetHashCode()
		{
			return HashCode.Combine<byte, byte>(this.Position, this.Strength);
		}

		// Token: 0x06026FEC RID: 159724 RVA: 0x003B76C8 File Offset: 0x003B58C8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFeedbackMode._ScriptStructPtr != 0) ? FFeedbackMode._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/TriggerEffect.FeedbackMode", ref FFeedbackMode._ScriptStructPtr);
		}

		// Token: 0x040156CF RID: 87759
		[FieldOffset(0)]
		public byte Position;

		// Token: 0x040156D0 RID: 87760
		[FieldOffset(1)]
		public byte Strength;

		// Token: 0x040156D1 RID: 87761
		public const string __ObjectPath = "/Script/TriggerEffect.FeedbackMode";

		// Token: 0x040156D2 RID: 87762
		private static IntPtr _ScriptStructPtr;
	}
}
