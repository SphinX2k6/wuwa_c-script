using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200210D RID: 8461
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.SpriteTransitionInfo")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class FSpriteTransitionInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FD59 RID: 130393 RVA: 0x002F58CC File Offset: 0x002F3ACC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSpriteTransitionInfo._ScriptStructPtr != 0) ? FSpriteTransitionInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.SpriteTransitionInfo", ref FSpriteTransitionInfo._ScriptStructPtr);
		}

		// Token: 0x17007D34 RID: 32052
		// (get) Token: 0x0601FD5A RID: 130394 RVA: 0x002F58F0 File Offset: 0x002F3AF0
		// (set) Token: 0x0601FD5B RID: 130395 RVA: 0x002F5933 File Offset: 0x002F3B33
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

		// Token: 0x17007D35 RID: 32053
		// (get) Token: 0x0601FD5C RID: 130396 RVA: 0x002F5954 File Offset: 0x002F3B54
		// (set) Token: 0x0601FD5D RID: 130397 RVA: 0x002F5997 File Offset: 0x002F3B97
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

		// Token: 0x17007D36 RID: 32054
		// (get) Token: 0x0601FD5E RID: 130398 RVA: 0x002F59B8 File Offset: 0x002F3BB8
		// (set) Token: 0x0601FD5F RID: 130399 RVA: 0x002F59FB File Offset: 0x002F3BFB
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

		// Token: 0x17007D37 RID: 32055
		// (get) Token: 0x0601FD60 RID: 130400 RVA: 0x002F5A1C File Offset: 0x002F3C1C
		// (set) Token: 0x0601FD61 RID: 130401 RVA: 0x002F5A5F File Offset: 0x002F3C5F
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

		// Token: 0x0601FD62 RID: 130402 RVA: 0x002F5A80 File Offset: 0x002F3C80
		public FSpriteTransitionInfo()
		{
		}

		// Token: 0x0601FD63 RID: 130403 RVA: 0x002F5A88 File Offset: 0x002F3C88
		public FSpriteTransitionInfo(FSpriteTransitionOfState NormalTransition, FSpriteTransitionOfState HighlightedTransition, FSpriteTransitionOfState PressedTransition, FSpriteTransitionOfState DisabledTransition)
		{
			this.NormalTransition = NormalTransition;
			this.HighlightedTransition = HighlightedTransition;
			this.PressedTransition = PressedTransition;
			this.DisabledTransition = DisabledTransition;
		}

		// Token: 0x0601FD64 RID: 130404 RVA: 0x002F5AAD File Offset: 0x002F3CAD
		protected override IntPtr GetUStructPtr()
		{
			return FSpriteTransitionInfo.StaticStruct();
		}

		// Token: 0x0601FD65 RID: 130405 RVA: 0x002F5AB9 File Offset: 0x002F3CB9
		[NullableContext(2)]
		public FSpriteTransitionInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FD66 RID: 130406 RVA: 0x002F5AC3 File Offset: 0x002F3CC3
		public FSpriteTransitionInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FD67 RID: 130407 RVA: 0x002F5ACE File Offset: 0x002F3CCE
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSpriteTransitionInfo(Pointer, false, true);
		}

		// Token: 0x0601FD68 RID: 130408 RVA: 0x002F5AD8 File Offset: 0x002F3CD8
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSpriteTransitionInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04011279 RID: 70265
		public const string __ObjectPath = "/Script/LGUI.SpriteTransitionInfo";

		// Token: 0x0401127A RID: 70266
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401127B RID: 70267
		internal static int __PropertyOffset_NormalTransition;

		// Token: 0x0401127C RID: 70268
		[Nullable(2)]
		private FSpriteTransitionOfState _NormalTransition;

		// Token: 0x0401127D RID: 70269
		internal static int __PropertyOffset_HighlightedTransition;

		// Token: 0x0401127E RID: 70270
		[Nullable(2)]
		private FSpriteTransitionOfState _HighlightedTransition;

		// Token: 0x0401127F RID: 70271
		internal static int __PropertyOffset_PressedTransition;

		// Token: 0x04011280 RID: 70272
		[Nullable(2)]
		private FSpriteTransitionOfState _PressedTransition;

		// Token: 0x04011281 RID: 70273
		internal static int __PropertyOffset_DisabledTransition;

		// Token: 0x04011282 RID: 70274
		[Nullable(2)]
		private FSpriteTransitionOfState _DisabledTransition;
	}
}
