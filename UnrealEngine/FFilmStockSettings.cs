using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000BD4 RID: 3028
	[UnrealObjectPath("/Script/Engine.FilmStockSettings")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FFilmStockSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060094DC RID: 38108 RVA: 0x000D46AC File Offset: 0x000D28AC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFilmStockSettings._ScriptStructPtr != 0) ? FFilmStockSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.FilmStockSettings", ref FFilmStockSettings._ScriptStructPtr);
		}

		// Token: 0x170023A0 RID: 9120
		// (get) Token: 0x060094DD RID: 38109 RVA: 0x000D46D0 File Offset: 0x000D28D0
		// (set) Token: 0x060094DE RID: 38110 RVA: 0x000D46E0 File Offset: 0x000D28E0
		public unsafe float Slope
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFilmStockSettings.__PropertyOffset_Slope);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFilmStockSettings.__PropertyOffset_Slope) = value;
			}
		}

		// Token: 0x170023A1 RID: 9121
		// (get) Token: 0x060094DF RID: 38111 RVA: 0x000D46F1 File Offset: 0x000D28F1
		// (set) Token: 0x060094E0 RID: 38112 RVA: 0x000D4701 File Offset: 0x000D2901
		public unsafe float Toe
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFilmStockSettings.__PropertyOffset_Toe);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFilmStockSettings.__PropertyOffset_Toe) = value;
			}
		}

		// Token: 0x170023A2 RID: 9122
		// (get) Token: 0x060094E1 RID: 38113 RVA: 0x000D4712 File Offset: 0x000D2912
		// (set) Token: 0x060094E2 RID: 38114 RVA: 0x000D4722 File Offset: 0x000D2922
		public unsafe float Shoulder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFilmStockSettings.__PropertyOffset_Shoulder);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFilmStockSettings.__PropertyOffset_Shoulder) = value;
			}
		}

		// Token: 0x170023A3 RID: 9123
		// (get) Token: 0x060094E3 RID: 38115 RVA: 0x000D4733 File Offset: 0x000D2933
		// (set) Token: 0x060094E4 RID: 38116 RVA: 0x000D4743 File Offset: 0x000D2943
		public unsafe float BlackClip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFilmStockSettings.__PropertyOffset_BlackClip);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFilmStockSettings.__PropertyOffset_BlackClip) = value;
			}
		}

		// Token: 0x170023A4 RID: 9124
		// (get) Token: 0x060094E5 RID: 38117 RVA: 0x000D4754 File Offset: 0x000D2954
		// (set) Token: 0x060094E6 RID: 38118 RVA: 0x000D4764 File Offset: 0x000D2964
		public unsafe float WhiteClip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFilmStockSettings.__PropertyOffset_WhiteClip);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFilmStockSettings.__PropertyOffset_WhiteClip) = value;
			}
		}

		// Token: 0x060094E7 RID: 38119 RVA: 0x000D4775 File Offset: 0x000D2975
		public FFilmStockSettings()
		{
		}

		// Token: 0x060094E8 RID: 38120 RVA: 0x000D477D File Offset: 0x000D297D
		public FFilmStockSettings(float Slope, float Toe, float Shoulder, float BlackClip, float WhiteClip)
		{
			this.Slope = Slope;
			this.Toe = Toe;
			this.Shoulder = Shoulder;
			this.BlackClip = BlackClip;
			this.WhiteClip = WhiteClip;
		}

		// Token: 0x060094E9 RID: 38121 RVA: 0x000D47AA File Offset: 0x000D29AA
		protected override IntPtr GetUStructPtr()
		{
			return FFilmStockSettings.StaticStruct();
		}

		// Token: 0x060094EA RID: 38122 RVA: 0x000D47B6 File Offset: 0x000D29B6
		[NullableContext(2)]
		public FFilmStockSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060094EB RID: 38123 RVA: 0x000D47C0 File Offset: 0x000D29C0
		public FFilmStockSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060094EC RID: 38124 RVA: 0x000D47CB File Offset: 0x000D29CB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFilmStockSettings(Pointer, false, true);
		}

		// Token: 0x060094ED RID: 38125 RVA: 0x000D47D5 File Offset: 0x000D29D5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFilmStockSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04005394 RID: 21396
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.FilmStockSettings";

		// Token: 0x04005395 RID: 21397
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005396 RID: 21398
		internal static int __PropertyOffset_Slope;

		// Token: 0x04005397 RID: 21399
		internal static int __PropertyOffset_Toe;

		// Token: 0x04005398 RID: 21400
		internal static int __PropertyOffset_Shoulder;

		// Token: 0x04005399 RID: 21401
		internal static int __PropertyOffset_BlackClip;

		// Token: 0x0400539A RID: 21402
		internal static int __PropertyOffset_WhiteClip;
	}
}
