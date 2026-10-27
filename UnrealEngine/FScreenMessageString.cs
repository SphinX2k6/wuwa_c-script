using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020010DD RID: 4317
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ScreenMessageString")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FScreenMessageString : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F78C RID: 63372 RVA: 0x0016E585 File Offset: 0x0016C785
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FScreenMessageString._ScriptStructPtr != 0) ? FScreenMessageString._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ScreenMessageString", ref FScreenMessageString._ScriptStructPtr);
		}

		// Token: 0x17003C39 RID: 15417
		// (get) Token: 0x0600F78D RID: 63373 RVA: 0x0016E5A9 File Offset: 0x0016C7A9
		// (set) Token: 0x0600F78E RID: 63374 RVA: 0x0016E5B9 File Offset: 0x0016C7B9
		public unsafe ulong Key
		{
			get
			{
				return (ulong)(*(base.NativePtr + (IntPtr)FScreenMessageString.__PropertyOffset_Key));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FScreenMessageString.__PropertyOffset_Key) = (long)value;
			}
		}

		// Token: 0x17003C3A RID: 15418
		// (get) Token: 0x0600F78F RID: 63375 RVA: 0x0016E5CA File Offset: 0x0016C7CA
		// (set) Token: 0x0600F790 RID: 63376 RVA: 0x0016E5DE File Offset: 0x0016C7DE
		public unsafe string ScreenMessage
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FScreenMessageString.__PropertyOffset_ScreenMessage)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FScreenMessageString.__PropertyOffset_ScreenMessage)), value);
			}
		}

		// Token: 0x17003C3B RID: 15419
		// (get) Token: 0x0600F791 RID: 63377 RVA: 0x0016E5F3 File Offset: 0x0016C7F3
		// (set) Token: 0x0600F792 RID: 63378 RVA: 0x0016E607 File Offset: 0x0016C807
		public unsafe FColor DisplayColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FScreenMessageString.__PropertyOffset_DisplayColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FScreenMessageString.__PropertyOffset_DisplayColor) = value;
			}
		}

		// Token: 0x17003C3C RID: 15420
		// (get) Token: 0x0600F793 RID: 63379 RVA: 0x0016E61C File Offset: 0x0016C81C
		// (set) Token: 0x0600F794 RID: 63380 RVA: 0x0016E62C File Offset: 0x0016C82C
		public unsafe float TimeToDisplay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FScreenMessageString.__PropertyOffset_TimeToDisplay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FScreenMessageString.__PropertyOffset_TimeToDisplay) = value;
			}
		}

		// Token: 0x17003C3D RID: 15421
		// (get) Token: 0x0600F795 RID: 63381 RVA: 0x0016E63D File Offset: 0x0016C83D
		// (set) Token: 0x0600F796 RID: 63382 RVA: 0x0016E64D File Offset: 0x0016C84D
		public unsafe float CurrentTimeDisplayed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FScreenMessageString.__PropertyOffset_CurrentTimeDisplayed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FScreenMessageString.__PropertyOffset_CurrentTimeDisplayed) = value;
			}
		}

		// Token: 0x17003C3E RID: 15422
		// (get) Token: 0x0600F797 RID: 63383 RVA: 0x0016E65E File Offset: 0x0016C85E
		// (set) Token: 0x0600F798 RID: 63384 RVA: 0x0016E672 File Offset: 0x0016C872
		public unsafe FVector2D TextScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FScreenMessageString.__PropertyOffset_TextScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FScreenMessageString.__PropertyOffset_TextScale) = value;
			}
		}

		// Token: 0x0600F799 RID: 63385 RVA: 0x0016E687 File Offset: 0x0016C887
		public FScreenMessageString()
		{
		}

		// Token: 0x0600F79A RID: 63386 RVA: 0x0016E68F File Offset: 0x0016C88F
		public FScreenMessageString(ulong Key, string ScreenMessage, FColor DisplayColor, float TimeToDisplay, float CurrentTimeDisplayed, FVector2D TextScale)
		{
			this.Key = Key;
			this.ScreenMessage = ScreenMessage;
			this.DisplayColor = DisplayColor;
			this.TimeToDisplay = TimeToDisplay;
			this.CurrentTimeDisplayed = CurrentTimeDisplayed;
			this.TextScale = TextScale;
		}

		// Token: 0x0600F79B RID: 63387 RVA: 0x0016E6C4 File Offset: 0x0016C8C4
		protected override IntPtr GetUStructPtr()
		{
			return FScreenMessageString.StaticStruct();
		}

		// Token: 0x0600F79C RID: 63388 RVA: 0x0016E6D0 File Offset: 0x0016C8D0
		[NullableContext(2)]
		public FScreenMessageString(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F79D RID: 63389 RVA: 0x0016E6DA File Offset: 0x0016C8DA
		public FScreenMessageString(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F79E RID: 63390 RVA: 0x0016E6E5 File Offset: 0x0016C8E5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FScreenMessageString(Pointer, false, true);
		}

		// Token: 0x0600F79F RID: 63391 RVA: 0x0016E6EF File Offset: 0x0016C8EF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FScreenMessageString(Pointer, MemoryOwner);
		}

		// Token: 0x040085C4 RID: 34244
		public const string __ObjectPath = "/Script/Engine.ScreenMessageString";

		// Token: 0x040085C5 RID: 34245
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040085C6 RID: 34246
		internal static int __PropertyOffset_Key;

		// Token: 0x040085C7 RID: 34247
		internal static int __PropertyOffset_ScreenMessage;

		// Token: 0x040085C8 RID: 34248
		internal static int __PropertyOffset_DisplayColor;

		// Token: 0x040085C9 RID: 34249
		internal static int __PropertyOffset_TimeToDisplay;

		// Token: 0x040085CA RID: 34250
		internal static int __PropertyOffset_CurrentTimeDisplayed;

		// Token: 0x040085CB RID: 34251
		internal static int __PropertyOffset_TextScale;
	}
}
