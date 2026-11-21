using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006E0 RID: 1760
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.TextTransitionInfo")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FTextTransitionInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600957D RID: 38269 RVA: 0x000E1BB1 File Offset: 0x000DFDB1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTextTransitionInfo._ScriptStructPtr != 0) ? FTextTransitionInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.TextTransitionInfo", ref FTextTransitionInfo._ScriptStructPtr);
		}

		// Token: 0x17001BBB RID: 7099
		// (get) Token: 0x0600957E RID: 38270 RVA: 0x000E1BD8 File Offset: 0x000DFDD8
		// (set) Token: 0x0600957F RID: 38271 RVA: 0x000E1C1B File Offset: 0x000DFE1B
		public FTextTransitionInfoOfState NormalTransition
		{
			get
			{
				base.FastCheckIsValid();
				FTextTransitionInfoOfState result;
				if ((result = this._NormalTransition) == null)
				{
					result = (this._NormalTransition = new FTextTransitionInfoOfState(base.NativePtr + (IntPtr)FTextTransitionInfo.__PropertyOffset_NormalTransition, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextTransitionInfoOfState.StaticStruct(), base.NativePtr + (IntPtr)FTextTransitionInfo.__PropertyOffset_NormalTransition, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001BBC RID: 7100
		// (get) Token: 0x06009580 RID: 38272 RVA: 0x000E1C3C File Offset: 0x000DFE3C
		// (set) Token: 0x06009581 RID: 38273 RVA: 0x000E1C7F File Offset: 0x000DFE7F
		public FTextTransitionInfoOfState HighlightedTransition
		{
			get
			{
				base.FastCheckIsValid();
				FTextTransitionInfoOfState result;
				if ((result = this._HighlightedTransition) == null)
				{
					result = (this._HighlightedTransition = new FTextTransitionInfoOfState(base.NativePtr + (IntPtr)FTextTransitionInfo.__PropertyOffset_HighlightedTransition, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextTransitionInfoOfState.StaticStruct(), base.NativePtr + (IntPtr)FTextTransitionInfo.__PropertyOffset_HighlightedTransition, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001BBD RID: 7101
		// (get) Token: 0x06009582 RID: 38274 RVA: 0x000E1CA0 File Offset: 0x000DFEA0
		// (set) Token: 0x06009583 RID: 38275 RVA: 0x000E1CE3 File Offset: 0x000DFEE3
		public FTextTransitionInfoOfState PressedTransition
		{
			get
			{
				base.FastCheckIsValid();
				FTextTransitionInfoOfState result;
				if ((result = this._PressedTransition) == null)
				{
					result = (this._PressedTransition = new FTextTransitionInfoOfState(base.NativePtr + (IntPtr)FTextTransitionInfo.__PropertyOffset_PressedTransition, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextTransitionInfoOfState.StaticStruct(), base.NativePtr + (IntPtr)FTextTransitionInfo.__PropertyOffset_PressedTransition, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001BBE RID: 7102
		// (get) Token: 0x06009584 RID: 38276 RVA: 0x000E1D04 File Offset: 0x000DFF04
		// (set) Token: 0x06009585 RID: 38277 RVA: 0x000E1D47 File Offset: 0x000DFF47
		public FTextTransitionInfoOfState DisabledTransition
		{
			get
			{
				base.FastCheckIsValid();
				FTextTransitionInfoOfState result;
				if ((result = this._DisabledTransition) == null)
				{
					result = (this._DisabledTransition = new FTextTransitionInfoOfState(base.NativePtr + (IntPtr)FTextTransitionInfo.__PropertyOffset_DisabledTransition, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextTransitionInfoOfState.StaticStruct(), base.NativePtr + (IntPtr)FTextTransitionInfo.__PropertyOffset_DisabledTransition, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06009586 RID: 38278 RVA: 0x000E1D68 File Offset: 0x000DFF68
		public FTextTransitionInfo()
		{
		}

		// Token: 0x06009587 RID: 38279 RVA: 0x000E1D70 File Offset: 0x000DFF70
		protected override IntPtr GetUStructPtr()
		{
			return FTextTransitionInfo.StaticStruct();
		}

		// Token: 0x06009588 RID: 38280 RVA: 0x000E1D7C File Offset: 0x000DFF7C
		[NullableContext(2)]
		public FTextTransitionInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009589 RID: 38281 RVA: 0x000E1D86 File Offset: 0x000DFF86
		public FTextTransitionInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600958A RID: 38282 RVA: 0x000E1D91 File Offset: 0x000DFF91
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTextTransitionInfo(Pointer, false, true);
		}

		// Token: 0x0600958B RID: 38283 RVA: 0x000E1D9B File Offset: 0x000DFF9B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTextTransitionInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04004109 RID: 16649
		public const string __ObjectPath = "/Script/LGUI.TextTransitionInfo";

		// Token: 0x0400410A RID: 16650
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400410B RID: 16651
		internal static int __PropertyOffset_NormalTransition;

		// Token: 0x0400410C RID: 16652
		[Nullable(2)]
		private FTextTransitionInfoOfState _NormalTransition;

		// Token: 0x0400410D RID: 16653
		internal static int __PropertyOffset_HighlightedTransition;

		// Token: 0x0400410E RID: 16654
		[Nullable(2)]
		private FTextTransitionInfoOfState _HighlightedTransition;

		// Token: 0x0400410F RID: 16655
		internal static int __PropertyOffset_PressedTransition;

		// Token: 0x04004110 RID: 16656
		[Nullable(2)]
		private FTextTransitionInfoOfState _PressedTransition;

		// Token: 0x04004111 RID: 16657
		internal static int __PropertyOffset_DisabledTransition;

		// Token: 0x04004112 RID: 16658
		[Nullable(2)]
		private FTextTransitionInfoOfState _DisabledTransition;
	}
}
