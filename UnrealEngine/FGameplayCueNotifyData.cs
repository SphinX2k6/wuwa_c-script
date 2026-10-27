using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200136C RID: 4972
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayCueNotifyData")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FGameplayCueNotifyData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060123B5 RID: 74677 RVA: 0x001AC3E2 File Offset: 0x001AA5E2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayCueNotifyData._ScriptStructPtr != 0) ? FGameplayCueNotifyData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayCueNotifyData", ref FGameplayCueNotifyData._ScriptStructPtr);
		}

		// Token: 0x17004702 RID: 18178
		// (get) Token: 0x060123B6 RID: 74678 RVA: 0x001AC406 File Offset: 0x001AA606
		// (set) Token: 0x060123B7 RID: 74679 RVA: 0x001AC41A File Offset: 0x001AA61A
		public unsafe FGameplayTag GameplayCueTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayCueNotifyData.__PropertyOffset_GameplayCueTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayCueNotifyData.__PropertyOffset_GameplayCueTag) = value;
			}
		}

		// Token: 0x17004703 RID: 18179
		// (get) Token: 0x060123B8 RID: 74680 RVA: 0x001AC430 File Offset: 0x001AA630
		// (set) Token: 0x060123B9 RID: 74681 RVA: 0x001AC473 File Offset: 0x001AA673
		public FSoftObjectPath GameplayCueNotifyObj
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._GameplayCueNotifyObj) == null)
				{
					result = (this._GameplayCueNotifyObj = new FSoftObjectPath(base.NativePtr + (IntPtr)FGameplayCueNotifyData.__PropertyOffset_GameplayCueNotifyObj, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)FGameplayCueNotifyData.__PropertyOffset_GameplayCueNotifyObj, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004704 RID: 18180
		// (get) Token: 0x060123BA RID: 74682 RVA: 0x001AC494 File Offset: 0x001AA694
		// (set) Token: 0x060123BB RID: 74683 RVA: 0x001AC4A8 File Offset: 0x001AA6A8
		public unsafe UClassStackOnlyPtr LoadedGameplayCueClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayCueNotifyData.__PropertyOffset_LoadedGameplayCueClass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayCueNotifyData.__PropertyOffset_LoadedGameplayCueClass) = value;
			}
		}

		// Token: 0x060123BC RID: 74684 RVA: 0x001AC4BD File Offset: 0x001AA6BD
		public FGameplayCueNotifyData()
		{
		}

		// Token: 0x060123BD RID: 74685 RVA: 0x001AC4C5 File Offset: 0x001AA6C5
		public FGameplayCueNotifyData(FGameplayTag GameplayCueTag, FSoftObjectPath GameplayCueNotifyObj, UClassStackOnlyPtr LoadedGameplayCueClass)
		{
			this.GameplayCueTag = GameplayCueTag;
			this.GameplayCueNotifyObj = GameplayCueNotifyObj;
			this.LoadedGameplayCueClass = LoadedGameplayCueClass;
		}

		// Token: 0x060123BE RID: 74686 RVA: 0x001AC4E2 File Offset: 0x001AA6E2
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayCueNotifyData.StaticStruct();
		}

		// Token: 0x060123BF RID: 74687 RVA: 0x001AC4EE File Offset: 0x001AA6EE
		[NullableContext(2)]
		public FGameplayCueNotifyData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060123C0 RID: 74688 RVA: 0x001AC4F8 File Offset: 0x001AA6F8
		public FGameplayCueNotifyData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060123C1 RID: 74689 RVA: 0x001AC503 File Offset: 0x001AA703
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayCueNotifyData(Pointer, false, true);
		}

		// Token: 0x060123C2 RID: 74690 RVA: 0x001AC50D File Offset: 0x001AA70D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayCueNotifyData(Pointer, MemoryOwner);
		}

		// Token: 0x04009C3C RID: 39996
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayCueNotifyData";

		// Token: 0x04009C3D RID: 39997
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009C3E RID: 39998
		internal static int __PropertyOffset_GameplayCueTag;

		// Token: 0x04009C3F RID: 39999
		internal static int __PropertyOffset_GameplayCueNotifyObj;

		// Token: 0x04009C40 RID: 40000
		[Nullable(2)]
		private FSoftObjectPath _GameplayCueNotifyObj;

		// Token: 0x04009C41 RID: 40001
		internal static int __PropertyOffset_LoadedGameplayCueClass;
	}
}
