using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002110 RID: 8464
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.TextTransitionInfo")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FTextTransitionInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FD85 RID: 130437 RVA: 0x002F5F0A File Offset: 0x002F410A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTextTransitionInfo._ScriptStructPtr != 0) ? FTextTransitionInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.TextTransitionInfo", ref FTextTransitionInfo._ScriptStructPtr);
		}

		// Token: 0x17007D3E RID: 32062
		// (get) Token: 0x0601FD86 RID: 130438 RVA: 0x002F5F30 File Offset: 0x002F4130
		// (set) Token: 0x0601FD87 RID: 130439 RVA: 0x002F5F73 File Offset: 0x002F4173
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

		// Token: 0x17007D3F RID: 32063
		// (get) Token: 0x0601FD88 RID: 130440 RVA: 0x002F5F94 File Offset: 0x002F4194
		// (set) Token: 0x0601FD89 RID: 130441 RVA: 0x002F5FD7 File Offset: 0x002F41D7
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

		// Token: 0x17007D40 RID: 32064
		// (get) Token: 0x0601FD8A RID: 130442 RVA: 0x002F5FF8 File Offset: 0x002F41F8
		// (set) Token: 0x0601FD8B RID: 130443 RVA: 0x002F603B File Offset: 0x002F423B
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

		// Token: 0x17007D41 RID: 32065
		// (get) Token: 0x0601FD8C RID: 130444 RVA: 0x002F605C File Offset: 0x002F425C
		// (set) Token: 0x0601FD8D RID: 130445 RVA: 0x002F609F File Offset: 0x002F429F
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

		// Token: 0x0601FD8E RID: 130446 RVA: 0x002F60C0 File Offset: 0x002F42C0
		public FTextTransitionInfo()
		{
		}

		// Token: 0x0601FD8F RID: 130447 RVA: 0x002F60C8 File Offset: 0x002F42C8
		public FTextTransitionInfo(FTextTransitionInfoOfState NormalTransition, FTextTransitionInfoOfState HighlightedTransition, FTextTransitionInfoOfState PressedTransition, FTextTransitionInfoOfState DisabledTransition)
		{
			this.NormalTransition = NormalTransition;
			this.HighlightedTransition = HighlightedTransition;
			this.PressedTransition = PressedTransition;
			this.DisabledTransition = DisabledTransition;
		}

		// Token: 0x0601FD90 RID: 130448 RVA: 0x002F60ED File Offset: 0x002F42ED
		protected override IntPtr GetUStructPtr()
		{
			return FTextTransitionInfo.StaticStruct();
		}

		// Token: 0x0601FD91 RID: 130449 RVA: 0x002F60F9 File Offset: 0x002F42F9
		[NullableContext(2)]
		public FTextTransitionInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FD92 RID: 130450 RVA: 0x002F6103 File Offset: 0x002F4303
		public FTextTransitionInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FD93 RID: 130451 RVA: 0x002F610E File Offset: 0x002F430E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTextTransitionInfo(Pointer, false, true);
		}

		// Token: 0x0601FD94 RID: 130452 RVA: 0x002F6118 File Offset: 0x002F4318
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTextTransitionInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04011294 RID: 70292
		public const string __ObjectPath = "/Script/LGUI.TextTransitionInfo";

		// Token: 0x04011295 RID: 70293
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011296 RID: 70294
		internal static int __PropertyOffset_NormalTransition;

		// Token: 0x04011297 RID: 70295
		[Nullable(2)]
		private FTextTransitionInfoOfState _NormalTransition;

		// Token: 0x04011298 RID: 70296
		internal static int __PropertyOffset_HighlightedTransition;

		// Token: 0x04011299 RID: 70297
		[Nullable(2)]
		private FTextTransitionInfoOfState _HighlightedTransition;

		// Token: 0x0401129A RID: 70298
		internal static int __PropertyOffset_PressedTransition;

		// Token: 0x0401129B RID: 70299
		[Nullable(2)]
		private FTextTransitionInfoOfState _PressedTransition;

		// Token: 0x0401129C RID: 70300
		internal static int __PropertyOffset_DisabledTransition;

		// Token: 0x0401129D RID: 70301
		[Nullable(2)]
		private FTextTransitionInfoOfState _DisabledTransition;
	}
}
