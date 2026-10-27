using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001B54 RID: 6996
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_SI_DissolveConst")]
	[UnrealStructLayout(64, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FKuroMaterialControllerParam_SI_DissolveConst : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A7C9 RID: 108489 RVA: 0x00270CE1 File Offset: 0x0026EEE1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialControllerParam_SI_DissolveConst._ScriptStructPtr != 0) ? FKuroMaterialControllerParam_SI_DissolveConst._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_SI_DissolveConst", ref FKuroMaterialControllerParam_SI_DissolveConst._ScriptStructPtr);
		}

		// Token: 0x17006A78 RID: 27256
		// (get) Token: 0x0601A7CA RID: 108490 RVA: 0x00270D05 File Offset: 0x0026EF05
		// (set) Token: 0x0601A7CB RID: 108491 RVA: 0x00270D15 File Offset: 0x0026EF15
		public unsafe float DissolveProgress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_DissolveConst.__PropertyOffset_DissolveProgress);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_DissolveConst.__PropertyOffset_DissolveProgress) = value;
			}
		}

		// Token: 0x17006A79 RID: 27257
		// (get) Token: 0x0601A7CC RID: 108492 RVA: 0x00270D26 File Offset: 0x0026EF26
		// (set) Token: 0x0601A7CD RID: 108493 RVA: 0x00270D36 File Offset: 0x0026EF36
		public unsafe float DissolveEdageWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_DissolveConst.__PropertyOffset_DissolveEdageWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_DissolveConst.__PropertyOffset_DissolveEdageWidth) = value;
			}
		}

		// Token: 0x17006A7A RID: 27258
		// (get) Token: 0x0601A7CE RID: 108494 RVA: 0x00270D47 File Offset: 0x0026EF47
		// (set) Token: 0x0601A7CF RID: 108495 RVA: 0x00270D57 File Offset: 0x0026EF57
		public unsafe float DissolveEdageStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_DissolveConst.__PropertyOffset_DissolveEdageStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_DissolveConst.__PropertyOffset_DissolveEdageStrength) = value;
			}
		}

		// Token: 0x17006A7B RID: 27259
		// (get) Token: 0x0601A7D0 RID: 108496 RVA: 0x00270D68 File Offset: 0x0026EF68
		// (set) Token: 0x0601A7D1 RID: 108497 RVA: 0x00270D78 File Offset: 0x0026EF78
		public unsafe float DissolveAdjustment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_DissolveConst.__PropertyOffset_DissolveAdjustment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_DissolveConst.__PropertyOffset_DissolveAdjustment) = value;
			}
		}

		// Token: 0x17006A7C RID: 27260
		// (get) Token: 0x0601A7D2 RID: 108498 RVA: 0x00270D89 File Offset: 0x0026EF89
		// (set) Token: 0x0601A7D3 RID: 108499 RVA: 0x00270D9D File Offset: 0x0026EF9D
		public unsafe FLinearColor DissolveEdageColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_DissolveConst.__PropertyOffset_DissolveEdageColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_DissolveConst.__PropertyOffset_DissolveEdageColor) = value;
			}
		}

		// Token: 0x17006A7D RID: 27261
		// (get) Token: 0x0601A7D4 RID: 108500 RVA: 0x00270DB2 File Offset: 0x0026EFB2
		// (set) Token: 0x0601A7D5 RID: 108501 RVA: 0x00270DC6 File Offset: 0x0026EFC6
		public unsafe FLinearColor DissolveTexScaleOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_DissolveConst.__PropertyOffset_DissolveTexScaleOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_DissolveConst.__PropertyOffset_DissolveTexScaleOffset) = value;
			}
		}

		// Token: 0x17006A7E RID: 27262
		// (get) Token: 0x0601A7D6 RID: 108502 RVA: 0x00270DDB File Offset: 0x0026EFDB
		// (set) Token: 0x0601A7D7 RID: 108503 RVA: 0x00270DEF File Offset: 0x0026EFEF
		public unsafe FLinearColor DissolveTexSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_DissolveConst.__PropertyOffset_DissolveTexSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_DissolveConst.__PropertyOffset_DissolveTexSpeed) = value;
			}
		}

		// Token: 0x0601A7D8 RID: 108504 RVA: 0x00270E04 File Offset: 0x0026F004
		public FKuroMaterialControllerParam_SI_DissolveConst()
		{
		}

		// Token: 0x0601A7D9 RID: 108505 RVA: 0x00270E0C File Offset: 0x0026F00C
		public FKuroMaterialControllerParam_SI_DissolveConst(float DissolveProgress, float DissolveEdageWidth, float DissolveEdageStrength, float DissolveAdjustment, FLinearColor DissolveEdageColor, FLinearColor DissolveTexScaleOffset, FLinearColor DissolveTexSpeed)
		{
			this.DissolveProgress = DissolveProgress;
			this.DissolveEdageWidth = DissolveEdageWidth;
			this.DissolveEdageStrength = DissolveEdageStrength;
			this.DissolveAdjustment = DissolveAdjustment;
			this.DissolveEdageColor = DissolveEdageColor;
			this.DissolveTexScaleOffset = DissolveTexScaleOffset;
			this.DissolveTexSpeed = DissolveTexSpeed;
		}

		// Token: 0x0601A7DA RID: 108506 RVA: 0x00270E49 File Offset: 0x0026F049
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialControllerParam_SI_DissolveConst.StaticStruct();
		}

		// Token: 0x0601A7DB RID: 108507 RVA: 0x00270E55 File Offset: 0x0026F055
		[NullableContext(2)]
		public FKuroMaterialControllerParam_SI_DissolveConst(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A7DC RID: 108508 RVA: 0x00270E5F File Offset: 0x0026F05F
		public FKuroMaterialControllerParam_SI_DissolveConst(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A7DD RID: 108509 RVA: 0x00270E6A File Offset: 0x0026F06A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialControllerParam_SI_DissolveConst(Pointer, false, true);
		}

		// Token: 0x0601A7DE RID: 108510 RVA: 0x00270E74 File Offset: 0x0026F074
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialControllerParam_SI_DissolveConst(Pointer, MemoryOwner);
		}

		// Token: 0x0400E591 RID: 58769
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_SI_DissolveConst";

		// Token: 0x0400E592 RID: 58770
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E593 RID: 58771
		internal static int __PropertyOffset_DissolveProgress;

		// Token: 0x0400E594 RID: 58772
		internal static int __PropertyOffset_DissolveEdageWidth;

		// Token: 0x0400E595 RID: 58773
		internal static int __PropertyOffset_DissolveEdageStrength;

		// Token: 0x0400E596 RID: 58774
		internal static int __PropertyOffset_DissolveAdjustment;

		// Token: 0x0400E597 RID: 58775
		internal static int __PropertyOffset_DissolveEdageColor;

		// Token: 0x0400E598 RID: 58776
		internal static int __PropertyOffset_DissolveTexScaleOffset;

		// Token: 0x0400E599 RID: 58777
		internal static int __PropertyOffset_DissolveTexSpeed;
	}
}
