using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020011BA RID: 4538
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SubtitleCue")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FSubtitleCue : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010BB8 RID: 68536 RVA: 0x00189008 File Offset: 0x00187208
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSubtitleCue._ScriptStructPtr != 0) ? FSubtitleCue._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SubtitleCue", ref FSubtitleCue._ScriptStructPtr);
		}

		// Token: 0x17004159 RID: 16729
		// (get) Token: 0x06010BB9 RID: 68537 RVA: 0x0018902C File Offset: 0x0018722C
		// (set) Token: 0x06010BBA RID: 68538 RVA: 0x0018906F File Offset: 0x0018726F
		public unsafe FText Text
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._Text) == null)
				{
					result = (this._Text = new FText(base.NativePtr + (IntPtr)FSubtitleCue.__PropertyOffset_Text, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)FSubtitleCue.__PropertyOffset_Text)), value.NativePtr, 1);
			}
		}

		// Token: 0x1700415A RID: 16730
		// (get) Token: 0x06010BBB RID: 68539 RVA: 0x0018908A File Offset: 0x0018728A
		// (set) Token: 0x06010BBC RID: 68540 RVA: 0x0018909A File Offset: 0x0018729A
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubtitleCue.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubtitleCue.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x06010BBD RID: 68541 RVA: 0x001890AB File Offset: 0x001872AB
		public FSubtitleCue()
		{
		}

		// Token: 0x06010BBE RID: 68542 RVA: 0x001890B3 File Offset: 0x001872B3
		public FSubtitleCue(FText Text, float Time)
		{
			this.Text = Text;
			this.Time = Time;
		}

		// Token: 0x06010BBF RID: 68543 RVA: 0x001890C9 File Offset: 0x001872C9
		protected override IntPtr GetUStructPtr()
		{
			return FSubtitleCue.StaticStruct();
		}

		// Token: 0x06010BC0 RID: 68544 RVA: 0x001890D5 File Offset: 0x001872D5
		[NullableContext(2)]
		public FSubtitleCue(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010BC1 RID: 68545 RVA: 0x001890DF File Offset: 0x001872DF
		public FSubtitleCue(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010BC2 RID: 68546 RVA: 0x001890EA File Offset: 0x001872EA
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSubtitleCue(Pointer, false, true);
		}

		// Token: 0x06010BC3 RID: 68547 RVA: 0x001890F4 File Offset: 0x001872F4
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSubtitleCue(Pointer, MemoryOwner);
		}

		// Token: 0x04008F1B RID: 36635
		public const string __ObjectPath = "/Script/Engine.SubtitleCue";

		// Token: 0x04008F1C RID: 36636
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008F1D RID: 36637
		internal static int __PropertyOffset_Text;

		// Token: 0x04008F1E RID: 36638
		[Nullable(2)]
		private FText _Text;

		// Token: 0x04008F1F RID: 36639
		internal static int __PropertyOffset_Time;
	}
}
