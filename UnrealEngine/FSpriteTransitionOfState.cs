using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006DF RID: 1759
	[UnrealObjectPath("/Script/LGUI.SpriteTransitionOfState")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FSpriteTransitionOfState : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600956C RID: 38252 RVA: 0x000E1A4C File Offset: 0x000DFC4C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSpriteTransitionOfState._ScriptStructPtr != 0) ? FSpriteTransitionOfState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.SpriteTransitionOfState", ref FSpriteTransitionOfState._ScriptStructPtr);
		}

		// Token: 0x17001BB6 RID: 7094
		// (get) Token: 0x0600956D RID: 38253 RVA: 0x000E1A70 File Offset: 0x000DFC70
		// (set) Token: 0x0600956E RID: 38254 RVA: 0x000E1A84 File Offset: 0x000DFC84
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

		// Token: 0x17001BB7 RID: 7095
		// (get) Token: 0x0600956F RID: 38255 RVA: 0x000E1A99 File Offset: 0x000DFC99
		// (set) Token: 0x06009570 RID: 38256 RVA: 0x000E1AAD File Offset: 0x000DFCAD
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

		// Token: 0x17001BB8 RID: 7096
		// (get) Token: 0x06009571 RID: 38257 RVA: 0x000E1AC2 File Offset: 0x000DFCC2
		// (set) Token: 0x06009572 RID: 38258 RVA: 0x000E1ADB File Offset: 0x000DFCDB
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

		// Token: 0x17001BB9 RID: 7097
		// (get) Token: 0x06009573 RID: 38259 RVA: 0x000E1B0B File Offset: 0x000DFD0B
		// (set) Token: 0x06009574 RID: 38260 RVA: 0x000E1B24 File Offset: 0x000DFD24
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

		// Token: 0x17001BBA RID: 7098
		// (get) Token: 0x06009575 RID: 38261 RVA: 0x000E1B54 File Offset: 0x000DFD54
		// (set) Token: 0x06009576 RID: 38262 RVA: 0x000E1B64 File Offset: 0x000DFD64
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

		// Token: 0x06009577 RID: 38263 RVA: 0x000E1B75 File Offset: 0x000DFD75
		public FSpriteTransitionOfState()
		{
		}

		// Token: 0x06009578 RID: 38264 RVA: 0x000E1B7D File Offset: 0x000DFD7D
		protected override IntPtr GetUStructPtr()
		{
			return FSpriteTransitionOfState.StaticStruct();
		}

		// Token: 0x06009579 RID: 38265 RVA: 0x000E1B89 File Offset: 0x000DFD89
		[NullableContext(2)]
		public FSpriteTransitionOfState(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600957A RID: 38266 RVA: 0x000E1B93 File Offset: 0x000DFD93
		public FSpriteTransitionOfState(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600957B RID: 38267 RVA: 0x000E1B9E File Offset: 0x000DFD9E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSpriteTransitionOfState(Pointer, false, true);
		}

		// Token: 0x0600957C RID: 38268 RVA: 0x000E1BA8 File Offset: 0x000DFDA8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSpriteTransitionOfState(Pointer, MemoryOwner);
		}

		// Token: 0x04004100 RID: 16640
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.SpriteTransitionOfState";

		// Token: 0x04004101 RID: 16641
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004102 RID: 16642
		internal static int __PropertyOffset_Sprite;

		// Token: 0x04004103 RID: 16643
		internal static int __PropertyOffset_Color;

		// Token: 0x04004104 RID: 16644
		internal static int __PropertyOffset_bSnapSize;

		// Token: 0x04004105 RID: 16645
		internal static byte __PropertyMask_bSnapSize;

		// Token: 0x04004106 RID: 16646
		internal static int __PropertyOffset_bGradualChange;

		// Token: 0x04004107 RID: 16647
		internal static byte __PropertyMask_bGradualChange;

		// Token: 0x04004108 RID: 16648
		internal static int __PropertyOffset_GradualDuration;
	}
}
