using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200210B RID: 8459
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.SpriteCollection")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FSpriteCollection : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FD45 RID: 130373 RVA: 0x002F5773 File Offset: 0x002F3973
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSpriteCollection._ScriptStructPtr != 0) ? FSpriteCollection._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.SpriteCollection", ref FSpriteCollection._ScriptStructPtr);
		}

		// Token: 0x17007D32 RID: 32050
		// (get) Token: 0x0601FD46 RID: 130374 RVA: 0x002F5798 File Offset: 0x002F3998
		// (set) Token: 0x0601FD47 RID: 130375 RVA: 0x002F57DB File Offset: 0x002F39DB
		public TArray<FSpriteSlot> SpriteSlots
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSpriteSlot> result;
				if ((result = this._SpriteSlots) == null)
				{
					result = (this._SpriteSlots = new TArray<FSpriteSlot>(base.NativePtr + (IntPtr)FSpriteCollection.__PropertyOffset_SpriteSlots, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SpriteSlots.CopyAssign(value);
			}
		}

		// Token: 0x0601FD48 RID: 130376 RVA: 0x002F57E9 File Offset: 0x002F39E9
		public FSpriteCollection()
		{
		}

		// Token: 0x0601FD49 RID: 130377 RVA: 0x002F57F1 File Offset: 0x002F39F1
		public FSpriteCollection(TArray<FSpriteSlot> SpriteSlots)
		{
			this.SpriteSlots = SpriteSlots;
		}

		// Token: 0x0601FD4A RID: 130378 RVA: 0x002F5800 File Offset: 0x002F3A00
		protected override IntPtr GetUStructPtr()
		{
			return FSpriteCollection.StaticStruct();
		}

		// Token: 0x0601FD4B RID: 130379 RVA: 0x002F580C File Offset: 0x002F3A0C
		[NullableContext(2)]
		public FSpriteCollection(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FD4C RID: 130380 RVA: 0x002F5816 File Offset: 0x002F3A16
		public FSpriteCollection(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FD4D RID: 130381 RVA: 0x002F5821 File Offset: 0x002F3A21
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSpriteCollection(Pointer, false, true);
		}

		// Token: 0x0601FD4E RID: 130382 RVA: 0x002F582B File Offset: 0x002F3A2B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSpriteCollection(Pointer, MemoryOwner);
		}

		// Token: 0x04011272 RID: 70258
		public const string __ObjectPath = "/Script/LGUI.SpriteCollection";

		// Token: 0x04011273 RID: 70259
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011274 RID: 70260
		internal static int __PropertyOffset_SpriteSlots;

		// Token: 0x04011275 RID: 70261
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSpriteSlot> _SpriteSlots;
	}
}
