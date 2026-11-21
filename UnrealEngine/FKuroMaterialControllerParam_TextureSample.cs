using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004D0 RID: 1232
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_TextureSample")]
	[UnrealStructLayout(5784, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 5784)]
	public class FKuroMaterialControllerParam_TextureSample : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600735F RID: 29535 RVA: 0x000A9133 File Offset: 0x000A7333
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialControllerParam_TextureSample._ScriptStructPtr != 0) ? FKuroMaterialControllerParam_TextureSample._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_TextureSample", ref FKuroMaterialControllerParam_TextureSample._ScriptStructPtr);
		}

		// Token: 0x170016A3 RID: 5795
		// (get) Token: 0x06007360 RID: 29536 RVA: 0x000A9157 File Offset: 0x000A7357
		// (set) Token: 0x06007361 RID: 29537 RVA: 0x000A916B File Offset: 0x000A736B
		[Nullable(2)]
		public unsafe UTexture2D MaskTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialControllerParam_TextureSample.__PropertyOffset_MaskTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialControllerParam_TextureSample.__PropertyOffset_MaskTexture, value);
			}
		}

		// Token: 0x170016A4 RID: 5796
		// (get) Token: 0x06007362 RID: 29538 RVA: 0x000A9180 File Offset: 0x000A7380
		// (set) Token: 0x06007363 RID: 29539 RVA: 0x000A9190 File Offset: 0x000A7390
		public unsafe bool bUseAlphaToMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_TextureSample.__PropertyOffset_bUseAlphaToMask) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_TextureSample.__PropertyOffset_bUseAlphaToMask) = (value ? 1 : 0);
			}
		}

		// Token: 0x170016A5 RID: 5797
		// (get) Token: 0x06007364 RID: 29540 RVA: 0x000A91A1 File Offset: 0x000A73A1
		// (set) Token: 0x06007365 RID: 29541 RVA: 0x000A91B1 File Offset: 0x000A73B1
		public unsafe ECharacterControllerUVSwitch UvSelection
		{
			get
			{
				return (ECharacterControllerUVSwitch)(*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_TextureSample.__PropertyOffset_UvSelection));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_TextureSample.__PropertyOffset_UvSelection) = (byte)value;
			}
		}

		// Token: 0x06007366 RID: 29542 RVA: 0x000A91C2 File Offset: 0x000A73C2
		public FKuroMaterialControllerParam_TextureSample()
		{
		}

		// Token: 0x06007367 RID: 29543 RVA: 0x000A91CA File Offset: 0x000A73CA
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialControllerParam_TextureSample.StaticStruct();
		}

		// Token: 0x06007368 RID: 29544 RVA: 0x000A91D6 File Offset: 0x000A73D6
		[NullableContext(2)]
		public FKuroMaterialControllerParam_TextureSample(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007369 RID: 29545 RVA: 0x000A91E0 File Offset: 0x000A73E0
		public FKuroMaterialControllerParam_TextureSample(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600736A RID: 29546 RVA: 0x000A91EB File Offset: 0x000A73EB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialControllerParam_TextureSample(Pointer, false, true);
		}

		// Token: 0x0600736B RID: 29547 RVA: 0x000A91F5 File Offset: 0x000A73F5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialControllerParam_TextureSample(Pointer, MemoryOwner);
		}

		// Token: 0x04003170 RID: 12656
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_TextureSample";

		// Token: 0x04003171 RID: 12657
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003172 RID: 12658
		internal static int __PropertyOffset_MaskTexture;

		// Token: 0x04003173 RID: 12659
		internal static int __PropertyOffset_bUseAlphaToMask;

		// Token: 0x04003174 RID: 12660
		internal static int __PropertyOffset_UvSelection;
	}
}
