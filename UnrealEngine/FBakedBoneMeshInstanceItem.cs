using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000882 RID: 2178
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BakedBoneMeshInstanceItem")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FBakedBoneMeshInstanceItem : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600772D RID: 30509 RVA: 0x000AAA4F File Offset: 0x000A8C4F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBakedBoneMeshInstanceItem._ScriptStructPtr != 0) ? FBakedBoneMeshInstanceItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BakedBoneMeshInstanceItem", ref FBakedBoneMeshInstanceItem._ScriptStructPtr);
		}

		// Token: 0x17001C24 RID: 7204
		// (get) Token: 0x0600772E RID: 30510 RVA: 0x000AAA73 File Offset: 0x000A8C73
		// (set) Token: 0x0600772F RID: 30511 RVA: 0x000AAA87 File Offset: 0x000A8C87
		public unsafe USkeletalMesh MainSkeletalMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + FBakedBoneMeshInstanceItem.__PropertyOffset_MainSkeletalMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FBakedBoneMeshInstanceItem.__PropertyOffset_MainSkeletalMesh, value);
			}
		}

		// Token: 0x17001C25 RID: 7205
		// (get) Token: 0x06007730 RID: 30512 RVA: 0x000AAA9C File Offset: 0x000A8C9C
		// (set) Token: 0x06007731 RID: 30513 RVA: 0x000AAADF File Offset: 0x000A8CDF
		[Nullable(1)]
		public TArray<USkeletalMesh> SubSkeletalMeshes
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<USkeletalMesh> result;
				if ((result = this._SubSkeletalMeshes) == null)
				{
					result = (this._SubSkeletalMeshes = new TArray<USkeletalMesh>(base.NativePtr + (IntPtr)FBakedBoneMeshInstanceItem.__PropertyOffset_SubSkeletalMeshes, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SubSkeletalMeshes.CopyAssign(value);
			}
		}

		// Token: 0x17001C26 RID: 7206
		// (get) Token: 0x06007732 RID: 30514 RVA: 0x000AAAED File Offset: 0x000A8CED
		// (set) Token: 0x06007733 RID: 30515 RVA: 0x000AAB01 File Offset: 0x000A8D01
		public unsafe UBakedBoneTexture2D AnimationTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBakedBoneTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + FBakedBoneMeshInstanceItem.__PropertyOffset_AnimationTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FBakedBoneMeshInstanceItem.__PropertyOffset_AnimationTexture, value);
			}
		}

		// Token: 0x17001C27 RID: 7207
		// (get) Token: 0x06007734 RID: 30516 RVA: 0x000AAB16 File Offset: 0x000A8D16
		// (set) Token: 0x06007735 RID: 30517 RVA: 0x000AAB2A File Offset: 0x000A8D2A
		public unsafe UTexture2D AnimStartTimeNoiseTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + FBakedBoneMeshInstanceItem.__PropertyOffset_AnimStartTimeNoiseTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FBakedBoneMeshInstanceItem.__PropertyOffset_AnimStartTimeNoiseTexture, value);
			}
		}

		// Token: 0x17001C28 RID: 7208
		// (get) Token: 0x06007736 RID: 30518 RVA: 0x000AAB40 File Offset: 0x000A8D40
		// (set) Token: 0x06007737 RID: 30519 RVA: 0x000AAB83 File Offset: 0x000A8D83
		[Nullable(1)]
		public TArray<int> InstanceIndicesInActor
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._InstanceIndicesInActor) == null)
				{
					result = (this._InstanceIndicesInActor = new TArray<int>(base.NativePtr + (IntPtr)FBakedBoneMeshInstanceItem.__PropertyOffset_InstanceIndicesInActor, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.InstanceIndicesInActor.CopyAssign(value);
			}
		}

		// Token: 0x06007738 RID: 30520 RVA: 0x000AAB91 File Offset: 0x000A8D91
		public FBakedBoneMeshInstanceItem()
		{
		}

		// Token: 0x06007739 RID: 30521 RVA: 0x000AAB99 File Offset: 0x000A8D99
		[NullableContext(1)]
		public FBakedBoneMeshInstanceItem(USkeletalMesh MainSkeletalMesh, TArray<USkeletalMesh> SubSkeletalMeshes, UBakedBoneTexture2D AnimationTexture, UTexture2D AnimStartTimeNoiseTexture, TArray<int> InstanceIndicesInActor)
		{
			this.MainSkeletalMesh = MainSkeletalMesh;
			this.SubSkeletalMeshes = SubSkeletalMeshes;
			this.AnimationTexture = AnimationTexture;
			this.AnimStartTimeNoiseTexture = AnimStartTimeNoiseTexture;
			this.InstanceIndicesInActor = InstanceIndicesInActor;
		}

		// Token: 0x0600773A RID: 30522 RVA: 0x000AABC6 File Offset: 0x000A8DC6
		protected override IntPtr GetUStructPtr()
		{
			return FBakedBoneMeshInstanceItem.StaticStruct();
		}

		// Token: 0x0600773B RID: 30523 RVA: 0x000AABD2 File Offset: 0x000A8DD2
		public FBakedBoneMeshInstanceItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600773C RID: 30524 RVA: 0x000AABDC File Offset: 0x000A8DDC
		public FBakedBoneMeshInstanceItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600773D RID: 30525 RVA: 0x000AABE7 File Offset: 0x000A8DE7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBakedBoneMeshInstanceItem(Pointer, false, true);
		}

		// Token: 0x0600773E RID: 30526 RVA: 0x000AABF1 File Offset: 0x000A8DF1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBakedBoneMeshInstanceItem(Pointer, MemoryOwner);
		}

		// Token: 0x04003936 RID: 14646
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.BakedBoneMeshInstanceItem";

		// Token: 0x04003937 RID: 14647
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003938 RID: 14648
		internal static int __PropertyOffset_MainSkeletalMesh;

		// Token: 0x04003939 RID: 14649
		internal static int __PropertyOffset_SubSkeletalMeshes;

		// Token: 0x0400393A RID: 14650
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USkeletalMesh> _SubSkeletalMeshes;

		// Token: 0x0400393B RID: 14651
		internal static int __PropertyOffset_AnimationTexture;

		// Token: 0x0400393C RID: 14652
		internal static int __PropertyOffset_AnimStartTimeNoiseTexture;

		// Token: 0x0400393D RID: 14653
		internal static int __PropertyOffset_InstanceIndicesInActor;

		// Token: 0x0400393E RID: 14654
		private TArray<int> _InstanceIndicesInActor;
	}
}
