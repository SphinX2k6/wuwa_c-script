using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001B4A RID: 6986
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_OutlineConst")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FKuroMaterialControllerParam_OutlineConst : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A739 RID: 108345 RVA: 0x0026FF71 File Offset: 0x0026E171
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialControllerParam_OutlineConst._ScriptStructPtr != 0) ? FKuroMaterialControllerParam_OutlineConst._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_OutlineConst", ref FKuroMaterialControllerParam_OutlineConst._ScriptStructPtr);
		}

		// Token: 0x17006A58 RID: 27224
		// (get) Token: 0x0601A73A RID: 108346 RVA: 0x0026FF95 File Offset: 0x0026E195
		// (set) Token: 0x0601A73B RID: 108347 RVA: 0x0026FFA5 File Offset: 0x0026E1A5
		public unsafe bool bOutlineUseTex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_OutlineConst.__PropertyOffset_bOutlineUseTex) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_OutlineConst.__PropertyOffset_bOutlineUseTex) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006A59 RID: 27225
		// (get) Token: 0x0601A73C RID: 108348 RVA: 0x0026FFB6 File Offset: 0x0026E1B6
		// (set) Token: 0x0601A73D RID: 108349 RVA: 0x0026FFC6 File Offset: 0x0026E1C6
		public unsafe bool bUseOuterOutlineEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_OutlineConst.__PropertyOffset_bUseOuterOutlineEffect) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_OutlineConst.__PropertyOffset_bUseOuterOutlineEffect) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006A5A RID: 27226
		// (get) Token: 0x0601A73E RID: 108350 RVA: 0x0026FFD7 File Offset: 0x0026E1D7
		// (set) Token: 0x0601A73F RID: 108351 RVA: 0x0026FFE7 File Offset: 0x0026E1E7
		public unsafe float OutlineWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_OutlineConst.__PropertyOffset_OutlineWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_OutlineConst.__PropertyOffset_OutlineWidth) = value;
			}
		}

		// Token: 0x17006A5B RID: 27227
		// (get) Token: 0x0601A740 RID: 108352 RVA: 0x0026FFF8 File Offset: 0x0026E1F8
		// (set) Token: 0x0601A741 RID: 108353 RVA: 0x0027000C File Offset: 0x0026E20C
		public unsafe FLinearColor OutlineColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_OutlineConst.__PropertyOffset_OutlineColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_OutlineConst.__PropertyOffset_OutlineColor) = value;
			}
		}

		// Token: 0x17006A5C RID: 27228
		// (get) Token: 0x0601A742 RID: 108354 RVA: 0x00270021 File Offset: 0x0026E221
		// (set) Token: 0x0601A743 RID: 108355 RVA: 0x00270031 File Offset: 0x0026E231
		public unsafe float OutlineIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_OutlineConst.__PropertyOffset_OutlineIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_OutlineConst.__PropertyOffset_OutlineIntensity) = value;
			}
		}

		// Token: 0x0601A744 RID: 108356 RVA: 0x00270042 File Offset: 0x0026E242
		public FKuroMaterialControllerParam_OutlineConst()
		{
		}

		// Token: 0x0601A745 RID: 108357 RVA: 0x0027004A File Offset: 0x0026E24A
		public FKuroMaterialControllerParam_OutlineConst(bool bOutlineUseTex, bool bUseOuterOutlineEffect, float OutlineWidth, FLinearColor OutlineColor, float OutlineIntensity)
		{
			this.bOutlineUseTex = bOutlineUseTex;
			this.bUseOuterOutlineEffect = bUseOuterOutlineEffect;
			this.OutlineWidth = OutlineWidth;
			this.OutlineColor = OutlineColor;
			this.OutlineIntensity = OutlineIntensity;
		}

		// Token: 0x0601A746 RID: 108358 RVA: 0x00270077 File Offset: 0x0026E277
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialControllerParam_OutlineConst.StaticStruct();
		}

		// Token: 0x0601A747 RID: 108359 RVA: 0x00270083 File Offset: 0x0026E283
		[NullableContext(2)]
		public FKuroMaterialControllerParam_OutlineConst(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A748 RID: 108360 RVA: 0x0027008D File Offset: 0x0026E28D
		public FKuroMaterialControllerParam_OutlineConst(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A749 RID: 108361 RVA: 0x00270098 File Offset: 0x0026E298
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialControllerParam_OutlineConst(Pointer, false, true);
		}

		// Token: 0x0601A74A RID: 108362 RVA: 0x002700A2 File Offset: 0x0026E2A2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialControllerParam_OutlineConst(Pointer, MemoryOwner);
		}

		// Token: 0x0400E54C RID: 58700
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_OutlineConst";

		// Token: 0x0400E54D RID: 58701
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E54E RID: 58702
		internal static int __PropertyOffset_bOutlineUseTex;

		// Token: 0x0400E54F RID: 58703
		internal static int __PropertyOffset_bUseOuterOutlineEffect;

		// Token: 0x0400E550 RID: 58704
		internal static int __PropertyOffset_OutlineWidth;

		// Token: 0x0400E551 RID: 58705
		internal static int __PropertyOffset_OutlineColor;

		// Token: 0x0400E552 RID: 58706
		internal static int __PropertyOffset_OutlineIntensity;
	}
}
