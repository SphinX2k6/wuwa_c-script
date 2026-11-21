using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000450 RID: 1104
	[UnrealObjectPath("/Script/KuroInteractionEffect.KuroInteractionEffectNDCConfigBase")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FKuroInteractionEffectNDCConfigBase : FTableRowBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006AC0 RID: 27328 RVA: 0x0009B848 File Offset: 0x00099A48
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroInteractionEffectNDCConfigBase._ScriptStructPtr != 0) ? FKuroInteractionEffectNDCConfigBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroInteractionEffect.KuroInteractionEffectNDCConfigBase", ref FKuroInteractionEffectNDCConfigBase._ScriptStructPtr);
		}

		// Token: 0x17001543 RID: 5443
		// (get) Token: 0x06006AC1 RID: 27329 RVA: 0x0009B86C File Offset: 0x00099A6C
		// (set) Token: 0x06006AC2 RID: 27330 RVA: 0x0009B87C File Offset: 0x00099A7C
		public unsafe bool bEnableNDC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroInteractionEffectNDCConfigBase.__PropertyOffset_bEnableNDC) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroInteractionEffectNDCConfigBase.__PropertyOffset_bEnableNDC) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001544 RID: 5444
		// (get) Token: 0x06006AC3 RID: 27331 RVA: 0x0009B88D File Offset: 0x00099A8D
		// (set) Token: 0x06006AC4 RID: 27332 RVA: 0x0009B89D File Offset: 0x00099A9D
		public unsafe float SpawnNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroInteractionEffectNDCConfigBase.__PropertyOffset_SpawnNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroInteractionEffectNDCConfigBase.__PropertyOffset_SpawnNum) = value;
			}
		}

		// Token: 0x17001545 RID: 5445
		// (get) Token: 0x06006AC5 RID: 27333 RVA: 0x0009B8AE File Offset: 0x00099AAE
		// (set) Token: 0x06006AC6 RID: 27334 RVA: 0x0009B8BE File Offset: 0x00099ABE
		public unsafe float HeightClamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroInteractionEffectNDCConfigBase.__PropertyOffset_HeightClamp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroInteractionEffectNDCConfigBase.__PropertyOffset_HeightClamp) = value;
			}
		}

		// Token: 0x17001546 RID: 5446
		// (get) Token: 0x06006AC7 RID: 27335 RVA: 0x0009B8CF File Offset: 0x00099ACF
		// (set) Token: 0x06006AC8 RID: 27336 RVA: 0x0009B8DF File Offset: 0x00099ADF
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroInteractionEffectNDCConfigBase.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroInteractionEffectNDCConfigBase.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x17001547 RID: 5447
		// (get) Token: 0x06006AC9 RID: 27337 RVA: 0x0009B8F0 File Offset: 0x00099AF0
		// (set) Token: 0x06006ACA RID: 27338 RVA: 0x0009B900 File Offset: 0x00099B00
		public unsafe float MoveSpawn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroInteractionEffectNDCConfigBase.__PropertyOffset_MoveSpawn);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroInteractionEffectNDCConfigBase.__PropertyOffset_MoveSpawn) = value;
			}
		}

		// Token: 0x17001548 RID: 5448
		// (get) Token: 0x06006ACB RID: 27339 RVA: 0x0009B911 File Offset: 0x00099B11
		// (set) Token: 0x06006ACC RID: 27340 RVA: 0x0009B921 File Offset: 0x00099B21
		public unsafe float WeaponSpawn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroInteractionEffectNDCConfigBase.__PropertyOffset_WeaponSpawn);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroInteractionEffectNDCConfigBase.__PropertyOffset_WeaponSpawn) = value;
			}
		}

		// Token: 0x17001549 RID: 5449
		// (get) Token: 0x06006ACD RID: 27341 RVA: 0x0009B932 File Offset: 0x00099B32
		// (set) Token: 0x06006ACE RID: 27342 RVA: 0x0009B942 File Offset: 0x00099B42
		public unsafe int EffectIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroInteractionEffectNDCConfigBase.__PropertyOffset_EffectIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroInteractionEffectNDCConfigBase.__PropertyOffset_EffectIndex) = value;
			}
		}

		// Token: 0x1700154A RID: 5450
		// (get) Token: 0x06006ACF RID: 27343 RVA: 0x0009B953 File Offset: 0x00099B53
		// (set) Token: 0x06006AD0 RID: 27344 RVA: 0x0009B963 File Offset: 0x00099B63
		public unsafe float TypeIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroInteractionEffectNDCConfigBase.__PropertyOffset_TypeIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroInteractionEffectNDCConfigBase.__PropertyOffset_TypeIndex) = value;
			}
		}

		// Token: 0x1700154B RID: 5451
		// (get) Token: 0x06006AD1 RID: 27345 RVA: 0x0009B974 File Offset: 0x00099B74
		// (set) Token: 0x06006AD2 RID: 27346 RVA: 0x0009B988 File Offset: 0x00099B88
		public unsafe FVector PlayerSpawnOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroInteractionEffectNDCConfigBase.__PropertyOffset_PlayerSpawnOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroInteractionEffectNDCConfigBase.__PropertyOffset_PlayerSpawnOffset) = value;
			}
		}

		// Token: 0x06006AD3 RID: 27347 RVA: 0x0009B99D File Offset: 0x00099B9D
		public FKuroInteractionEffectNDCConfigBase()
		{
		}

		// Token: 0x06006AD4 RID: 27348 RVA: 0x0009B9A5 File Offset: 0x00099BA5
		protected override IntPtr GetUStructPtr()
		{
			return FKuroInteractionEffectNDCConfigBase.StaticStruct();
		}

		// Token: 0x06006AD5 RID: 27349 RVA: 0x0009B9B1 File Offset: 0x00099BB1
		[NullableContext(2)]
		public FKuroInteractionEffectNDCConfigBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006AD6 RID: 27350 RVA: 0x0009B9BB File Offset: 0x00099BBB
		public FKuroInteractionEffectNDCConfigBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006AD7 RID: 27351 RVA: 0x0009B9C6 File Offset: 0x00099BC6
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroInteractionEffectNDCConfigBase(Pointer, false, true);
		}

		// Token: 0x06006AD8 RID: 27352 RVA: 0x0009B9D0 File Offset: 0x00099BD0
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroInteractionEffectNDCConfigBase(Pointer, MemoryOwner);
		}

		// Token: 0x04002D48 RID: 11592
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroInteractionEffect.KuroInteractionEffectNDCConfigBase";

		// Token: 0x04002D49 RID: 11593
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002D4A RID: 11594
		internal static int __PropertyOffset_bEnableNDC;

		// Token: 0x04002D4B RID: 11595
		internal static int __PropertyOffset_SpawnNum;

		// Token: 0x04002D4C RID: 11596
		internal static int __PropertyOffset_HeightClamp;

		// Token: 0x04002D4D RID: 11597
		internal static int __PropertyOffset_Weight;

		// Token: 0x04002D4E RID: 11598
		internal static int __PropertyOffset_MoveSpawn;

		// Token: 0x04002D4F RID: 11599
		internal static int __PropertyOffset_WeaponSpawn;

		// Token: 0x04002D50 RID: 11600
		internal static int __PropertyOffset_EffectIndex;

		// Token: 0x04002D51 RID: 11601
		internal static int __PropertyOffset_TypeIndex;

		// Token: 0x04002D52 RID: 11602
		internal static int __PropertyOffset_PlayerSpawnOffset;
	}
}
