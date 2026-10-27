using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200210C RID: 8460
	[UnrealObjectPath("/Script/LGUI.SpriteSlot")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FSpriteSlot : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FD4F RID: 130383 RVA: 0x002F5834 File Offset: 0x002F3A34
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSpriteSlot._ScriptStructPtr != 0) ? FSpriteSlot._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.SpriteSlot", ref FSpriteSlot._ScriptStructPtr);
		}

		// Token: 0x17007D33 RID: 32051
		// (get) Token: 0x0601FD50 RID: 130384 RVA: 0x002F5858 File Offset: 0x002F3A58
		// (set) Token: 0x0601FD51 RID: 130385 RVA: 0x002F586C File Offset: 0x002F3A6C
		[Nullable(2)]
		public unsafe UUISpriteBase Sprite
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUISpriteBase>(base.NativePtr / (IntPtr)sizeof(void*) + FSpriteSlot.__PropertyOffset_Sprite);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSpriteSlot.__PropertyOffset_Sprite, value);
			}
		}

		// Token: 0x0601FD52 RID: 130386 RVA: 0x002F5881 File Offset: 0x002F3A81
		public FSpriteSlot()
		{
		}

		// Token: 0x0601FD53 RID: 130387 RVA: 0x002F5889 File Offset: 0x002F3A89
		[NullableContext(1)]
		public FSpriteSlot(UUISpriteBase Sprite)
		{
			this.Sprite = Sprite;
		}

		// Token: 0x0601FD54 RID: 130388 RVA: 0x002F5898 File Offset: 0x002F3A98
		protected override IntPtr GetUStructPtr()
		{
			return FSpriteSlot.StaticStruct();
		}

		// Token: 0x0601FD55 RID: 130389 RVA: 0x002F58A4 File Offset: 0x002F3AA4
		[NullableContext(2)]
		public FSpriteSlot(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FD56 RID: 130390 RVA: 0x002F58AE File Offset: 0x002F3AAE
		public FSpriteSlot(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FD57 RID: 130391 RVA: 0x002F58B9 File Offset: 0x002F3AB9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSpriteSlot(Pointer, false, true);
		}

		// Token: 0x0601FD58 RID: 130392 RVA: 0x002F58C3 File Offset: 0x002F3AC3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSpriteSlot(Pointer, MemoryOwner);
		}

		// Token: 0x04011276 RID: 70262
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.SpriteSlot";

		// Token: 0x04011277 RID: 70263
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011278 RID: 70264
		internal static int __PropertyOffset_Sprite;
	}
}
