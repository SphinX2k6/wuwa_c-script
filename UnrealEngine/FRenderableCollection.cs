using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020020FF RID: 8447
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.RenderableCollection")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRenderableCollection : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FC90 RID: 130192 RVA: 0x002F449A File Offset: 0x002F269A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRenderableCollection._ScriptStructPtr != 0) ? FRenderableCollection._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.RenderableCollection", ref FRenderableCollection._ScriptStructPtr);
		}

		// Token: 0x17007D0D RID: 32013
		// (get) Token: 0x0601FC91 RID: 130193 RVA: 0x002F44C0 File Offset: 0x002F26C0
		// (set) Token: 0x0601FC92 RID: 130194 RVA: 0x002F4503 File Offset: 0x002F2703
		public TArray<FRenderableSlot> RenderableSlots
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRenderableSlot> result;
				if ((result = this._RenderableSlots) == null)
				{
					result = (this._RenderableSlots = new TArray<FRenderableSlot>(base.NativePtr + (IntPtr)FRenderableCollection.__PropertyOffset_RenderableSlots, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RenderableSlots.CopyAssign(value);
			}
		}

		// Token: 0x0601FC93 RID: 130195 RVA: 0x002F4511 File Offset: 0x002F2711
		public FRenderableCollection()
		{
		}

		// Token: 0x0601FC94 RID: 130196 RVA: 0x002F4519 File Offset: 0x002F2719
		public FRenderableCollection(TArray<FRenderableSlot> RenderableSlots)
		{
			this.RenderableSlots = RenderableSlots;
		}

		// Token: 0x0601FC95 RID: 130197 RVA: 0x002F4528 File Offset: 0x002F2728
		protected override IntPtr GetUStructPtr()
		{
			return FRenderableCollection.StaticStruct();
		}

		// Token: 0x0601FC96 RID: 130198 RVA: 0x002F4534 File Offset: 0x002F2734
		[NullableContext(2)]
		public FRenderableCollection(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FC97 RID: 130199 RVA: 0x002F453E File Offset: 0x002F273E
		public FRenderableCollection(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FC98 RID: 130200 RVA: 0x002F4549 File Offset: 0x002F2749
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRenderableCollection(Pointer, false, true);
		}

		// Token: 0x0601FC99 RID: 130201 RVA: 0x002F4553 File Offset: 0x002F2753
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRenderableCollection(Pointer, MemoryOwner);
		}

		// Token: 0x04011216 RID: 70166
		public const string __ObjectPath = "/Script/LGUI.RenderableCollection";

		// Token: 0x04011217 RID: 70167
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011218 RID: 70168
		internal static int __PropertyOffset_RenderableSlots;

		// Token: 0x04011219 RID: 70169
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRenderableSlot> _RenderableSlots;
	}
}
