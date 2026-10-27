using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001168 RID: 4456
	[UnrealObjectPath("/Script/Engine.SpatialHashSettings")]
	[UnrealStructLayout(4, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FSpatialHashSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601046E RID: 66670 RVA: 0x0017FAE1 File Offset: 0x0017DCE1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSpatialHashSettings._ScriptStructPtr != 0) ? FSpatialHashSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SpatialHashSettings", ref FSpatialHashSettings._ScriptStructPtr);
		}

		// Token: 0x17003FC0 RID: 16320
		// (get) Token: 0x0601046F RID: 66671 RVA: 0x0017FB05 File Offset: 0x0017DD05
		// (set) Token: 0x06010470 RID: 66672 RVA: 0x0017FB15 File Offset: 0x0017DD15
		public unsafe bool bUseAlignedGridLevels
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpatialHashSettings.__PropertyOffset_bUseAlignedGridLevels) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpatialHashSettings.__PropertyOffset_bUseAlignedGridLevels) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FC1 RID: 16321
		// (get) Token: 0x06010471 RID: 66673 RVA: 0x0017FB26 File Offset: 0x0017DD26
		// (set) Token: 0x06010472 RID: 66674 RVA: 0x0017FB36 File Offset: 0x0017DD36
		public unsafe bool bSnapNonAlignedGridLevelsToLowerLevels
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpatialHashSettings.__PropertyOffset_bSnapNonAlignedGridLevelsToLowerLevels) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpatialHashSettings.__PropertyOffset_bSnapNonAlignedGridLevelsToLowerLevels) = (value ? 1 : 0);
			}
		}

		// Token: 0x06010473 RID: 66675 RVA: 0x0017FB47 File Offset: 0x0017DD47
		public FSpatialHashSettings()
		{
		}

		// Token: 0x06010474 RID: 66676 RVA: 0x0017FB4F File Offset: 0x0017DD4F
		public FSpatialHashSettings(bool bUseAlignedGridLevels, bool bSnapNonAlignedGridLevelsToLowerLevels, bool bPlaceSmallActorsUsingLocation, bool bPlacePartitionActorsUsingLocation)
		{
			this.bUseAlignedGridLevels = bUseAlignedGridLevels;
			this.bSnapNonAlignedGridLevelsToLowerLevels = bSnapNonAlignedGridLevelsToLowerLevels;
		}

		// Token: 0x06010475 RID: 66677 RVA: 0x0017FB65 File Offset: 0x0017DD65
		protected override IntPtr GetUStructPtr()
		{
			return FSpatialHashSettings.StaticStruct();
		}

		// Token: 0x06010476 RID: 66678 RVA: 0x0017FB71 File Offset: 0x0017DD71
		[NullableContext(2)]
		public FSpatialHashSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010477 RID: 66679 RVA: 0x0017FB7B File Offset: 0x0017DD7B
		public FSpatialHashSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010478 RID: 66680 RVA: 0x0017FB86 File Offset: 0x0017DD86
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSpatialHashSettings(Pointer, false, true);
		}

		// Token: 0x06010479 RID: 66681 RVA: 0x0017FB90 File Offset: 0x0017DD90
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSpatialHashSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04008C18 RID: 35864
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SpatialHashSettings";

		// Token: 0x04008C19 RID: 35865
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008C1A RID: 35866
		internal static int __PropertyOffset_bUseAlignedGridLevels;

		// Token: 0x04008C1B RID: 35867
		internal static int __PropertyOffset_bSnapNonAlignedGridLevelsToLowerLevels;
	}
}
