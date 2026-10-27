using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002100 RID: 8448
	[UnrealObjectPath("/Script/LGUI.RenderableSlot")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FRenderableSlot : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FC9A RID: 130202 RVA: 0x002F455C File Offset: 0x002F275C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRenderableSlot._ScriptStructPtr != 0) ? FRenderableSlot._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.RenderableSlot", ref FRenderableSlot._ScriptStructPtr);
		}

		// Token: 0x17007D0E RID: 32014
		// (get) Token: 0x0601FC9B RID: 130203 RVA: 0x002F4580 File Offset: 0x002F2780
		// (set) Token: 0x0601FC9C RID: 130204 RVA: 0x002F4594 File Offset: 0x002F2794
		[Nullable(2)]
		public unsafe UUIBatchGeometryRenderable Renderable
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUIBatchGeometryRenderable>(base.NativePtr / (IntPtr)sizeof(void*) + FRenderableSlot.__PropertyOffset_Renderable);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FRenderableSlot.__PropertyOffset_Renderable, value);
			}
		}

		// Token: 0x0601FC9D RID: 130205 RVA: 0x002F45A9 File Offset: 0x002F27A9
		public FRenderableSlot()
		{
		}

		// Token: 0x0601FC9E RID: 130206 RVA: 0x002F45B1 File Offset: 0x002F27B1
		[NullableContext(1)]
		public FRenderableSlot(UUIBatchGeometryRenderable Renderable)
		{
			this.Renderable = Renderable;
		}

		// Token: 0x0601FC9F RID: 130207 RVA: 0x002F45C0 File Offset: 0x002F27C0
		protected override IntPtr GetUStructPtr()
		{
			return FRenderableSlot.StaticStruct();
		}

		// Token: 0x0601FCA0 RID: 130208 RVA: 0x002F45CC File Offset: 0x002F27CC
		[NullableContext(2)]
		public FRenderableSlot(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FCA1 RID: 130209 RVA: 0x002F45D6 File Offset: 0x002F27D6
		public FRenderableSlot(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FCA2 RID: 130210 RVA: 0x002F45E1 File Offset: 0x002F27E1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRenderableSlot(Pointer, false, true);
		}

		// Token: 0x0601FCA3 RID: 130211 RVA: 0x002F45EB File Offset: 0x002F27EB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRenderableSlot(Pointer, MemoryOwner);
		}

		// Token: 0x0401121A RID: 70170
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.RenderableSlot";

		// Token: 0x0401121B RID: 70171
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401121C RID: 70172
		internal static int __PropertyOffset_Renderable;
	}
}
