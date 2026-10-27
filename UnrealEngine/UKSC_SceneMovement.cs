using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E29 RID: 7721
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_SceneMovement")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public class UKSC_SceneMovement : UKSC_BaseObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D6CD RID: 120525 RVA: 0x002B7713 File Offset: 0x002B5913
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_SceneMovement._ClassPtr;
		}

		// Token: 0x0601D6CE RID: 120526 RVA: 0x002B7720 File Offset: 0x002B5920
		public UKSC_SceneMovement() : this(BuiltinUtils.AllocNativeUObject(UKSC_SceneMovement.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D6CF RID: 120527 RVA: 0x002B7748 File Offset: 0x002B5948
		public UKSC_SceneMovement(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_SceneMovement.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700769C RID: 30364
		// (get) Token: 0x0601D6D0 RID: 120528 RVA: 0x002B777C File Offset: 0x002B597C
		// (set) Token: 0x0601D6D1 RID: 120529 RVA: 0x002B77B5 File Offset: 0x002B59B5
		public TMap<UKSC_DA_SceneSegmentContainer, int> LoadedSceneSegmentDa
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UKSC_DA_SceneSegmentContainer, int> result;
				if ((result = this._LoadedSceneSegmentDa) == null)
				{
					result = (this._LoadedSceneSegmentDa = new TMap<UKSC_DA_SceneSegmentContainer, int>(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_LoadedSceneSegmentDa, this));
				}
				return result;
			}
			set
			{
				this.LoadedSceneSegmentDa.CopyAssign(value);
			}
		}

		// Token: 0x1700769D RID: 30365
		// (get) Token: 0x0601D6D2 RID: 120530 RVA: 0x002B77C3 File Offset: 0x002B59C3
		// (set) Token: 0x0601D6D3 RID: 120531 RVA: 0x002B77D7 File Offset: 0x002B59D7
		public unsafe FVector MovementDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_MovementDirection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_MovementDirection) = value;
			}
		}

		// Token: 0x1700769E RID: 30366
		// (get) Token: 0x0601D6D4 RID: 120532 RVA: 0x002B77EC File Offset: 0x002B59EC
		// (set) Token: 0x0601D6D5 RID: 120533 RVA: 0x002B7800 File Offset: 0x002B5A00
		public unsafe FVector MovementRight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_MovementRight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_MovementRight) = value;
			}
		}

		// Token: 0x1700769F RID: 30367
		// (get) Token: 0x0601D6D6 RID: 120534 RVA: 0x002B7815 File Offset: 0x002B5A15
		// (set) Token: 0x0601D6D7 RID: 120535 RVA: 0x002B7829 File Offset: 0x002B5A29
		public unsafe FVector MovementUp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_MovementUp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_MovementUp) = value;
			}
		}

		// Token: 0x170076A0 RID: 30368
		// (get) Token: 0x0601D6D8 RID: 120536 RVA: 0x002B783E File Offset: 0x002B5A3E
		// (set) Token: 0x0601D6D9 RID: 120537 RVA: 0x002B7852 File Offset: 0x002B5A52
		public unsafe FVector MovementTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_MovementTarget);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_MovementTarget) = value;
			}
		}

		// Token: 0x170076A1 RID: 30369
		// (get) Token: 0x0601D6DA RID: 120538 RVA: 0x002B7867 File Offset: 0x002B5A67
		// (set) Token: 0x0601D6DB RID: 120539 RVA: 0x002B787B File Offset: 0x002B5A7B
		public unsafe FRotator SegmentRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_SegmentRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_SegmentRotation) = value;
			}
		}

		// Token: 0x170076A2 RID: 30370
		// (get) Token: 0x0601D6DC RID: 120540 RVA: 0x002B7890 File Offset: 0x002B5A90
		// (set) Token: 0x0601D6DD RID: 120541 RVA: 0x002B78A0 File Offset: 0x002B5AA0
		public unsafe float SceneSegmentLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_SceneSegmentLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_SceneSegmentLength) = value;
			}
		}

		// Token: 0x170076A3 RID: 30371
		// (get) Token: 0x0601D6DE RID: 120542 RVA: 0x002B78B1 File Offset: 0x002B5AB1
		// (set) Token: 0x0601D6DF RID: 120543 RVA: 0x002B78C1 File Offset: 0x002B5AC1
		public unsafe int SceneSegmentCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_SceneSegmentCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_SceneSegmentCount) = value;
			}
		}

		// Token: 0x170076A4 RID: 30372
		// (get) Token: 0x0601D6E0 RID: 120544 RVA: 0x002B78D2 File Offset: 0x002B5AD2
		// (set) Token: 0x0601D6E1 RID: 120545 RVA: 0x002B78E2 File Offset: 0x002B5AE2
		public unsafe int SceneSegmentGenerateCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_SceneSegmentGenerateCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_SceneSegmentGenerateCount) = value;
			}
		}

		// Token: 0x170076A5 RID: 30373
		// (get) Token: 0x0601D6E2 RID: 120546 RVA: 0x002B78F3 File Offset: 0x002B5AF3
		// (set) Token: 0x0601D6E3 RID: 120547 RVA: 0x002B7903 File Offset: 0x002B5B03
		public unsafe float MoveDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_MoveDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_MoveDistance) = value;
			}
		}

		// Token: 0x170076A6 RID: 30374
		// (get) Token: 0x0601D6E4 RID: 120548 RVA: 0x002B7914 File Offset: 0x002B5B14
		// (set) Token: 0x0601D6E5 RID: 120549 RVA: 0x002B794D File Offset: 0x002B5B4D
		public FOnSceneSegmentFinish OnSceneSegmentFinish
		{
			get
			{
				base.FastCheckIsValid();
				FOnSceneSegmentFinish result;
				if ((result = this._OnSceneSegmentFinish) == null)
				{
					result = (this._OnSceneSegmentFinish = new FOnSceneSegmentFinish(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_OnSceneSegmentFinish, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_OnSceneSegmentFinish, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170076A7 RID: 30375
		// (get) Token: 0x0601D6E6 RID: 120550 RVA: 0x002B7970 File Offset: 0x002B5B70
		// (set) Token: 0x0601D6E7 RID: 120551 RVA: 0x002B79A9 File Offset: 0x002B5BA9
		public FOnSceneMoveThreshold OnSceneMoveThreshold
		{
			get
			{
				base.FastCheckIsValid();
				FOnSceneMoveThreshold result;
				if ((result = this._OnSceneMoveThreshold) == null)
				{
					result = (this._OnSceneMoveThreshold = new FOnSceneMoveThreshold(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_OnSceneMoveThreshold, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_OnSceneMoveThreshold, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170076A8 RID: 30376
		// (get) Token: 0x0601D6E8 RID: 120552 RVA: 0x002B79CA File Offset: 0x002B5BCA
		// (set) Token: 0x0601D6E9 RID: 120553 RVA: 0x002B79DA File Offset: 0x002B5BDA
		public unsafe float MoveDistanceThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_MoveDistanceThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_MoveDistanceThreshold) = value;
			}
		}

		// Token: 0x170076A9 RID: 30377
		// (get) Token: 0x0601D6EA RID: 120554 RVA: 0x002B79EB File Offset: 0x002B5BEB
		// (set) Token: 0x0601D6EB RID: 120555 RVA: 0x002B79FB File Offset: 0x002B5BFB
		public unsafe float MoveSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_MoveSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_MoveSpeed) = value;
			}
		}

		// Token: 0x170076AA RID: 30378
		// (get) Token: 0x0601D6EC RID: 120556 RVA: 0x002B7A0C File Offset: 0x002B5C0C
		// (set) Token: 0x0601D6ED RID: 120557 RVA: 0x002B7A45 File Offset: 0x002B5C45
		public TArray<AKSC_SceneSegment> SceneSegments
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AKSC_SceneSegment> result;
				if ((result = this._SceneSegments) == null)
				{
					result = (this._SceneSegments = new TArray<AKSC_SceneSegment>(base.NativePtr + (IntPtr)UKSC_SceneMovement.__PropertyOffset_SceneSegments, this));
				}
				return result;
			}
			set
			{
				this.SceneSegments.CopyAssign(value);
			}
		}

		// Token: 0x170076AB RID: 30379
		// (get) Token: 0x0601D6EE RID: 120558 RVA: 0x002B7A53 File Offset: 0x002B5C53
		// (set) Token: 0x0601D6EF RID: 120559 RVA: 0x002B7A67 File Offset: 0x002B5C67
		[Nullable(2)]
		public unsafe UKSC_DA_SceneSegmentContainer SceneSegmentContainer
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_SceneSegmentContainer>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_SceneMovement.__PropertyOffset_SceneSegmentContainer);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_SceneMovement.__PropertyOffset_SceneSegmentContainer, value);
			}
		}

		// Token: 0x0601D6F0 RID: 120560 RVA: 0x002B7A7C File Offset: 0x002B5C7C
		public void SetSegmentRotation(in FRotator NewSegmentRotation)
		{
			UKSC_SceneMovement.__SetSegmentRotation_Internal(base.NativePtr, NewSegmentRotation);
		}

		// Token: 0x0601D6F1 RID: 120561 RVA: 0x002B7A8A File Offset: 0x002B5C8A
		[NullableContext(2)]
		public void SetSceneSegment(UKSC_DA_SceneSegmentContainer NewSceneSegment, int GenerateCount = -1)
		{
			UKSC_SceneMovement.__SetSceneSegment_Internal(base.NativePtr, (NewSceneSegment != null) ? NewSceneSegment.NativePtr : IntPtr.Zero, GenerateCount);
		}

		// Token: 0x0601D6F2 RID: 120562 RVA: 0x002B7AA8 File Offset: 0x002B5CA8
		public void SetMovementDirection(in FVector NewMovementDirection)
		{
			UKSC_SceneMovement.__SetMovementDirection_Internal(base.NativePtr, NewMovementDirection);
		}

		// Token: 0x0601D6F3 RID: 120563 RVA: 0x002B7AB6 File Offset: 0x002B5CB6
		public void D_SetMovementTarget(in FVectorDouble NewMovementTarget)
		{
			UKSC_SceneMovement.__D_SetMovementTarget_Internal(base.NativePtr, NewMovementTarget);
		}

		// Token: 0x0601D6F4 RID: 120564
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSegmentRotation_Internal(IntPtr @this, in FRotator NewSegmentRotation);

		// Token: 0x0601D6F5 RID: 120565
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSceneSegment_Internal(IntPtr @this, IntPtr NewSceneSegment, int GenerateCount);

		// Token: 0x0601D6F6 RID: 120566
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMovementDirection_Internal(IntPtr @this, in FVector NewMovementDirection);

		// Token: 0x0601D6F7 RID: 120567
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_SetMovementTarget_Internal(IntPtr @this, in FVectorDouble NewMovementTarget);

		// Token: 0x0601D6F8 RID: 120568 RVA: 0x002B7AC4 File Offset: 0x002B5CC4
		static UKSC_SceneMovement()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_SceneMovement");
		}

		// Token: 0x0601D6F9 RID: 120569 RVA: 0x002B7AD2 File Offset: 0x002B5CD2
		protected UKSC_SceneMovement(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FF4E RID: 65358
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_SceneMovement";

		// Token: 0x0400FF4F RID: 65359
		private static IntPtr _ClassPtr;

		// Token: 0x0400FF50 RID: 65360
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FF51 RID: 65361
		public static IntPtr __OnSceneSegmentFinish__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400FF52 RID: 65362
		public static IntPtr __OnSceneMoveThreshold__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400FF53 RID: 65363
		internal static int __PropertyOffset_LoadedSceneSegmentDa;

		// Token: 0x0400FF54 RID: 65364
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<UKSC_DA_SceneSegmentContainer, int> _LoadedSceneSegmentDa;

		// Token: 0x0400FF55 RID: 65365
		internal static int __PropertyOffset_MovementDirection;

		// Token: 0x0400FF56 RID: 65366
		internal static int __PropertyOffset_MovementRight;

		// Token: 0x0400FF57 RID: 65367
		internal static int __PropertyOffset_MovementUp;

		// Token: 0x0400FF58 RID: 65368
		internal static int __PropertyOffset_MovementTarget;

		// Token: 0x0400FF59 RID: 65369
		internal static int __PropertyOffset_SegmentRotation;

		// Token: 0x0400FF5A RID: 65370
		internal static int __PropertyOffset_SceneSegmentLength;

		// Token: 0x0400FF5B RID: 65371
		internal static int __PropertyOffset_SceneSegmentCount;

		// Token: 0x0400FF5C RID: 65372
		internal static int __PropertyOffset_SceneSegmentGenerateCount;

		// Token: 0x0400FF5D RID: 65373
		internal static int __PropertyOffset_MoveDistance;

		// Token: 0x0400FF5E RID: 65374
		internal static int __PropertyOffset_OnSceneSegmentFinish;

		// Token: 0x0400FF5F RID: 65375
		[Nullable(2)]
		private FOnSceneSegmentFinish _OnSceneSegmentFinish;

		// Token: 0x0400FF60 RID: 65376
		internal static int __PropertyOffset_OnSceneMoveThreshold;

		// Token: 0x0400FF61 RID: 65377
		[Nullable(2)]
		private FOnSceneMoveThreshold _OnSceneMoveThreshold;

		// Token: 0x0400FF62 RID: 65378
		internal static int __PropertyOffset_MoveDistanceThreshold;

		// Token: 0x0400FF63 RID: 65379
		internal static int __PropertyOffset_MoveSpeed;

		// Token: 0x0400FF64 RID: 65380
		internal static int __PropertyOffset_SceneSegments;

		// Token: 0x0400FF65 RID: 65381
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AKSC_SceneSegment> _SceneSegments;

		// Token: 0x0400FF66 RID: 65382
		internal static int __PropertyOffset_SceneSegmentContainer;
	}
}
