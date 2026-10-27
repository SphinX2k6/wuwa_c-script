using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001B50 RID: 6992
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_SI_BaseColorConst")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FKuroMaterialControllerParam_SI_BaseColorConst : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A78F RID: 108431 RVA: 0x0027068E File Offset: 0x0026E88E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialControllerParam_SI_BaseColorConst._ScriptStructPtr != 0) ? FKuroMaterialControllerParam_SI_BaseColorConst._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_SI_BaseColorConst", ref FKuroMaterialControllerParam_SI_BaseColorConst._ScriptStructPtr);
		}

		// Token: 0x17006A6B RID: 27243
		// (get) Token: 0x0601A790 RID: 108432 RVA: 0x002706B2 File Offset: 0x0026E8B2
		// (set) Token: 0x0601A791 RID: 108433 RVA: 0x002706C2 File Offset: 0x0026E8C2
		public unsafe float BaseColorScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_BaseColorConst.__PropertyOffset_BaseColorScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_BaseColorConst.__PropertyOffset_BaseColorScale) = value;
			}
		}

		// Token: 0x17006A6C RID: 27244
		// (get) Token: 0x0601A792 RID: 108434 RVA: 0x002706D3 File Offset: 0x0026E8D3
		// (set) Token: 0x0601A793 RID: 108435 RVA: 0x002706E7 File Offset: 0x0026E8E7
		public unsafe FLinearColor BaseColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_BaseColorConst.__PropertyOffset_BaseColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_BaseColorConst.__PropertyOffset_BaseColor) = value;
			}
		}

		// Token: 0x0601A794 RID: 108436 RVA: 0x002706FC File Offset: 0x0026E8FC
		public FKuroMaterialControllerParam_SI_BaseColorConst()
		{
		}

		// Token: 0x0601A795 RID: 108437 RVA: 0x00270704 File Offset: 0x0026E904
		public FKuroMaterialControllerParam_SI_BaseColorConst(float BaseColorScale, FLinearColor BaseColor)
		{
			this.BaseColorScale = BaseColorScale;
			this.BaseColor = BaseColor;
		}

		// Token: 0x0601A796 RID: 108438 RVA: 0x0027071A File Offset: 0x0026E91A
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialControllerParam_SI_BaseColorConst.StaticStruct();
		}

		// Token: 0x0601A797 RID: 108439 RVA: 0x00270726 File Offset: 0x0026E926
		[NullableContext(2)]
		public FKuroMaterialControllerParam_SI_BaseColorConst(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A798 RID: 108440 RVA: 0x00270730 File Offset: 0x0026E930
		public FKuroMaterialControllerParam_SI_BaseColorConst(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A799 RID: 108441 RVA: 0x0027073B File Offset: 0x0026E93B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialControllerParam_SI_BaseColorConst(Pointer, false, true);
		}

		// Token: 0x0601A79A RID: 108442 RVA: 0x00270745 File Offset: 0x0026E945
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialControllerParam_SI_BaseColorConst(Pointer, MemoryOwner);
		}

		// Token: 0x0400E571 RID: 58737
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_SI_BaseColorConst";

		// Token: 0x0400E572 RID: 58738
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E573 RID: 58739
		internal static int __PropertyOffset_BaseColorScale;

		// Token: 0x0400E574 RID: 58740
		internal static int __PropertyOffset_BaseColor;
	}
}
