using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006DE RID: 1758
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.SpriteTransitionInfo")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class FSpriteTransitionInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600955D RID: 38237 RVA: 0x000E185A File Offset: 0x000DFA5A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSpriteTransitionInfo._ScriptStructPtr != 0) ? FSpriteTransitionInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.SpriteTransitionInfo", ref FSpriteTransitionInfo._ScriptStructPtr);
		}

		// Token: 0x17001BB2 RID: 7090
		// (get) Token: 0x0600955E RID: 38238 RVA: 0x000E1880 File Offset: 0x000DFA80
		// (set) Token: 0x0600955F RID: 38239 RVA: 0x000E18C3 File Offset: 0x000DFAC3
		public FSpriteTransitionOfState NormalTransition
		{
			get
			{
				base.FastCheckIsValid();
				FSpriteTransitionOfState result;
				if ((result = this._NormalTransition) == null)
				{
					result = (this._NormalTransition = new FSpriteTransitionOfState(base.NativePtr + (IntPtr)FSpriteTransitionInfo.__PropertyOffset_NormalTransition, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSpriteTransitionOfState.StaticStruct(), base.NativePtr + (IntPtr)FSpriteTransitionInfo.__PropertyOffset_NormalTransition, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001BB3 RID: 7091
		// (get) Token: 0x06009560 RID: 38240 RVA: 0x000E18E4 File Offset: 0x000DFAE4
		// (set) Token: 0x06009561 RID: 38241 RVA: 0x000E1927 File Offset: 0x000DFB27
		public FSpriteTransitionOfState HighlightedTransition
		{
			get
			{
				base.FastCheckIsValid();
				FSpriteTransitionOfState result;
				if ((result = this._HighlightedTransition) == null)
				{
					result = (this._HighlightedTransition = new FSpriteTransitionOfState(base.NativePtr + (IntPtr)FSpriteTransitionInfo.__PropertyOffset_HighlightedTransition, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSpriteTransitionOfState.StaticStruct(), base.NativePtr + (IntPtr)FSpriteTransitionInfo.__PropertyOffset_HighlightedTransition, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001BB4 RID: 7092
		// (get) Token: 0x06009562 RID: 38242 RVA: 0x000E1948 File Offset: 0x000DFB48
		// (set) Token: 0x06009563 RID: 38243 RVA: 0x000E198B File Offset: 0x000DFB8B
		public FSpriteTransitionOfState PressedTransition
		{
			get
			{
				base.FastCheckIsValid();
				FSpriteTransitionOfState result;
				if ((result = this._PressedTransition) == null)
				{
					result = (this._PressedTransition = new FSpriteTransitionOfState(base.NativePtr + (IntPtr)FSpriteTransitionInfo.__PropertyOffset_PressedTransition, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSpriteTransitionOfState.StaticStruct(), base.NativePtr + (IntPtr)FSpriteTransitionInfo.__PropertyOffset_PressedTransition, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001BB5 RID: 7093
		// (get) Token: 0x06009564 RID: 38244 RVA: 0x000E19AC File Offset: 0x000DFBAC
		// (set) Token: 0x06009565 RID: 38245 RVA: 0x000E19EF File Offset: 0x000DFBEF
		public FSpriteTransitionOfState DisabledTransition
		{
			get
			{
				base.FastCheckIsValid();
				FSpriteTransitionOfState result;
				if ((result = this._DisabledTransition) == null)
				{
					result = (this._DisabledTransition = new FSpriteTransitionOfState(base.NativePtr + (IntPtr)FSpriteTransitionInfo.__PropertyOffset_DisabledTransition, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSpriteTransitionOfState.StaticStruct(), base.NativePtr + (IntPtr)FSpriteTransitionInfo.__PropertyOffset_DisabledTransition, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06009566 RID: 38246 RVA: 0x000E1A10 File Offset: 0x000DFC10
		public FSpriteTransitionInfo()
		{
		}

		// Token: 0x06009567 RID: 38247 RVA: 0x000E1A18 File Offset: 0x000DFC18
		protected override IntPtr GetUStructPtr()
		{
			return FSpriteTransitionInfo.StaticStruct();
		}

		// Token: 0x06009568 RID: 38248 RVA: 0x000E1A24 File Offset: 0x000DFC24
		[NullableContext(2)]
		public FSpriteTransitionInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009569 RID: 38249 RVA: 0x000E1A2E File Offset: 0x000DFC2E
		public FSpriteTransitionInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600956A RID: 38250 RVA: 0x000E1A39 File Offset: 0x000DFC39
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSpriteTransitionInfo(Pointer, false, true);
		}

		// Token: 0x0600956B RID: 38251 RVA: 0x000E1A43 File Offset: 0x000DFC43
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSpriteTransitionInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040040F6 RID: 16630
		public const string __ObjectPath = "/Script/LGUI.SpriteTransitionInfo";

		// Token: 0x040040F7 RID: 16631
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040040F8 RID: 16632
		internal static int __PropertyOffset_NormalTransition;

		// Token: 0x040040F9 RID: 16633
		[Nullable(2)]
		private FSpriteTransitionOfState _NormalTransition;

		// Token: 0x040040FA RID: 16634
		internal static int __PropertyOffset_HighlightedTransition;

		// Token: 0x040040FB RID: 16635
		[Nullable(2)]
		private FSpriteTransitionOfState _HighlightedTransition;

		// Token: 0x040040FC RID: 16636
		internal static int __PropertyOffset_PressedTransition;

		// Token: 0x040040FD RID: 16637
		[Nullable(2)]
		private FSpriteTransitionOfState _PressedTransition;

		// Token: 0x040040FE RID: 16638
		internal static int __PropertyOffset_DisabledTransition;

		// Token: 0x040040FF RID: 16639
		[Nullable(2)]
		private FSpriteTransitionOfState _DisabledTransition;
	}
}
