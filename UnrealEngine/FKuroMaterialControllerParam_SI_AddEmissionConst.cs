using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001B4E RID: 6990
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_SI_AddEmissionConst")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKuroMaterialControllerParam_SI_AddEmissionConst : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A779 RID: 108409 RVA: 0x002704B7 File Offset: 0x0026E6B7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialControllerParam_SI_AddEmissionConst._ScriptStructPtr != 0) ? FKuroMaterialControllerParam_SI_AddEmissionConst._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_SI_AddEmissionConst", ref FKuroMaterialControllerParam_SI_AddEmissionConst._ScriptStructPtr);
		}

		// Token: 0x17006A68 RID: 27240
		// (get) Token: 0x0601A77A RID: 108410 RVA: 0x002704DB File Offset: 0x0026E6DB
		// (set) Token: 0x0601A77B RID: 108411 RVA: 0x002704EF File Offset: 0x0026E6EF
		public unsafe FLinearColor AddEmissionColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_AddEmissionConst.__PropertyOffset_AddEmissionColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_AddEmissionConst.__PropertyOffset_AddEmissionColor) = value;
			}
		}

		// Token: 0x0601A77C RID: 108412 RVA: 0x00270504 File Offset: 0x0026E704
		public FKuroMaterialControllerParam_SI_AddEmissionConst()
		{
		}

		// Token: 0x0601A77D RID: 108413 RVA: 0x0027050C File Offset: 0x0026E70C
		public FKuroMaterialControllerParam_SI_AddEmissionConst(FLinearColor AddEmissionColor)
		{
			this.AddEmissionColor = AddEmissionColor;
		}

		// Token: 0x0601A77E RID: 108414 RVA: 0x0027051B File Offset: 0x0026E71B
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialControllerParam_SI_AddEmissionConst.StaticStruct();
		}

		// Token: 0x0601A77F RID: 108415 RVA: 0x00270527 File Offset: 0x0026E727
		[NullableContext(2)]
		public FKuroMaterialControllerParam_SI_AddEmissionConst(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A780 RID: 108416 RVA: 0x00270531 File Offset: 0x0026E731
		public FKuroMaterialControllerParam_SI_AddEmissionConst(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A781 RID: 108417 RVA: 0x0027053C File Offset: 0x0026E73C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialControllerParam_SI_AddEmissionConst(Pointer, false, true);
		}

		// Token: 0x0601A782 RID: 108418 RVA: 0x00270546 File Offset: 0x0026E746
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialControllerParam_SI_AddEmissionConst(Pointer, MemoryOwner);
		}

		// Token: 0x0400E568 RID: 58728
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_SI_AddEmissionConst";

		// Token: 0x0400E569 RID: 58729
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E56A RID: 58730
		internal static int __PropertyOffset_AddEmissionColor;
	}
}
