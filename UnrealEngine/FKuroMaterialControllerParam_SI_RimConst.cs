using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001B58 RID: 7000
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_SI_RimConst")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FKuroMaterialControllerParam_SI_RimConst : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A807 RID: 108551 RVA: 0x00271252 File Offset: 0x0026F452
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialControllerParam_SI_RimConst._ScriptStructPtr != 0) ? FKuroMaterialControllerParam_SI_RimConst._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_SI_RimConst", ref FKuroMaterialControllerParam_SI_RimConst._ScriptStructPtr);
		}

		// Token: 0x17006A87 RID: 27271
		// (get) Token: 0x0601A808 RID: 108552 RVA: 0x00271276 File Offset: 0x0026F476
		// (set) Token: 0x0601A809 RID: 108553 RVA: 0x00271286 File Offset: 0x0026F486
		public unsafe float RimPow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_RimConst.__PropertyOffset_RimPow);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_RimConst.__PropertyOffset_RimPow) = value;
			}
		}

		// Token: 0x17006A88 RID: 27272
		// (get) Token: 0x0601A80A RID: 108554 RVA: 0x00271297 File Offset: 0x0026F497
		// (set) Token: 0x0601A80B RID: 108555 RVA: 0x002712AB File Offset: 0x0026F4AB
		public unsafe FLinearColor RimLightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_RimConst.__PropertyOffset_RimLightColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_RimConst.__PropertyOffset_RimLightColor) = value;
			}
		}

		// Token: 0x0601A80C RID: 108556 RVA: 0x002712C0 File Offset: 0x0026F4C0
		public FKuroMaterialControllerParam_SI_RimConst()
		{
		}

		// Token: 0x0601A80D RID: 108557 RVA: 0x002712C8 File Offset: 0x0026F4C8
		public FKuroMaterialControllerParam_SI_RimConst(float RimPow, FLinearColor RimLightColor)
		{
			this.RimPow = RimPow;
			this.RimLightColor = RimLightColor;
		}

		// Token: 0x0601A80E RID: 108558 RVA: 0x002712DE File Offset: 0x0026F4DE
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialControllerParam_SI_RimConst.StaticStruct();
		}

		// Token: 0x0601A80F RID: 108559 RVA: 0x002712EA File Offset: 0x0026F4EA
		[NullableContext(2)]
		public FKuroMaterialControllerParam_SI_RimConst(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A810 RID: 108560 RVA: 0x002712F4 File Offset: 0x0026F4F4
		public FKuroMaterialControllerParam_SI_RimConst(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A811 RID: 108561 RVA: 0x002712FF File Offset: 0x0026F4FF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialControllerParam_SI_RimConst(Pointer, false, true);
		}

		// Token: 0x0601A812 RID: 108562 RVA: 0x00271309 File Offset: 0x0026F509
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialControllerParam_SI_RimConst(Pointer, MemoryOwner);
		}

		// Token: 0x0400E5AD RID: 58797
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_SI_RimConst";

		// Token: 0x0400E5AE RID: 58798
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E5AF RID: 58799
		internal static int __PropertyOffset_RimPow;

		// Token: 0x0400E5B0 RID: 58800
		internal static int __PropertyOffset_RimLightColor;
	}
}
