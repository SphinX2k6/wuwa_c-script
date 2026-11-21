using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000402 RID: 1026
	[UnrealObjectPath("/Script/KuroGameplay.KuroSkeletalMeshEffectContext")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FKuroSkeletalMeshEffectContext : FKuroEffectContext, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060064A6 RID: 25766 RVA: 0x0008FB2C File Offset: 0x0008DD2C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroSkeletalMeshEffectContext._ScriptStructPtr != 0) ? FKuroSkeletalMeshEffectContext._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroSkeletalMeshEffectContext", ref FKuroSkeletalMeshEffectContext._ScriptStructPtr);
		}

		// Token: 0x1700142A RID: 5162
		// (get) Token: 0x060064A7 RID: 25767 RVA: 0x0008FB50 File Offset: 0x0008DD50
		// (set) Token: 0x060064A8 RID: 25768 RVA: 0x0008FB64 File Offset: 0x0008DD64
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

		// Token: 0x1700142B RID: 5163
		// (get) Token: 0x060064A9 RID: 25769 RVA: 0x0008FB79 File Offset: 0x0008DD79
		// (set) Token: 0x060064AA RID: 25770 RVA: 0x0008FB89 File Offset: 0x0008DD89
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

		// Token: 0x1700142C RID: 5164
		// (get) Token: 0x060064AB RID: 25771 RVA: 0x0008FB9A File Offset: 0x0008DD9A
		// (set) Token: 0x060064AC RID: 25772 RVA: 0x0008FBAA File Offset: 0x0008DDAA
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

		// Token: 0x060064AD RID: 25773 RVA: 0x0008FBBB File Offset: 0x0008DDBB
		public FKuroSkeletalMeshEffectContext()
		{
		}

		// Token: 0x060064AE RID: 25774 RVA: 0x0008FBC3 File Offset: 0x0008DDC3
		protected override IntPtr GetUStructPtr()
		{
			return FKuroSkeletalMeshEffectContext.StaticStruct();
		}

		// Token: 0x060064AF RID: 25775 RVA: 0x0008FBCF File Offset: 0x0008DDCF
		[NullableContext(2)]
		public FKuroSkeletalMeshEffectContext(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060064B0 RID: 25776 RVA: 0x0008FBD9 File Offset: 0x0008DDD9
		public FKuroSkeletalMeshEffectContext(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060064B1 RID: 25777 RVA: 0x0008FBE4 File Offset: 0x0008DDE4
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroSkeletalMeshEffectContext(Pointer, false, true);
		}

		// Token: 0x060064B2 RID: 25778 RVA: 0x0008FBEE File Offset: 0x0008DDEE
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroSkeletalMeshEffectContext(Pointer, MemoryOwner);
		}

		// Token: 0x04002A65 RID: 10853
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroSkeletalMeshEffectContext";

		// Token: 0x04002A66 RID: 10854
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002A67 RID: 10855
		internal static int __PropertyOffset_SkeletalMeshComponent;

		// Token: 0x04002A68 RID: 10856
		internal static int __PropertyOffset_IsSyncTimeDilation;

		// Token: 0x04002A69 RID: 10857
		internal static int __PropertyOffset_IsSyncEventTimeToEffectTime;
	}
}
