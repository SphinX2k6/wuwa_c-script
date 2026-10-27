using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200292D RID: 10541
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/TriggerEffect.MultiplePositionFeedbackMode")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FMultiplePositionFeedbackMode : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06027004 RID: 159748 RVA: 0x003B7929 File Offset: 0x003B5B29
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMultiplePositionFeedbackMode._ScriptStructPtr != 0) ? FMultiplePositionFeedbackMode._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/TriggerEffect.MultiplePositionFeedbackMode", ref FMultiplePositionFeedbackMode._ScriptStructPtr);
		}

		// Token: 0x1700961F RID: 38431
		// (get) Token: 0x06027005 RID: 159749 RVA: 0x003B7950 File Offset: 0x003B5B50
		// (set) Token: 0x06027006 RID: 159750 RVA: 0x003B7993 File Offset: 0x003B5B93
		public TArray<byte> Strength
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._Strength) == null)
				{
					result = (this._Strength = new TArray<byte>(base.NativePtr + (IntPtr)FMultiplePositionFeedbackMode.__PropertyOffset_Strength, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Strength.CopyAssign(value);
			}
		}

		// Token: 0x06027007 RID: 159751 RVA: 0x003B79A1 File Offset: 0x003B5BA1
		public FMultiplePositionFeedbackMode()
		{
		}

		// Token: 0x06027008 RID: 159752 RVA: 0x003B79A9 File Offset: 0x003B5BA9
		public FMultiplePositionFeedbackMode(TArray<byte> Strength)
		{
			this.Strength = Strength;
		}

		// Token: 0x06027009 RID: 159753 RVA: 0x003B79B8 File Offset: 0x003B5BB8
		protected override IntPtr GetUStructPtr()
		{
			return FMultiplePositionFeedbackMode.StaticStruct();
		}

		// Token: 0x0602700A RID: 159754 RVA: 0x003B79C4 File Offset: 0x003B5BC4
		[NullableContext(2)]
		public FMultiplePositionFeedbackMode(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602700B RID: 159755 RVA: 0x003B79CE File Offset: 0x003B5BCE
		public FMultiplePositionFeedbackMode(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602700C RID: 159756 RVA: 0x003B79D9 File Offset: 0x003B5BD9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMultiplePositionFeedbackMode(Pointer, false, true);
		}

		// Token: 0x0602700D RID: 159757 RVA: 0x003B79E3 File Offset: 0x003B5BE3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMultiplePositionFeedbackMode(Pointer, MemoryOwner);
		}

		// Token: 0x040156E1 RID: 87777
		public const string __ObjectPath = "/Script/TriggerEffect.MultiplePositionFeedbackMode";

		// Token: 0x040156E2 RID: 87778
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040156E3 RID: 87779
		internal static int __PropertyOffset_Strength;

		// Token: 0x040156E4 RID: 87780
		[Nullable(2)]
		private TArray<byte> _Strength;
	}
}
