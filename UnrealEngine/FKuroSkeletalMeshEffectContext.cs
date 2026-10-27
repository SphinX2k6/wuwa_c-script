using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200190D RID: 6413
	[UnrealObjectPath("/Script/KuroGameplay.KuroSkeletalMeshEffectContext")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FKuroSkeletalMeshEffectContext : FKuroEffectContext, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06017CD7 RID: 97495 RVA: 0x0022DD38 File Offset: 0x0022BF38
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroSkeletalMeshEffectContext._ScriptStructPtr != 0) ? FKuroSkeletalMeshEffectContext._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroSkeletalMeshEffectContext", ref FKuroSkeletalMeshEffectContext._ScriptStructPtr);
		}

		// Token: 0x17005FB3 RID: 24499
		// (get) Token: 0x06017CD8 RID: 97496 RVA: 0x0022DD5C File Offset: 0x0022BF5C
		// (set) Token: 0x06017CD9 RID: 97497 RVA: 0x0022DD70 File Offset: 0x0022BF70
		[Nullable(2)]
		public unsafe USkeletalMeshComponent SkeletalMeshComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroSkeletalMeshEffectContext.__PropertyOffset_SkeletalMeshComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroSkeletalMeshEffectContext.__PropertyOffset_SkeletalMeshComponent, value);
			}
		}

		// Token: 0x17005FB4 RID: 24500
		// (get) Token: 0x06017CDA RID: 97498 RVA: 0x0022DD85 File Offset: 0x0022BF85
		// (set) Token: 0x06017CDB RID: 97499 RVA: 0x0022DD95 File Offset: 0x0022BF95
		public unsafe bool IsSyncTimeDilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkeletalMeshEffectContext.__PropertyOffset_IsSyncTimeDilation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkeletalMeshEffectContext.__PropertyOffset_IsSyncTimeDilation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005FB5 RID: 24501
		// (get) Token: 0x06017CDC RID: 97500 RVA: 0x0022DDA6 File Offset: 0x0022BFA6
		// (set) Token: 0x06017CDD RID: 97501 RVA: 0x0022DDB6 File Offset: 0x0022BFB6
		public unsafe bool IsSyncEventTimeToEffectTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkeletalMeshEffectContext.__PropertyOffset_IsSyncEventTimeToEffectTime) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkeletalMeshEffectContext.__PropertyOffset_IsSyncEventTimeToEffectTime) = (value ? 1 : 0);
			}
		}

		// Token: 0x06017CDE RID: 97502 RVA: 0x0022DDC7 File Offset: 0x0022BFC7
		public FKuroSkeletalMeshEffectContext()
		{
		}

		// Token: 0x06017CDF RID: 97503 RVA: 0x0022DDD0 File Offset: 0x0022BFD0
		[NullableContext(1)]
		public FKuroSkeletalMeshEffectContext(USkeletalMeshComponent SkeletalMeshComponent, bool IsSyncTimeDilation, bool IsSyncEventTimeToEffectTime, int EntityId, UObject SourceObject, bool DisablePostProcess, int CreateFromType, int PlayFlag, bool CreateFromBpEffectActor, byte ContextType, int HitEffectType, FName AnsSlotName)
		{
			this.SkeletalMeshComponent = SkeletalMeshComponent;
			this.IsSyncTimeDilation = IsSyncTimeDilation;
			this.IsSyncEventTimeToEffectTime = IsSyncEventTimeToEffectTime;
			base.EntityId = EntityId;
			base.SourceObject = SourceObject;
			base.DisablePostProcess = DisablePostProcess;
			base.CreateFromType = CreateFromType;
			base.PlayFlag = PlayFlag;
			base.CreateFromBpEffectActor = CreateFromBpEffectActor;
			base.ContextType = ContextType;
			base.HitEffectType = HitEffectType;
			base.AnsSlotName = AnsSlotName;
		}

		// Token: 0x06017CE0 RID: 97504 RVA: 0x0022DE40 File Offset: 0x0022C040
		protected override IntPtr GetUStructPtr()
		{
			return FKuroSkeletalMeshEffectContext.StaticStruct();
		}

		// Token: 0x06017CE1 RID: 97505 RVA: 0x0022DE4C File Offset: 0x0022C04C
		[NullableContext(2)]
		public FKuroSkeletalMeshEffectContext(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017CE2 RID: 97506 RVA: 0x0022DE56 File Offset: 0x0022C056
		public FKuroSkeletalMeshEffectContext(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017CE3 RID: 97507 RVA: 0x0022DE61 File Offset: 0x0022C061
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroSkeletalMeshEffectContext(Pointer, false, true);
		}

		// Token: 0x06017CE4 RID: 97508 RVA: 0x0022DE6B File Offset: 0x0022C06B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroSkeletalMeshEffectContext(Pointer, MemoryOwner);
		}

		// Token: 0x0400CE71 RID: 52849
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroSkeletalMeshEffectContext";

		// Token: 0x0400CE72 RID: 52850
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400CE73 RID: 52851
		internal static int __PropertyOffset_SkeletalMeshComponent;

		// Token: 0x0400CE74 RID: 52852
		internal static int __PropertyOffset_IsSyncTimeDilation;

		// Token: 0x0400CE75 RID: 52853
		internal static int __PropertyOffset_IsSyncEventTimeToEffectTime;
	}
}
