using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CE4 RID: 3300
	[UnrealObjectPath("/Script/Engine.KuroCellLayer")]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1)]
	public class FKuroCellLayer : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600AF11 RID: 44817 RVA: 0x000F8568 File Offset: 0x000F6768
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCellLayer._ScriptStructPtr != 0) ? FKuroCellLayer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroCellLayer", ref FKuroCellLayer._ScriptStructPtr);
		}

		// Token: 0x1700278D RID: 10125
		// (get) Token: 0x0600AF12 RID: 44818 RVA: 0x000F858C File Offset: 0x000F678C
		// (set) Token: 0x0600AF13 RID: 44819 RVA: 0x000F859C File Offset: 0x000F679C
		public unsafe EKuroCellLayerType Type
		{
			get
			{
				return (EKuroCellLayerType)(*(base.NativePtr + (IntPtr)FKuroCellLayer.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCellLayer.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x0600AF14 RID: 44820 RVA: 0x000F85AD File Offset: 0x000F67AD
		public FKuroCellLayer()
		{
		}

		// Token: 0x0600AF15 RID: 44821 RVA: 0x000F85B5 File Offset: 0x000F67B5
		public FKuroCellLayer(EKuroCellLayerType Type)
		{
			this.Type = Type;
		}

		// Token: 0x0600AF16 RID: 44822 RVA: 0x000F85C4 File Offset: 0x000F67C4
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCellLayer.StaticStruct();
		}

		// Token: 0x0600AF17 RID: 44823 RVA: 0x000F85D0 File Offset: 0x000F67D0
		[NullableContext(2)]
		public FKuroCellLayer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AF18 RID: 44824 RVA: 0x000F85DA File Offset: 0x000F67DA
		public FKuroCellLayer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AF19 RID: 44825 RVA: 0x000F85E5 File Offset: 0x000F67E5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCellLayer(Pointer, false, true);
		}

		// Token: 0x0600AF1A RID: 44826 RVA: 0x000F85EF File Offset: 0x000F67EF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCellLayer(Pointer, MemoryOwner);
		}

		// Token: 0x04005BB0 RID: 23472
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.KuroCellLayer";

		// Token: 0x04005BB1 RID: 23473
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005BB2 RID: 23474
		internal static int __PropertyOffset_Type;
	}
}
