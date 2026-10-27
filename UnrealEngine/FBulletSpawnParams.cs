using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016CB RID: 5835
	[UnrealObjectPath("/Script/KuroBulletCore.BulletSpawnParams")]
	[UnrealStructLayout(96, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FBulletSpawnParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060151F0 RID: 86512 RVA: 0x001F0E6E File Offset: 0x001EF06E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBulletSpawnParams._ScriptStructPtr != 0) ? FBulletSpawnParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroBulletCore.BulletSpawnParams", ref FBulletSpawnParams._ScriptStructPtr);
		}

		// Token: 0x17005381 RID: 21377
		// (get) Token: 0x060151F1 RID: 86513 RVA: 0x001F0E92 File Offset: 0x001EF092
		// (set) Token: 0x060151F2 RID: 86514 RVA: 0x001F0EA6 File Offset: 0x001EF0A6
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

		// Token: 0x17005382 RID: 21378
		// (get) Token: 0x060151F3 RID: 86515 RVA: 0x001F0EBB File Offset: 0x001EF0BB
		// (set) Token: 0x060151F4 RID: 86516 RVA: 0x001F0ECF File Offset: 0x001EF0CF
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

		// Token: 0x17005383 RID: 21379
		// (get) Token: 0x060151F5 RID: 86517 RVA: 0x001F0EE4 File Offset: 0x001EF0E4
		// (set) Token: 0x060151F6 RID: 86518 RVA: 0x001F0EF4 File Offset: 0x001EF0F4
		public unsafe EInheritedVelocityMode InheritedVelocityMode
		{
			get
			{
				return (EInheritedVelocityMode)(*(base.NativePtr + (IntPtr)FBulletSpawnParams.__PropertyOffset_InheritedVelocityMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBulletSpawnParams.__PropertyOffset_InheritedVelocityMode) = (byte)value;
			}
		}

		// Token: 0x17005384 RID: 21380
		// (get) Token: 0x060151F7 RID: 86519 RVA: 0x001F0F05 File Offset: 0x001EF105
		// (set) Token: 0x060151F8 RID: 86520 RVA: 0x001F0F15 File Offset: 0x001EF115
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

		// Token: 0x17005385 RID: 21381
		// (get) Token: 0x060151F9 RID: 86521 RVA: 0x001F0F26 File Offset: 0x001EF126
		// (set) Token: 0x060151FA RID: 86522 RVA: 0x001F0F3A File Offset: 0x001EF13A
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

		// Token: 0x060151FB RID: 86523 RVA: 0x001F0F4F File Offset: 0x001EF14F
		public FBulletSpawnParams()
		{
		}

		// Token: 0x060151FC RID: 86524 RVA: 0x001F0F57 File Offset: 0x001EF157
		[NullableContext(1)]
		public FBulletSpawnParams(FTransformDouble InitialTransform, FVector InheritedVelocity, EInheritedVelocityMode InheritedVelocityMode, float SpeedFactor, UBulletActionBase ActionBeforeInit)
		{
			this.InitialTransform = InitialTransform;
			this.InheritedVelocity = InheritedVelocity;
			this.InheritedVelocityMode = InheritedVelocityMode;
			this.SpeedFactor = SpeedFactor;
			this.ActionBeforeInit = ActionBeforeInit;
		}

		// Token: 0x060151FD RID: 86525 RVA: 0x001F0F84 File Offset: 0x001EF184
		protected override IntPtr GetUStructPtr()
		{
			return FBulletSpawnParams.StaticStruct();
		}

		// Token: 0x060151FE RID: 86526 RVA: 0x001F0F90 File Offset: 0x001EF190
		[NullableContext(2)]
		public FBulletSpawnParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060151FF RID: 86527 RVA: 0x001F0F9A File Offset: 0x001EF19A
		public FBulletSpawnParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015200 RID: 86528 RVA: 0x001F0FA5 File Offset: 0x001EF1A5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBulletSpawnParams(Pointer, false, true);
		}

		// Token: 0x06015201 RID: 86529 RVA: 0x001F0FAF File Offset: 0x001EF1AF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBulletSpawnParams(Pointer, MemoryOwner);
		}

		// Token: 0x0400B7F1 RID: 47089
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroBulletCore.BulletSpawnParams";

		// Token: 0x0400B7F2 RID: 47090
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B7F3 RID: 47091
		internal static int __PropertyOffset_InitialTransform;

		// Token: 0x0400B7F4 RID: 47092
		internal static int __PropertyOffset_InheritedVelocity;

		// Token: 0x0400B7F5 RID: 47093
		internal static int __PropertyOffset_InheritedVelocityMode;

		// Token: 0x0400B7F6 RID: 47094
		internal static int __PropertyOffset_SpeedFactor;

		// Token: 0x0400B7F7 RID: 47095
		internal static int __PropertyOffset_ActionBeforeInit;
	}
}
