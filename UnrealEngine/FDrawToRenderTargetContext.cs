using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009DB RID: 2523
	[UnrealObjectPath("/Script/Engine.DrawToRenderTargetContext")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FDrawToRenderTargetContext : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008E8C RID: 36492 RVA: 0x000CBDB2 File Offset: 0x000C9FB2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDrawToRenderTargetContext._ScriptStructPtr != 0) ? FDrawToRenderTargetContext._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.DrawToRenderTargetContext", ref FDrawToRenderTargetContext._ScriptStructPtr);
		}

		// Token: 0x17002198 RID: 8600
		// (get) Token: 0x06008E8D RID: 36493 RVA: 0x000CBDD6 File Offset: 0x000C9FD6
		// (set) Token: 0x06008E8E RID: 36494 RVA: 0x000CBDEA File Offset: 0x000C9FEA
		[Nullable(2)]
		public unsafe UTextureRenderTarget2D RenderTarget
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + FDrawToRenderTargetContext.__PropertyOffset_RenderTarget);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FDrawToRenderTargetContext.__PropertyOffset_RenderTarget, value);
			}
		}

		// Token: 0x06008E8F RID: 36495 RVA: 0x000CBDFF File Offset: 0x000C9FFF
		public FDrawToRenderTargetContext()
		{
		}

		// Token: 0x06008E90 RID: 36496 RVA: 0x000CBE07 File Offset: 0x000CA007
		[NullableContext(1)]
		public FDrawToRenderTargetContext(UTextureRenderTarget2D RenderTarget)
		{
			this.RenderTarget = RenderTarget;
		}

		// Token: 0x06008E91 RID: 36497 RVA: 0x000CBE16 File Offset: 0x000CA016
		protected override IntPtr GetUStructPtr()
		{
			return FDrawToRenderTargetContext.StaticStruct();
		}

		// Token: 0x06008E92 RID: 36498 RVA: 0x000CBE22 File Offset: 0x000CA022
		[NullableContext(2)]
		public FDrawToRenderTargetContext(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008E93 RID: 36499 RVA: 0x000CBE2C File Offset: 0x000CA02C
		public FDrawToRenderTargetContext(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008E94 RID: 36500 RVA: 0x000CBE37 File Offset: 0x000CA037
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDrawToRenderTargetContext(Pointer, false, true);
		}

		// Token: 0x06008E95 RID: 36501 RVA: 0x000CBE41 File Offset: 0x000CA041
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDrawToRenderTargetContext(Pointer, MemoryOwner);
		}

		// Token: 0x040043D0 RID: 17360
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.DrawToRenderTargetContext";

		// Token: 0x040043D1 RID: 17361
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040043D2 RID: 17362
		internal static int __PropertyOffset_RenderTarget;
	}
}
