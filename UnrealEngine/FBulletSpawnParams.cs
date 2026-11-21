using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000326 RID: 806
	[UnrealObjectPath("/Script/KuroBulletCore.BulletSpawnParams")]
	[UnrealStructLayout(96, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FBulletSpawnParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005478 RID: 21624 RVA: 0x00076563 File Offset: 0x00074763
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBulletSpawnParams._ScriptStructPtr != 0) ? FBulletSpawnParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroBulletCore.BulletSpawnParams", ref FBulletSpawnParams._ScriptStructPtr);
		}

		// Token: 0x170010B0 RID: 4272
		// (get) Token: 0x06005479 RID: 21625 RVA: 0x00076587 File Offset: 0x00074787
		// (set) Token: 0x0600547A RID: 21626 RVA: 0x0007659B File Offset: 0x0007479B
		public unsafe FTransformDouble InitialTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBulletSpawnParams.__PropertyOffset_InitialTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBulletSpawnParams.__PropertyOffset_InitialTransform) = value;
			}
		}

		// Token: 0x170010B1 RID: 4273
		// (get) Token: 0x0600547B RID: 21627 RVA: 0x000765B0 File Offset: 0x000747B0
		// (set) Token: 0x0600547C RID: 21628 RVA: 0x000765C4 File Offset: 0x000747C4
		public unsafe FVector InheritedVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBulletSpawnParams.__PropertyOffset_InheritedVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBulletSpawnParams.__PropertyOffset_InheritedVelocity) = value;
			}
		}

		// Token: 0x170010B2 RID: 4274
		// (get) Token: 0x0600547D RID: 21629 RVA: 0x000765D9 File Offset: 0x000747D9
		// (set) Token: 0x0600547E RID: 21630 RVA: 0x000765E9 File Offset: 0x000747E9
		public unsafe float SpeedFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBulletSpawnParams.__PropertyOffset_SpeedFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBulletSpawnParams.__PropertyOffset_SpeedFactor) = value;
			}
		}

		// Token: 0x170010B3 RID: 4275
		// (get) Token: 0x0600547F RID: 21631 RVA: 0x000765FA File Offset: 0x000747FA
		// (set) Token: 0x06005480 RID: 21632 RVA: 0x0007660E File Offset: 0x0007480E
		[Nullable(2)]
		public unsafe UBulletActionBase ActionBeforeInit
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBulletActionBase>(base.NativePtr / (IntPtr)sizeof(void*) + FBulletSpawnParams.__PropertyOffset_ActionBeforeInit);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FBulletSpawnParams.__PropertyOffset_ActionBeforeInit, value);
			}
		}

		// Token: 0x06005481 RID: 21633 RVA: 0x00076623 File Offset: 0x00074823
		public FBulletSpawnParams()
		{
		}

		// Token: 0x06005482 RID: 21634 RVA: 0x0007662B File Offset: 0x0007482B
		protected override IntPtr GetUStructPtr()
		{
			return FBulletSpawnParams.StaticStruct();
		}

		// Token: 0x06005483 RID: 21635 RVA: 0x00076637 File Offset: 0x00074837
		[NullableContext(2)]
		public FBulletSpawnParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005484 RID: 21636 RVA: 0x00076641 File Offset: 0x00074841
		public FBulletSpawnParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005485 RID: 21637 RVA: 0x0007664C File Offset: 0x0007484C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBulletSpawnParams(Pointer, false, true);
		}

		// Token: 0x06005486 RID: 21638 RVA: 0x00076656 File Offset: 0x00074856
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBulletSpawnParams(Pointer, MemoryOwner);
		}

		// Token: 0x04002289 RID: 8841
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroBulletCore.BulletSpawnParams";

		// Token: 0x0400228A RID: 8842
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400228B RID: 8843
		internal static int __PropertyOffset_InitialTransform;

		// Token: 0x0400228C RID: 8844
		internal static int __PropertyOffset_InheritedVelocity;

		// Token: 0x0400228D RID: 8845
		internal static int __PropertyOffset_SpeedFactor;

		// Token: 0x0400228E RID: 8846
		internal static int __PropertyOffset_ActionBeforeInit;
	}
}
