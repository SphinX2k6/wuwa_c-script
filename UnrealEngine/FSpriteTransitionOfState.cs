using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200210E RID: 8462
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.SpriteTransitionOfState")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FSpriteTransitionOfState : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FD69 RID: 130409 RVA: 0x002F5AE1 File Offset: 0x002F3CE1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSpriteTransitionOfState._ScriptStructPtr != 0) ? FSpriteTransitionOfState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.SpriteTransitionOfState", ref FSpriteTransitionOfState._ScriptStructPtr);
		}

		// Token: 0x17007D38 RID: 32056
		// (get) Token: 0x0601FD6A RID: 130410 RVA: 0x002F5B05 File Offset: 0x002F3D05
		// (set) Token: 0x0601FD6B RID: 130411 RVA: 0x002F5B19 File Offset: 0x002F3D19
		[Nullable(2)]
		public unsafe ULGUISpriteData_BaseObject Sprite
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUISpriteData_BaseObject>(base.NativePtr / (IntPtr)sizeof(void*) + FSpriteTransitionOfState.__PropertyOffset_Sprite);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSpriteTransitionOfState.__PropertyOffset_Sprite, value);
			}
		}

		// Token: 0x17007D39 RID: 32057
		// (get) Token: 0x0601FD6C RID: 130412 RVA: 0x002F5B2E File Offset: 0x002F3D2E
		// (set) Token: 0x0601FD6D RID: 130413 RVA: 0x002F5B42 File Offset: 0x002F3D42
		public unsafe FColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpriteTransitionOfState.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpriteTransitionOfState.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x17007D3A RID: 32058
		// (get) Token: 0x0601FD6E RID: 130414 RVA: 0x002F5B57 File Offset: 0x002F3D57
		// (set) Token: 0x0601FD6F RID: 130415 RVA: 0x002F5B70 File Offset: 0x002F3D70
		public unsafe bool bSnapSize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSpriteTransitionOfState.__PropertyOffset_bSnapSize) & FSpriteTransitionOfState.__PropertyMask_bSnapSize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSpriteTransitionOfState.__PropertyOffset_bSnapSize) = ((*(base.NativePtr + (IntPtr)FSpriteTransitionOfState.__PropertyOffset_bSnapSize) & ~FSpriteTransitionOfState.__PropertyMask_bSnapSize) | (value ? FSpriteTransitionOfState.__PropertyMask_bSnapSize : 0));
			}
		}

		// Token: 0x17007D3B RID: 32059
		// (get) Token: 0x0601FD70 RID: 130416 RVA: 0x002F5BA0 File Offset: 0x002F3DA0
		// (set) Token: 0x0601FD71 RID: 130417 RVA: 0x002F5BB9 File Offset: 0x002F3DB9
		public unsafe bool bGradualChange
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSpriteTransitionOfState.__PropertyOffset_bGradualChange) & FSpriteTransitionOfState.__PropertyMask_bGradualChange) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSpriteTransitionOfState.__PropertyOffset_bGradualChange) = ((*(base.NativePtr + (IntPtr)FSpriteTransitionOfState.__PropertyOffset_bGradualChange) & ~FSpriteTransitionOfState.__PropertyMask_bGradualChange) | (value ? FSpriteTransitionOfState.__PropertyMask_bGradualChange : 0));
			}
		}

		// Token: 0x17007D3C RID: 32060
		// (get) Token: 0x0601FD72 RID: 130418 RVA: 0x002F5BE9 File Offset: 0x002F3DE9
		// (set) Token: 0x0601FD73 RID: 130419 RVA: 0x002F5BF9 File Offset: 0x002F3DF9
		public unsafe float GradualDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpriteTransitionOfState.__PropertyOffset_GradualDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpriteTransitionOfState.__PropertyOffset_GradualDuration) = value;
			}
		}

		// Token: 0x17007D3D RID: 32061
		// (get) Token: 0x0601FD74 RID: 130420 RVA: 0x002F5C0C File Offset: 0x002F3E0C
		// (set) Token: 0x0601FD75 RID: 130421 RVA: 0x002F5C4F File Offset: 0x002F3E4F
		public FRenderableAdditionalInfo AdditionInfo
		{
			get
			{
				base.FastCheckIsValid();
				FRenderableAdditionalInfo result;
				if ((result = this._AdditionInfo) == null)
				{
					result = (this._AdditionInfo = new FRenderableAdditionalInfo(base.NativePtr + (IntPtr)FSpriteTransitionOfState.__PropertyOffset_AdditionInfo, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRenderableAdditionalInfo.StaticStruct(), base.NativePtr + (IntPtr)FSpriteTransitionOfState.__PropertyOffset_AdditionInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601FD76 RID: 130422 RVA: 0x002F5C70 File Offset: 0x002F3E70
		public FSpriteTransitionOfState()
		{
		}

		// Token: 0x0601FD77 RID: 130423 RVA: 0x002F5C78 File Offset: 0x002F3E78
		public FSpriteTransitionOfState(ULGUISpriteData_BaseObject Sprite, string PredefineColor, FColor Color, bool bSnapSize, bool bGradualChange, float GradualDuration, FRenderableAdditionalInfo AdditionInfo)
		{
			this.Sprite = Sprite;
			this.Color = Color;
			this.bSnapSize = bSnapSize;
			this.bGradualChange = bGradualChange;
			this.GradualDuration = GradualDuration;
			this.AdditionInfo = AdditionInfo;
		}

		// Token: 0x0601FD78 RID: 130424 RVA: 0x002F5CAE File Offset: 0x002F3EAE
		protected override IntPtr GetUStructPtr()
		{
			return FSpriteTransitionOfState.StaticStruct();
		}

		// Token: 0x0601FD79 RID: 130425 RVA: 0x002F5CBA File Offset: 0x002F3EBA
		[NullableContext(2)]
		public FSpriteTransitionOfState(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FD7A RID: 130426 RVA: 0x002F5CC4 File Offset: 0x002F3EC4
		public FSpriteTransitionOfState(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FD7B RID: 130427 RVA: 0x002F5CCF File Offset: 0x002F3ECF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSpriteTransitionOfState(Pointer, false, true);
		}

		// Token: 0x0601FD7C RID: 130428 RVA: 0x002F5CD9 File Offset: 0x002F3ED9
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSpriteTransitionOfState(Pointer, MemoryOwner);
		}

		// Token: 0x04011283 RID: 70275
		public const string __ObjectPath = "/Script/LGUI.SpriteTransitionOfState";

		// Token: 0x04011284 RID: 70276
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011285 RID: 70277
		internal static int __PropertyOffset_Sprite;

		// Token: 0x04011286 RID: 70278
		internal static int __PropertyOffset_Color;

		// Token: 0x04011287 RID: 70279
		internal static int __PropertyOffset_bSnapSize;

		// Token: 0x04011288 RID: 70280
		internal static byte __PropertyMask_bSnapSize;

		// Token: 0x04011289 RID: 70281
		internal static int __PropertyOffset_bGradualChange;

		// Token: 0x0401128A RID: 70282
		internal static byte __PropertyMask_bGradualChange;

		// Token: 0x0401128B RID: 70283
		internal static int __PropertyOffset_GradualDuration;

		// Token: 0x0401128C RID: 70284
		internal static int __PropertyOffset_AdditionInfo;

		// Token: 0x0401128D RID: 70285
		[Nullable(2)]
		private FRenderableAdditionalInfo _AdditionInfo;
	}
}
